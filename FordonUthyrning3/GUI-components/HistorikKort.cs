using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UthyrningSystem.Entiteter;

namespace FordonUthyrning3.GUI_components
{
    public partial class HistorikKort : UserControl
    {
        private HyresHistorik _historik;
        public HistorikKort(HyresHistorik historik)
        {
            InitializeComponent();
            _historik = historik;
        }

        private void HistorikKort_Load(object sender, EventArgs e)
        {
            lblVärdeBetalningMetod.Text = _historik.BetalningsMetod.ToString();
            lblVärdeDatum.Text = _historik.UthyrningsDatum.ToString();
            lblVärdeStartTid.Text = _historik.StartTid.ToString();
            lblVärdeSluttid.Text = _historik.SlutTid.ToString();
            lblVärdeFId.Text = _historik.FordonID.ToString();
            lblVärdeKostnad.Text = _historik.kostnad.ToString() + "kr";
            lblAnvändareNamn.Text = _historik.HyresTagare.FörNamn +" "+ _historik.HyresTagare.EfterNamn;
        }
    }
}
