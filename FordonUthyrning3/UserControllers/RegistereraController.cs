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

namespace FordonUthyrning3
{
    public partial class RegistereraController : UserControl
    {
        private RegistreraService _service;
        private Form1 _form1;
        public RegistereraController(Form1 form)
        {
            InitializeComponent();
            _form1 = form;
            _service = new RegistreraService();
        }

        public void btnRegistrera_Click(object sender, EventArgs e)
        {
            string Förnamn = tbxFörnamn.Text;
            string Efternamn = tbxEfternamn.Text;
            string Epost = tbxEpost.Text;
            string Lösenord = tbxLösenord.Text;
            string BehörighetsNivå = cboBehörighet.Text;
            bool RegistreringStatus  = _service.Registrera(Förnamn, Efternamn, Epost, Lösenord, BehörighetsNivå);
            if (RegistreringStatus) 
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

                // Use a Timer to delay the disposal or transition to the next step
                var timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; // 1 second
                timer.Tick += (s, ev) =>
                {
                    timer.Stop();

                    // Dispose the current controls or form after the delay
                    this.Controls.Clear();
                    this.Dispose();
                    _form1.GbxContent_Container.Controls.Add(new LoginController(_form1));
                };
                timer.Start();

            }
            else
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
                lblRegistereingStatus.Text = "Registrering misslyckad!";

                // Use a Timer to delay the disposal or transition to the next step
                var timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; // 1 second
                timer.Tick += (s, ev) =>
                {
                    timer.Stop();

                    // Dispose the current controls or form after the delay
                    this.Controls.Clear();
                    this.Dispose();
                    _form1.GbxContent_Container.Controls.Add(new LoginController(_form1));
                };
                timer.Start();

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
    }
}
