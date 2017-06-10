using System;
using System.Windows.Forms;

namespace WcfDuplexServiceClient
{
    public partial class FormSelectPlayers : Form
    {
        public WcfDuplexServiceInterface.Player ReturnPlayer1 { get; set; }
        public WcfDuplexServiceInterface.Player ReturnPlayer2 { get; set; }
        public FormSelectPlayers()
        {
            InitializeComponent();
        }

        private void FormSelectPlyers_Load(object sender, EventArgs e)
        {
            UploadPlayers();
        }

        /// <summary>
        /// upload players to comboBoxPlayer1 and comboBoxPlayer2
        /// </summary>
        private void UploadPlayers()
        {
            foreach (var player in Program._proxy.UploadPlayersNoArg())
            {
                comboBoxPlayer1.Items.Add(player);
                comboBoxPlayer2.Items.Add(player);
            }
        }

        /// <summary>
        /// accept the selected players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCompare_Click(object sender, EventArgs e)
        {
            if(comboBoxPlayer1.SelectedIndex == -1 || comboBoxPlayer2.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select two players", "Select error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if((ReturnPlayer1 = Program._proxy.FindPlayers(comboBoxPlayer1.Text)) == null ||
                (ReturnPlayer2 = Program._proxy.FindPlayers(comboBoxPlayer2.Text)) == null)
            {
                this.DialogResult = DialogResult.None;
                this.Close();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
