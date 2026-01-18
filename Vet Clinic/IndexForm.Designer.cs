namespace Vet_Clinic
{
    partial class IndexForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            labelTitle = new Label();
            listViewPets = new ListView();
            imageListPets = new ImageList(components);
            buttonAddNewPet = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 30F);
            labelTitle.ForeColor = SystemColors.ButtonFace;
            labelTitle.Location = new Point(314, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(187, 54);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Vet Clinic";
            // 
            // listViewPets
            // 
            listViewPets.LargeImageList = imageListPets;
            listViewPets.Location = new Point(60, 101);
            listViewPets.Name = "listViewPets";
            listViewPets.Size = new Size(669, 255);
            listViewPets.SmallImageList = imageListPets;
            listViewPets.TabIndex = 1;
            listViewPets.UseCompatibleStateImageBehavior = false;
            listViewPets.MouseClick += ListViewPetsMouseClick;
            // 
            // imageListPets
            // 
            imageListPets.ColorDepth = ColorDepth.Depth16Bit;
            imageListPets.ImageStream = (ImageListStreamer)resources.GetObject("imageListPets.ImageStream");
            imageListPets.TransparentColor = Color.Transparent;
            imageListPets.Images.SetKeyName(0, "icons8-cat-100");
            imageListPets.Images.SetKeyName(1, "icons8-dog-100");
            // 
            // buttonAddNewPet
            // 
            buttonAddNewPet.BackColor = SystemColors.ActiveCaption;
            buttonAddNewPet.Location = new Point(586, 362);
            buttonAddNewPet.Name = "buttonAddNewPet";
            buttonAddNewPet.Size = new Size(143, 46);
            buttonAddNewPet.TabIndex = 2;
            buttonAddNewPet.Text = "Add New Pet";
            buttonAddNewPet.UseVisualStyleBackColor = false;
            buttonAddNewPet.Click += ButtonAddNewPetClick;
            // 
            // IndexForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddNewPet);
            Controls.Add(listViewPets);
            Controls.Add(labelTitle);
            Name = "IndexForm";
            Text = "Vet Clinic";
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private ListView listViewPets;
        private ImageList imageListPets;
        private Button buttonAddNewPet;
    }
}
