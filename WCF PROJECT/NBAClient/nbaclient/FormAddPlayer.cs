
using System;
using System.Drawing;
using System.IO;
using System.ServiceModel;
using System.Windows.Forms;
using WcfDuplexServiceInterface;

namespace WcfDuplexServiceClient
{
    public partial class FormAddPlayer : Form
    {

        //Binary file_binary;
        private byte[] file_byte;
        Image tmp_image;

        //private string _imgName;

        public FormAddPlayer()
        {
            InitializeComponent();
            file_byte = null;
            tmp_image = pictureBoxNewPlayer.Image;
        }

        /// <summary>
        /// Add picture for the new player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxNewPlayer_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "bmp files (*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Convert System.Drawing.Image to a byte[]
                    
                    file_byte = ImageToByteArray(new Bitmap(dlg.FileName));
                    pictureBoxNewPlayer.Image = Image.FromFile(dlg.FileName);
                }
            }
        }

        /// <summary>
        /// send player data to the server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            if(CheckTextBoxFields() == false)
            {
                MessageBox.Show("Wrong input!", "Insert data again");
                return;
            }
            try
            {
                Program._proxy.InsertPlayer(textBoxPlayerName.Text, comboBoxTeams.SelectedItem.ToString(), Convert.ToInt32(textBoxAge.Text),
                   Convert.ToDouble(textBoxHeight.Text), Convert.ToDouble(textBoxWeight.Text), comboBoxPosition.Text, Convert.ToInt32(textBoxExperience.Text),
                   Convert.ToInt32(textBoxTitles.Text), file_byte, comboBoxAgents.Text);
            }
            catch(FaultException<DataBaseException> ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            ClearTextBoxes();
            pictureBoxNewPlayer.Image = tmp_image;
            file_byte = null;
        }

        /// <summary>
        /// check the text boxes validation
        /// </summary>
        /// <returns></returns>
        private bool CheckTextBoxFields()
        {
            if (RegexValidations.NameValidation(textBoxPlayerName.Text) &&
                RegexValidations.NumericValidation(textBoxExperience.Text) &&
                RegexValidations.NumericValidation(textBoxAge.Text) &&
                RegexValidations.NumericValidation(textBoxTitles.Text) &&
                RegexValidations.HeightAndWeightValidation(textBoxHeight.Text) &&
                RegexValidations.HeightAndWeightValidation(textBoxWeight.Text))
                return true;
            else
            {
                // change the color of the specific textBox problem
                if (!RegexValidations.NameValidation(textBoxPlayerName.Text))
                    textBoxPlayerName.ForeColor = Color.Red;
                if (!RegexValidations.NameValidation(textBoxExperience.Text))
                    textBoxPlayerName.ForeColor = Color.Red;
                if (!RegexValidations.NameValidation(textBoxAge.Text))
                    textBoxPlayerName.ForeColor = Color.Red;
                if (!RegexValidations.NameValidation(textBoxTitles.Text))
                    textBoxPlayerName.ForeColor = Color.Red;
                if (!RegexValidations.NameValidation(textBoxHeight.Text))
                    textBoxPlayerName.ForeColor = Color.Red;
                if (!RegexValidations.NameValidation(textBoxWeight.Text))
                    textBoxPlayerName.ForeColor = Color.Red;
                return false;
            }

        }

        /// <summary>
        /// Clear all the textboxes fields, and change the color to black
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxAge.Text = string.Empty;
            textBoxExperience.Text = string.Empty;
            textBoxHeight.Text = string.Empty;
            textBoxPlayerName.Text = string.Empty;
            textBoxTitles.Text = string.Empty;
            textBoxWeight.Text = string.Empty;
            textBoxExperience.ForeColor = Color.Black;
            textBoxHeight.ForeColor = Color.Black;
            textBoxPlayerName.ForeColor = Color.Black;
            textBoxWeight.ForeColor = Color.Black;
            textBoxTitles.ForeColor = Color.Black;
            textBoxAge.ForeColor = Color.Black;
        }

        private void FormAddPlayer_Load(object sender, EventArgs e)
        {
            UploadTeam();
            UploadAgents();
        
        }

        /// <summary>
        /// upload teams to 'comboBoxTeams'
        /// </summary>
        private void UploadTeam()
        {
            foreach (var team in Program._proxy.UploadTeam())
            {
                comboBoxTeams.Items.Add(team);
            }
            // if there is no teams in data base, close the form.
            if (comboBoxTeams.Items.Count == 0)
            {
                MessageBox.Show("There is no teams yet", "Please add a team", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        /// <summary>
        /// Upload agents to comboBox Agents
        /// </summary>
        private void UploadAgents()
        {
            // Upload agents to ComboBox 
            foreach (var agent in Program._proxy.UploadAgents())
            {
                comboBoxAgents.Items.Add(agent);
            }
        }

        /// <summary>
        /// change Image format, to store the image on the database
        /// </summary>
        /// <param name="imageIn"></param>
        /// <returns></returns>
        public static byte[] ImageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
