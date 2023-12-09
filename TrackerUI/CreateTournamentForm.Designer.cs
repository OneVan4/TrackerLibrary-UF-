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
            this.CreateTournamentLabel = new System.Windows.Forms.Label();
            this.TournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeTextbox = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addteamButton = new System.Windows.Forms.Button();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.TournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.TournamentPlayersTextBox = new System.Windows.Forms.Label();
            this.PrizesLabel = new System.Windows.Forms.Label();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.deleteselectedTeamsButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.CreatetournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateTournamentLabel
            // 
            this.CreateTournamentLabel.AutoSize = true;
            this.CreateTournamentLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CreateTournamentLabel.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentLabel.ForeColor = System.Drawing.Color.Navy;
            this.CreateTournamentLabel.Location = new System.Drawing.Point(21, 35);
            this.CreateTournamentLabel.Name = "CreateTournamentLabel";
            this.CreateTournamentLabel.Size = new System.Drawing.Size(522, 53);
            this.CreateTournamentLabel.TabIndex = 1;
            this.CreateTournamentLabel.Text = "Create Tournament ";
            // 
            // TournamentNameTextBox
            // 
            this.TournamentNameTextBox.Location = new System.Drawing.Point(30, 182);
            this.TournamentNameTextBox.Name = "TournamentNameTextBox";
            this.TournamentNameTextBox.Size = new System.Drawing.Size(513, 43);
            this.TournamentNameTextBox.TabIndex = 11;
            this.TournamentNameTextBox.TextChanged += new System.EventHandler(this.TeamOneScoreTextBox_TextChanged);
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.Black;
            this.TournamentNameLabel.Location = new System.Drawing.Point(12, 127);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(247, 38);
            this.TournamentNameLabel.TabIndex = 10;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // EntryFeeTextbox
            // 
            this.EntryFeeTextbox.Location = new System.Drawing.Point(149, 270);
            this.EntryFeeTextbox.Name = "EntryFeeTextbox";
            this.EntryFeeTextbox.Size = new System.Drawing.Size(157, 43);
            this.EntryFeeTextbox.TabIndex = 13;
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.ForeColor = System.Drawing.Color.Black;
            this.EntryFeeLabel.Location = new System.Drawing.Point(26, 270);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(133, 38);
            this.EntryFeeLabel.TabIndex = 12;
            this.EntryFeeLabel.Text = "Entry fee:";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(30, 414);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(513, 45);
            this.SelectTeamDropDown.TabIndex = 16;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.ForeColor = System.Drawing.Color.Black;
            this.SelectTeamLabel.Location = new System.Drawing.Point(26, 354);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(170, 38);
            this.SelectTeamLabel.TabIndex = 15;
            this.SelectTeamLabel.Text = "Select Team:";
            this.SelectTeamLabel.Click += new System.EventHandler(this.RoundLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 14;
            // 
            // CreateNewTeamLink
            // 
            this.CreateNewTeamLink.AutoSize = true;
            this.CreateNewTeamLink.Location = new System.Drawing.Point(402, 354);
            this.CreateNewTeamLink.Name = "CreateNewTeamLink";
            this.CreateNewTeamLink.Size = new System.Drawing.Size(161, 38);
            this.CreateNewTeamLink.TabIndex = 17;
            this.CreateNewTeamLink.TabStop = true;
            this.CreateNewTeamLink.Text = "Create New";
            // 
            // addteamButton
            // 
            this.addteamButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addteamButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.addteamButton.FlatAppearance.BorderSize = 2;
            this.addteamButton.Location = new System.Drawing.Point(119, 498);
            this.addteamButton.Name = "addteamButton";
            this.addteamButton.Size = new System.Drawing.Size(309, 74);
            this.addteamButton.TabIndex = 18;
            this.addteamButton.Text = "ADD TEAM";
            this.addteamButton.UseVisualStyleBackColor = false;
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.CreatePrizeButton.FlatAppearance.BorderSize = 2;
            this.CreatePrizeButton.Location = new System.Drawing.Point(119, 615);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(309, 74);
            this.CreatePrizeButton.TabIndex = 19;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = false;
            // 
            // TournamentPlayersListBox
            // 
            this.TournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentPlayersListBox.FormattingEnabled = true;
            this.TournamentPlayersListBox.ItemHeight = 37;
            this.TournamentPlayersListBox.Location = new System.Drawing.Point(616, 182);
            this.TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            this.TournamentPlayersListBox.Size = new System.Drawing.Size(485, 224);
            this.TournamentPlayersListBox.TabIndex = 20;
            // 
            // TournamentPlayersTextBox
            // 
            this.TournamentPlayersTextBox.AutoSize = true;
            this.TournamentPlayersTextBox.ForeColor = System.Drawing.Color.Black;
            this.TournamentPlayersTextBox.Location = new System.Drawing.Point(609, 117);
            this.TournamentPlayersTextBox.Name = "TournamentPlayersTextBox";
            this.TournamentPlayersTextBox.Size = new System.Drawing.Size(193, 38);
            this.TournamentPlayersTextBox.TabIndex = 21;
            this.TournamentPlayersTextBox.Text = "Teams/Players";
            // 
            // PrizesLabel
            // 
            this.PrizesLabel.AutoSize = true;
            this.PrizesLabel.ForeColor = System.Drawing.Color.Black;
            this.PrizesLabel.Location = new System.Drawing.Point(609, 419);
            this.PrizesLabel.Name = "PrizesLabel";
            this.PrizesLabel.Size = new System.Drawing.Size(193, 38);
            this.PrizesLabel.TabIndex = 23;
            this.PrizesLabel.Text = "Teams/Players";
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 37;
            this.PrizesListBox.Location = new System.Drawing.Point(616, 484);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(485, 224);
            this.PrizesListBox.TabIndex = 22;
            // 
            // deleteselectedTeamsButton
            // 
            this.deleteselectedTeamsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteselectedTeamsButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deleteselectedTeamsButton.FlatAppearance.BorderSize = 2;
            this.deleteselectedTeamsButton.Location = new System.Drawing.Point(1129, 258);
            this.deleteselectedTeamsButton.Name = "deleteselectedTeamsButton";
            this.deleteselectedTeamsButton.Size = new System.Drawing.Size(218, 104);
            this.deleteselectedTeamsButton.TabIndex = 24;
            this.deleteselectedTeamsButton.Text = "delete selected";
            this.deleteselectedTeamsButton.UseVisualStyleBackColor = false;
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deleteSelectedPrizeButton.FlatAppearance.BorderSize = 2;
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(1129, 555);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(218, 104);
            this.deleteSelectedPrizeButton.TabIndex = 25;
            this.deleteSelectedPrizeButton.Text = "delete selected";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = false;
            // 
            // CreatetournamentButton
            // 
            this.CreatetournamentButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CreatetournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.CreatetournamentButton.FlatAppearance.BorderSize = 2;
            this.CreatetournamentButton.Location = new System.Drawing.Point(409, 790);
            this.CreatetournamentButton.Name = "CreatetournamentButton";
            this.CreatetournamentButton.Size = new System.Drawing.Size(478, 74);
            this.CreatetournamentButton.TabIndex = 26;
            this.CreatetournamentButton.Text = "Create Tournament";
            this.CreatetournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1359, 889);
            this.Controls.Add(this.CreatetournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.deleteselectedTeamsButton);
            this.Controls.Add(this.PrizesLabel);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.TournamentPlayersTextBox);
            this.Controls.Add(this.TournamentPlayersListBox);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.addteamButton);
            this.Controls.Add(this.CreateNewTeamLink);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EntryFeeTextbox);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameTextBox);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.CreateTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateTournamentLabel;
        private System.Windows.Forms.TextBox TournamentNameTextBox;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox EntryFeeTextbox;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel CreateNewTeamLink;
        private System.Windows.Forms.Button addteamButton;
        private System.Windows.Forms.Button CreatePrizeButton;
        private System.Windows.Forms.ListBox TournamentPlayersListBox;
        private System.Windows.Forms.Label TournamentPlayersTextBox;
        private System.Windows.Forms.Label PrizesLabel;
        private System.Windows.Forms.ListBox PrizesListBox;
        private System.Windows.Forms.Button deleteselectedTeamsButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.Button CreatetournamentButton;
    }
}