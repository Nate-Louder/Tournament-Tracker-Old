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

            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.tournamentPrizesListBox = new System.Windows.Forms.ListBox();

            //
            //Label: Header
            //
            this.headerLabel.Name = "headerLabel"; //Label name
            this.headerLabel.Text = "Create Tournament"; //Displayed Text Content
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27); //Displayed Text Font and Size
            this.headerLabel.Location = new System.Drawing.Point(45, 40);
            this.headerLabel.Size = new System.Drawing.Size(315, 45);//
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)


            //
            // Label: Tournament Name
            //
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Text = "Tournament Name";
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.tournamentNameLabel.Location = new System.Drawing.Point(55, 130);
            this.tournamentNameLabel.Size = new System.Drawing.Size(240, 35);
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Label: Entry Fee
            //
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Text = "Entry Fee";
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.entryFeeLabel.Location = new System.Drawing.Point(55, 260);
            this.entryFeeLabel.Size = new System.Drawing.Size(125, 40); //Bottom right is at 
            this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)


            //
            // Label: Select Team
            //
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Text = "Select Team";
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.selectTeamLabel.Location = new System.Drawing.Point(55, 360);
            this.selectTeamLabel.Size = new System.Drawing.Size(160, 30);
            this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)


            //
            // Label: Teams / Players In Tournament
            //
            this.teamsInTournamentLabel.Name = "teamsInTournamentLabel";
            this.teamsInTournamentLabel.Text = "Teams / Players";
            this.teamsInTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.teamsInTournamentLabel.Location = new System.Drawing.Point(490, 130);
            this.teamsInTournamentLabel.Size = new System.Drawing.Size(200, 40);
            this.teamsInTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)


            //
            // Label: Prizes in Tournament
            //
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Text = "Prizes";
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.prizesLabel.Location = new System.Drawing.Point(490, 360);
            this.prizesLabel.Size = new System.Drawing.Size(85, 35);//
            this.prizesLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)



            //
            // Text Box: Tournament Name
            //
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Font = new System.Drawing.Font("Segoe UI", 16); //Displayed Text Font and Size
            this.tournamentNameValue.Location = new System.Drawing.Point(65, 175);
            this.tournamentNameValue.Size = new System.Drawing.Size(330, 30);
            this.tournamentNameValue.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Text Box: Entry Fee
            //
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Font = new System.Drawing.Font("Segoe UI", 16); //Displayed Text Font and Size
            this.entryFeeValue.Location = new System.Drawing.Point(190, 260);
            this.entryFeeValue.Size = new System.Drawing.Size(100, 35);
            this.entryFeeValue.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Combo Box: Select Team
            //
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Font = new System.Drawing.Font("Segoe UI", 15);
            this.selectTeamDropDown.DropDownWidth = 330;
            this.selectTeamDropDown.DropDownHeight = 30;
            this.selectTeamDropDown.Size = new System.Drawing.Size(330, 30);
            this.selectTeamDropDown.Location = new System.Drawing.Point(65, 405);
            this.selectTeamDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;

            //
            // List Box: Teams in Tournament
            //
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(500, 175);
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(290, 150);
            this.tournamentTeamsListBox.Font = new System.Drawing.Font("Segoe UI", 20);
            this.tournamentTeamsListBox.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // List Box: Prizes for Tournament
            //
            this.tournamentPrizesListBox.Name = "tournamentPrizesListBox";
            this.tournamentPrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPrizesListBox.Location = new System.Drawing.Point(500, 405);
            this.tournamentPrizesListBox.Size = new System.Drawing.Size(290, 150);
            this.tournamentPrizesListBox.Font = new System.Drawing.Font("Segoe UI", 20);
            this.tournamentPrizesListBox.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)



            //
            //Button: Delete Team
            //
            this.removeTeamButton.Name = "removeTeamButton";
            this.removeTeamButton.Text = "Remove Selected";
            this.removeTeamButton.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.removeTeamButton.Location = new System.Drawing.Point(820, 215);
            this.removeTeamButton.Size = new System.Drawing.Size(125, 70);
            this.removeTeamButton.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.removeTeamButton.ForeColor = System.Drawing.Color.White;
            this.removeTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTeamButton.FlatAppearance.BorderSize = 0;
            this.removeTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 87, 87);
            this.removeTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(199, 60, 60);

            //
            //Button: Delete Prize
            //
            this.removePrizeButton.Name = "removePrizeButton";
            this.removePrizeButton.Text = "Remove Selected";
            this.removePrizeButton.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.removePrizeButton.Location = new System.Drawing.Point(820, 445);
            this.removePrizeButton.Size = new System.Drawing.Size(125, 70);
            this.removePrizeButton.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.removePrizeButton.ForeColor = System.Drawing.Color.White;
            this.removePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePrizeButton.FlatAppearance.BorderSize = 0;
            this.removePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 87, 87);
            this.removePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(199, 60, 60);

            //
            //Button: Add Team
            //
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.addTeamButton.Location = new System.Drawing.Point(115, 470);
            this.addTeamButton.Size = new System.Drawing.Size(230, 40);
            this.addTeamButton.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.addTeamButton.ForeColor = System.Drawing.Color.White;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.FlatAppearance.BorderSize = 0;
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(250, 191, 102);
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(230, 171, 82);

            //
            //Button: Add Prize
            //
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.createPrizeButton.Location = new System.Drawing.Point(115, 520);
            this.createPrizeButton.Size = new System.Drawing.Size(230, 40);
            this.createPrizeButton.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.createPrizeButton.ForeColor = System.Drawing.Color.White;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.FlatAppearance.BorderSize = 0;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(250, 191, 102);
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(230, 171, 82);

            //
            //Button: Create Tournament
            //
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 25, System.Drawing.FontStyle.Bold);
            this.createTournamentButton.Location = new System.Drawing.Point(330, 600);
            this.createTournamentButton.Size = new System.Drawing.Size(340, 60);
            this.createTournamentButton.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.createTournamentButton.ForeColor = System.Drawing.Color.White;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.FlatAppearance.BorderSize = 0;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(133, 255, 133);
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(86, 196, 86);

            //
            // Link: Create Team
            //
            this.newTeamLink.Name = "newTeamLink";
            this.newTeamLink.Text = "Create New";
            this.newTeamLink.Location = new System.Drawing.Point(285, 370);
            this.newTeamLink.Size = new System.Drawing.Size(130, 30);
            this.newTeamLink.Font = new System.Drawing.Font("Segoe UI", 15);
            this.newTeamLink.ForeColor = System.Drawing.Color.FromArgb(0, 0, 25);


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
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.tournamentPrizesListBox);
            this.Controls.Add(this.createTournamentButton);
            this.ClientSize = new System.Drawing.Size(1000, 700);
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

        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.ListBox tournamentPrizesListBox;

    }
}

