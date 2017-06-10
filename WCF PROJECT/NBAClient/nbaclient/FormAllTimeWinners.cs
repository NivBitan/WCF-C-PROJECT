using System;
using System.Windows.Forms;

namespace WcfDuplexServiceClient
{
    public partial class FormAllTimeWinners : Form
    {
        public FormAllTimeWinners()
        {
            InitializeComponent();
        }

        private void FormAllTimeWinners_Load(object sender, EventArgs e)
        {
            UploadWinnersTables();
        }

        /// <summary>
        /// Upload whole tables with data from the server
        /// </summary>
        private void UploadWinnersTables()
        {
            // Manager upload
            foreach (var manager in Program._proxy.UploadManagersWinners())
            {
                dataGridViewManagersWinners.Rows.Add(manager[0], manager[1], manager[2]);
            }

            // Players upload
            foreach (var player in Program._proxy.UploadPlayersWinners())
            {
                dataGridViewPlayersWinners.Rows.Add(player[0], player[1], player[2]);
            }
            // Teams upload

            foreach (var team in Program._proxy.UploadTeamsWinners())
            {
                dataGridViewTeamWinners.Rows.Add(team[0], team[1]);
            }

        }
    }
}
