using System;
using System.ServiceModel;
using System.Windows.Forms;
using WcfDuplexServiceInterface;

namespace WcfDuplexServiceClient
{
    public partial class FormAddManager : Form
    {
        public FormAddManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// send manager data to the sever
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddManager_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxFields() == false)
            {
                ClearTextBoxes();
                MessageBox.Show("Wrong input!", "Insert data again");
                return;
            }
            try
            {
                // send the data fields to the server
                Program._proxy.InsertManager(textBoxManagerName.Text, comboBoxTeams.SelectedItem.ToString(), Convert.ToInt32(textBoxAge.Text),
                    Convert.ToInt32(textBoxExperience.Text), Convert.ToInt32(textBoxTitles.Text));
            }
            catch (FaultException<DataBaseException> ex)
            {
                MessageBox.Show(ex.Message, "Manager insertion exception: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ClearTextBoxes();    
        }

        /// <summary>
        /// clear all the textBoxes fields
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxAge.Text = string.Empty;
            textBoxExperience.Text = string.Empty;
            textBoxManagerName.Text = string.Empty;
            textBoxTitles.Text = string.Empty;
        }

        /// <summary>
        /// chheck if the textBoxes are valids
        /// </summary>
        /// <returns>True - if valids, False - if not</returns>
        private bool CheckTextBoxFields()
        {
            if (RegexValidations.NameValidation(textBoxManagerName.Text) &&
                RegexValidations.NumericValidation(textBoxExperience.Text) &&
                RegexValidations.NumericValidation(textBoxAge.Text) &&
                RegexValidations.NumericValidation(textBoxTitles.Text))
                return true;
            else
                return false;
        }

        private void FormAddManager_Load(object sender, EventArgs e)
        {
            // Upload teams to ComboBox 
            foreach (var team in Program._proxy.UploadTeam())
            {
                comboBoxTeams.Items.Add(team);
            }
            // if there is no teams on database
            if (comboBoxTeams.Items.Count == 0)
            {
                MessageBox.Show("There is no teams yet", "Please add a team", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

    }
}
