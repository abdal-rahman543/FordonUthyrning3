using FordonUthyrning3.GUI_components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uthyrning.Entiteter;
using UthyrningSystem.Entiteter;

namespace FordonUthyrning3.Controllers
{
    public partial class ProfilController : UserControl
    {
        public ProfilController()
        {
            InitializeComponent();
        }

        private void ProfilController_Load(object sender, EventArgs e)
        {
            Användare användare = session.Instance.InloggadAnvändare;
            Konto _konto = användare.konto;

            tbxFörnamn.Text = användare.FörNamn;
            tbxEfternamn.Text = användare.EfterNamn;
            tbxEpost.Text = användare.Epost;
            tbxLösenord.Text = användare.Lösenord;
            tbxBehörighet.PlaceholderText += " " + _konto.Behörighet.ToString();

            if (_konto.BetalningsMetod.Contains(Enums.BetalningsMetod.Swish))
            {

                tbxSwishnr.PlaceholderText = _konto.TeleNr;


            }
            if (_konto.BetalningsMetod.Contains(Enums.BetalningsMetod.Kort))
            {
                tbxKortNr.PlaceholderText = _konto.KortNr;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Användare användare = session.Instance.InloggadAnvändare;

            användare.FörNamn = tbxFörnamn.Text;
            användare.EfterNamn = tbxEfternamn.Text;
            användare.Epost = tbxEpost.Text;
            användare.Lösenord = tbxLösenord.Text;
        }
    }
}
