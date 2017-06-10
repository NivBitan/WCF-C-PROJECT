namespace WcfDuplexServiceClient
{
    partial class FormTable
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
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.labelRegion = new System.Windows.Forms.Label();
            this.ColumnTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTeam,
            this.ColumnGames,
            this.ColumnWin,
            this.ColumnLose,
            this.ColumnPoints});
            this.dataGridViewTable.Location = new System.Drawing.Point(106, 90);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowTemplate.Height = 24;
            this.dataGridViewTable.Size = new System.Drawing.Size(546, 481);
            this.dataGridViewTable.TabIndex = 0;
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Location = new System.Drawing.Point(292, 36);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(46, 17);
            this.labelRegion.TabIndex = 1;
            this.labelRegion.Text = "label1";
            // 
            // ColumnTeam
            // 
            this.ColumnTeam.HeaderText = "Team";
            this.ColumnTeam.Name = "ColumnTeam";
            // 
            // ColumnGames
            // 
            this.ColumnGames.HeaderText = "Games";
            this.ColumnGames.Name = "ColumnGames";
            // 
            // ColumnWin
            // 
            this.ColumnWin.HeaderText = "W";
            this.ColumnWin.Name = "ColumnWin";
            // 
            // ColumnLose
            // 
            this.ColumnLose.HeaderText = "L";
            this.ColumnLose.Name = "ColumnLose";
            // 
            // ColumnPoints
            // 
            this.ColumnPoints.HeaderText = "Points";
            this.ColumnPoints.Name = "ColumnPoints";
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 613);
            this.Controls.Add(this.labelRegion);
            this.Controls.Add(this.dataGridViewTable);
            this.Name = "FormTable";
            this.Text = "FormTable";
            this.Load += new System.EventHandler(this.FormTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPoints;
    }
}