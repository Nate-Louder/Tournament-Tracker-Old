namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cellPhoneLabel = new System.Windows.Forms.Label();

            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.cellPhoneValue = new System.Windows.Forms.TextBox();

            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();

            this.addMemberButton = new System.Windows.Forms.Button();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.removeMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();

            this.teamMembersListBox = new System.Windows.Forms.ListBox();

            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();

            //
            //Label: Header
            //
            this.headerLabel.Name = "headerLabel"; //Label name
            this.headerLabel.Text = "Create Team"; //Displayed Text Content
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27); //Displayed Text Font and Size
            this.headerLabel.Location = new System.Drawing.Point(45, 40);
            this.headerLabel.Size = new System.Drawing.Size(315, 45);//
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)


            //
            // Label: Team Name
            //
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Text = "Team Name";
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.teamNameLabel.Location = new System.Drawing.Point(45, 100);
            this.teamNameLabel.Size = new System.Drawing.Size(160, 35);
            this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Label: Select Team Member
            //
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Text = "Select Team Member";
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(45, 200);
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(265, 35);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Label: First Name
            //
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.firstNameLabel.Location = new System.Drawing.Point(25, 50);
            this.firstNameLabel.Size = new System.Drawing.Size(145, 35);
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Label: Last Name
            //
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.lastNameLabel.Location = new System.Drawing.Point(25, 100);
            this.lastNameLabel.Size = new System.Drawing.Size(145, 35);
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Label: Email
            //
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Text = "Email";
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.emailLabel.Location = new System.Drawing.Point(25, 150);
            this.emailLabel.Size = new System.Drawing.Size(85, 35);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Label: Cell #
            //
            this.cellPhoneLabel.Name = "cellPhoneLabel";
            this.cellPhoneLabel.Text = "Cell #";
            this.cellPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.cellPhoneLabel.Location = new System.Drawing.Point(25, 200);
            this.cellPhoneLabel.Size = new System.Drawing.Size(90, 35);
            this.cellPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)


            //
            // Text Box: Team Name
            //
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Font = new System.Drawing.Font("Segoe UI", 16); //Displayed Text Font and Size
            this.teamNameValue.Location = new System.Drawing.Point(55, 145);
            this.teamNameValue.Size = new System.Drawing.Size(400, 30);
            this.teamNameValue.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Text Box: First Name
            //
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Font = new System.Drawing.Font("Segoe UI", 16); //Displayed Text Font and Size
            this.firstNameValue.Location = new System.Drawing.Point(190, 55);
            this.firstNameValue.Size = new System.Drawing.Size(200, 35);
            this.firstNameValue.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Text Box: Last Name
            //
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Font = new System.Drawing.Font("Segoe UI", 16); //Displayed Text Font and Size
            this.lastNameValue.Location = new System.Drawing.Point(190, 105);
            this.lastNameValue.Size = new System.Drawing.Size(200, 35);
            this.lastNameValue.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Text Box: Email
            //
            this.emailValue.Name = "emailValue";
            this.emailValue.Font = new System.Drawing.Font("Segoe UI", 16); //Displayed Text Font and Size
            this.emailValue.Location = new System.Drawing.Point(190, 155);
            this.emailValue.Size = new System.Drawing.Size(200, 35);
            this.emailValue.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Text Box: Cell #
            //
            this.cellPhoneValue.Name = "cellPhoneValue";
            this.cellPhoneValue.Font = new System.Drawing.Font("Segoe UI", 16); //Displayed Text Font and Size
            this.cellPhoneValue.Location = new System.Drawing.Point(190, 205);
            this.cellPhoneValue.Size = new System.Drawing.Size(200, 35);
            this.cellPhoneValue.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)


            //
            // Combo Box: Select Team Members
            //
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Font = new System.Drawing.Font("Segoe UI", 15);
            this.selectTeamMemberDropDown.DropDownWidth = 400;
            this.selectTeamMemberDropDown.DropDownHeight = 30;
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(400, 30);
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(55, 245);
            this.selectTeamMemberDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;

            //
            // List Box: Team Members
            //
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.Location = new System.Drawing.Point(560, 145);
            this.teamMembersListBox.Size = new System.Drawing.Size(325, 534);
            this.teamMembersListBox.Font = new System.Drawing.Font("Segoe UI", 15);
            this.teamMembersListBox.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            //Button: Add Member
            //
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.addMemberButton.Location = new System.Drawing.Point(155, 300);
            this.addMemberButton.Size = new System.Drawing.Size(200, 45);
            this.addMemberButton.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.addMemberButton.ForeColor = System.Drawing.Color.White;
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.FlatAppearance.BorderSize = 0;
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(250, 191, 102);
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(230, 171, 82);

            //
            //Button: Create Member
            //
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Text = "Create";
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.createMemberButton.Location = new System.Drawing.Point(115, 260);
            this.createMemberButton.Size = new System.Drawing.Size(170, 45);
            this.createMemberButton.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.createMemberButton.ForeColor = System.Drawing.Color.White;
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.FlatAppearance.BorderSize = 0;
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(250, 191, 102);
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(230, 171, 82);


            //
            // Button: Delete Selected Member
            //
            this.removeMemberButton.Name = "removeMemberButton";
            this.removeMemberButton.Text = "Delete Selected";
            this.removeMemberButton.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.removeMemberButton.Location = new System.Drawing.Point(905, 377);
            this.removeMemberButton.Size = new System.Drawing.Size(125, 70);
            this.removeMemberButton.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.removeMemberButton.ForeColor = System.Drawing.Color.White;
            this.removeMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeMemberButton.FlatAppearance.BorderSize = 0;
            this.removeMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 87, 87);
            this.removeMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(199, 60, 60);


            //
            // Button: Create Team
            //
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold);
            this.createTeamButton.Location = new System.Drawing.Point(375, 715);
            this.createTeamButton.Size = new System.Drawing.Size(350, 50);
            this.createTeamButton.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.createTeamButton.ForeColor = System.Drawing.Color.White;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.FlatAppearance.BorderSize = 0;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(133, 255, 133);
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(86, 196, 86);


            //
            // GroupBox: addNewMemberGroupBox
            //
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Text = "Create New Member";
            this.addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 20);
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(55, 360);
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(400, 320);
            this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);


            /// <summary>
            /// These are the settings for the form itself.
            /// </summary>
            /// <returns></returns>
            this.BackColor = System.Drawing.Color.White;
            this.components = new System.ComponentModel.Container();
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.addMemberButton);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupBox.Controls.Add(this.cellPhoneLabel);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.emailValue);
            this.addNewMemberGroupBox.Controls.Add(this.cellPhoneValue);
            this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.removeMemberButton);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.ClientSize = new System.Drawing.Size(1050, 790);
            this.Name = "CreateTeamForm";
            this.Text = "Create New Team";

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label cellPhoneLabel;

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.TextBox cellPhoneValue;

        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;

        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.Button removeMemberButton;
        private System.Windows.Forms.Button createTeamButton;

        private System.Windows.Forms.ListBox teamMembersListBox;

        private System.Windows.Forms.GroupBox addNewMemberGroupBox;

    }
}

