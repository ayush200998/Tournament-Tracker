namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.headerlabel = new System.Windows.Forms.Label();
            this.tournamentname = new System.Windows.Forms.Label();
            this.roundlabel = new System.Windows.Forms.Label();
            this.rounddropdown = new System.Windows.Forms.ComboBox();
            this.unplayedcheckbox = new System.Windows.Forms.CheckBox();
            this.matchuplistbox = new System.Windows.Forms.ListBox();
            this.teamonename = new System.Windows.Forms.Label();
            this.teamonescorelabel = new System.Windows.Forms.Label();
            this.teamonescoretextvalue = new System.Windows.Forms.TextBox();
            this.teamtwoscoretextvalue = new System.Windows.Forms.TextBox();
            this.teamtwoscorelabel = new System.Windows.Forms.Label();
            this.teamtwoname = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerlabel
            // 
            this.headerlabel.AutoSize = true;
            this.headerlabel.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.headerlabel.Location = new System.Drawing.Point(41, 32);
            this.headerlabel.Name = "headerlabel";
            this.headerlabel.Size = new System.Drawing.Size(193, 45);
            this.headerlabel.TabIndex = 0;
            this.headerlabel.Text = "Tournament:";
            // 
            // tournamentname
            // 
            this.tournamentname.AutoSize = true;
            this.tournamentname.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tournamentname.Location = new System.Drawing.Point(228, 32);
            this.tournamentname.Name = "tournamentname";
            this.tournamentname.Size = new System.Drawing.Size(92, 45);
            this.tournamentname.TabIndex = 1;
            this.tournamentname.Text = "none";
            this.tournamentname.Click += new System.EventHandler(this.tournamentname_Click);
            // 
            // roundlabel
            // 
            this.roundlabel.AutoSize = true;
            this.roundlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundlabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.roundlabel.Location = new System.Drawing.Point(42, 113);
            this.roundlabel.Name = "roundlabel";
            this.roundlabel.Size = new System.Drawing.Size(112, 41);
            this.roundlabel.TabIndex = 2;
            this.roundlabel.Text = "Round:";
            // 
            // rounddropdown
            // 
            this.rounddropdown.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.rounddropdown.FormattingEnabled = true;
            this.rounddropdown.Location = new System.Drawing.Point(171, 109);
            this.rounddropdown.Name = "rounddropdown";
            this.rounddropdown.Size = new System.Drawing.Size(216, 45);
            this.rounddropdown.TabIndex = 3;
            // 
            // unplayedcheckbox
            // 
            this.unplayedcheckbox.AutoSize = true;
            this.unplayedcheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedcheckbox.Location = new System.Drawing.Point(171, 160);
            this.unplayedcheckbox.Name = "unplayedcheckbox";
            this.unplayedcheckbox.Size = new System.Drawing.Size(149, 42);
            this.unplayedcheckbox.TabIndex = 4;
            this.unplayedcheckbox.Text = "unplayed";
            this.unplayedcheckbox.UseVisualStyleBackColor = true;
            // 
            // matchuplistbox
            // 
            this.matchuplistbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchuplistbox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.matchuplistbox.FormattingEnabled = true;
            this.matchuplistbox.ItemHeight = 37;
            this.matchuplistbox.Location = new System.Drawing.Point(49, 245);
            this.matchuplistbox.Name = "matchuplistbox";
            this.matchuplistbox.Size = new System.Drawing.Size(338, 261);
            this.matchuplistbox.TabIndex = 5;
            // 
            // teamonename
            // 
            this.teamonename.AutoSize = true;
            this.teamonename.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamonename.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.teamonename.Location = new System.Drawing.Point(479, 200);
            this.teamonename.Name = "teamonename";
            this.teamonename.Size = new System.Drawing.Size(151, 41);
            this.teamonename.TabIndex = 6;
            this.teamonename.Text = "TeamOne:";
            // 
            // teamonescorelabel
            // 
            this.teamonescorelabel.AutoSize = true;
            this.teamonescorelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamonescorelabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.teamonescorelabel.Location = new System.Drawing.Point(411, 245);
            this.teamonescorelabel.Name = "teamonescorelabel";
            this.teamonescorelabel.Size = new System.Drawing.Size(92, 41);
            this.teamonescorelabel.TabIndex = 7;
            this.teamonescorelabel.Text = "Score";
            // 
            // teamonescoretextvalue
            // 
            this.teamonescoretextvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamonescoretextvalue.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.teamonescoretextvalue.Location = new System.Drawing.Point(509, 243);
            this.teamonescoretextvalue.Name = "teamonescoretextvalue";
            this.teamonescoretextvalue.Size = new System.Drawing.Size(159, 43);
            this.teamonescoretextvalue.TabIndex = 8;
            // 
            // teamtwoscoretextvalue
            // 
            this.teamtwoscoretextvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamtwoscoretextvalue.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.teamtwoscoretextvalue.Location = new System.Drawing.Point(509, 396);
            this.teamtwoscoretextvalue.Name = "teamtwoscoretextvalue";
            this.teamtwoscoretextvalue.Size = new System.Drawing.Size(159, 43);
            this.teamtwoscoretextvalue.TabIndex = 11;
            // 
            // teamtwoscorelabel
            // 
            this.teamtwoscorelabel.AutoSize = true;
            this.teamtwoscorelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamtwoscorelabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.teamtwoscorelabel.Location = new System.Drawing.Point(411, 398);
            this.teamtwoscorelabel.Name = "teamtwoscorelabel";
            this.teamtwoscorelabel.Size = new System.Drawing.Size(92, 41);
            this.teamtwoscorelabel.TabIndex = 10;
            this.teamtwoscorelabel.Text = "Score";
            // 
            // teamtwoname
            // 
            this.teamtwoname.AutoSize = true;
            this.teamtwoname.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamtwoname.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.teamtwoname.Location = new System.Drawing.Point(479, 353);
            this.teamtwoname.Name = "teamtwoname";
            this.teamtwoname.Size = new System.Drawing.Size(149, 41);
            this.teamtwoname.TabIndex = 9;
            this.teamtwoname.Text = "TeamTwo:";
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.versusLabel.Location = new System.Drawing.Point(515, 301);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(77, 41);
            this.versusLabel.TabIndex = 12;
            this.versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(12)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.Location = new System.Drawing.Point(677, 302);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(135, 50);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 541);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamtwoscoretextvalue);
            this.Controls.Add(this.teamtwoscorelabel);
            this.Controls.Add(this.teamtwoname);
            this.Controls.Add(this.teamonescoretextvalue);
            this.Controls.Add(this.teamonescorelabel);
            this.Controls.Add(this.teamonename);
            this.Controls.Add(this.matchuplistbox);
            this.Controls.Add(this.unplayedcheckbox);
            this.Controls.Add(this.rounddropdown);
            this.Controls.Add(this.roundlabel);
            this.Controls.Add(this.tournamentname);
            this.Controls.Add(this.headerlabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerlabel;
        private System.Windows.Forms.Label tournamentname;
        private System.Windows.Forms.Label roundlabel;
        private System.Windows.Forms.ComboBox rounddropdown;
        private System.Windows.Forms.CheckBox unplayedcheckbox;
        private System.Windows.Forms.ListBox matchuplistbox;
        private System.Windows.Forms.Label teamonename;
        private System.Windows.Forms.Label teamonescorelabel;
        private System.Windows.Forms.TextBox teamonescoretextvalue;
        private System.Windows.Forms.TextBox teamtwoscoretextvalue;
        private System.Windows.Forms.Label teamtwoscorelabel;
        private System.Windows.Forms.Label teamtwoname;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

