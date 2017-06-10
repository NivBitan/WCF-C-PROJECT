namespace WcfDuplexServiceClient
{
    partial class FormAddManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddManager));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxManagerName = new System.Windows.Forms.TextBox();
            this.textBoxExperience = new System.Windows.Forms.TextBox();
            this.textBoxTitles = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.comboBoxTeams = new System.Windows.Forms.ComboBox();
            this.buttonAddManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of tiltles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Experience";
            // 
            // textBoxManagerName
            // 
            this.textBoxManagerName.Location = new System.Drawing.Point(232, 163);
            this.textBoxManagerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxManagerName.Name = "textBoxManagerName";
            this.textBoxManagerName.Size = new System.Drawing.Size(184, 22);
            this.textBoxManagerName.TabIndex = 5;
            // 
            // textBoxExperience
            // 
            this.textBoxExperience.Location = new System.Drawing.Point(266, 363);
            this.textBoxExperience.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExperience.Name = "textBoxExperience";
            this.textBoxExperience.Size = new System.Drawing.Size(100, 22);
            this.textBoxExperience.TabIndex = 9;
            // 
            // textBoxTitles
            // 
            this.textBoxTitles.Location = new System.Drawing.Point(603, 262);
            this.textBoxTitles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitles.Name = "textBoxTitles";
            this.textBoxTitles.Size = new System.Drawing.Size(100, 22);
            this.textBoxTitles.TabIndex = 8;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(266, 262);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 22);
            this.textBoxAge.TabIndex = 7;
            // 
            // comboBoxTeams
            // 
            this.comboBoxTeams.FormattingEnabled = true;
            this.comboBoxTeams.Location = new System.Drawing.Point(603, 160);
            this.comboBoxTeams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTeams.Name = "comboBoxTeams";
            this.comboBoxTeams.Size = new System.Drawing.Size(157, 24);
            this.comboBoxTeams.TabIndex = 6;
            // 
            // buttonAddManager
            // 
            this.buttonAddManager.Location = new System.Drawing.Point(603, 342);
            this.buttonAddManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddManager.Name = "buttonAddManager";
            this.buttonAddManager.Size = new System.Drawing.Size(128, 43);
            this.buttonAddManager.TabIndex = 10;
            this.buttonAddManager.Text = "Add manager";
            this.buttonAddManager.UseVisualStyleBackColor = true;
            this.buttonAddManager.Click += new System.EventHandler(this.buttonAddManager_Click);
            // 
            // FormAddManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 451);
            this.Controls.Add(this.buttonAddManager);
            this.Controls.Add(this.comboBoxTeams);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxTitles);
            this.Controls.Add(this.textBoxExperience);
            this.Controls.Add(this.textBoxManagerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddManager";
            this.Text = "buttom";
            this.Load += new System.EventHandler(this.FormAddManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxManagerName;
        private System.Windows.Forms.TextBox textBoxExperience;
        private System.Windows.Forms.TextBox textBoxTitles;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.ComboBox comboBoxTeams;
        private System.Windows.Forms.Button buttonAddManager;
    }
}