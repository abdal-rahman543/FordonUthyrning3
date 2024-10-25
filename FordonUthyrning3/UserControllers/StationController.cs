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
namespace FordonUthyrning3
{
    public partial class StationController : UserControl
    {
        private StationService _service;
        private Form1 _form1;
        public StationController(Form1 form)
        {
            InitializeComponent();
            _form1 = form;
            _service = new StationService();
            this.Dock = DockStyle.Left | DockStyle.Bottom;

        }
        public void LaddaInStationer()
        {
            List<Station> StationList = _service.HämtaStationer();
            foreach (Station station in StationList)
            {
                StationsKort StationKort = new StationsKort(station, _form1);
                pnlStationContainer.Controls.Add(StationKort);
                StationKort.Width = pnlStationContainer.Width - 30;



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
                FordonKort nyttKort = new FordonKort(fordon, _form1);
                pnlSection.Controls.Add(nyttKort);
            }
        }
    }     
}
