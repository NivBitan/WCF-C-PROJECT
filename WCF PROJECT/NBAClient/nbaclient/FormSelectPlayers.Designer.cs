namespace WcfDuplexServiceClient
{
    partial class FormSelectPlayers
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
            this.comboBoxPlayer1 = new System.Windows.Forms.ComboBox();
            this.comboBoxPlayer2 = new System.Windows.Forms.ComboBox();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPlayer1
            // 
            this.comboBoxPlayer1.FormattingEnabled = true;
            this.comboBoxPlayer1.Location = new System.Drawing.Point(28, 92);
            this.comboBoxPlayer1.Name = "comboBoxPlayer1";
            this.comboBoxPlayer1.Size = new System.Drawing.Size(195, 24);
            this.comboBoxPlayer1.TabIndex = 0;
            this.comboBoxPlayer1.Text = "Player1";
            // 
            // comboBoxPlayer2
            // 
            this.comboBoxPlayer2.FormattingEnabled = true;
            this.comboBoxPlayer2.Location = new System.Drawing.Point(244, 92);
            this.comboBoxPlayer2.Name = "comboBoxPlayer2";
            this.comboBoxPlayer2.Size = new System.Drawing.Size(194, 24);
            this.comboBoxPlayer2.TabIndex = 1;
            this.comboBoxPlayer2.Text = "Player2";
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(166, 169);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(99, 38);
            this.buttonCompare.TabIndex = 2;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // FormSelectPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 268);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.comboBoxPlayer2);
            this.Controls.Add(this.comboBoxPlayer1);
            this.Name = "FormSelectPlayers";
            this.Text = "FormSelectPlyers";
            this.Load += new System.EventHandler(this.FormSelectPlyers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPlayer1;
        private System.Windows.Forms.ComboBox comboBoxPlayer2;
        private System.Windows.Forms.Button buttonCompare;
    }
}