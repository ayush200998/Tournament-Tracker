namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.tournamentdashboardheader = new System.Windows.Forms.Label();
            this.loadtournamentbutton = new System.Windows.Forms.Button();
            this.loadexistingtournamentvalue = new System.Windows.Forms.ComboBox();
            this.loadexistingtournament = new System.Windows.Forms.Label();
            this.createtournamentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentdashboardheader
            // 
            this.tournamentdashboardheader.AccessibleName = "";
            this.tournamentdashboardheader.AutoSize = true;
            this.tournamentdashboardheader.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentdashboardheader.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.tournamentdashboardheader.Location = new System.Drawing.Point(280, 60);
            this.tournamentdashboardheader.Name = "tournamentdashboardheader";
            this.tournamentdashboardheader.Size = new System.Drawing.Size(345, 45);
            this.tournamentdashboardheader.TabIndex = 15;
            this.tournamentdashboardheader.Text = "Tournament Dashboard";
            // 
            // loadtournamentbutton
            // 
            this.loadtournamentbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadtournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.loadtournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.loadtournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.loadtournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadtournamentbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadtournamentbutton.ForeColor = System.Drawing.Color.Turquoise;
            this.loadtournamentbutton.Location = new System.Drawing.Point(325, 238);
            this.loadtournamentbutton.Name = "loadtournamentbutton";
            this.loadtournamentbutton.Size = new System.Drawing.Size(251, 51);
            this.loadtournamentbutton.TabIndex = 28;
            this.loadtournamentbutton.Text = "Load Tournament";
            this.loadtournamentbutton.UseVisualStyleBackColor = true;
            // 
            // loadexistingtournamentvalue
            // 
            this.loadexistingtournamentvalue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.loadexistingtournamentvalue.FormattingEnabled = true;
            this.loadexistingtournamentvalue.Location = new System.Drawing.Point(288, 172);
            this.loadexistingtournamentvalue.Name = "loadexistingtournamentvalue";
            this.loadexistingtournamentvalue.Size = new System.Drawing.Size(323, 45);
            this.loadexistingtournamentvalue.TabIndex = 27;
            // 
            // loadexistingtournament
            // 
            this.loadexistingtournament.AutoSize = true;
            this.loadexistingtournament.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadexistingtournament.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.loadexistingtournament.Location = new System.Drawing.Point(281, 128);
            this.loadexistingtournament.Name = "loadexistingtournament";
            this.loadexistingtournament.Size = new System.Drawing.Size(359, 41);
            this.loadexistingtournament.TabIndex = 26;
            this.loadexistingtournament.Text = "Load Existing Tournament";
            // 
            // createtournamentbutton
            // 
            this.createtournamentbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createtournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.createtournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(12)))));
            this.createtournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.createtournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createtournamentbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createtournamentbutton.ForeColor = System.Drawing.Color.Turquoise;
            this.createtournamentbutton.Location = new System.Drawing.Point(310, 344);
            this.createtournamentbutton.Name = "createtournamentbutton";
            this.createtournamentbutton.Size = new System.Drawing.Size(274, 85);
            this.createtournamentbutton.TabIndex = 29;
            this.createtournamentbutton.Text = "Create Tournament";
            this.createtournamentbutton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 549);
            this.Controls.Add(this.createtournamentbutton);
            this.Controls.Add(this.loadtournamentbutton);
            this.Controls.Add(this.loadexistingtournamentvalue);
            this.Controls.Add(this.loadexistingtournament);
            this.Controls.Add(this.tournamentdashboardheader);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "TournamentDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentdashboardheader;
        private System.Windows.Forms.Button loadtournamentbutton;
        private System.Windows.Forms.ComboBox loadexistingtournamentvalue;
        private System.Windows.Forms.Label loadexistingtournament;
        private System.Windows.Forms.Button createtournamentbutton;
    }
}