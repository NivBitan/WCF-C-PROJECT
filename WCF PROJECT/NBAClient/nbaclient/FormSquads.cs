using System;
using System.Windows.Forms;

namespace WcfDuplexServiceClient
{
    public partial class FormSquads : Form
    {
        public FormSquads()
        {
            InitializeComponent();
        }

        private void FormSquads_Load(object sender, EventArgs e)
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
                comboBoxTeams.Items.Add(team);
            }
            if (comboBoxTeams.Items.Count == 0)
            {
                MessageBox.Show("There is no teams yet", "Please add a team", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        
        }

        /// <summary>
        /// show the squads of selected team item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewSquad.Rows.Clear();
            foreach (var player in Program._proxy.GetSquad(comboBoxTeams.Text))
            {
                dataGridViewSquad.Rows.Add(player.PlayerName, player.Position, player.Age, player.Height, player.Weight, player.MVP, player.ExeperienceYears, player.NumberOfTitles);
            }
        }
    }
}
