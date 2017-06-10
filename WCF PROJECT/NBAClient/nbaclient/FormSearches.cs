using System;
using System.Windows.Forms;

namespace WcfDuplexServiceClient
{
    public partial class FormSearches : Form
    {
        // variables for players search
        private int age1, age2, managerAge1, managerAge2, wins1, wins2;


        // variables for teams search
        private int squadAmount1, squadAmount2, managerExp1, managerExp2;

        private void FormSearches_Load(object sender, EventArgs e)
        {
            
        }

        public FormSearches()
        {
            InitializeComponent();
        }

        /// <summary>
        /// click to search a players with the data on him, and show the founds players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxSearchPlayer_Click(object sender, EventArgs e)
        {
            dataGridViewResults.Columns.Clear();
            // create a player column 
            dataGridViewResults.Columns.Add("ColumnPlayer", "Player");

            if (CheckPlayerTextBoxes() == false)
                return;
            // show all return players on data grid view
            foreach (var player in Program._proxy.AdvanceSearchPlayers(age1, age2, wins1, wins2, managerAge1, managerAge2))
            {
                dataGridViewResults.Rows.Add(player);
            }
            
        }
        /// <summary>
        /// click to search a teams with the inserted data, and show the results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxSearchTeams_Click(object sender, EventArgs e)
        {
            dataGridViewResults.Columns.Clear();
            dataGridViewResults.Columns.Add("ColumnTeams", "Teams");

            if (CheckTeamsTextBoxes() == false)
                return;
            foreach (var team in Program._proxy.AdvanceSearchTeams(squadAmount1, squadAmount2, managerExp1, managerExp2, comboBoxRegion.Text))
            {
                dataGridViewResults.Rows.Add(team);
            }
        }

        /// <summary>
        /// valid the inserted  fields of teams search
        /// </summary>
        /// <returns>True - data correctly, False - data not correctly</returns>
        private bool CheckTeamsTextBoxes()
        {
            if (string.IsNullOrEmpty(textBoxManagerExp1.Text) || string.IsNullOrEmpty(textBoxManagerExp2.Text) ||
               string.IsNullOrEmpty(textBoxSquad1.Text) || string.IsNullOrEmpty(textBoxSquad2.Text)
               || string.IsNullOrEmpty(comboBoxRegion.Text))
            {
                MessageBox.Show("Fill all teams search fields", "All field doesn't full", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            squadAmount1 = Convert.ToInt32(textBoxSquad1.Text);
            squadAmount2 = Convert.ToInt32(textBoxSquad2.Text);
            managerExp1 = Convert.ToInt32(textBoxManagerExp1.Text);
            managerExp2 = Convert.ToInt32(textBoxManagerExp2.Text);

            // left side need to be equal or smaller from right side
            if (squadAmount1 > squadAmount2 || managerExp1 > managerExp2)
            {
                MessageBox.Show("Left side fields need to be equal or smaller from right side", "fields error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool CheckPlayerTextBoxes()
        {
            if(string.IsNullOrEmpty(textBoxAge1.Text) || string.IsNullOrEmpty(textBoxAge2.Text) ||
                string.IsNullOrEmpty(textBoxManagerAge1.Text) || string.IsNullOrEmpty(textBoxManagerAge2.Text)
                || string.IsNullOrEmpty(textBoxWins1.Text ) || string.IsNullOrEmpty(textBoxWins2.Text))
            {
                MessageBox.Show("Fill all players search fields", "All field doesn't full", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            age1 = Convert.ToInt32(textBoxAge1.Text);
            age2 = Convert.ToInt32(textBoxAge2.Text);
            managerAge1 = Convert.ToInt32(textBoxManagerAge1.Text);
            managerAge2 = Convert.ToInt32(textBoxManagerAge2.Text);
            wins1 = Convert.ToInt32(textBoxWins1.Text);
            wins2 = Convert.ToInt32(textBoxWins2.Text);

            // left side need to be equal or smaller from right side
            if (age1 > age2 || managerAge1 > managerAge2 || wins1 > wins2)
            {
                MessageBox.Show("Left side fields need to be equal or bigger from right side", "fields error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
