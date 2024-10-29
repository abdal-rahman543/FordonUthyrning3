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
using FordonUthyrning3.UserControllers;
using FordonUthyrning3.GUI_components;
using FordonUthyrning3.Controllers;
namespace FordonUthyrning3
{
    public partial class StationController : UserControl
    {
        private StationService _service;
        private static Form1 _form1 = Form1._instance;
        public StationController()
        {
            InitializeComponent();
            _service = Custom_ServiceContainer.GetService<StationService>();
            this.Dock = DockStyle.Left | DockStyle.Bottom;

        }
        public void LaddaInStationer()
        {
            List<Station> StationList = _service.HämtaStationer();
            foreach (Station station in StationList)
            {
                StationsKort StationKort = new StationsKort(station);
                pnlStationContainer.Controls.Add(StationKort);
                StationKort.Width = pnlStationContainer.Width - 30;
                station.UppdateraAntalFordon();



            }
        }
        public void VisaFordonIStation(Station station)
        {

            pnlStationContainer.FlowDirection = FlowDirection.LeftToRight;
            pnlStationContainer.WrapContents = true;
            lblNamn.Text = station.StationNamn;
            pnlSection.Width = pnlStationContainer.Width;
            pnlSection.Height = pnlStationContainer.Height;
            pnlSection.Visible = true;
            pnlSection.WrapContents = true;

            foreach (Fordon fordon in station.Fordonlista)
            {
               if(fordon.BokningStatus == Enums.BokningStatus.Tillgänglig)
                {
                    FordonKort nyttKort = new FordonKort(fordon, _form1);
                    pnlSection.Controls.Add(nyttKort);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vyer.LaddaStationRegistrering();
        }

    }
}
