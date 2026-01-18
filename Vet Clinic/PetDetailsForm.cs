using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vet_Clinic
{
    public partial class PetDetailsForm : Form
    {
        private readonly IAnimal? pet;
        public PetDetailsForm(IAnimal? pet)
        {
            InitializeComponent();
            this.pet = pet;
        }

        private void FillPetInfo(object sender, EventArgs e)
        {
            this.labelPetsName.Text = pet?.Name;
            this.textBoxType.Text = pet?.GetType().Name;
            this.dateTimePickerBirthday.Text = pet.Birthday.ToString();
            this.textBoxBreed.Text = pet.Breed;
            this.textBoxColor.Text = pet.Color;
            this.textBoxWeight.Text = pet.Weight.ToString();
            this.textBoxMedicalHistory.Text = pet.MedicalHistory;
            this.textBoxStatus.Text = pet.Status.ToString();

            if (!string.IsNullOrEmpty(pet.Image) && File.Exists(pet.Image))
            {
                this.ImagePictureBoxPet.Image = Image.FromFile(pet.Image);
            }

            if (pet is Cat cat)
            {
                this.textBoxFavToy.Text = cat.FavoriteToy;
            }
            else
            {
                this.textBoxFavToy.Visible = false;
                this.labelFavToy.Visible = false;
            }

            this.buttonAdopt.Enabled = this.pet.Status != Status.Adopted;
        }

        private void AdoptPetButtonClick(object sender, EventArgs e)
        {
            this.pet.Status = Status.Adopted;
            this.textBoxStatus.Text = this.pet.Status.ToString();
            this.buttonAdopt.Enabled = false;
        }


    }
}
