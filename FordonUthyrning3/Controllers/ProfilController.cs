using FordonUthyrning3.GUI_components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uthyrning.Entiteter;
using UthyrningSystem.Entiteter;

namespace FordonUthyrning3.Controllers
{
    public partial class ProfilController : UserControl
    {
        private Användare användare;
        private Konto _konto;
        public ProfilController()
        {
            InitializeComponent();
            användare = session.Instance.InloggadAnvändare;
            _konto = användare.konto;
        }

        private void ProfilController_Load(object sender, EventArgs e)
        {
          

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
           

            användare.FörNamn = tbxFörnamn.Text;
            användare.EfterNamn = tbxEfternamn.Text;
            användare.Epost = tbxEpost.Text;
            användare.Lösenord = tbxLösenord.Text;


        }

        private void tbxSwishnr_TextChanged(object sender, EventArgs e)
        {
            if (_konto.BetalningsMetod.Contains(Enums.BetalningsMetod.Swish)) 
            {
                if (tbxSwishnr.Text.Length == 10 && Regex.IsMatch(tbxSwishnr.Text, @"^\d+$")) 
                {
                    _konto.TeleNr = tbxSwishnr.Text;
                    MessageBox.Show("Swish nummer ändrad");
                }
            }
            else
            {
                if (tbxSwishnr.Text.Length == 10 && Regex.IsMatch(tbxSwishnr.Text, @"^\d+$"))
                {
                    _konto.TeleNr = tbxSwishnr.Text;
                    _konto.BetalningsMetod.Add(Enums.BetalningsMetod.Swish);
                    MessageBox.Show("Swish tillagt");


                }

            }
        }
    }
}
