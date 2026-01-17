namespace Vet_Clinic
{
    public partial class IndexForm : Form
    {
        private readonly List<IAnimal> pets = new List<IAnimal>()
        {
            new Cat("Fluffy", new DateTime(2018, 5, 15), "Persian", "Regular checkups", 4.5, "Golden", "Feather wand"),
            new Dog("Buddy", new DateTime(2016, 8, 20), "Golden Retriever", "Vaccinated", 25.5, "Golden", "Stick")
        };
        public IndexForm()
        {
            InitializeComponent();
        }
        private void OnLoad(object sender, EventArgs e)
        {
            LoadAllPets();
        }

        private void LoadAllPets()
        {
            this.listViewPets.Clear();

            foreach (var pet in pets)
            {
                this.listViewPets.Items.Add(pet.Name, pet.GetType() == typeof(Cat) ? 0 : 1);
            }
        }

        private void ListViewPetsMouseClick(object sender, MouseEventArgs e)
        {
            IAnimal selectedPet = pets[this.listViewPets.SelectedItems[0].Index];

            if (selectedPet != null)
            {
                using PetDetailsForm detailsForm = new PetDetailsForm(selectedPet);
                detailsForm.ShowDialog();
            }
        }

        private void ButtonAddNewPetClick(object sender, EventArgs e)
        {
            using (NewPetForm newPetForm = new())
            {
                if (newPetForm.ShowDialog() == DialogResult.OK)
                {
                    this.pets.Add(newPetForm.Animal);
                }
            }
            LoadAllPets();
        }
    }
}
