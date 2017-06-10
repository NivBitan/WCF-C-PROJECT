using System;
using System.Windows.Forms;

namespace WcfDuplexServiceClient
{
    public partial class FormMenu : Form
    {
        public bool Admin { get; set; }

        public FormMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// open FormAddPlayer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddPlayer formAddPlayer = new FormAddPlayer();
            formAddPlayer.ShowDialog();
        }

        /// <summary>
        /// open FormAddManager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newManagerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAddManager formAddManager = new FormAddManager();
            formAddManager.ShowDialog();
        }

        /// <summary>
        /// open FormAddGame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAddGame formAddGame = new FormAddGame();
            formAddGame.ShowDialog();
        }

        /// <summary>
        /// open FormDeletePlayerAndManagers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDeletePlayerAndManagers formDeletePlayer = new FormDeletePlayerAndManagers();
            formDeletePlayer.ShowDialog();
        }

        /// <summary>
        /// open FormAllTimeWinners
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void allTimeWinnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllTimeWinners formWinners = new FormAllTimeWinners();
            formWinners.Show();
        }

        /// <summary>
        /// open FormOneOnOne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oneOnOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOneOnOne formOneOnOne = new FormOneOnOne();
            formOneOnOne.Show();
        }

        /// <summary>
        /// open 'Atlantic' FormTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAtlantic_Click(object sender, EventArgs e)
        {
            FormTable formTable = new FormTable();
            formTable.RegionTable = "Atlantic";
            formTable.Show();
        }

        /// <summary>
        /// open 'Central' FormTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCentral_Click(object sender, EventArgs e)
        {
            FormTable formTable = new FormTable();
            formTable.RegionTable = "Central";
            formTable.Show();
        }

        /// <summary>
        /// open 'Suotheast' FormTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSoutheast_Click(object sender, EventArgs e)
        {
            FormTable formTable = new FormTable();
            formTable.RegionTable = "Southeast";
            formTable.Show();
        }

        /// <summary>
        /// open 'Northwest' FormTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNorthwest_Click(object sender, EventArgs e)
        {
            FormTable formTable = new FormTable();
            formTable.RegionTable = "Northwest";
            formTable.Show();
        }

        /// <summary>
        /// open 'Pacific' FormTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPacific_Click(object sender, EventArgs e)
        {
            FormTable formTable = new FormTable();
            formTable.RegionTable = "Pacific";
            formTable.Show();
        }

        /// <summary>
        /// open 'Southwest' FormTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSouthwest_Click(object sender, EventArgs e)
        {
            FormTable formTable = new FormTable();
            formTable.RegionTable = "Southwest";
            formTable.Show();
        }

        /// <summary>
        /// open FormSquads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAskDB_Click(object sender, EventArgs e)
        {
            FormSquads frmSquads = new FormSquads();
            frmSquads.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if(Admin == false)
            {
                // disable add options
                menuStrip1.Items[0].Visible = false;
                // disable delete options
                menuStrip1.Items[1].Visible = false;
            }
        }

        /// <summary>
        /// open FormSearches
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormSearches frmSearches = new FormSearches();
            frmSearches.Show();
        }
    }
}
