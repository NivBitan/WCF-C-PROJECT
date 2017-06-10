using System;
using System.ServiceModel;
using System.Windows.Forms;
using WcfDuplexServiceInterface;

namespace WcfDuplexServiceClient
{
    public partial class FormDeletePlayerAndManagers : Form
    {
        public FormDeletePlayerAndManagers()
        {
            InitializeComponent();
        }
        

        private void FormDeletePlayer_Load(object sender, EventArgs e)
        {
            UploadTeams();
        }

        /// <summary>
        /// upload teams to comboBoxTeams
        /// </summary>
        private void UploadTeams()
        {    
            foreach (var team in Program._proxy.UploadTeam())
            {
                comboBoxTeam.Items.Add(team);
            }
        }

        /// <summary>
        /// upload the comboBox with the selected radio button and the team selected of comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDeleteSelect.Text = string.Empty;
            if (radioButtonManager.Checked)
                UploadComboBox("Manager");
            else
                UploadComboBox("Player");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DeletePlayerOrManager();
            comboBoxDeleteSelect.Text = string.Empty;
            if (radioButtonManager.Checked)
                UploadComboBox("Manager");
            else
                UploadComboBox("Player");
        }

        /// <summary>
        /// delete player or manager according to selected radio button
        /// </summary>
        private void DeletePlayerOrManager()
        {
            // check if selected manager or player
            if(comboBoxDeleteSelect.SelectedIndex == -1)
            {
                MessageBox.Show("Enter Player or Manager To delete");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete: " + comboBoxDeleteSelect.Text,
                       "Delete player", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;     
            //delete player
            if (radioButtonPlayer.Checked)
            {
                try
                {
                    Program._proxy.DeletePlayer(comboBoxDeleteSelect.Text, comboBoxTeam.Text);
                }
                catch(FaultException<DataBaseException> ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            // delete manager
            else
            {
                try
                {
                    Program._proxy.DeleteManager(comboBoxDeleteSelect.Text, comboBoxTeam.Text);
                }
                catch (FaultException<DataBaseException> ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
                }

        private void radioButtonManager_CheckedChanged(object sender, EventArgs e)
        {
            UploadComboBox("Manager");
           
        }

        /// <summary>
        /// upload players or managers to 'comboBoxDeleteSelected'
        /// </summary>
        /// <param name="str"></param>
        private void UploadComboBox(string str)
        {
            comboBoxDeleteSelect.Text = str + " to delete";
            comboBoxDeleteSelect.Items.Clear();
           
                foreach (var item in Program._proxy.UploadByString(str, comboBoxTeam.Text))
                {
                    comboBoxDeleteSelect.Items.Add(item);
                }
            
        }

        private void radioButtonPlayer_CheckedChanged(object sender, EventArgs e)
        {
            UploadComboBox("Player");
        }
    }
}