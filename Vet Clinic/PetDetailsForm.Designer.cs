namespace Vet_Clinic
{
    partial class PetDetailsForm
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
            labelPetsName = new Label();
            labelType = new Label();
            labelBirthday = new Label();
            labelBreed = new Label();
            labelMedicalHistory = new Label();
            labelWeight = new Label();
            labelColor = new Label();
            labelFavToy = new Label();
            labelStatus = new Label();
            textBoxColor = new TextBox();
            textBoxWeight = new TextBox();
            textBoxBreed = new TextBox();
            textBoxMedicalHistory = new TextBox();
            textBoxFavToy = new TextBox();
            textBoxStatus = new TextBox();
            textBoxType = new TextBox();
            dateTimePickerBirthday = new DateTimePicker();
            buttonAdopt = new Button();
            pictureBoxImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // labelPetsName
            // 
            labelPetsName.AutoSize = true;
            labelPetsName.Location = new Point(355, 51);
            labelPetsName.Name = "labelPetsName";
            labelPetsName.Size = new Size(13, 15);
            labelPetsName.TabIndex = 0;
            labelPetsName.Text = "e";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(134, 174);
            labelType.Name = "labelType";
            labelType.Size = new Size(32, 15);
            labelType.TabIndex = 1;
            labelType.Text = "Type";
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Location = new Point(115, 216);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(51, 15);
            labelBirthday.TabIndex = 2;
            labelBirthday.Text = "Birthday";
            // 
            // labelBreed
            // 
            labelBreed.AutoSize = true;
            labelBreed.Location = new Point(129, 257);
            labelBreed.Name = "labelBreed";
            labelBreed.Size = new Size(37, 15);
            labelBreed.TabIndex = 3;
            labelBreed.Text = "Breed";
            // 
            // labelMedicalHistory
            // 
            labelMedicalHistory.AutoSize = true;
            labelMedicalHistory.Location = new Point(76, 298);
            labelMedicalHistory.Name = "labelMedicalHistory";
            labelMedicalHistory.Size = new Size(90, 15);
            labelMedicalHistory.TabIndex = 4;
            labelMedicalHistory.Text = "Medical History";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(478, 174);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(45, 15);
            labelWeight.TabIndex = 5;
            labelWeight.Text = "Weight";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(487, 216);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(36, 15);
            labelColor.TabIndex = 6;
            labelColor.Text = "Color";
            // 
            // labelFavToy
            // 
            labelFavToy.AutoSize = true;
            labelFavToy.Location = new Point(455, 257);
            labelFavToy.Name = "labelFavToy";
            labelFavToy.Size = new Size(71, 15);
            labelFavToy.TabIndex = 7;
            labelFavToy.Text = "Favorite Toy";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(487, 298);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(39, 15);
            labelStatus.TabIndex = 8;
            labelStatus.Text = "Status";
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(556, 213);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(195, 23);
            textBoxColor.TabIndex = 9;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(556, 171);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(195, 23);
            textBoxWeight.TabIndex = 10;
            // 
            // textBoxBreed
            // 
            textBoxBreed.Location = new Point(189, 254);
            textBoxBreed.Name = "textBoxBreed";
            textBoxBreed.Size = new Size(195, 23);
            textBoxBreed.TabIndex = 11;
            // 
            // textBoxMedicalHistory
            // 
            textBoxMedicalHistory.Location = new Point(189, 295);
            textBoxMedicalHistory.Name = "textBoxMedicalHistory";
            textBoxMedicalHistory.Size = new Size(195, 23);
            textBoxMedicalHistory.TabIndex = 12;
            // 
            // textBoxFavToy
            // 
            textBoxFavToy.Location = new Point(556, 257);
            textBoxFavToy.Name = "textBoxFavToy";
            textBoxFavToy.Size = new Size(195, 23);
            textBoxFavToy.TabIndex = 13;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(556, 295);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(195, 23);
            textBoxStatus.TabIndex = 14;
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(189, 171);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(195, 23);
            textBoxType.TabIndex = 15;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new Point(189, 210);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(195, 23);
            dateTimePickerBirthday.TabIndex = 16;
            // 
            // buttonAdopt
            // 
            buttonAdopt.Location = new Point(595, 373);
            buttonAdopt.Name = "buttonAdopt";
            buttonAdopt.Size = new Size(75, 23);
            buttonAdopt.TabIndex = 17;
            buttonAdopt.Text = "Adopt";
            buttonAdopt.UseVisualStyleBackColor = true;
            buttonAdopt.Click += ButtonAddNewPetClick;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(102, 51);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(100, 70);
            pictureBoxImage.TabIndex = 18;
            pictureBoxImage.TabStop = false;
            // 
            // PetDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxImage);
            Controls.Add(buttonAdopt);
            Controls.Add(dateTimePickerBirthday);
            Controls.Add(textBoxType);
            Controls.Add(textBoxStatus);
            Controls.Add(textBoxFavToy);
            Controls.Add(textBoxMedicalHistory);
            Controls.Add(textBoxBreed);
            Controls.Add(textBoxWeight);
            Controls.Add(textBoxColor);
            Controls.Add(labelStatus);
            Controls.Add(labelFavToy);
            Controls.Add(labelColor);
            Controls.Add(labelWeight);
            Controls.Add(labelMedicalHistory);
            Controls.Add(labelBreed);
            Controls.Add(labelBirthday);
            Controls.Add(labelType);
            Controls.Add(labelPetsName);
            Name = "PetDetailsForm";
            Text = "PetDetailsForm";
            Load += FillPetInfo;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPetsName;
        private Label labelType;
        private Label labelBirthday;
        private Label labelBreed;
        private Label labelMedicalHistory;
        private Label labelWeight;
        private Label labelColor;
        private Label labelFavToy;
        private Label labelStatus;
        private TextBox textBoxColor;
        private TextBox textBoxWeight;
        private TextBox textBoxBreed;
        private TextBox textBoxMedicalHistory;
        private TextBox textBoxFavToy;
        private TextBox textBoxStatus;
        private TextBox textBoxType;
        private DateTimePicker dateTimePickerBirthday;
        private Button buttonAdopt;
        private PictureBox pictureBoxImage;
    }
}