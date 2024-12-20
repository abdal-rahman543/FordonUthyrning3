using FordonUthyrning3.GUI_components;
using System.ComponentModel.Design;
using Uthyrning.Databas;
using Uthyrning.Aff�rslager;
using Microsoft.VisualBasic.Devices;
using UthyrningSystem.Entiteter;
using FordonUthyrning3.UserControllers;
using Uthyrning.Entiteter;
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


        // Metod f�r att initiera Form1-instansen

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (GbxContent_Container != null)
            {

                GbxContent_Container.Height = this.ClientSize.Height - 350;

                // Center GroupBox in the form�s client area
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

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vyer.LaddaProfil();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _instance.Meny.Visible = false;
            session.Instance.EndSession();
            Vyer.LaddaLogginVy();
        }

        private void toolStripMenuBack_Click(object sender, EventArgs e)
        {
            _instance.Meny.Visible = true;
            Vyer.LaddaLogginVy();
        }


        private void btnAddStation_Click(object sender, EventArgs e)
        {
            Vyer.LaddaStationRegistrering();
        }

        private void btnAddFordon_Click(object sender, EventArgs e)
        {
            Vyer.LaddaFordonRegistrering();
        }
    }
}
