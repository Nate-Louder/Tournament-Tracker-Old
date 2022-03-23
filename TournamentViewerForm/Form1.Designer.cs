namespace TournamentViewerForm
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

            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.vsLabel = new System.Windows.Forms.Label();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.scoreButton = new System.Windows.Forms.Button();

            //
            //Label: Header
            //
            this.headerLabel.Name = "headerLabel"; //Label name
            this.headerLabel.Text = "Tournament:"; //Displayed Text Content
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27); //Displayed Text Font and Size
            this.headerLabel.Location = new System.Drawing.Point(28, 37);
            this.headerLabel.Size = new System.Drawing.Size(214, 50);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Label: Tournament Name
            //
            this.tournamentNameLabel.Name = "tournamentNameLabel"; //Label name
            this.tournamentNameLabel.Text = "<none>"; //Displayed text content
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 27); //Displayed Text Font and Size
            this.tournamentNameLabel.Location = new System.Drawing.Point(232, 37);
            this.tournamentNameLabel.Size = new System.Drawing.Size(214, 50);
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text Color (Light Blue)

            //
            // Label: Round
            //
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Text = "Round";
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.roundLabel.Location = new System.Drawing.Point(28, 100);
            this.roundLabel.Size = new System.Drawing.Size(94, 30);
            this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Label: Versus
            //
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Text = "- VS -";
            this.vsLabel.Font = new System.Drawing.Font("Segoe UI", 15); //Displayed Text Font and Size
            this.vsLabel.Location = new System.Drawing.Point(425, 280);
            this.vsLabel.Size = new System.Drawing.Size(75, 25);
            this.vsLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Label: Team One Name
            //
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Text = "<team one>";
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.teamOneName.Location = new System.Drawing.Point(364, 180);
            this.teamOneName.Size = new System.Drawing.Size(165, 30);
            this.teamOneName.ForeColor = System.Drawing.Color.FromArgb(250, 191, 102); //Text color (Light Blue)

            //
            // Label: Team One Score
            //
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Text = "Score";
            this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.teamOneScoreLabel.Location = new System.Drawing.Point(364, 234);
            this.teamOneScoreLabel.Size = new System.Drawing.Size(96, 30);
            this.teamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Label: Team Two Name
            //
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Text = "<team two>";
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.teamTwoName.Location = new System.Drawing.Point(364, 310);
            this.teamTwoName.Size = new System.Drawing.Size(165, 30);
            this.teamTwoName.ForeColor = System.Drawing.Color.FromArgb(250, 191, 102); //Text color (Light Blue)

            //
            // Label: Team Two Score
            //
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Text = "Score";
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(364, 364);
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(96, 30);
            this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Text Box: Team One Score
            //
            this.teamOneScoreTextBox.Name = "teamOneScoreValue";
            this.teamOneScoreTextBox.Font = new System.Drawing.Font("Segoe UI", 16); //Displayed Text Font and Size
            this.teamOneScoreTextBox.Location = new System.Drawing.Point(460, 235);
            this.teamOneScoreTextBox.Size = new System.Drawing.Size(100, 90);
            this.teamOneScoreTextBox.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Text Box: Team Two Score
            //
            this.teamTwoScoreTextBox.Name = "teamTwoScoreValue";
            this.teamTwoScoreTextBox.Font = new System.Drawing.Font("Segoe UI", 16); //Displayed Text Font and Size
            this.teamTwoScoreTextBox.Location = new System.Drawing.Point(460, 365);
            this.teamTwoScoreTextBox.Size = new System.Drawing.Size(100, 90);
            this.teamTwoScoreTextBox.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Combo Box: Round Drop Down
            //
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Font = new System.Drawing.Font("Segoe UI", 15);
            this.roundDropDown.DropDownWidth = 190;
            this.roundDropDown.DropDownHeight = 106;
            this.roundDropDown.Size = new System.Drawing.Size(190, 12);
            this.roundDropDown.Location = new System.Drawing.Point(130, 100);
            this.roundDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;

            //
            // Check Box: Unplayed Games
            //
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Text = "Unplayed Only";
            this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 20);
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(130, 140);
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(200, 45);
            this.unplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.unplayedOnlyCheckBox.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);

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
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI", 20);
            this.scoreButton.Location = new System.Drawing.Point(585, 290);
            this.scoreButton.Size = new System.Drawing.Size(125, 50);
            this.scoreButton.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.scoreButton.ForeColor = System.Drawing.Color.White;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            //
            // Form 1
            //
            this.BackColor = System.Drawing.Color.White;
            this.components = new System.ComponentModel.Container();
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamOneScoreTextBox);
            this.Controls.Add(this.teamTwoScoreTextBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.scoreButton);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";


        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.TextBox teamOneScoreTextBox;
        private System.Windows.Forms.TextBox teamTwoScoreTextBox;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Button scoreButton;
    }
}

