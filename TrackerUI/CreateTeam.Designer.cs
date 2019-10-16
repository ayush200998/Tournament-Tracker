namespace TrackerUI
{
    partial class CreateTeam
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
            this.teammembervalue = new System.Windows.Forms.TextBox();
            this.teamnamelabel = new System.Windows.Forms.Label();
            this.headerlabel = new System.Windows.Forms.Label();
            this.addmemberbutton = new System.Windows.Forms.Button();
            this.selectteamemberdropdown = new System.Windows.Forms.ComboBox();
            this.selectteamlabel = new System.Windows.Forms.Label();
            this.addmemberlabel = new System.Windows.Forms.GroupBox();
            this.firstnamevalue = new System.Windows.Forms.TextBox();
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.lastnamevalue = new System.Windows.Forms.TextBox();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.cellphonelabel = new System.Windows.Forms.Label();
            this.emailvalue = new System.Windows.Forms.TextBox();
            this.cellphonevalue = new System.Windows.Forms.TextBox();
            this.creatememberbutton = new System.Windows.Forms.Button();
            this.teammemberlistbox = new System.Windows.Forms.ListBox();
            this.deleteselectedmemberbutton = new System.Windows.Forms.Button();
            this.createteambutton = new System.Windows.Forms.Button();
            this.addmemberlabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // teammembervalue
            // 
            this.teammembervalue.AccessibleName = "";
            this.teammembervalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teammembervalue.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.teammembervalue.Location = new System.Drawing.Point(34, 86);
            this.teammembervalue.Name = "teammembervalue";
            this.teammembervalue.Size = new System.Drawing.Size(323, 43);
            this.teammembervalue.TabIndex = 13;
            // 
            // teamnamelabel
            // 
            this.teamnamelabel.AutoSize = true;
            this.teamnamelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamnamelabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.teamnamelabel.Location = new System.Drawing.Point(27, 45);
            this.teamnamelabel.Name = "teamnamelabel";
            this.teamnamelabel.Size = new System.Drawing.Size(175, 41);
            this.teamnamelabel.TabIndex = 12;
            this.teamnamelabel.Text = "Team Name";
            this.teamnamelabel.Click += new System.EventHandler(this.TournamentnameLabel_Click);
            // 
            // headerlabel
            // 
            this.headerlabel.AccessibleName = "Createteammemberlabel";
            this.headerlabel.AutoSize = true;
            this.headerlabel.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.headerlabel.Location = new System.Drawing.Point(26, 0);
            this.headerlabel.Name = "headerlabel";
            this.headerlabel.Size = new System.Drawing.Size(191, 45);
            this.headerlabel.TabIndex = 11;
            this.headerlabel.Text = "Create Team";
            // 
            // addmemberbutton
            // 
            this.addmemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addmemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(12)))));
            this.addmemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addmemberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addmemberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmemberbutton.ForeColor = System.Drawing.Color.Turquoise;
            this.addmemberbutton.Location = new System.Drawing.Point(91, 242);
            this.addmemberbutton.Name = "addmemberbutton";
            this.addmemberbutton.Size = new System.Drawing.Size(197, 50);
            this.addmemberbutton.TabIndex = 19;
            this.addmemberbutton.Text = "Add Member";
            this.addmemberbutton.UseVisualStyleBackColor = true;
            this.addmemberbutton.Click += new System.EventHandler(this.addmemberbutton_Click);
            // 
            // selectteamemberdropdown
            // 
            this.selectteamemberdropdown.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.selectteamemberdropdown.FormattingEnabled = true;
            this.selectteamemberdropdown.Location = new System.Drawing.Point(34, 185);
            this.selectteamemberdropdown.Name = "selectteamemberdropdown";
            this.selectteamemberdropdown.Size = new System.Drawing.Size(323, 45);
            this.selectteamemberdropdown.TabIndex = 18;
            // 
            // selectteamlabel
            // 
            this.selectteamlabel.AutoSize = true;
            this.selectteamlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectteamlabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.selectteamlabel.Location = new System.Drawing.Point(27, 143);
            this.selectteamlabel.Name = "selectteamlabel";
            this.selectteamlabel.Size = new System.Drawing.Size(296, 41);
            this.selectteamlabel.TabIndex = 17;
            this.selectteamlabel.Text = "Select Team Member";
            this.selectteamlabel.Click += new System.EventHandler(this.selectteamlabel_Click);
            // 
            // addmemberlabel
            // 
            this.addmemberlabel.Controls.Add(this.creatememberbutton);
            this.addmemberlabel.Controls.Add(this.cellphonevalue);
            this.addmemberlabel.Controls.Add(this.cellphonelabel);
            this.addmemberlabel.Controls.Add(this.emailvalue);
            this.addmemberlabel.Controls.Add(this.emaillabel);
            this.addmemberlabel.Controls.Add(this.lastnamevalue);
            this.addmemberlabel.Controls.Add(this.lastnamelabel);
            this.addmemberlabel.Controls.Add(this.firstnamevalue);
            this.addmemberlabel.Controls.Add(this.firstnamelabel);
            this.addmemberlabel.Location = new System.Drawing.Point(34, 301);
            this.addmemberlabel.Name = "addmemberlabel";
            this.addmemberlabel.Size = new System.Drawing.Size(416, 332);
            this.addmemberlabel.TabIndex = 20;
            this.addmemberlabel.TabStop = false;
            this.addmemberlabel.Text = "Add Member";
            // 
            // firstnamevalue
            // 
            this.firstnamevalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstnamevalue.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.firstnamevalue.Location = new System.Drawing.Point(170, 47);
            this.firstnamevalue.Name = "firstnamevalue";
            this.firstnamevalue.Size = new System.Drawing.Size(229, 43);
            this.firstnamevalue.TabIndex = 22;
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnamelabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.firstnamelabel.Location = new System.Drawing.Point(15, 49);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(160, 41);
            this.firstnamelabel.TabIndex = 21;
            this.firstnamelabel.Text = "First Name";
            // 
            // lastnamevalue
            // 
            this.lastnamevalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastnamevalue.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lastnamevalue.Location = new System.Drawing.Point(171, 108);
            this.lastnamevalue.Name = "lastnamevalue";
            this.lastnamevalue.Size = new System.Drawing.Size(229, 43);
            this.lastnamevalue.TabIndex = 24;
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.AutoSize = true;
            this.lastnamelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnamelabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lastnamelabel.Location = new System.Drawing.Point(16, 110);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(157, 41);
            this.lastnamelabel.TabIndex = 23;
            this.lastnamelabel.Text = "Last Name";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.emaillabel.Location = new System.Drawing.Point(80, 173);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(88, 41);
            this.emaillabel.TabIndex = 25;
            this.emaillabel.Text = "Email";
            // 
            // cellphonelabel
            // 
            this.cellphonelabel.AutoSize = true;
            this.cellphonelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellphonelabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.cellphonelabel.Location = new System.Drawing.Point(17, 223);
            this.cellphonelabel.Name = "cellphonelabel";
            this.cellphonelabel.Size = new System.Drawing.Size(153, 41);
            this.cellphonelabel.TabIndex = 27;
            this.cellphonelabel.Text = "Cellphone";
            this.cellphonelabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailvalue
            // 
            this.emailvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailvalue.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailvalue.Location = new System.Drawing.Point(170, 172);
            this.emailvalue.Name = "emailvalue";
            this.emailvalue.Size = new System.Drawing.Size(229, 43);
            this.emailvalue.TabIndex = 26;
            this.emailvalue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cellphonevalue
            // 
            this.cellphonevalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cellphonevalue.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cellphonevalue.Location = new System.Drawing.Point(170, 224);
            this.cellphonevalue.Name = "cellphonevalue";
            this.cellphonevalue.Size = new System.Drawing.Size(229, 43);
            this.cellphonevalue.TabIndex = 28;
            // 
            // creatememberbutton
            // 
            this.creatememberbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.creatememberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(12)))));
            this.creatememberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.creatememberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creatememberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatememberbutton.ForeColor = System.Drawing.Color.Turquoise;
            this.creatememberbutton.Location = new System.Drawing.Point(92, 273);
            this.creatememberbutton.Name = "creatememberbutton";
            this.creatememberbutton.Size = new System.Drawing.Size(231, 50);
            this.creatememberbutton.TabIndex = 21;
            this.creatememberbutton.Text = "Create Member";
            this.creatememberbutton.UseVisualStyleBackColor = true;
            // 
            // teammemberlistbox
            // 
            this.teammemberlistbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teammemberlistbox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.teammemberlistbox.FormattingEnabled = true;
            this.teammemberlistbox.ItemHeight = 37;
            this.teammemberlistbox.Location = new System.Drawing.Point(500, 45);
            this.teammemberlistbox.Name = "teammemberlistbox";
            this.teammemberlistbox.Size = new System.Drawing.Size(301, 594);
            this.teammemberlistbox.TabIndex = 21;
            // 
            // deleteselectedmemberbutton
            // 
            this.deleteselectedmemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteselectedmemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteselectedmemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteselectedmemberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteselectedmemberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteselectedmemberbutton.ForeColor = System.Drawing.Color.Turquoise;
            this.deleteselectedmemberbutton.Location = new System.Drawing.Point(813, 338);
            this.deleteselectedmemberbutton.Name = "deleteselectedmemberbutton";
            this.deleteselectedmemberbutton.Size = new System.Drawing.Size(135, 86);
            this.deleteselectedmemberbutton.TabIndex = 22;
            this.deleteselectedmemberbutton.Text = "Delete Selected";
            this.deleteselectedmemberbutton.UseVisualStyleBackColor = true;
            // 
            // createteambutton
            // 
            this.createteambutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.createteambutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createteambutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createteambutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createteambutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createteambutton.ForeColor = System.Drawing.Color.Turquoise;
            this.createteambutton.Location = new System.Drawing.Point(349, 651);
            this.createteambutton.Name = "createteambutton";
            this.createteambutton.Size = new System.Drawing.Size(285, 60);
            this.createteambutton.TabIndex = 25;
            this.createteambutton.Text = "Create Team";
            this.createteambutton.UseVisualStyleBackColor = true;
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 719);
            this.Controls.Add(this.createteambutton);
            this.Controls.Add(this.deleteselectedmemberbutton);
            this.Controls.Add(this.teammemberlistbox);
            this.Controls.Add(this.addmemberlabel);
            this.Controls.Add(this.addmemberbutton);
            this.Controls.Add(this.selectteamemberdropdown);
            this.Controls.Add(this.selectteamlabel);
            this.Controls.Add(this.teammembervalue);
            this.Controls.Add(this.teamnamelabel);
            this.Controls.Add(this.headerlabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeam";
            this.Text = "CreateTeam";
            this.addmemberlabel.ResumeLayout(false);
            this.addmemberlabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teammembervalue;
        private System.Windows.Forms.Label teamnamelabel;
        private System.Windows.Forms.Label headerlabel;
        private System.Windows.Forms.Button addmemberbutton;
        private System.Windows.Forms.ComboBox selectteamemberdropdown;
        private System.Windows.Forms.Label selectteamlabel;
        private System.Windows.Forms.GroupBox addmemberlabel;
        private System.Windows.Forms.Label cellphonelabel;
        private System.Windows.Forms.TextBox emailvalue;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.TextBox lastnamevalue;
        private System.Windows.Forms.Label lastnamelabel;
        private System.Windows.Forms.TextBox firstnamevalue;
        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.Button creatememberbutton;
        private System.Windows.Forms.TextBox cellphonevalue;
        private System.Windows.Forms.ListBox teammemberlistbox;
        private System.Windows.Forms.Button deleteselectedmemberbutton;
        private System.Windows.Forms.Button createteambutton;
    }
}