namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.prizePercentLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();

            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizePercentValue = new System.Windows.Forms.TextBox();

            this.createPrizeButton = new System.Windows.Forms.Button(); ;

            //
            //Label: Header
            //
            this.headerLabel.Name = "headerLabel"; //Label name
            this.headerLabel.Text = "Create Prize"; //Displayed Text Content
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27); //Displayed Text Font and Size
            this.headerLabel.Location = new System.Drawing.Point(45, 40);
            this.headerLabel.Size = new System.Drawing.Size(220, 50);//
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)


            //
            // Label: Place Number
            //
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Text = "Place Number";
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.placeNumberLabel.Location = new System.Drawing.Point(65, 120);
            this.placeNumberLabel.Size = new System.Drawing.Size(220, 40);
            this.placeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Label: Place Name
            //
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Text = "Place Name";
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.placeNameLabel.Location = new System.Drawing.Point(65, 180);
            this.placeNameLabel.Size = new System.Drawing.Size(220, 40);
            this.placeNameLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Label: Prize Amount
            //
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Text = "Prize Amount";
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.prizeAmountLabel.Location = new System.Drawing.Point(65, 240);
            this.prizeAmountLabel.Size = new System.Drawing.Size(220, 40);
            this.prizeAmountLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Label: Prize Percentage
            //
            this.prizePercentLabel.Name = "prizePercentLabel";
            this.prizePercentLabel.Text = "Prize Percentage";
            this.prizePercentLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.prizePercentLabel.Location = new System.Drawing.Point(65, 360);
            this.prizePercentLabel.Size = new System.Drawing.Size(220, 40);
            this.prizePercentLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Label: OR
            //
            this.orLabel.Name = "orLabel";
            this.orLabel.Text = "-or-";
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 20); //Displayed Text Font and Size
            this.orLabel.Location = new System.Drawing.Point(225, 300);
            this.orLabel.Size = new System.Drawing.Size(75, 40);
            this.orLabel.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Text Box: Place Number
            //
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Font = new System.Drawing.Font("Segoe UI", 16); //Displayed Text Font and Size
            this.placeNumberValue.Location = new System.Drawing.Point(290, 125);
            this.placeNumberValue.Size = new System.Drawing.Size(150, 40);
            this.placeNumberValue.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Text Box: Place Name
            //
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Font = new System.Drawing.Font("Segoe UI", 16); //Displayed Text Font and Size
            this.placeNameValue.Location = new System.Drawing.Point(290, 185);
            this.placeNameValue.Size = new System.Drawing.Size(150, 40);
            this.placeNameValue.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Text Box: Prize Amount
            //
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Font = new System.Drawing.Font("Segoe UI", 16); //Displayed Text Font and Size
            this.prizeAmountValue.Location = new System.Drawing.Point(290, 245);
            this.prizeAmountValue.Size = new System.Drawing.Size(150, 40);
            this.prizeAmountValue.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            // Text Box: Prize Percentage
            //
            this.prizePercentValue.Name = "prizePercentValue";
            this.prizePercentValue.Font = new System.Drawing.Font("Segoe UI", 16); //Displayed Text Font and Size
            this.prizePercentValue.Location = new System.Drawing.Point(290, 365);
            this.prizePercentValue.Size = new System.Drawing.Size(150, 40);
            this.prizePercentValue.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255); //Text color (Light Blue)

            //
            //Button: Create Prize
            //
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.createPrizeButton.Location = new System.Drawing.Point(120, 440);
            this.createPrizeButton.Size = new System.Drawing.Size(270, 55);
            this.createPrizeButton.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.createPrizeButton.ForeColor = System.Drawing.Color.White;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.FlatAppearance.BorderSize = 0;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(133, 255, 133);
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(86, 196, 86);

            this.BackColor = System.Drawing.Color.White;
            this.components = new System.ComponentModel.Container();
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.prizePercentLabel);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.prizePercentValue);
            this.Controls.Add(this.createPrizeButton);
            this.ClientSize = new System.Drawing.Size(510, 530);
            this.Name = "createPrizeForm";
            this.Text = "Create Prize";
        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.Label prizePercentLabel;
        private System.Windows.Forms.Label orLabel;

        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.TextBox prizePercentValue;

        private System.Windows.Forms.Button createPrizeButton;
    }
}

