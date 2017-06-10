using System;
using System.ServiceModel;
using System.Windows.Forms;
using WcfDuplexServiceInterface;

namespace WcfDuplexServiceClient
{
    public partial class FormAddGame : Form
    {
        public FormAddGame()
        {
            InitializeComponent();
        }

        private void FormAddGame_Load(object sender, EventArgs e)
        {
            UploadFixtures();
            UploadTeams();
        }
        
        /// <summary>
        /// Upload teams to ComboBoxHome and ComboBoxAway. 
        /// </summary>
        private void UploadTeams()
        {
            // get the items from the server
            foreach (var team in Program._proxy.UploadTeam())
            {
                comboBoxHome.Items.Add(team);
                comboBoxAway.Items.Add(team);
            }
            if (comboBoxHome.Items.Count == 0)
            {
                MessageBox.Show("There is no teams yet", "Please add a team", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        /// <summary>
        /// Upload players to comboBoxMVP
        /// </summary>
        private void UploadPlayers()
        {
            comboBoxMVP.Items.Clear();
            // get the items from the sever
            foreach (var player in Program._proxy.UploadPlayers(comboBoxHome.Text, comboBoxAway.Text))
            {
                comboBoxMVP.Items.Add(player);
            }
        }

        /// <summary>
        /// Fill comboBoxFixtures with all numbers of the season fuxtures
        /// </summary>
        private void UploadFixtures()
        {
            for(int i=1; i<=82; i++)
            {
                comboBoxFixture.Items.Add(i);
            }
        }

        /// <summary>
        /// Add game to the database, use the method 'InsertGameToDataBase'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxFields() == false)
            {
                ClearTextBoxes();
                return;
            }
            if (InsertGameToDataBase())
            {
                ClearTextBoxes();
            }
        }

        /// <summary>
        /// send all the data fields to the server.
        /// </summary>
        /// <returns>True - if the server accept the data, False - if was exception from the server side</returns>
        private bool InsertGameToDataBase()
        {
            try
            {
                // send to the server
                Program._proxy.InsertGame(comboBoxHome.SelectedItem.ToString(), comboBoxAway.SelectedItem.ToString(), comboBoxMVP.Text,
                    calendarGames.SelectionStart.Date, Convert.ToInt32(textBoxAwayScore.Text), Convert.ToInt32(textBoxHomeScore.Text),
                    Convert.ToInt32(comboBoxFixture.Text));

                // update wins and losses for each team
                if (Convert.ToInt32(textBoxHomeScore.Text) > Convert.ToInt32(textBoxAwayScore.Text))
                    Program._proxy.UpdateWinAndLose(comboBoxHome.Text, comboBoxAway.Text);
                else
                    Program._proxy.UpdateWinAndLose(comboBoxAway.Text, comboBoxHome.Text);
                // update the MVP of the game
                Program._proxy.UpdateMVP(comboBoxMVP.Text);

            }
            catch (FaultException<DataBaseException> ex)
            {
                MessageBox.Show(ex.Message);
                ClearTextBoxes();
                return false;
            }


            return true;
        }
        /// <summary>
        /// Clear all the boxes
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxAwayScore.Text = string.Empty;
            textBoxHomeScore.Text = string.Empty;
        }

        /// <summary>
        /// check the textboxes input from the user
        /// </summary>
        /// <returns>True - if it's O.k input, False - if something wrong with the input</returns>
        private bool CheckTextBoxFields()
        {
            // check if the score is valid
            if (!RegexValidations.NumericValidation(textBoxAwayScore.Text) ||
                 !RegexValidations.NumericValidation(textBoxHomeScore.Text))
            { 
                MessageBox.Show("Wrong input!", "Insert data again");
                return false;
            }

            // check if the score is draw
            if (Convert.ToInt32(textBoxHomeScore.Text) == Convert.ToInt32(textBoxAwayScore.Text))
            {
                MessageBox.Show("The result can't be a draw", "Wrong input!");
                return false;
            }
            // check if fixture combo box selected
            if (string.IsNullOrEmpty(comboBoxFixture.Text))
            {
                MessageBox.Show("Select Fixture", "Fixture not selected");
                return false;
            }
            // check if MVP combo box selected
            if (string.IsNullOrEmpty(comboBoxMVP.Text))
            {
                MessageBox.Show("Select MVP", "MVP not selected");
                return false;
            }
            // check if selected away and home teams
            if(comboBoxHome.SelectedItem == null || comboBoxAway.SelectedItem == null)
            {
                MessageBox.Show("Select two teams");
            }
            // check if not selected the same team in home and away
            if(comboBoxHome.SelectedItem.ToString() == comboBoxAway.SelectedItem.ToString())
            {
                MessageBox.Show("Select different teams", "Select teams error");
                return false;
            }

                return true;
        }

        /// <summary>
        /// When selected team changed refresh the optionality players on comboBoxMVP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAway_SelectedValueChanged(object sender, EventArgs e)
        {
            UploadPlayers();
        }

        /// <summary>
        /// When selected team changed refresh the optionality players on comboBoxMVP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxHome_SelectedValueChanged(object sender, EventArgs e)
        {
            UploadPlayers();
        }

    }
}
