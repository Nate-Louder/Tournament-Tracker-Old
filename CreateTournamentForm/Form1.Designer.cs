namespace CreateTournamentForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            /// <summary>
            /// These are the components used to fill out the form.
            /// </summary>
            /// <returns></returns>
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.teamsInTournamentLabel = new System.Windows.Forms.Label();
            this.prizesLabel = new System.Windows.Forms.Label();

            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.entryFeeValue = new System.Windows.Forms.TextBox();

            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();

            this.newTeamLink = new System.Windows.Forms.LinkLabel();

            this.addTeamButton = new System.Windows.Forms.Button(); ;
            this.createPrizeButton = new System.Windows.Forms.Button(); ;
            this.removeTeamButton = new System.Windows.Forms.Button();
            this.removePrizeButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();

            this.tournamentTeamsList = new System.Windows.Forms.ListBox();
            this.tournamentPrizesList = new System.Windows.Forms.ListBox();

            //
            //Label: Header
            //
            this.headerLabel.Name = "headerLabel"; //Label name
            this.headerLabel.Text = "Create Tournament"; //Displayed Text Content
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27); //Displayed Text Font and Size
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Size = new System.Drawing.Size(290, 30);//
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)
            this.headerLabel.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0); //Clear background

            //
            // Label: Tournament Name
            //
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Text = "Tournament Name";
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.tournamentNameLabel.Location = new System.Drawing.Point(50, 50);
            this.tournamentNameLabel.Size = new System.Drawing.Size(300, 50);
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)
            this.tournamentNameLabel.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0); //Clear background

            //
            // Label: Entry Fee
            //
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Text = "Entry Fee";
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.entryFeeLabel.Location = new System.Drawing.Point(100, 100);
            this.entryFeeLabel.Size = new System.Drawing.Size(110, 25); //Bottom right is at 
            this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)
            this.entryFeeLabel.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0); //Clear background

            //
            // Label: Select Team
            //
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Text = "Select Team";
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.selectTeamLabel.Location = new System.Drawing.Point(150, 150);
            this.selectTeamLabel.Size = new System.Drawing.Size(300, 50);
            this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)
            this.selectTeamLabel.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0); //Clear background

            //
            // Label: Teams / Players In Tournament
            //
            this.teamsInTournamentLabel.Name = "teamsInTournamentLabel";
            this.teamsInTournamentLabel.Text = "Teams / Players";
            this.teamsInTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.teamsInTournamentLabel.Location = new System.Drawing.Point(200, 200);
            this.teamsInTournamentLabel.Size = new System.Drawing.Size(300, 50);
            this.teamsInTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)
            this.teamsInTournamentLabel.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0); //Clear background

            //
            // Label: Prizes in Tournament
            //
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Text = "Prizes";
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.prizesLabel.Location = new System.Drawing.Point(250, 250);
            this.prizesLabel.Size = new System.Drawing.Size(70, 25);//
            this.prizesLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)
            this.prizesLabel.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0); //Clear background


            //
            // Text Box: Team One Score
            /*
            this.teamOneScoreTextBox.Name = "teamOneScoreValue";
            this.teamOneScoreTextBox.Font = new System.Drawing.Font("Segoe UI", 16); //Displayed Text Font and Size
            this.teamOneScoreTextBox.Location = new System.Drawing.Point(300, 300);
            this.teamOneScoreTextBox.Size = new System.Drawing.Size(100, 90);
            this.teamOneScoreTextBox.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)
            this..BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0); //Clear background

            //
            // Combo Box: Round Drop Down
            //
            this.selectRoundDropDown.Name = "roundDropDown";
            this.selectRoundDropDown.Font = new System.Drawing.Font("Segoe UI", 15);
            this.selectRoundDropDown.DropDownWidth = 190;
            this.selectRoundDropDown.DropDownHeight = 106;
            this.selectRoundDropDown.Size = new System.Drawing.Size(190, 12);
            this.selectRoundDropDown.Location = new System.Drawing.Point(130, 100);
            this.selectRoundDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;

            //
            // List Box: Matchups
            //
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.Location = new System.Drawing.Point(35, 200);
            this.matchupListBox.Size = new System.Drawing.Size(280, 250);
            this.matchupListBox.Font = new System.Drawing.Font("Segoe UI", 20);

            //
            //Button: Score
            //
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Text = "Score";
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.scoreButton.Location = new System.Drawing.Point(585, 290);
            this.scoreButton.Size = new System.Drawing.Size(125, 50);
            this.scoreButton.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.scoreButton.ForeColor = System.Drawing.Color.White;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.FlatAppearance.BorderSize = 0;
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(250, 191, 102);
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(230, 171, 82);
            */

            /// <summary>
            /// These are the settings for the form itself.
            /// </summary>
            /// <returns></returns>
            this.BackColor = System.Drawing.Color.White;
            this.components = new System.ComponentModel.Container();
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.teamsInTournamentLabel);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.newTeamLink);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.removeTeamButton);
            this.Controls.Add(this.removePrizeButton);
            this.Controls.Add(this.tournamentTeamsList);
            this.Controls.Add(this.tournamentPrizesList);
            this.Controls.Add(this.createTournamentButton);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "CreateTournamentForm";
            this.Text = "Create New Tournament";

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.Label teamsInTournamentLabel;
        private System.Windows.Forms.Label prizesLabel;

        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.TextBox entryFeeValue;

        private System.Windows.Forms.ComboBox selectTeamDropDown;

        private System.Windows.Forms.LinkLabel newTeamLink;

        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Button removeTeamButton;
        private System.Windows.Forms.Button removePrizeButton;
        private System.Windows.Forms.Button createTournamentButton;

        private System.Windows.Forms.ListBox tournamentTeamsList;
        private System.Windows.Forms.ListBox tournamentPrizesList;

    }
}

