namespace WcfDuplexServiceClient
{
    partial class FormAllTimeWinners
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPlayersWinners = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewManagersWinners = new System.Windows.Forms.DataGridView();
            this.columnManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTeamWinners = new System.Windows.Forms.DataGridView();
            this.ColumnTeamT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChampionships = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeamP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitlesP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayersWinners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagersWinners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamWinners)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Most Winner Manager";
            // 
            // dataGridViewPlayersWinners
            // 
            this.dataGridViewPlayersWinners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayersWinners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPlayer,
            this.ColumnTeamP,
            this.ColumnTitlesP});
            this.dataGridViewPlayersWinners.Location = new System.Drawing.Point(380, 29);
            this.dataGridViewPlayersWinners.Name = "dataGridViewPlayersWinners";
            this.dataGridViewPlayersWinners.RowTemplate.Height = 24;
            this.dataGridViewPlayersWinners.Size = new System.Drawing.Size(356, 587);
            this.dataGridViewPlayersWinners.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Most Winner Players";
            // 
            // dataGridViewManagersWinners
            // 
            this.dataGridViewManagersWinners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManagersWinners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnManager,
            this.ColumnTeam,
            this.ColumnTitles});
            this.dataGridViewManagersWinners.Location = new System.Drawing.Point(8, 29);
            this.dataGridViewManagersWinners.Name = "dataGridViewManagersWinners";
            this.dataGridViewManagersWinners.RowTemplate.Height = 24;
            this.dataGridViewManagersWinners.Size = new System.Drawing.Size(356, 587);
            this.dataGridViewManagersWinners.TabIndex = 3;
            // 
            // columnManager
            // 
            this.columnManager.HeaderText = "Manager";
            this.columnManager.Name = "columnManager";
            // 
            // ColumnTeam
            // 
            this.ColumnTeam.HeaderText = "Team";
            this.ColumnTeam.Name = "ColumnTeam";
            // 
            // ColumnTitles
            // 
            this.ColumnTitles.HeaderText = "Titles";
            this.ColumnTitles.Name = "ColumnTitles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(874, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Most Team Winners";
            // 
            // dataGridViewTeamWinners
            // 
            this.dataGridViewTeamWinners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeamWinners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTeamT,
            this.ColumnChampionships});
            this.dataGridViewTeamWinners.Location = new System.Drawing.Point(758, 29);
            this.dataGridViewTeamWinners.Name = "dataGridViewTeamWinners";
            this.dataGridViewTeamWinners.RowTemplate.Height = 24;
            this.dataGridViewTeamWinners.Size = new System.Drawing.Size(356, 587);
            this.dataGridViewTeamWinners.TabIndex = 6;
            // 
            // ColumnTeamT
            // 
            this.ColumnTeamT.HeaderText = "Team";
            this.ColumnTeamT.Name = "ColumnTeamT";
            // 
            // ColumnChampionships
            // 
            this.ColumnChampionships.HeaderText = "Championships";
            this.ColumnChampionships.Name = "ColumnChampionships";
            this.ColumnChampionships.Width = 120;
            // 
            // ColumnPlayer
            // 
            this.ColumnPlayer.HeaderText = "Player";
            this.ColumnPlayer.Name = "ColumnPlayer";
            // 
            // ColumnTeamP
            // 
            this.ColumnTeamP.HeaderText = "Team";
            this.ColumnTeamP.Name = "ColumnTeamP";
            // 
            // ColumnTitlesP
            // 
            this.ColumnTitlesP.HeaderText = "Titles";
            this.ColumnTitlesP.Name = "ColumnTitlesP";
            // 
            // FormAllTimeWinners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 677);
            this.Controls.Add(this.dataGridViewTeamWinners);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewManagersWinners);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewPlayersWinners);
            this.Controls.Add(this.label1);
            this.Name = "FormAllTimeWinners";
            this.Text = "FormStatistics";
            this.Load += new System.EventHandler(this.FormAllTimeWinners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayersWinners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagersWinners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamWinners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPlayersWinners;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewManagersWinners;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeamP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitlesP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewTeamWinners;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeamT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChampionships;
    }
}