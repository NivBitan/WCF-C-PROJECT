namespace WcfDuplexServiceClient
{
    partial class FormDeletePlayerAndManagers
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
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.comboBoxDeleteSelect = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.radioButtonPlayer = new System.Windows.Forms.RadioButton();
            this.radioButtonManager = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(12, 47);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(224, 24);
            this.comboBoxTeam.TabIndex = 0;
            this.comboBoxTeam.Text = "Select team";
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeam_SelectedIndexChanged);
            // 
            // comboBoxDeleteSelect
            // 
            this.comboBoxDeleteSelect.FormattingEnabled = true;
            this.comboBoxDeleteSelect.Location = new System.Drawing.Point(12, 146);
            this.comboBoxDeleteSelect.Name = "comboBoxDeleteSelect";
            this.comboBoxDeleteSelect.Size = new System.Drawing.Size(224, 24);
            this.comboBoxDeleteSelect.TabIndex = 1;
            this.comboBoxDeleteSelect.Text = "Player to delete";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(308, 88);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 31);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonPlayer
            // 
            this.radioButtonPlayer.AutoSize = true;
            this.radioButtonPlayer.Checked = true;
            this.radioButtonPlayer.Location = new System.Drawing.Point(20, 21);
            this.radioButtonPlayer.Name = "radioButtonPlayer";
            this.radioButtonPlayer.Size = new System.Drawing.Size(69, 21);
            this.radioButtonPlayer.TabIndex = 3;
            this.radioButtonPlayer.TabStop = true;
            this.radioButtonPlayer.Text = "Player";
            this.radioButtonPlayer.UseVisualStyleBackColor = true;
            this.radioButtonPlayer.CheckedChanged += new System.EventHandler(this.radioButtonPlayer_CheckedChanged);
            // 
            // radioButtonManager
            // 
            this.radioButtonManager.AutoSize = true;
            this.radioButtonManager.Location = new System.Drawing.Point(139, 21);
            this.radioButtonManager.Name = "radioButtonManager";
            this.radioButtonManager.Size = new System.Drawing.Size(85, 21);
            this.radioButtonManager.TabIndex = 4;
            this.radioButtonManager.TabStop = true;
            this.radioButtonManager.Text = "Manager";
            this.radioButtonManager.UseVisualStyleBackColor = true;
            this.radioButtonManager.CheckedChanged += new System.EventHandler(this.radioButtonManager_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonManager);
            this.groupBox1.Controls.Add(this.radioButtonPlayer);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 54);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete option";
            // 
            // FormDeletePlayerAndManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 202);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxDeleteSelect);
            this.Controls.Add(this.comboBoxTeam);
            this.Name = "FormDeletePlayerAndManagers";
            this.Text = "FormDeletePlayer";
            this.Load += new System.EventHandler(this.FormDeletePlayer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.ComboBox comboBoxDeleteSelect;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.RadioButton radioButtonPlayer;
        private System.Windows.Forms.RadioButton radioButtonManager;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}