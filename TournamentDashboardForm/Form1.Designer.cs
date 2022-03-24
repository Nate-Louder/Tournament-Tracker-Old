namespace TournamentDashboardForm
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
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();

            this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();

            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();

            //
            //Label: Header
            //
            this.headerLabel.Name = "headerLabel"; //Label name
            this.headerLabel.Text = "Tournament Dashboard"; //Displayed Text Content
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27); //Displayed Text Font and Size
            this.headerLabel.Location = new System.Drawing.Point(90, 50);
            this.headerLabel.Size = new System.Drawing.Size(400, 50);//
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)



            //
            // Label: Load Existing Tournament
            //
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(114, 130);
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(400, 40);
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Combo Box: Load Existing Tournament
            //
            this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            this.loadExistingTournamentDropDown.Font = new System.Drawing.Font("Segoe UI", 15);
            this.loadExistingTournamentDropDown.DropDownWidth = 370;
            this.loadExistingTournamentDropDown.DropDownHeight = 30;
            this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(370, 30);
            this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(91, 175);
            this.loadExistingTournamentDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;

            //
            //Button: Load Tournament
            //
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.loadTournamentButton.Location = new System.Drawing.Point(166, 225);
            this.loadTournamentButton.Size = new System.Drawing.Size(220, 50);
            this.loadTournamentButton.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.loadTournamentButton.ForeColor = System.Drawing.Color.White;
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.FlatAppearance.BorderSize = 0;
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(133, 255, 133);
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(86, 196, 86);

            //
            //Button: Create Tournament
            //
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.createTournamentButton.Location = new System.Drawing.Point(111, 295);
            this.createTournamentButton.Size = new System.Drawing.Size(330, 50);
            this.createTournamentButton.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.createTournamentButton.ForeColor = System.Drawing.Color.White;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.FlatAppearance.BorderSize = 0;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(250, 191, 102);
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(230, 171, 82);


            this.BackColor = System.Drawing.Color.White;
            this.components = new System.ComponentModel.Container();
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.loadExistingTournamentDropDown);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.createTournamentButton);
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Name = "tournamentDashboardForm";
            this.Text = "Tournament Dashboard";
        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label loadExistingTournamentLabel;

        private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;

        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}

