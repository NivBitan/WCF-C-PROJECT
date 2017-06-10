using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WcfDuplexServiceClient
{
    public partial class FormOneOnOne : Form
    {
        Image no_image;

        public FormOneOnOne()
        {
            InitializeComponent();
            pictureBox2.SendToBack();
            pictureBox1.SendToBack();
            no_image = pictureBox1.Image;
        }

        /// <summary>
        /// open FormSelectPlayers as dialog, and get two players for comparison
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectPlayers_Click(object sender, EventArgs e)
        {
            using (var formSelectPlayers = new FormSelectPlayers())
            {
                var result = formSelectPlayers.ShowDialog();
                if (result == DialogResult.OK)
                {                 
                    WcfDuplexServiceInterface.Player player1 = formSelectPlayers.ReturnPlayer1;
                    WcfDuplexServiceInterface.Player player2 = formSelectPlayers.ReturnPlayer2;         
                    FillSubjects(player1, player2);
                }
            }
        }

        /// <summary>
        /// chagne the Image format from byte[] to 'Image' type to show the picture in the 'pictureBox'
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns>Image type</returns>
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn.Length == 0)
                return null;
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        /// <summary>
        /// fill the fields with the players data
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        private void FillSubjects(WcfDuplexServiceInterface.Player player1, WcfDuplexServiceInterface.Player player2)
        {
            // Player1 fields
            labelPlayer1.Text = player1.PlayerName;
            textBoxTeam1.Text = player1.TeamName;
            textBoxExp1.Text = Convert.ToString(player1.ExeperienceYears);
            textBoxMVP1.Text = Convert.ToString(player1.MVP);
            textBoxPosition1.Text = getPosition(player1.Position);
            textBoxTitles1.Text = Convert.ToString(player1.NumberOfTitles);
            pictureBox1.Image = ByteArrayToImage(Program._proxy.retireveImageFromDb(player1.PlayerName));
            if (pictureBox1.Image == null)
                pictureBox1.Image = no_image;
            pictureBox1.Visible = true;
            // Player2 fields
            labelPlayer2.Text = player2.PlayerName;
            textBoxTeam2.Text = player2.TeamName;
            textBoxExp2.Text = Convert.ToString(player2.ExeperienceYears);
            textBoxMVP2.Text = Convert.ToString(player2.MVP);
            textBoxPosition2.Text = getPosition(player2.Position);
            textBoxTitles2.Text = Convert.ToString(player2.NumberOfTitles);
            pictureBox2.Image = ByteArrayToImage(Program._proxy.retireveImageFromDb(player2.PlayerName));
            if (pictureBox2.Image == null)
                pictureBox2.Image = no_image;
            pictureBox2.Visible = true;

            // set green color player who win that subject, otherwise red
            if (player1.MVP > player2.MVP)
             {
                 textBoxMVP1.ForeColor = Color.Green;
                 textBoxMVP2.ForeColor = Color.Red;
             }
             else if(player1.MVP < player2.MVP)
             {
                 textBoxMVP1.ForeColor = Color.Red;
                 textBoxMVP2.ForeColor = Color.Green;
             }
             else
             {
                 textBoxMVP1.ForeColor = Color.Blue;
                 textBoxMVP2.ForeColor = Color.Blue;
             }

            if (player1.NumberOfTitles > player2.NumberOfTitles)
            {
                textBoxTitles1.ForeColor = Color.Green;
                textBoxTitles2.ForeColor = Color.Red;
            }
            else if (player1.NumberOfTitles < player2.NumberOfTitles)
            {
                textBoxTitles1.ForeColor = Color.Red;
                textBoxTitles2.ForeColor = Color.Green;
            }
            else
            {
                textBoxTitles1.ForeColor = Color.Blue;
                textBoxTitles2.ForeColor = Color.Blue;
            }

            if (player1.ExeperienceYears > player2.ExeperienceYears)
            {
                textBoxExp1.ForeColor = Color.Green;
                textBoxExp2.ForeColor = Color.Red;
            }
            else if (player1.NumberOfTitles < player2.NumberOfTitles)
            {
                textBoxExp1.ForeColor = Color.Red;
                textBoxExp2.ForeColor = Color.Green;
            }
            else
            {
                textBoxExp1.ForeColor = Color.Blue;
                textBoxExp2.ForeColor = Color.Blue;
            }

        }

        /// <summary>
        /// get position shortcut
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private string getPosition(string position)
        {
            switch (position)
            {
                case "Point guard":
                {
                    return "PG";
                }
                case "Shooting guard":
                    {
                        return "SG";
                    }
                case "Small forward":
                    {
                        return "SF";
                    }
                case "Power forward":
                    {
                        return "PF";
                    }
                case "Center":
                    {
                        return "C";
                    }
            }
            return "Unkown";
        }
        

    }
}
