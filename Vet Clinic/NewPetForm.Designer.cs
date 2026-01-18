namespace Vet_Clinic
{
    partial class NewPetForm
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
            labelTitle = new Label();
            radioButtonCat = new RadioButton();
            radioButtonDog = new RadioButton();
            labelFavToy = new Label();
            labelName = new Label();
            labelBirthday = new Label();
            labelBreed = new Label();
            labelMedicalHistory = new Label();
            labelWeight = new Label();
            labelColor = new Label();
            labelImage = new Label();
            textBoxMedicalHistory = new TextBox();
            textBoxBreed = new TextBox();
            textBoxWeight = new TextBox();
            textBoxName = new TextBox();
            textBoxColor = new TextBox();
            textBoxImage = new TextBox();
            textBoxFavoriteToy = new TextBox();
            dateTimePickerBirthday = new DateTimePicker();
            buttonAddNewPet = new Button();
            labelInfoName = new Label();
            labelInfoBreed = new Label();
            labelInfoMedicalHistory = new Label();
            labelInfoWeight = new Label();
            labelInfoColor = new Label();
            labelInfoImage = new Label();
            labelInfoFavToy = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 30F);
            labelTitle.Location = new Point(297, 36);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(206, 79);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "New Pet";
            // 
            // radioButtonCat
            // 
            radioButtonCat.AutoSize = true;
            radioButtonCat.Location = new Point(145, 155);
            radioButtonCat.Name = "radioButtonCat";
            radioButtonCat.Size = new Size(43, 19);
            radioButtonCat.TabIndex = 1;
            radioButtonCat.TabStop = true;
            radioButtonCat.Text = "Cat";
            radioButtonCat.UseVisualStyleBackColor = true;
            radioButtonCat.CheckedChanged += RadioButtonCatCheckedChanged;
            // 
            // radioButtonDog
            // 
            radioButtonDog.AutoSize = true;
            radioButtonDog.Location = new Point(222, 155);
            radioButtonDog.Name = "radioButtonDog";
            radioButtonDog.Size = new Size(47, 19);
            radioButtonDog.TabIndex = 15;
            radioButtonDog.TabStop = true;
            radioButtonDog.Text = "Dog";
            radioButtonDog.UseVisualStyleBackColor = true;
            radioButtonDog.CheckedChanged += RadioButtonDogCheckedChanged;
            // 
            // labelFavToy
            // 
            labelFavToy.AutoSize = true;
            labelFavToy.Location = new Point(439, 335);
            labelFavToy.Name = "labelFavToy";
            labelFavToy.Size = new Size(78, 15);
            labelFavToy.TabIndex = 3;
            labelFavToy.Text = "Favourite Toy";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(77, 211);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 4;
            labelName.Text = "Name";
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Location = new Point(63, 246);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(51, 15);
            labelBirthday.TabIndex = 5;
            labelBirthday.Text = "Birthday";
            // 
            // labelBreed
            // 
            labelBreed.AutoSize = true;
            labelBreed.Location = new Point(77, 292);
            labelBreed.Name = "labelBreed";
            labelBreed.Size = new Size(37, 15);
            labelBreed.TabIndex = 6;
            labelBreed.Text = "Breed";
            // 
            // labelMedicalHistory
            // 
            labelMedicalHistory.AutoSize = true;
            labelMedicalHistory.Location = new Point(24, 327);
            labelMedicalHistory.Name = "labelMedicalHistory";
            labelMedicalHistory.Size = new Size(90, 15);
            labelMedicalHistory.TabIndex = 7;
            labelMedicalHistory.Text = "Medical History";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(472, 211);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(45, 15);
            labelWeight.TabIndex = 8;
            labelWeight.Text = "Weight";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(481, 249);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(36, 15);
            labelColor.TabIndex = 9;
            labelColor.Text = "Color";
            // 
            // labelImage
            // 
            labelImage.AutoSize = true;
            labelImage.Location = new Point(477, 292);
            labelImage.Name = "labelImage";
            labelImage.Size = new Size(40, 15);
            labelImage.TabIndex = 10;
            labelImage.Text = "Image";
            // 
            // textBoxMedicalHistory
            // 
            textBoxMedicalHistory.BorderStyle = BorderStyle.FixedSingle;
            textBoxMedicalHistory.Location = new Point(132, 327);
            textBoxMedicalHistory.Multiline = true;
            textBoxMedicalHistory.Name = "textBoxMedicalHistory";
            textBoxMedicalHistory.Size = new Size(281, 45);
            textBoxMedicalHistory.TabIndex = 4;
            // 
            // textBoxBreed
            // 
            textBoxBreed.BorderStyle = BorderStyle.FixedSingle;
            textBoxBreed.Location = new Point(132, 284);
            textBoxBreed.Name = "textBoxBreed";
            textBoxBreed.Size = new Size(281, 23);
            textBoxBreed.TabIndex = 3;
            // 
            // textBoxWeight
            // 
            textBoxWeight.BorderStyle = BorderStyle.FixedSingle;
            textBoxWeight.Location = new Point(538, 208);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(218, 23);
            textBoxWeight.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(132, 208);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(281, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxColor
            // 
            textBoxColor.BorderStyle = BorderStyle.FixedSingle;
            textBoxColor.Location = new Point(538, 252);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(218, 23);
            textBoxColor.TabIndex = 6;
            // 
            // textBoxImage
            // 
            textBoxImage.BorderStyle = BorderStyle.FixedSingle;
            textBoxImage.Location = new Point(538, 292);
            textBoxImage.Name = "textBoxImage";
            textBoxImage.Size = new Size(218, 23);
            textBoxImage.TabIndex = 7;
            textBoxImage.MouseClick += TextBoxPhotoMouseDown;
            // 
            // textBoxFavoriteToy
            // 
            textBoxFavoriteToy.BorderStyle = BorderStyle.FixedSingle;
            textBoxFavoriteToy.Location = new Point(538, 332);
            textBoxFavoriteToy.Name = "textBoxFavoriteToy";
            textBoxFavoriteToy.Size = new Size(218, 23);
            textBoxFavoriteToy.TabIndex = 8;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new Point(132, 249);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(281, 23);
            dateTimePickerBirthday.TabIndex = 2;
            // 
            // buttonAddNewPet
            // 
            buttonAddNewPet.BackColor = SystemColors.ActiveCaption;
            buttonAddNewPet.ForeColor = SystemColors.ActiveCaptionText;
            buttonAddNewPet.Location = new Point(626, 387);
            buttonAddNewPet.Name = "buttonAddNewPet";
            buttonAddNewPet.Size = new Size(110, 41);
            buttonAddNewPet.TabIndex = 1;
            buttonAddNewPet.Text = "Add";
            buttonAddNewPet.UseVisualStyleBackColor = false;
            buttonAddNewPet.Click += ButtonAddNewPetClick;
            // 
            // labelInfoName
            // 
            labelInfoName.AutoSize = true;
            labelInfoName.ForeColor = Color.Red;
            labelInfoName.Location = new Point(132, 231);
            labelInfoName.Name = "labelInfoName";
            labelInfoName.Size = new Size(227, 15);
            labelInfoName.TabIndex = 16;
            labelInfoName.Text = "Name should be atleast 3 characters long!";
            // 
            // labelInfoBreed
            // 
            labelInfoBreed.AutoSize = true;
            labelInfoBreed.ForeColor = Color.Red;
            labelInfoBreed.Location = new Point(134, 309);
            labelInfoBreed.Name = "labelInfoBreed";
            labelInfoBreed.Size = new Size(225, 15);
            labelInfoBreed.TabIndex = 17;
            labelInfoBreed.Text = "Breed should be atleast 5 characters long!";
            // 
            // labelInfoMedicalHistory
            // 
            labelInfoMedicalHistory.AutoSize = true;
            labelInfoMedicalHistory.ForeColor = Color.Red;
            labelInfoMedicalHistory.Location = new Point(135, 375);
            labelInfoMedicalHistory.Name = "labelInfoMedicalHistory";
            labelInfoMedicalHistory.Size = new Size(284, 15);
            labelInfoMedicalHistory.TabIndex = 18;
            labelInfoMedicalHistory.Text = "Medical History should be atleast 10 characters long!";
            // 
            // labelInfoWeight
            // 
            labelInfoWeight.AutoSize = true;
            labelInfoWeight.ForeColor = Color.Red;
            labelInfoWeight.Location = new Point(538, 231);
            labelInfoWeight.Name = "labelInfoWeight";
            labelInfoWeight.Size = new Size(97, 15);
            labelInfoWeight.TabIndex = 19;
            labelInfoWeight.Text = "Weight is invalid!";
            // 
            // labelInfoColor
            // 
            labelInfoColor.AutoSize = true;
            labelInfoColor.ForeColor = Color.Red;
            labelInfoColor.Location = new Point(538, 274);
            labelInfoColor.Name = "labelInfoColor";
            labelInfoColor.Size = new Size(97, 15);
            labelInfoColor.TabIndex = 20;
            labelInfoColor.Text = "Color is required!";
            // 
            // labelInfoImage
            // 
            labelInfoImage.AutoSize = true;
            labelInfoImage.ForeColor = Color.Red;
            labelInfoImage.Location = new Point(538, 314);
            labelInfoImage.Name = "labelInfoImage";
            labelInfoImage.Size = new Size(101, 15);
            labelInfoImage.TabIndex = 21;
            labelInfoImage.Text = "Image is required!";
            // 
            // labelInfoFavToy
            // 
            labelInfoFavToy.AutoSize = true;
            labelInfoFavToy.ForeColor = Color.Red;
            labelInfoFavToy.Location = new Point(538, 357);
            labelInfoFavToy.Name = "labelInfoFavToy";
            labelInfoFavToy.Size = new Size(130, 15);
            labelInfoFavToy.TabIndex = 22;
            labelInfoFavToy.Text = "Favorite toy is required!";
            // 
            // NewPetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(labelInfoFavToy);
            Controls.Add(labelInfoImage);
            Controls.Add(labelInfoColor);
            Controls.Add(labelInfoWeight);
            Controls.Add(labelInfoMedicalHistory);
            Controls.Add(labelInfoBreed);
            Controls.Add(labelInfoName);
            Controls.Add(buttonAddNewPet);
            Controls.Add(dateTimePickerBirthday);
            Controls.Add(textBoxFavoriteToy);
            Controls.Add(textBoxImage);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxName);
            Controls.Add(textBoxWeight);
            Controls.Add(textBoxBreed);
            Controls.Add(textBoxMedicalHistory);
            Controls.Add(labelImage);
            Controls.Add(labelColor);
            Controls.Add(labelWeight);
            Controls.Add(labelMedicalHistory);
            Controls.Add(labelBreed);
            Controls.Add(labelBirthday);
            Controls.Add(labelName);
            Controls.Add(labelFavToy);
            Controls.Add(radioButtonDog);
            Controls.Add(radioButtonCat);
            Controls.Add(labelTitle);
            Name = "NewPetForm";
            Text = "New Pet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private RadioButton radioButtonCat;
        private RadioButton radioButtonDog;
        private Label labelFavToy;
        private Label labelName;
        private Label labelBirthday;
        private Label labelBreed;
        private Label labelMedicalHistory;
        private Label labelWeight;
        private Label labelColor;
        private Label labelImage;
        private TextBox textBoxMedicalHistory;
        private TextBox textBoxBreed;
        private TextBox textBoxWeight;
        private TextBox textBoxName;
        private TextBox textBoxColor;
        private TextBox textBoxImage;
        private TextBox textBoxFavoriteToy;
        private DateTimePicker dateTimePickerBirthday;
        private Button buttonAddNewPet;
        private Label labelInfoName;
        private Label labelInfoBreed;
        private Label labelInfoMedicalHistory;
        private Label labelInfoWeight;
        private Label labelInfoColor;
        private Label labelInfoImage;
        private Label labelInfoFavToy;
    }
}