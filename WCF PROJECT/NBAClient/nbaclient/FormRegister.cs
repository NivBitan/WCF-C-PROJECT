using System;
using System.ServiceModel;
using System.Windows.Forms;
using WcfDuplexServiceInterface;

namespace WcfDuplexServiceClient
{
    public partial class FormRegister : Form
    {
        
        private const string ServiceEndpointUri = "http://localhost:9001/WCFServices/NBADuplexService";
        public FormRegister()
        {
            InitializeComponent();
            InitializeClient();
        }
        
        /// <summary>
        /// initialize the client service, open the service and connect to srever's database
        /// </summary>
        private void InitializeClient()
        {
            if (Program._proxy != null)
            {
                try
                {
                    Program._proxy.Close();
                }
                catch
                {
                    Program._proxy.Abort();
                }
                finally
                {
                    Program._proxy = null;
                }
            }

            var nbaDuplexCallback = new WcfDuplexCallBack();
            var instanceContext = new InstanceContext(nbaDuplexCallback);
            var dualHttpBinding = new WSDualHttpBinding(WSDualHttpSecurityMode.None);
            var endpointAddress = new EndpointAddress(ServiceEndpointUri);
            Program._proxy = new WcfDuplexServiceClient(instanceContext, dualHttpBinding, endpointAddress);
            Program._proxy.Open();
            Program._proxy.Connect();
            // connect to server database
            try
            {
                Program._proxy.connectDB();
            }
            catch(FaultException<DataBaseException> ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
        
        /// <summary>
        /// user sign up to the application, check if the insert user name and password
        /// in a correct format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxUserNameReg.Text == string.Empty)
            {
                MessageBox.Show("Enter name", "Name is empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxPasswordReg.Text == string.Empty)
            {
                MessageBox.Show("Enter password", "Password is empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Program._proxy.CheckContainingUser(textBoxUserNameReg.Text) == true)
            {
                MessageBox.Show("User already registered, enter new name", "User name wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxes();
                return;
            }
            // registered user and insert the user to the server's data base
            try
            {
                Program._proxy.InsertUser(textBoxUserNameReg.Text, textBoxPasswordReg.Text);
            }
            catch (FaultException<DataBaseException> ex)
            {
                MessageBox.Show(ex.Message);
            }
            OpenMenu(false);
        }
        /// <summary>
        /// after checked in the user name and password, enter to the application menu
        /// </summary>
        /// <param name="admin">True - it is admin, False - it is normal user</param>
        private void OpenMenu(bool admin)
        {
            FormMenu frmMenu = new FormMenu();
            this.Hide();
            frmMenu.Admin = admin;
            frmMenu.ShowDialog();
            this.Close();
            
        }
        
        private void clearTextBoxes()
        {
            textBoxUserNameReg.Text = string.Empty;
            textBoxPasswordReg.Text = string.Empty;
            textBoxSignInName.Text = string.Empty;
            textBoxSignInPassword.Text = string.Empty;
            textBoxAdminName.Text = string.Empty;
            textBoxAdminPassword.Text = string.Empty;
        }

        /// <summary>
        /// sign in to the application, check if the user name and password in a correct format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxSignInName.Text == string.Empty)
            {
                MessageBox.Show("Enter name", "Name is empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxSignInPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter password", "Password is empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Program._proxy.CheckContainingUser(textBoxSignInName.Text) == false)
            {
                MessageBox.Show("Enter name again", "User not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxes();
                return;
            }
            if(Program._proxy.CheckPassword(textBoxSignInName.Text, textBoxSignInPassword.Text) == true)
                OpenMenu(false);
            else
            {
                MessageBox.Show("Enter password again", "Wrong Password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxes();
            }
            
        }

        /// <summary>
        /// admin sign in, check if the user is admin user and his password are fit to the user name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnterAdmin_Click(object sender, EventArgs e)
        {
            if (textBoxAdminName.Text == string.Empty)
            {
                MessageBox.Show("Enter name", "Name is empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxAdminPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter password", "Password is empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Program._proxy.CheckContainingUser(textBoxAdminName.Text);
            }
            catch (FaultException<WcfDuplexServiceInterface.InvalidUserException> ex)
            {
                MessageBox.Show(ex.Message, "User not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxes();
                return;
            }
            if (Program._proxy.CheckPassword(textBoxAdminName.Text, textBoxAdminPassword.Text) == false)
            {
                MessageBox.Show("Enter password again", "Wrong Password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxes();
                return;
            }
            if (Program._proxy.CheckAdmin(textBoxAdminName.Text) == false)
            {
                MessageBox.Show("No admin user!","Wrong admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxes();
                return;
            }
            OpenMenu(true);
        
        }
    }
}
