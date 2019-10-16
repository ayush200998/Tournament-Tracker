namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.tournamentnamevalue = new System.Windows.Forms.TextBox();
            this.TournamentnameLabel = new System.Windows.Forms.Label();
            this.entryfeevalue = new System.Windows.Forms.TextBox();
            this.entryfeelabel = new System.Windows.Forms.Label();
            this.selectteamdropdown = new System.Windows.Forms.ComboBox();
            this.selectteamlabel = new System.Windows.Forms.Label();
            this.createnewlabel = new System.Windows.Forms.LinkLabel();
            this.addteambutton = new System.Windows.Forms.Button();
            this.createprizebutton = new System.Windows.Forms.Button();
            this.tournamentplayerlistbox = new System.Windows.Forms.ListBox();
            this.prizebox = new System.Windows.Forms.ListBox();
            this.teamplayerlabel = new System.Windows.Forms.Label();
            this.deleteselectedplayerbutton = new System.Windows.Forms.Button();
            this.deleteselectedprizebutton = new System.Windows.Forms.Button();
            this.teamplayerprizelabel = new System.Windows.Forms.Label();
            this.createtournamentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerlabel
            // 
            this.headerlabel.AutoSize = true;
            this.headerlabel.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.headerlabel.Location = new System.Drawing.Point(42, 35);
            this.headerlabel.Name = "headerlabel";
            this.headerlabel.Size = new System.Drawing.Size(292, 45);
            this.headerlabel.TabIndex = 1;
            this.headerlabel.Text = "Create Tournament:";
            // 
            // tournamentnamevalue
            // 
            this.tournamentnamevalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentnamevalue.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tournamentnamevalue.Location = new System.Drawing.Point(50, 138);
            this.tournamentnamevalue.Name = "tournamentnamevalue";
            this.tournamentnamevalue.Size = new System.Drawing.Size(323, 43);
            this.tournamentnamevalue.TabIndex = 10;
            // 
            // TournamentnameLabel
            // 
            this.TournamentnameLabel.AutoSize = true;
            this.TournamentnameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentnameLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.TournamentnameLabel.Location = new System.Drawing.Point(43, 94);
            this.TournamentnameLabel.Name = "TournamentnameLabel";
            this.TournamentnameLabel.Size = new System.Drawing.Size(264, 41);
            this.TournamentnameLabel.TabIndex = 9;
            this.TournamentnameLabel.Text = "Tournament Name";
            this.TournamentnameLabel.Click += new System.EventHandler(this.teamonescorelabel_Click);
            // 
            // entryfeevalue
            // 
            this.entryfeevalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entryfeevalue.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.entryfeevalue.Location = new System.Drawing.Point(180, 222);
            this.entryfeevalue.Name = "entryfeevalue";
            this.entryfeevalue.Size = new System.Drawing.Size(159, 43);
            this.entryfeevalue.TabIndex = 12;
            // 
            // entryfeelabel
            // 
            this.entryfeelabel.AutoSize = true;
            this.entryfeelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryfeelabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.entryfeelabel.Location = new System.Drawing.Point(43, 222);
            this.entryfeelabel.Name = "entryfeelabel";
            this.entryfeelabel.Size = new System.Drawing.Size(140, 41);
            this.entryfeelabel.TabIndex = 11;
            this.entryfeelabel.Text = "Entry Fee";
            // 
            // selectteamdropdown
            // 
            this.selectteamdropdown.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.selectteamdropdown.FormattingEnabled = true;
            this.selectteamdropdown.Location = new System.Drawing.Point(50, 356);
            this.selectteamdropdown.Name = "selectteamdropdown";
            this.selectteamdropdown.Size = new System.Drawing.Size(323, 45);
            this.selectteamdropdown.TabIndex = 14;
            // 
            // selectteamlabel
            // 
            this.selectteamlabel.AutoSize = true;
            this.selectteamlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectteamlabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.selectteamlabel.Location = new System.Drawing.Point(52, 301);
            this.selectteamlabel.Name = "selectteamlabel";
            this.selectteamlabel.Size = new System.Drawing.Size(175, 41);
            this.selectteamlabel.TabIndex = 13;
            this.selectteamlabel.Text = "Select Team";
            this.selectteamlabel.Click += new System.EventHandler(this.roundlabel_Click);
            // 
            // createnewlabel
            // 
            this.createnewlabel.AutoSize = true;
            this.createnewlabel.Location = new System.Drawing.Point(266, 301);
            this.createnewlabel.Name = "createnewlabel";
            this.createnewlabel.Size = new System.Drawing.Size(161, 38);
            this.createnewlabel.TabIndex = 15;
            this.createnewlabel.TabStop = true;
            this.createnewlabel.Text = "Create New";
            // 
            // addteambutton
            // 
            this.addteambutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addteambutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(12)))));
            this.addteambutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addteambutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addteambutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addteambutton.ForeColor = System.Drawing.Color.Turquoise;
            this.addteambutton.Location = new System.Drawing.Point(126, 431);
            this.addteambutton.Name = "addteambutton";
            this.addteambutton.Size = new System.Drawing.Size(166, 50);
            this.addteambutton.TabIndex = 16;
            this.addteambutton.Text = "Add Team";
            this.addteambutton.UseVisualStyleBackColor = true;
            // 
            // createprizebutton
            // 
            this.createprizebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.createprizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(12)))));
            this.createprizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createprizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createprizebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createprizebutton.ForeColor = System.Drawing.Color.Turquoise;
            this.createprizebutton.Location = new System.Drawing.Point(126, 507);
            this.createprizebutton.Name = "createprizebutton";
            this.createprizebutton.Size = new System.Drawing.Size(181, 50);
            this.createprizebutton.TabIndex = 17;
            this.createprizebutton.Text = "Create Prize";
            this.createprizebutton.UseVisualStyleBackColor = true;
            // 
            // tournamentplayerlistbox
            // 
            this.tournamentplayerlistbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentplayerlistbox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.tournamentplayerlistbox.FormattingEnabled = true;
            this.tournamentplayerlistbox.ItemHeight = 37;
            this.tournamentplayerlistbox.Location = new System.Drawing.Point(498, 104);
            this.tournamentplayerlistbox.Name = "tournamentplayerlistbox";
            this.tournamentplayerlistbox.Size = new System.Drawing.Size(301, 150);
            this.tournamentplayerlistbox.TabIndex = 18;
            this.tournamentplayerlistbox.SelectedIndexChanged += new System.EventHandler(this.matchuplistbox_SelectedIndexChanged);
            // 
            // prizebox
            // 
            this.prizebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizebox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.prizebox.FormattingEnabled = true;
            this.prizebox.ItemHeight = 37;
            this.prizebox.Location = new System.Drawing.Point(498, 356);
            this.prizebox.Name = "prizebox";
            this.prizebox.Size = new System.Drawing.Size(301, 150);
            this.prizebox.TabIndex = 19;
            this.prizebox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // teamplayerlabel
            // 
            this.teamplayerlabel.AutoSize = true;
            this.teamplayerlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamplayerlabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.teamplayerlabel.Location = new System.Drawing.Point(500, 51);
            this.teamplayerlabel.Name = "teamplayerlabel";
            this.teamplayerlabel.Size = new System.Drawing.Size(222, 41);
            this.teamplayerlabel.TabIndex = 20;
            this.teamplayerlabel.Text = "Teams / Players";
            this.teamplayerlabel.Click += new System.EventHandler(this.teamplayelabel_Click);
            // 
            // deleteselectedplayerbutton
            // 
            this.deleteselectedplayerbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteselectedplayerbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteselectedplayerbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteselectedplayerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteselectedplayerbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteselectedplayerbutton.ForeColor = System.Drawing.Color.Turquoise;
            this.deleteselectedplayerbutton.Location = new System.Drawing.Point(824, 138);
            this.deleteselectedplayerbutton.Name = "deleteselectedplayerbutton";
            this.deleteselectedplayerbutton.Size = new System.Drawing.Size(135, 86);
            this.deleteselectedplayerbutton.TabIndex = 21;
            this.deleteselectedplayerbutton.Text = "Delete Selected";
            this.deleteselectedplayerbutton.UseVisualStyleBackColor = true;
            // 
            // deleteselectedprizebutton
            // 
            this.deleteselectedprizebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteselectedprizebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteselectedprizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteselectedprizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteselectedprizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteselectedprizebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteselectedprizebutton.ForeColor = System.Drawing.Color.Turquoise;
            this.deleteselectedprizebutton.Location = new System.Drawing.Point(824, 380);
            this.deleteselectedprizebutton.Name = "deleteselectedprizebutton";
            this.deleteselectedprizebutton.Size = new System.Drawing.Size(135, 90);
            this.deleteselectedprizebutton.TabIndex = 22;
            this.deleteselectedprizebutton.Text = "Delete Selected";
            this.deleteselectedprizebutton.UseVisualStyleBackColor = true;
            // 
            // teamplayerprizelabel
            // 
            this.teamplayerprizelabel.AutoSize = true;
            this.teamplayerprizelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamplayerprizelabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.teamplayerprizelabel.Location = new System.Drawing.Point(500, 312);
            this.teamplayerprizelabel.Name = "teamplayerprizelabel";
            this.teamplayerprizelabel.Size = new System.Drawing.Size(222, 41);
            this.teamplayerprizelabel.TabIndex = 23;
            this.teamplayerprizelabel.Text = "Teams / Players";
            // 
            // createtournamentbutton
            // 
            this.createtournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.createtournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createtournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createtournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createtournamentbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createtournamentbutton.ForeColor = System.Drawing.Color.Turquoise;
            this.createtournamentbutton.Location = new System.Drawing.Point(414, 550);
            this.createtournamentbutton.Name = "createtournamentbutton";
            this.createtournamentbutton.Size = new System.Drawing.Size(285, 60);
            this.createtournamentbutton.TabIndex = 24;
            this.createtournamentbutton.Text = "Create Tournament";
            this.createtournamentbutton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 622);
            this.Controls.Add(this.createtournamentbutton);
            this.Controls.Add(this.teamplayerprizelabel);
            this.Controls.Add(this.deleteselectedprizebutton);
            this.Controls.Add(this.deleteselectedplayerbutton);
            this.Controls.Add(this.teamplayerlabel);
            this.Controls.Add(this.prizebox);
            this.Controls.Add(this.tournamentplayerlistbox);
            this.Controls.Add(this.createprizebutton);
            this.Controls.Add(this.addteambutton);
            this.Controls.Add(this.createnewlabel);
            this.Controls.Add(this.selectteamdropdown);
            this.Controls.Add(this.selectteamlabel);
            this.Controls.Add(this.entryfeevalue);
            this.Controls.Add(this.entryfeelabel);
            this.Controls.Add(this.tournamentnamevalue);
            this.Controls.Add(this.TournamentnameLabel);
            this.Controls.Add(this.headerlabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerlabel;
        private System.Windows.Forms.TextBox tournamentnamevalue;
        private System.Windows.Forms.Label TournamentnameLabel;
        private System.Windows.Forms.TextBox entryfeevalue;
        private System.Windows.Forms.Label entryfeelabel;
        private System.Windows.Forms.ComboBox selectteamdropdown;
        private System.Windows.Forms.Label selectteamlabel;
        private System.Windows.Forms.LinkLabel createnewlabel;
        private System.Windows.Forms.Button addteambutton;
        private System.Windows.Forms.Button createprizebutton;
        private System.Windows.Forms.ListBox tournamentplayerlistbox;
        private System.Windows.Forms.ListBox prizebox;
        private System.Windows.Forms.Label teamplayerlabel;
        private System.Windows.Forms.Button deleteselectedplayerbutton;
        private System.Windows.Forms.Button deleteselectedprizebutton;
        private System.Windows.Forms.Label teamplayerprizelabel;
        private System.Windows.Forms.Button createtournamentbutton;
    }
}