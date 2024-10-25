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
        }
        public void pnlStationContainer_Load(object sender, EventArgs e)
        {
            List<Station> StationList = _service.HämtaStationer();
            foreach (Station station in StationList)
            {
                UI_StationsKort StationKort = new UI_StationsKort(station);
                pnlStationContainer.Controls.Add(StationKort);
                StationKort.Width = pnlStationContainer.Width - 30 ;
               

            }
        }

       
    }
}
