namespace TrackerUI
{
    partial class CreateTeambutton
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
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.CreateTeamLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.SelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddNewMember = new System.Windows.Forms.GroupBox();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.CellPhoneTextbox = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.CellPhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteselectedTeamMembersButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.Location = new System.Drawing.Point(59, 178);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(513, 43);
            this.teamNameTextBox.TabIndex = 14;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.ForeColor = System.Drawing.Color.Black;
            this.TeamNameLabel.Location = new System.Drawing.Point(83, 99);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(164, 38);
            this.TeamNameLabel.TabIndex = 13;
            this.TeamNameLabel.Text = "Team Name";
            this.TeamNameLabel.Click += new System.EventHandler(this.TournamentNameLabel_Click);
            // 
            // CreateTeamLabel
            // 
            this.CreateTeamLabel.AutoSize = true;
            this.CreateTeamLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CreateTeamLabel.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamLabel.ForeColor = System.Drawing.Color.Navy;
            this.CreateTeamLabel.Location = new System.Drawing.Point(50, 9);
            this.CreateTeamLabel.Name = "CreateTeamLabel";
            this.CreateTeamLabel.Size = new System.Drawing.Size(339, 53);
            this.CreateTeamLabel.TabIndex = 12;
            this.CreateTeamLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.addMemberButton.FlatAppearance.BorderSize = 2;
            this.addMemberButton.Location = new System.Drawing.Point(167, 396);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(309, 74);
            this.addMemberButton.TabIndex = 23;
            this.addMemberButton.Text = "ADD Member";
            this.addMemberButton.UseVisualStyleBackColor = false;
            // 
            // SelectTeamMemberDropDown
            // 
            this.SelectTeamMemberDropDown.FormattingEnabled = true;
            this.SelectTeamMemberDropDown.Location = new System.Drawing.Point(59, 317);
            this.SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            this.SelectTeamMemberDropDown.Size = new System.Drawing.Size(513, 45);
            this.SelectTeamMemberDropDown.TabIndex = 21;
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.ForeColor = System.Drawing.Color.Black;
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(52, 251);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(283, 38);
            this.SelectTeamMemberLabel.TabIndex = 20;
            this.SelectTeamMemberLabel.Text = "Select Team Member:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 19;
            // 
            // AddNewMember
            // 
            this.AddNewMember.Controls.Add(this.button1);
            this.AddNewMember.Controls.Add(this.EmailLabel);
            this.AddNewMember.Controls.Add(this.CellPhoneLabel);
            this.AddNewMember.Controls.Add(this.LastNameLabel);
            this.AddNewMember.Controls.Add(this.firstNameLabel);
            this.AddNewMember.Controls.Add(this.EmailTextbox);
            this.AddNewMember.Controls.Add(this.CellPhoneTextbox);
            this.AddNewMember.Controls.Add(this.LastNameTextBox);
            this.AddNewMember.Controls.Add(this.FirstNameTextbox);
            this.AddNewMember.Location = new System.Drawing.Point(90, 496);
            this.AddNewMember.Name = "AddNewMember";
            this.AddNewMember.Size = new System.Drawing.Size(543, 434);
            this.AddNewMember.TabIndex = 24;
            this.AddNewMember.TabStop = false;
            this.AddNewMember.Text = "Add new Member";
            this.AddNewMember.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(225, 57);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(288, 43);
            this.FirstNameTextbox.TabIndex = 25;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(225, 136);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(288, 43);
            this.LastNameTextBox.TabIndex = 26;
            // 
            // CellPhoneTextbox
            // 
            this.CellPhoneTextbox.Location = new System.Drawing.Point(225, 206);
            this.CellPhoneTextbox.Name = "CellPhoneTextbox";
            this.CellPhoneTextbox.Size = new System.Drawing.Size(288, 43);
            this.CellPhoneTextbox.TabIndex = 27;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(225, 279);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(288, 43);
            this.EmailTextbox.TabIndex = 28;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.ForeColor = System.Drawing.Color.Black;
            this.firstNameLabel.Location = new System.Drawing.Point(38, 62);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(151, 38);
            this.firstNameLabel.TabIndex = 29;
            this.firstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.ForeColor = System.Drawing.Color.Black;
            this.LastNameLabel.Location = new System.Drawing.Point(38, 136);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(147, 38);
            this.LastNameLabel.TabIndex = 30;
            this.LastNameLabel.Text = "Last Name";
            // 
            // CellPhoneLabel
            // 
            this.CellPhoneLabel.AutoSize = true;
            this.CellPhoneLabel.ForeColor = System.Drawing.Color.Black;
            this.CellPhoneLabel.Location = new System.Drawing.Point(38, 211);
            this.CellPhoneLabel.Name = "CellPhoneLabel";
            this.CellPhoneLabel.Size = new System.Drawing.Size(150, 38);
            this.CellPhoneLabel.TabIndex = 31;
            this.CellPhoneLabel.Text = "Cell Phone";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.ForeColor = System.Drawing.Color.Black;
            this.EmailLabel.Location = new System.Drawing.Point(38, 282);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(94, 38);
            this.EmailLabel.TabIndex = 32;
            this.EmailLabel.Text = "E-mail";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Location = new System.Drawing.Point(116, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 74);
            this.button1.TabIndex = 33;
            this.button1.Text = "Create Member";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 37;
            this.TeamMembersListBox.Location = new System.Drawing.Point(738, 178);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(627, 668);
            this.TeamMembersListBox.TabIndex = 25;
            // 
            // deleteselectedTeamMembersButton
            // 
            this.deleteselectedTeamMembersButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteselectedTeamMembersButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deleteselectedTeamMembersButton.FlatAppearance.BorderSize = 2;
            this.deleteselectedTeamMembersButton.Location = new System.Drawing.Point(991, 860);
            this.deleteselectedTeamMembersButton.Name = "deleteselectedTeamMembersButton";
            this.deleteselectedTeamMembersButton.Size = new System.Drawing.Size(313, 87);
            this.deleteselectedTeamMembersButton.TabIndex = 26;
            this.deleteselectedTeamMembersButton.Text = "delete selected";
            this.deleteselectedTeamMembersButton.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.Location = new System.Drawing.Point(589, 939);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(313, 104);
            this.button2.TabIndex = 34;
            this.button2.Text = "Create Team";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // CreateTeambutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1326, 1055);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deleteselectedTeamMembersButton);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.AddNewMember);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.SelectTeamMemberDropDown);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.CreateTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeambutton";
            this.Text = "CreateTeam";
            this.Load += new System.EventHandler(this.CreateMemberButton_Load);
            this.AddNewMember.ResumeLayout(false);
            this.AddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label CreateTeamLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox SelectTeamMemberDropDown;
        private System.Windows.Forms.Label SelectTeamMemberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox AddNewMember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label CellPhoneLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.TextBox CellPhoneTextbox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextbox;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.Button deleteselectedTeamMembersButton;
        private System.Windows.Forms.Button button2;
    }
}