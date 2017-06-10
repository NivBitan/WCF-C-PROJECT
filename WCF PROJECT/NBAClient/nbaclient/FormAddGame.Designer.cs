namespace WcfDuplexServiceClient
{
    partial class FormAddGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddGame));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxHome = new System.Windows.Forms.ComboBox();
            this.comboBoxAway = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHomeScore = new System.Windows.Forms.TextBox();
            this.textBoxAwayScore = new System.Windows.Forms.TextBox();
            this.comboBoxFixture = new System.Windows.Forms.ComboBox();
            this.calendarGames = new System.Windows.Forms.MonthCalendar();
            this.comboBoxMVP = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(99, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(527, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Away team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(527, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(99, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(311, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fixtures";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(311, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "MVP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(311, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date";
            // 
            // comboBoxHome
            // 
            this.comboBoxHome.FormattingEnabled = true;
            this.comboBoxHome.Location = new System.Drawing.Point(43, 129);
            this.comboBoxHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxHome.Name = "comboBoxHome";
            this.comboBoxHome.Size = new System.Drawing.Size(186, 24);
            this.comboBoxHome.TabIndex = 7;
            this.comboBoxHome.SelectedValueChanged += new System.EventHandler(this.comboBoxHome_SelectedValueChanged);
            // 
            // comboBoxAway
            // 
            this.comboBoxAway.FormattingEnabled = true;
            this.comboBoxAway.Location = new System.Drawing.Point(463, 129);
            this.comboBoxAway.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAway.Name = "comboBoxAway";
            this.comboBoxAway.Size = new System.Drawing.Size(182, 24);
            this.comboBoxAway.TabIndex = 8;
            this.comboBoxAway.SelectedValueChanged += new System.EventHandler(this.comboBoxAway_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(255, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "NBA game!";
            // 
            // textBoxHomeScore
            // 
            this.textBoxHomeScore.Location = new System.Drawing.Point(75, 250);
            this.textBoxHomeScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHomeScore.Name = "textBoxHomeScore";
            this.textBoxHomeScore.Size = new System.Drawing.Size(100, 22);
            this.textBoxHomeScore.TabIndex = 10;
            // 
            // textBoxAwayScore
            // 
            this.textBoxAwayScore.Location = new System.Drawing.Point(503, 250);
            this.textBoxAwayScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAwayScore.Name = "textBoxAwayScore";
            this.textBoxAwayScore.Size = new System.Drawing.Size(100, 22);
            this.textBoxAwayScore.TabIndex = 11;
            // 
            // comboBoxFixture
            // 
            this.comboBoxFixture.FormattingEnabled = true;
            this.comboBoxFixture.Location = new System.Drawing.Point(301, 129);
            this.comboBoxFixture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxFixture.Name = "comboBoxFixture";
            this.comboBoxFixture.Size = new System.Drawing.Size(75, 24);
            this.comboBoxFixture.TabIndex = 12;
            // 
            // calendarGames
            // 
            this.calendarGames.Location = new System.Drawing.Point(188, 250);
            this.calendarGames.Name = "calendarGames";
            this.calendarGames.TabIndex = 13;
            // 
            // comboBoxMVP
            // 
            this.comboBoxMVP.FormattingEnabled = true;
            this.comboBoxMVP.Location = new System.Drawing.Point(214, 539);
            this.comboBoxMVP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMVP.Name = "comboBoxMVP";
            this.comboBoxMVP.Size = new System.Drawing.Size(236, 24);
            this.comboBoxMVP.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(43, 539);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 604);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxMVP);
            this.Controls.Add(this.calendarGames);
            this.Controls.Add(this.comboBoxFixture);
            this.Controls.Add(this.textBoxAwayScore);
            this.Controls.Add(this.textBoxHomeScore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxAway);
            this.Controls.Add(this.comboBoxHome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddGame";
            this.Text = "FormAddGame";
            this.Load += new System.EventHandler(this.FormAddGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxHome;
        private System.Windows.Forms.ComboBox comboBoxAway;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxHomeScore;
        private System.Windows.Forms.TextBox textBoxAwayScore;
        private System.Windows.Forms.ComboBox comboBoxFixture;
        private System.Windows.Forms.MonthCalendar calendarGames;
        private System.Windows.Forms.ComboBox comboBoxMVP;
        private System.Windows.Forms.Button button1;
    }
}