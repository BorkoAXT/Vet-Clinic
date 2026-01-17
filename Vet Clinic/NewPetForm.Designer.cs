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
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(368, 89);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(51, 15);
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
            labelFavToy.Location = new Point(419, 335);
            labelFavToy.Name = "labelFavToy";
            labelFavToy.Size = new Size(78, 15);
            labelFavToy.TabIndex = 3;
            labelFavToy.Text = "Favourite Toy";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(114, 211);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 4;
            labelName.Text = "Name";
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Location = new Point(102, 249);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(51, 15);
            labelBirthday.TabIndex = 5;
            labelBirthday.Text = "Birthday";
            // 
            // labelBreed
            // 
            labelBreed.AutoSize = true;
            labelBreed.Location = new Point(114, 292);
            labelBreed.Name = "labelBreed";
            labelBreed.Size = new Size(37, 15);
            labelBreed.TabIndex = 6;
            labelBreed.Text = "Breed";
            // 
            // labelMedicalHistory
            // 
            labelMedicalHistory.AutoSize = true;
            labelMedicalHistory.Location = new Point(63, 327);
            labelMedicalHistory.Name = "labelMedicalHistory";
            labelMedicalHistory.Size = new Size(90, 15);
            labelMedicalHistory.TabIndex = 7;
            labelMedicalHistory.Text = "Medical History";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(452, 211);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(45, 15);
            labelWeight.TabIndex = 8;
            labelWeight.Text = "Weight";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(461, 249);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(36, 15);
            labelColor.TabIndex = 9;
            labelColor.Text = "Color";
            // 
            // labelImage
            // 
            labelImage.AutoSize = true;
            labelImage.Location = new Point(457, 289);
            labelImage.Name = "labelImage";
            labelImage.Size = new Size(40, 15);
            labelImage.TabIndex = 10;
            labelImage.Text = "Image";
            // 
            // textBoxMedicalHistory
            // 
            textBoxMedicalHistory.Location = new Point(169, 327);
            textBoxMedicalHistory.Name = "textBoxMedicalHistory";
            textBoxMedicalHistory.Size = new Size(210, 23);
            textBoxMedicalHistory.TabIndex = 4;
            // 
            // textBoxBreed
            // 
            textBoxBreed.Location = new Point(169, 289);
            textBoxBreed.Name = "textBoxBreed";
            textBoxBreed.Size = new Size(210, 23);
            textBoxBreed.TabIndex = 3;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(517, 208);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(206, 23);
            textBoxWeight.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(169, 208);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(210, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(517, 246);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(206, 23);
            textBoxColor.TabIndex = 6;
            // 
            // textBoxImage
            // 
            textBoxImage.Location = new Point(517, 292);
            textBoxImage.Name = "textBoxImage";
            textBoxImage.Size = new Size(206, 23);
            textBoxImage.TabIndex = 7;
            // 
            // textBoxFavoriteToy
            // 
            textBoxFavoriteToy.Location = new Point(517, 332);
            textBoxFavoriteToy.Name = "textBoxFavoriteToy";
            textBoxFavoriteToy.Size = new Size(206, 23);
            textBoxFavoriteToy.TabIndex = 8;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new Point(169, 249);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(210, 23);
            dateTimePickerBirthday.TabIndex = 2;
            // 
            // buttonAddNewPet
            // 
            buttonAddNewPet.Location = new Point(459, 375);
            buttonAddNewPet.Name = "buttonAddNewPet";
            buttonAddNewPet.Size = new Size(75, 23);
            buttonAddNewPet.TabIndex = 1;
            buttonAddNewPet.Text = "Add";
            buttonAddNewPet.UseVisualStyleBackColor = true;
            buttonAddNewPet.Click += ButtonAddNewPetClick;
            // 
            // labelInfoName
            // 
            labelInfoName.AutoSize = true;
            labelInfoName.Location = new Point(169, 231);
            labelInfoName.Name = "labelInfoName";
            labelInfoName.Size = new Size(0, 15);
            labelInfoName.TabIndex = 16;
            // 
            // labelInfoBreed
            // 
            labelInfoBreed.AutoSize = true;
            labelInfoBreed.Location = new Point(169, 309);
            labelInfoBreed.Name = "labelInfoBreed";
            labelInfoBreed.Size = new Size(0, 15);
            labelInfoBreed.TabIndex = 17;
            // 
            // labelInfoMedicalHistory
            // 
            labelInfoMedicalHistory.AutoSize = true;
            labelInfoMedicalHistory.Location = new Point(169, 375);
            labelInfoMedicalHistory.Name = "labelInfoMedicalHistory";
            labelInfoMedicalHistory.Size = new Size(0, 15);
            labelInfoMedicalHistory.TabIndex = 18;
            // 
            // labelInfoWeight
            // 
            labelInfoWeight.AutoSize = true;
            labelInfoWeight.Location = new Point(517, 231);
            labelInfoWeight.Name = "labelInfoWeight";
            labelInfoWeight.Size = new Size(0, 15);
            labelInfoWeight.TabIndex = 19;
            // 
            // labelInfoColor
            // 
            labelInfoColor.AutoSize = true;
            labelInfoColor.Location = new Point(517, 272);
            labelInfoColor.Name = "labelInfoColor";
            labelInfoColor.Size = new Size(0, 15);
            labelInfoColor.TabIndex = 20;
            // 
            // labelInfoImage
            // 
            labelInfoImage.AutoSize = true;
            labelInfoImage.Location = new Point(517, 314);
            labelInfoImage.Name = "labelInfoImage";
            labelInfoImage.Size = new Size(0, 15);
            labelInfoImage.TabIndex = 21;
            // 
            // labelInfoFavToy
            // 
            labelInfoFavToy.AutoSize = true;
            labelInfoFavToy.Location = new Point(517, 357);
            labelInfoFavToy.Name = "labelInfoFavToy";
            labelInfoFavToy.Size = new Size(0, 15);
            labelInfoFavToy.TabIndex = 22;
            // 
            // NewPetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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