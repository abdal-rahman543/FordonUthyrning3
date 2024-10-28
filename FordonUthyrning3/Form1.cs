using FordonUthyrning3.GUI_components;
using System.ComponentModel.Design;
using Uthyrning.Databas;
using Uthyrning.Affärslager;
using Microsoft.VisualBasic.Devices;
using UthyrningSystem.Entiteter;
using FordonUthyrning3.UserControllers;
namespace FordonUthyrning3
{
    public partial class Form1 : Form
    {
       
        public static Form1 _instance;
      


        public Form1()
        {
            InitializeComponent();

            _instance = this;
           

            // Ensure GbxContent_Container is initialized before adding controller
            if (GbxContent_Container != null)
            {
                Vyer.LaddaLogginVy();
               
            }
            else
            {
                MessageBox.Show("GbxContent_Container is not initialized.");
            }
        }
       

        // Metod för att initiera Form1-instansen
      
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (GbxContent_Container != null)
            {

                GbxContent_Container.Height = this.ClientSize.Height - 350;

                // Center GroupBox in the form’s client area
                GbxContent_Container.Location = new Point(
                    (this.ClientSize.Width / 2) - (GbxContent_Container.Width / 2),
                    (this.ClientSize.Height / 2) - (GbxContent_Container.Height / 2)
                );

                // Centrerar LoginBoxen
               
               
            }
            
        }

        private void hemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GbxContent_Container.Controls.Clear();
            
            Vyer.LaddaHemVy();
            
        }
    }
}
