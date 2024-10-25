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

namespace FordonUthyrning3.UserControllers
{
    public partial class UI_StationsKort : UserControl
    {
        private readonly Station _Station;
        private StationService _service;
        public UI_StationsKort(Station station)
        {
            InitializeComponent();
            _Station = station; 
        }

        private void UI_StationsKort_Load(object sender, EventArgs e)
        {
            lblStationNamn.Text = _Station.StationNamn;
            lblVärdeAdress.Text = _Station.Adress + "," + _Station.Ort;
            lblVärdeKapacitet.Text = _Station.Kapacitet.ToString();

        }
    }
}
