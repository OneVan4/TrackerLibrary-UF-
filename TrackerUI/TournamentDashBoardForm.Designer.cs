namespace TrackerUI
{
    partial class TournamentDashBoardForm
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
            this.TournamentDashboardLabel = new System.Windows.Forms.Label();
            this.loadexistingtournaments = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.laodtournamentbutton = new System.Windows.Forms.Button();
            this.loadexistingtournamentsDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TournamentDashboardLabel
            // 
            this.TournamentDashboardLabel.AutoSize = true;
            this.TournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentDashboardLabel.Location = new System.Drawing.Point(320, 50);
            this.TournamentDashboardLabel.Name = "TournamentDashboardLabel";
            this.TournamentDashboardLabel.Size = new System.Drawing.Size(439, 54);
            this.TournamentDashboardLabel.TabIndex = 43;
            this.TournamentDashboardLabel.Text = "Tournament Dashboard";
            this.TournamentDashboardLabel.Click += new System.EventHandler(this.CreatePrizeLabel_Click);
            // 
            // loadexistingtournaments
            // 
            this.loadexistingtournaments.AutoSize = true;
            this.loadexistingtournaments.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadexistingtournaments.Location = new System.Drawing.Point(274, 164);
            this.loadexistingtournaments.Name = "loadexistingtournaments";
            this.loadexistingtournaments.Size = new System.Drawing.Size(485, 54);
            this.loadexistingtournaments.TabIndex = 44;
            this.loadexistingtournaments.Text = "load existing tournaments";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.createTournamentButton.FlatAppearance.BorderSize = 2;
            this.createTournamentButton.Location = new System.Drawing.Point(344, 451);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(316, 74);
            this.createTournamentButton.TabIndex = 45;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // laodtournamentbutton
            // 
            this.laodtournamentbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.laodtournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.laodtournamentbutton.FlatAppearance.BorderSize = 2;
            this.laodtournamentbutton.Location = new System.Drawing.Point(386, 329);
            this.laodtournamentbutton.Name = "laodtournamentbutton";
            this.laodtournamentbutton.Size = new System.Drawing.Size(238, 74);
            this.laodtournamentbutton.TabIndex = 46;
            this.laodtournamentbutton.Text = "loadTournament";
            this.laodtournamentbutton.UseVisualStyleBackColor = false;
            // 
            // loadexistingtournamentsDropDown
            // 
            this.loadexistingtournamentsDropDown.FormattingEnabled = true;
            this.loadexistingtournamentsDropDown.Location = new System.Drawing.Point(370, 254);
            this.loadexistingtournamentsDropDown.Name = "loadexistingtournamentsDropDown";
            this.loadexistingtournamentsDropDown.Size = new System.Drawing.Size(254, 45);
            this.loadexistingtournamentsDropDown.TabIndex = 47;
            // 
            // TournamentDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(976, 588);
            this.Controls.Add(this.loadexistingtournamentsDropDown);
            this.Controls.Add(this.laodtournamentbutton);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadexistingtournaments);
            this.Controls.Add(this.TournamentDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashBoardForm";
            this.Text = "TournamentDashBoardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentDashboardLabel;
        private System.Windows.Forms.Label loadexistingtournaments;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Button laodtournamentbutton;
        private System.Windows.Forms.ComboBox loadexistingtournamentsDropDown;
    }
}