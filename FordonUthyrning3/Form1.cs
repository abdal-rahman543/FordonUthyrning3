using FordonUthyrning3.GUI_components;
using System.ComponentModel.Design;
using Uthyrning.Databas;
using Uthyrning.Aff�rslager;
using Microsoft.VisualBasic.Devices;
using UthyrningSystem.Entiteter;
namespace FordonUthyrning3
{
    public partial class Form1 : Form
    {
        private LoginController controller;
        public static Form1 _instance;
        public static Anv�ndare UserInContext;
      


        public Form1()
        {
            InitializeComponent();

            _instance = this;
           

            // Ensure GbxContent_Container is initialized before adding controller
            if (GbxContent_Container != null)
            {
                controller = new LoginController();
                this.GbxContent_Container.Controls.Add(controller);
            }
            else
            {
                MessageBox.Show("GbxContent_Container is not initialized.");
            }
        }
       

        // Metod f�r att initiera Form1-instansen
      
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (GbxContent_Container != null && controller != null)
            {
                GbxContent_Container.Width = this.ClientSize.Width - 300;
                GbxContent_Container.Height = this.ClientSize.Height - 200;

                // Center GroupBox in the form�s client area
                GbxContent_Container.Location = new Point(
                    (this.ClientSize.Width / 2) - (GbxContent_Container.Width / 2),
                    (this.ClientSize.Height / 2) - (GbxContent_Container.Height / 2)
                );

            }
            // Centrerar LoginBoxen
            controller.Location = new Point(GbxContent_Container.Width / 2 - controller.Width / 2, GbxContent_Container.Height / 2 - controller.Height / 2);
        }

        private void hemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GbxContent_Container.Controls.Clear();
            Vyer hemvy = new(this);
            hemvy.LaddaHemVy();
            
        }
    }
}
