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
        private Form1 _form1;   
        public UI_StationsKort(Station station, Form1 form)
        {
            InitializeComponent();
            _Station = station;
            _form1 = form;
        }

        private void UI_StationsKort_Load(object sender, EventArgs e)
        {
            lblStationNamn.Text = _Station.StationNamn;
            lblVärdeAdress.Text = _Station.Adress + "," + _Station.Ort;
            lblVärdeKapacitet.Text = _Station.Kapacitet.ToString();

        }

        private void btnVälj_Click(object sender, EventArgs e)
        {
            _form1.GbxContent_Container.Controls.Clear();
            StationController Stationen = new StationController(_form1);
            Stationen.VisaFordonIStation(_Station);
            _form1.GbxContent_Container.Controls.Add(Stationen);
            Stationen.Dock = DockStyle.Fill;





        }
    }
}
