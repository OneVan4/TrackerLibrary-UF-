namespace TrackerUI
{
    partial class TournamentViewer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewer));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.MatchupListBox = new System.Windows.Forms.ListBox();
            this.teamOnename = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreTextBox = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreText = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.TeamTwoNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.Lime;
            this.HeaderLabel.Location = new System.Drawing.Point(70, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(345, 53);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament :";
            this.HeaderLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName.ForeColor = System.Drawing.Color.LimeGreen;
            this.TournamentName.Location = new System.Drawing.Point(669, 47);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(38, 53);
            this.TournamentName.TabIndex = 2;
            this.TournamentName.Text = "-";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.ForeColor = System.Drawing.Color.Black;
            this.RoundLabel.Location = new System.Drawing.Point(72, 115);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(103, 38);
            this.RoundLabel.TabIndex = 3;
            this.RoundLabel.Text = "Round:";
            this.RoundLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(196, 108);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(254, 45);
            this.RoundDropDown.TabIndex = 4;
            this.RoundDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UnplayedOnlyCheckbox
            // 
            this.UnplayedOnlyCheckbox.AutoSize = true;
            this.UnplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnplayedOnlyCheckbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UnplayedOnlyCheckbox.Location = new System.Drawing.Point(216, 159);
            this.UnplayedOnlyCheckbox.Name = "UnplayedOnlyCheckbox";
            this.UnplayedOnlyCheckbox.Size = new System.Drawing.Size(157, 32);
            this.UnplayedOnlyCheckbox.TabIndex = 5;
            this.UnplayedOnlyCheckbox.Text = "Unplayed only";
            this.UnplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            this.UnplayedOnlyCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MatchupListBox
            // 
            this.MatchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListBox.FormattingEnabled = true;
            this.MatchupListBox.ItemHeight = 37;
            this.MatchupListBox.Location = new System.Drawing.Point(34, 197);
            this.MatchupListBox.Name = "MatchupListBox";
            this.MatchupListBox.Size = new System.Drawing.Size(485, 372);
            this.MatchupListBox.TabIndex = 6;
            // 
            // teamOnename
            // 
            this.teamOnename.AutoSize = true;
            this.teamOnename.ForeColor = System.Drawing.Color.Black;
            this.teamOnename.Location = new System.Drawing.Point(708, 197);
            this.teamOnename.Name = "teamOnename";
            this.teamOnename.Size = new System.Drawing.Size(208, 38);
            this.teamOnename.TabIndex = 7;
            this.teamOnename.Text = "TeamOneName";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(636, 259);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(92, 38);
            this.TeamOneScoreLabel.TabIndex = 8;
            this.TeamOneScoreLabel.Text = "Score:";
            // 
            // TeamOneScoreTextBox
            // 
            this.TeamOneScoreTextBox.Location = new System.Drawing.Point(759, 259);
            this.TeamOneScoreTextBox.Name = "TeamOneScoreTextBox";
            this.TeamOneScoreTextBox.Size = new System.Drawing.Size(157, 43);
            this.TeamOneScoreTextBox.TabIndex = 9;
            // 
            // TeamTwoScoreText
            // 
            this.TeamTwoScoreText.Location = new System.Drawing.Point(759, 496);
            this.TeamTwoScoreText.Name = "TeamTwoScoreText";
            this.TeamTwoScoreText.Size = new System.Drawing.Size(157, 43);
            this.TeamTwoScoreText.TabIndex = 12;
            this.TeamTwoScoreText.TextChanged += new System.EventHandler(this.TeamTwoScoreText_TextChanged);
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(636, 501);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(92, 38);
            this.TeamTwoScoreLabel.TabIndex = 11;
            this.TeamTwoScoreLabel.Text = "Score:";
            // 
            // TeamTwoNameLabel
            // 
            this.TeamTwoNameLabel.AutoSize = true;
            this.TeamTwoNameLabel.ForeColor = System.Drawing.Color.Black;
            this.TeamTwoNameLabel.Location = new System.Drawing.Point(711, 434);
            this.TeamTwoNameLabel.Name = "TeamTwoNameLabel";
            this.TeamTwoNameLabel.Size = new System.Drawing.Size(205, 38);
            this.TeamTwoNameLabel.TabIndex = 10;
            this.TeamTwoNameLabel.Text = "TeamTwoName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(796, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 38);
            this.label2.TabIndex = 13;
            this.label2.Text = "VS";
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.scoreButton.FlatAppearance.BorderSize = 2;
            this.scoreButton.Location = new System.Drawing.Point(924, 342);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(141, 74);
            this.scoreButton.TabIndex = 14;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = false;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1077, 574);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TeamTwoScoreText);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.TeamTwoNameLabel);
            this.Controls.Add(this.TeamOneScoreTextBox);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.teamOnename);
            this.Controls.Add(this.MatchupListBox);
            this.Controls.Add(this.UnplayedOnlyCheckbox);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewer";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundDropDown;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox MatchupListBox;
        private System.Windows.Forms.Label teamOnename;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.TextBox TeamOneScoreTextBox;
        private System.Windows.Forms.TextBox TeamTwoScoreText;
        private System.Windows.Forms.Label TeamTwoScoreLabel;
        private System.Windows.Forms.Label TeamTwoNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button scoreButton;
    }
}

