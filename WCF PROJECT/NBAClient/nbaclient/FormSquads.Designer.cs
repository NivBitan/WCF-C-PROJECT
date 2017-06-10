namespace WcfDuplexServiceClient
{
    partial class FormSquads
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSquads));
            this.comboBoxTeams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSquad = new System.Windows.Forms.DataGridView();
            this.ColumnPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSquad)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTeams
            // 
            this.comboBoxTeams.FormattingEnabled = true;
            this.comboBoxTeams.Location = new System.Drawing.Point(12, 37);
            this.comboBoxTeams.Name = "comboBoxTeams";
            this.comboBoxTeams.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTeams.TabIndex = 0;
            this.comboBoxTeams.Text = "Choose a team";
            this.comboBoxTeams.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeams_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Squad";
            // 
            // dataGridViewSquad
            // 
            this.dataGridViewSquad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSquad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPlayer,
            this.ColumnPosition,
            this.ColumnAge,
            this.ColumnHeight,
            this.ColumnWeight,
            this.ColumnMVP,
            this.ColumnExp,
            this.ColumnTitles});
            this.dataGridViewSquad.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewSquad.Name = "dataGridViewSquad";
            this.dataGridViewSquad.RowTemplate.Height = 24;
            this.dataGridViewSquad.Size = new System.Drawing.Size(852, 359);
            this.dataGridViewSquad.TabIndex = 2;
            // 
            // ColumnPlayer
            // 
            this.ColumnPlayer.HeaderText = "Player";
            this.ColumnPlayer.Name = "ColumnPlayer";
            this.ColumnPlayer.ReadOnly = true;
            // 
            // ColumnPosition
            // 
            this.ColumnPosition.HeaderText = "Position";
            this.ColumnPosition.Name = "ColumnPosition";
            this.ColumnPosition.ReadOnly = true;
            // 
            // ColumnAge
            // 
            this.ColumnAge.HeaderText = "Age";
            this.ColumnAge.Name = "ColumnAge";
            this.ColumnAge.ReadOnly = true;
            // 
            // ColumnHeight
            // 
            this.ColumnHeight.HeaderText = "Height";
            this.ColumnHeight.Name = "ColumnHeight";
            this.ColumnHeight.ReadOnly = true;
            // 
            // ColumnWeight
            // 
            this.ColumnWeight.HeaderText = "Weight";
            this.ColumnWeight.Name = "ColumnWeight";
            this.ColumnWeight.ReadOnly = true;
            // 
            // ColumnMVP
            // 
            this.ColumnMVP.HeaderText = "MVP";
            this.ColumnMVP.Name = "ColumnMVP";
            this.ColumnMVP.ReadOnly = true;
            // 
            // ColumnExp
            // 
            this.ColumnExp.HeaderText = "Experience";
            this.ColumnExp.Name = "ColumnExp";
            this.ColumnExp.ReadOnly = true;
            // 
            // ColumnTitles
            // 
            this.ColumnTitles.HeaderText = "Titles";
            this.ColumnTitles.Name = "ColumnTitles";
            this.ColumnTitles.ReadOnly = true;
            // 
            // FormSquads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(888, 509);
            this.Controls.Add(this.dataGridViewSquad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTeams);
            this.Name = "FormSquads";
            this.Text = "FormSquads";
            this.Load += new System.EventHandler(this.FormSquads_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSquad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTeams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSquad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitles;
    }
}