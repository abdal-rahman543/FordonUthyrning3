using FordonUthyrning3.GUI_components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Uthyrning.Affärslager;
using Uthyrning.Databas;
using UthyrningSystem.Entiteter;
using static UthyrningSystem.Entiteter.Enums;

namespace FordonUthyrning3.Controllers
{
    public partial class FordonRegistreringController : UserControl
    {
        private static Form1 _form1 = Form1._instance;
        private readonly FordonService _Fordonservice;
        private readonly StationService _Stationservice;
        private ComboBox cbxStationer;

        public FordonRegistreringController()
        {
            InitializeComponent();

            _Fordonservice = Custom_ServiceContainer.GetService<FordonService>();
            _Stationservice = Custom_ServiceContainer.GetService<StationService>();
            // Initialize ComboBox for assigning stations to vehicles

            tbxRTilldelaStation.DropDownStyle = ComboBoxStyle.DropDownList;
            tbxRTilldelaStation.DataSource = _Stationservice.HämtaStationer();
            tbxRTilldelaStation.DisplayMember = "StationNamn";


            cbxStationer = new ComboBox();
            cbxStationer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStationer.DataSource = _Stationservice.HämtaStationer();
            cbxStationer.DisplayMember = "StationNamn";
            cbxStationer.ValueMember = "StationID";
            Controls.Add(cbxStationer);

            // Set items for ComboBoxes using Enums
            tbxRFordonTyp.DropDownStyle = ComboBoxStyle.DropDownList;
            tbxRFordonTyp.Items.AddRange(Enum.GetNames(typeof(FordonsTyp)));

            tbxRBokningStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            tbxRBokningStatus.Items.AddRange(Enum.GetNames(typeof(BokningStatus)));

            tbxRFordonStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            tbxRFordonStatus.Items.AddRange(Enum.GetNames(typeof(FordonStatus)));

            tbxRBatteriNivå.DropDownStyle = ComboBoxStyle.DropDownList;
            tbxRBatteriNivå.Items.AddRange(new string[] { "100", "75", "50", "25", "0" });
        }

       

        private void label1_Click(object sender, EventArgs e)
        {
            // Hantera klickhändelsen för lblRBatteriNivå (eller annan logik om det behövs)
        }


        private void btnRegistreraFordon_Click(object sender, EventArgs e)
        {
            // Hämta användarens val från befintliga ComboBox-komponenter
            FordonsTyp valdTyp = (FordonsTyp)Enum.Parse(typeof(FordonsTyp), tbxRFordonTyp.SelectedItem.ToString());
            FordonStatus valdStatus = (FordonStatus)Enum.Parse(typeof(FordonStatus), tbxRFordonStatus.SelectedItem.ToString());
            BokningStatus valdBokningStatus = (BokningStatus)Enum.Parse(typeof(BokningStatus), tbxRBokningStatus.SelectedItem.ToString());
            int valdBatteriNivå = int.Parse(tbxRBatteriNivå.SelectedItem.ToString());
            int pris = int.Parse(tbxPris.Text);

            // Skapa ett nytt fordon baserat på användarens val
            Fordon nyttFordon = _Fordonservice.SkapaFordon(valdTyp, valdStatus, pris, valdBatteriNivå);

            // Registrera fordonet till vald station
            RegistreraNyttFordonMedStation(nyttFordon);
           
        }
        public void RegistreraNyttFordonMedStation(Fordon fordon)
        {
            Station station = tbxRTilldelaStation.SelectedItem as Station;

            if (station != null)
            {
                // Add the vehicle to the station's vehicle list
                if (station.Fordonlista.Count == station.Kapacitet)
                {
                    MessageBox.Show($"Stationen {station.StationNamn} har nått sin maximala kapacitet och kan inte ta emot fler fordon.");
                    return;
                }
                else
                {

                    _Fordonservice.RegistreraFordon(fordon,station);
                    Vyer.LaddaHemVy();
                    MessageBox.Show($"Fordonet med ID {fordon.FordonID} har registrerats vid stationen {station.StationNamn}.");
                }
               

                // Update the station list in the database to reflect the changes
              
            }
            else
            {
                MessageBox.Show("Ingen station är vald.");
            }
        }
    }
}
