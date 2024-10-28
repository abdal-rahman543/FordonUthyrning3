using FordonUthyrning3.GUI_components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uthyrning.Affärslager;
using UthyrningSystem.Entiteter;
using static UthyrningSystem.Entiteter.Enums;

namespace FordonUthyrning3
{
    public partial class RegistereraController : UserControl
    {
        private RegistreraService _service;
        private static Form1 _form1 = Form1._instance;

        string Förnamn;
        string Efternamn;
        string Epost;
        string Lösenord;
        string BehörighetsNivå;
        public RegistereraController()
        {
            InitializeComponent();
            _service = Custom_ServiceContainer.GetService<RegistreraService>();
           
        }
        private void LoadValues()
        {
             Förnamn = tbxFörnamn.Text;
             Efternamn = tbxEfternamn.Text;
             Epost = tbxEpost.Text;
             Lösenord = tbxLösenord.Text;
             BehörighetsNivå = (string)cboBehörighet.SelectedItem;
        }
        public void btnRegistrera_Click(object sender, EventArgs e)
        {
           
            if (BehörighetsNivå == "kund")
            {
                if (Förnamn != "" && Efternamn != "" && Epost != "" && Lösenord != "") 
                {
                    BetalningsMetodForm betalform = new(this);
                    betalform.Dock = DockStyle.None; // Ta bort dockning så att vi kan centrera det manuellt

                    // Beräkna position för att centrera formen
                    int x = (_form1.GbxContent_Container.Width - betalform.Width) / 2;
                    int y = (_form1.GbxContent_Container.Height - betalform.Height) / 2;
                    betalform.Location = new Point(x, y);

                    // Rensa och lägg till den centrerade formen
                    foreach (Control control in _form1.GbxContent_Container.Controls)
                    {
                        control.Visible = false;
                    }

                    _form1.GbxContent_Container.Controls.Add(betalform);
                }
                else
                {
                    MessageBox.Show("Du måste fylla i all information");

                }
               
            }
            else
            {
                Registrera();
            }
        }

        public  void Registrera()
        {
           
            Användare RegisterdUser = _service.Registrera(Förnamn, Efternamn, Epost, Lösenord, BehörighetsNivå);
            if (RegisterdUser != null)
            {
                // Dispose the textboxes and other controls
                tbxFörnamn.Visible = false;
                tbxEfternamn.Visible = false;
                tbxEpost.Visible = false;
                tbxLösenord.Visible = false;
                btnRegistrera.Visible = false;
                cboBehörighet.Visible = false;
                lblRegistrering.Visible = false;

                // Show the status message
                lblRegistereingStatus.Visible = true;
                lblRegistereingStatus.Text = "Registrering lyckad!";
                MessageBox.Show("Registrering lyckades" +"\n"+ 
                    "Ditt användare id:" + RegisterdUser.ID);

                // Use a Timer to delay the disposal or transition to the next step
                var timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; // 1 second
                timer.Tick += (s, ev) =>
                {
                    timer.Stop();

                    // Dispose the current controls or form after the delay
                    this.Controls.Clear();
                    Vyer.LaddaLogginVy();
                };
                timer.Start();

            }
            else
            {



                // Show the status message
                MessageBox.Show("Fel inmatning av uppgifter prova igen");

            }
        }

        public void RegistereraController_SizeChanged(object sender, EventArgs e)
        {
            int containerWidth = this.ClientSize.Width;

            // Calculate the starting Y position for vertical stacking
            int currentY = 100; // Start a bit lower from the top

            // Center lblRegistrering (which is wider)
            lblRegistrering.Location = new Point(
                (containerWidth - lblRegistrering.Width) / 2,
                currentY
            );
            currentY += lblRegistrering.Height + 20; // Add some spacing after the label

            // Center tbxFörnamn
            tbxFörnamn.Location = new Point(
                (containerWidth - tbxFörnamn.Width) / 2,
                currentY
            );
            currentY += tbxFörnamn.Height + 10;

            // Center tbxEfternamn
            tbxEfternamn.Location = new Point(
                (containerWidth - tbxEfternamn.Width) / 2,
                currentY
            );
            currentY += tbxEfternamn.Height + 10;

            // Center tbxEpost
            tbxEpost.Location = new Point(
                (containerWidth - tbxEpost.Width) / 2,
                currentY
            );
            currentY += tbxEpost.Height + 10;

            // Center tbxLösenord
            tbxLösenord.Location = new Point(
                (containerWidth - tbxLösenord.Width) / 2,
                currentY
            );
            currentY += tbxLösenord.Height + 10;

            // Center comboBox1
            cboBehörighet.Location = new Point(
                (containerWidth - cboBehörighet.Width) / 2,
                currentY
            );
            currentY += cboBehörighet.Height + 20;

            // Center btnRegistrera
            btnRegistrera.Location = new Point(
                (containerWidth - btnRegistrera.Width) / 2,
                currentY
            );
        }

        private void cboBehörighet_DropDownClosed(object sender, EventArgs e)
        {
            LoadValues();
            if (cboBehörighet.SelectedItem != null) 
            {
                if (cboBehörighet.SelectedItem == "kund")
                {
                    btnRegistrera.Text = "Nästa";

                }
                else
                {
                    btnRegistrera.Text = "Registrera";
                }
            }
        }
    }
}
