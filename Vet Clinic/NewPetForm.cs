using System.Drawing;
using Vet_Clinic.Interfaces;
using Vet_Clinic.Models;

namespace Vet_Clinic
{
    public partial class NewPetForm : Form
    {
        private string petImage;

        public NewPetForm()
        {
            InitializeComponent();

            this.labelInfoBreed.Visible = false;
            this.labelInfoName.Visible = false;
            this.labelInfoMedicalHistory.Visible = false;
            this.labelInfoColor.Visible = false;
            this.labelInfoWeight.Visible = false;
            this.labelInfoImage.Visible = false;
            this.labelInfoFavToy.Visible = false;
        }

        public IAnimal Animal { get; set; }

        private void RadioButtonDogCheckedChanged(object sender, EventArgs e)
        {
            this.labelFavToy.Visible = false;
            this.textBoxFavoriteToy.Visible = false;
            this.labelInfoFavToy.Visible = false;
        }

        private void RadioButtonCatCheckedChanged(object sender, EventArgs e)
        {
            this.labelFavToy.Visible = true;
            this.textBoxFavoriteToy.Visible = true;
        }

        public void ButtonAddNewPetClick(object sender, EventArgs e)
        {
            if (!CheckIfInputsAreValid())
            {
                return;
            }

            IAnimal newAnimal = CreateNewAnimal();
            if (newAnimal != null)
            {
                this.Animal = newAnimal;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private bool CheckIfInputsAreValid()
            => CheckIfValid(this.textBoxName, 3, this.labelInfoName) && CheckIfValid(this.textBoxBreed, 5, this.labelInfoBreed) &&
    CheckIfValid(this.textBoxMedicalHistory, 10, this.labelInfoMedicalHistory) && CheckIfValid(this.textBoxColor, 3, this.labelInfoColor) && CheckIfValidDouble(this.textBoxWeight, this.labelInfoWeight, 0.5) &&
    CheckIfNotEmpty(this.petImage, this.labelInfoImage);

        private static bool CheckIfValid(TextBox textBox, int minLength, Label errorLabel)
        {
            bool isValid = textBox.Text.Trim().Length >= minLength;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private static void ShowValidationError(Label label, bool isValid)
        {
            label.Visible = !isValid;
        }

        private static bool CheckIfValidDouble(TextBox textBox, Label errorLabel, double min)
        {
            bool isValid = double.TryParse(textBox.Text.Trim(), out double parsedValue) && parsedValue > min;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private static bool CheckIfNotEmpty(string value, Label errorLabel)
        {
            bool isValid = !string.IsNullOrWhiteSpace(value?.Trim());
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private IAnimal CreateNewAnimal()
        {
            string name = this.textBoxName.Text.Trim();
            string breed = this.textBoxBreed.Text.Trim();
            string medicalHistory = this.textBoxMedicalHistory.Text.Trim();
            string color = this.textBoxColor.Text.Trim();
            DateTime birthday = this.dateTimePickerBirthday.Value;
            double weight = double.Parse(this.textBoxWeight.Text.Trim());

            IAnimal animal;
            if (this.radioButtonCat.Checked)
            {
                animal = CreateCat(name, birthday, breed, medicalHistory, weight, color);
            }
            else
            {
                animal = new Dog(name, birthday, breed, medicalHistory, weight, color);
            }

            animal.Image = petImage;
            return animal;
        }

        private Cat CreateCat(string name, DateTime birthday, string breed, string medicalHistory, double weight,
            string color)
        {
            string favToy = this.textBoxFavoriteToy.Text.Trim();
            if (!CheckIfValid(this.textBoxFavoriteToy, 3, this.labelInfoFavToy))
            {
                return null;
            }

            return new Cat(name, birthday, breed, medicalHistory, weight, color, favToy);
        }

        private void TextBoxPhotoMouseDown(object sender, MouseEventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select Pet Image";

            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; .bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                petImage = openFileDialog.FileName;
                this.textBoxImage.Text = Path.GetFileName(petImage);
            }
        }

    }
}