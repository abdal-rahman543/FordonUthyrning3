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

namespace FordonUthyrning3.Controllers
{
    public partial class StationRegistreringController : UserControl
    {
        private StationService _stationService;
        private static Form1 _form1 = Form1._instance;
        private static int currentStationNummer = 126;
        public StationRegistreringController()
        {
            InitializeComponent();
            _stationService = Custom_ServiceContainer.GetService<StationService>();
        }

        private void StationRegistreringController_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string stationID = GenerateStationID();
            string stationNamn = tbxStationNamn.Text; //Bör vi ha kontroll av namn osv?
            string stationAdress = tbxStationAdress.Text;
            string stationOrt = tbxStationOrt.Text;
            int antalFordon = 0;
            int kapacitet;
            new List<Fordon>();
            currentStationNummer++;

            if (!int.TryParse(tbxStationKapacitet.Text, out kapacitet) || kapacitet < 0 || kapacitet > 100)
            {
                MessageBox.Show("Kapacitet måste vara ett heltal mellan 0 och 100.");
                return;
            }

            Station station = new Station(stationID, stationNamn, stationAdress, stationOrt, kapacitet);

            if (station != null)
            {
                // Tar bort registrera Station rutan

                tbxStationNamn.Visible = false;
                tbxStationAdress.Visible = false;
                tbxStationOrt.Visible = false;
                _stationService.LäggTillStation(station);
                MessageBox.Show("Station registrerad!");
                Vyer.LaddaHemVy();

            }

        }
        private string GenerateStationID()
        {
            return "S" + currentStationNummer;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
