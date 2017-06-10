using System.Windows.Forms;

namespace WcfDuplexServiceClient
{
    partial class FormOneOnOne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOneOnOne));
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelTeam = new System.Windows.Forms.Label();
            this.labelExperience = new System.Windows.Forms.Label();
            this.labelTitles = new System.Windows.Forms.Label();
            this.labelMVP = new System.Windows.Forms.Label();
            this.textBoxPosition1 = new System.Windows.Forms.TextBox();
            this.textBoxTeam1 = new System.Windows.Forms.TextBox();
            this.textBoxTitles1 = new System.Windows.Forms.TextBox();
            this.textBoxExp1 = new System.Windows.Forms.TextBox();
            this.textBoxMVP1 = new System.Windows.Forms.TextBox();
            this.textBoxPosition2 = new System.Windows.Forms.TextBox();
            this.textBoxTeam2 = new System.Windows.Forms.TextBox();
            this.textBoxExp2 = new System.Windows.Forms.TextBox();
            this.textBoxTitles2 = new System.Windows.Forms.TextBox();
            this.textBoxMVP2 = new System.Windows.Forms.TextBox();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.buttonSelectPlayers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.BackColor = System.Drawing.Color.Transparent;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSubject.ForeColor = System.Drawing.Color.White;
            this.labelSubject.Location = new System.Drawing.Point(533, 145);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(72, 20);
            this.labelSubject.TabIndex = 1;
            this.labelSubject.Text = "Subject";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPosition.ForeColor = System.Drawing.Color.Black;
            this.labelPosition.Location = new System.Drawing.Point(532, 236);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(69, 20);
            this.labelPosition.TabIndex = 3;
            this.labelPosition.Text = "Position";
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTeam.ForeColor = System.Drawing.Color.Black;
            this.labelTeam.Location = new System.Drawing.Point(532, 320);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(51, 20);
            this.labelTeam.TabIndex = 4;
            this.labelTeam.Text = "Team";
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelExperience.ForeColor = System.Drawing.Color.Black;
            this.labelExperience.Location = new System.Drawing.Point(532, 391);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(92, 20);
            this.labelExperience.TabIndex = 5;
            this.labelExperience.Text = "Experience";
            // 
            // labelTitles
            // 
            this.labelTitles.AutoSize = true;
            this.labelTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTitles.ForeColor = System.Drawing.Color.Black;
            this.labelTitles.Location = new System.Drawing.Point(535, 476);
            this.labelTitles.Name = "labelTitles";
            this.labelTitles.Size = new System.Drawing.Size(50, 20);
            this.labelTitles.TabIndex = 6;
            this.labelTitles.Text = "Titles";
            // 
            // labelMVP
            // 
            this.labelMVP.AutoSize = true;
            this.labelMVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMVP.ForeColor = System.Drawing.Color.Black;
            this.labelMVP.Location = new System.Drawing.Point(535, 551);
            this.labelMVP.Name = "labelMVP";
            this.labelMVP.Size = new System.Drawing.Size(45, 20);
            this.labelMVP.TabIndex = 7;
            this.labelMVP.Text = "MVP";
            // 
            // textBoxPosition1
            // 
            this.textBoxPosition1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPosition1.Location = new System.Drawing.Point(384, 236);
            this.textBoxPosition1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPosition1.Name = "textBoxPosition1";
            this.textBoxPosition1.Size = new System.Drawing.Size(100, 26);
            this.textBoxPosition1.TabIndex = 8;
            // 
            // textBoxTeam1
            // 
            this.textBoxTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxTeam1.Location = new System.Drawing.Point(384, 320);
            this.textBoxTeam1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTeam1.Name = "textBoxTeam1";
            this.textBoxTeam1.Size = new System.Drawing.Size(100, 26);
            this.textBoxTeam1.TabIndex = 9;
            // 
            // textBoxTitles1
            // 
            this.textBoxTitles1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxTitles1.Location = new System.Drawing.Point(384, 476);
            this.textBoxTitles1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitles1.Name = "textBoxTitles1";
            this.textBoxTitles1.Size = new System.Drawing.Size(100, 26);
            this.textBoxTitles1.TabIndex = 10;
            // 
            // textBoxExp1
            // 
            this.textBoxExp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxExp1.Location = new System.Drawing.Point(384, 391);
            this.textBoxExp1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExp1.Name = "textBoxExp1";
            this.textBoxExp1.Size = new System.Drawing.Size(100, 26);
            this.textBoxExp1.TabIndex = 11;
            // 
            // textBoxMVP1
            // 
            this.textBoxMVP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxMVP1.Location = new System.Drawing.Point(384, 551);
            this.textBoxMVP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMVP1.Name = "textBoxMVP1";
            this.textBoxMVP1.Size = new System.Drawing.Size(100, 26);
            this.textBoxMVP1.TabIndex = 12;
            // 
            // textBoxPosition2
            // 
            this.textBoxPosition2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPosition2.Location = new System.Drawing.Point(639, 236);
            this.textBoxPosition2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPosition2.Name = "textBoxPosition2";
            this.textBoxPosition2.Size = new System.Drawing.Size(100, 26);
            this.textBoxPosition2.TabIndex = 13;
            // 
            // textBoxTeam2
            // 
            this.textBoxTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxTeam2.Location = new System.Drawing.Point(639, 318);
            this.textBoxTeam2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTeam2.Name = "textBoxTeam2";
            this.textBoxTeam2.Size = new System.Drawing.Size(100, 26);
            this.textBoxTeam2.TabIndex = 14;
            // 
            // textBoxExp2
            // 
            this.textBoxExp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxExp2.Location = new System.Drawing.Point(639, 391);
            this.textBoxExp2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExp2.Name = "textBoxExp2";
            this.textBoxExp2.Size = new System.Drawing.Size(100, 26);
            this.textBoxExp2.TabIndex = 15;
            // 
            // textBoxTitles2
            // 
            this.textBoxTitles2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxTitles2.Location = new System.Drawing.Point(639, 476);
            this.textBoxTitles2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitles2.Name = "textBoxTitles2";
            this.textBoxTitles2.Size = new System.Drawing.Size(100, 26);
            this.textBoxTitles2.TabIndex = 16;
            // 
            // textBoxMVP2
            // 
            this.textBoxMVP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxMVP2.Location = new System.Drawing.Point(639, 551);
            this.textBoxMVP2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMVP2.Name = "textBoxMVP2";
            this.textBoxMVP2.Size = new System.Drawing.Size(100, 26);
            this.textBoxMVP2.TabIndex = 17;
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPlayer1.ForeColor = System.Drawing.Color.White;
            this.labelPlayer1.Location = new System.Drawing.Point(408, 145);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(72, 20);
            this.labelPlayer1.TabIndex = 0;
            this.labelPlayer1.Text = "Player1";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPlayer2.ForeColor = System.Drawing.Color.White;
            this.labelPlayer2.Location = new System.Drawing.Point(635, 145);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(72, 20);
            this.labelPlayer2.TabIndex = 2;
            this.labelPlayer2.Text = "Player2";
            // 
            // buttonSelectPlayers
            // 
            this.buttonSelectPlayers.Location = new System.Drawing.Point(499, 22);
            this.buttonSelectPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelectPlayers.Name = "buttonSelectPlayers";
            this.buttonSelectPlayers.Size = new System.Drawing.Size(136, 37);
            this.buttonSelectPlayers.TabIndex = 18;
            this.buttonSelectPlayers.Text = "Select players";
            this.buttonSelectPlayers.UseVisualStyleBackColor = true;
            this.buttonSelectPlayers.Click += new System.EventHandler(this.buttonSelectPlayers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(833, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 244);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // FormOneOnOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 720);
            this.Controls.Add(this.buttonSelectPlayers);
            this.Controls.Add(this.textBoxMVP2);
            this.Controls.Add(this.textBoxTitles2);
            this.Controls.Add(this.textBoxExp2);
            this.Controls.Add(this.textBoxTeam2);
            this.Controls.Add(this.textBoxPosition2);
            this.Controls.Add(this.textBoxMVP1);
            this.Controls.Add(this.textBoxExp1);
            this.Controls.Add(this.textBoxTitles1);
            this.Controls.Add(this.textBoxTeam1);
            this.Controls.Add(this.textBoxPosition1);
            this.Controls.Add(this.labelMVP);
            this.Controls.Add(this.labelTitles);
            this.Controls.Add(this.labelExperience);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOneOnOne";
            this.Text = "FormOneOnOne";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.Label labelTitles;
        private System.Windows.Forms.Label labelMVP;
        private System.Windows.Forms.TextBox textBoxPosition1;
        private System.Windows.Forms.TextBox textBoxTeam1;
        private System.Windows.Forms.TextBox textBoxTitles1;
        private System.Windows.Forms.TextBox textBoxExp1;
        private System.Windows.Forms.TextBox textBoxMVP1;
        private System.Windows.Forms.TextBox textBoxPosition2;
        private System.Windows.Forms.TextBox textBoxTeam2;
        private System.Windows.Forms.TextBox textBoxExp2;
        private System.Windows.Forms.TextBox textBoxTitles2;
        private System.Windows.Forms.TextBox textBoxMVP2;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Button buttonSelectPlayers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}