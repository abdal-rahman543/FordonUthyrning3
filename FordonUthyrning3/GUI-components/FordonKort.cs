using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uthyrning.Entiteter;
using UthyrningSystem.Entiteter;
namespace FordonUthyrning3.GUI_components
{
    public partial class FordonKort : UserControl
    {
        private Form1 _form1;
        private Fordon _fordon;
        private Användare _user;
        private Station _station;
        public FordonKort(Fordon fordon, Station station, Form1 form)
        {
            InitializeComponent();
            _form1 = form;
            _fordon = fordon;
            _station = station;
            _user = session.Instance.InloggadAnvändare;
        }

        private void FordonKort_Load(object sender, EventArgs e)
        {

            lblVärdeBatteri.Text = _fordon.BatteriNivå.ToString();
            lblVärdeFStatus.Text = _fordon.FordonStatus.ToString();
            lblVärdeBStatus.Text = _fordon.BokningStatus.ToString();
            lblVärdeFTyp.Text = _fordon.FordonTyp.ToString();
            lblKostnad.Text = _fordon.kostnad.ToString() + "kr/min";
            lblFordonID.Text = _fordon.FordonID;

            if (_user.konto.Behörighet == Enums.BehörighetsNivå.Admin)
            {
                btn_Tabort.Visible = true;
                btnVälj.Visible = false;
            }



        }

        private void btnVälj_Click(object sender, EventArgs e)
        {
            //Ser till att det inte finns några pågående turer
            PågåendeTurer tur = _user.konto.tur;
            if (tur == null)
            {
                infoForm _infoForm = new();
                BekräftaTurForm form = new(_fordon, _infoForm);
                form.TurerFormLoad();
                _infoForm.Controls.Add(form);
                _infoForm.ShowDialog();


            }
            else
            {
                MessageBox.Show("Du kan endast hyra 1 fordon åtgången" +
                    "\n" + "Avsluta pågående tur ");
            }
        }

        private void btn_Tabort_Click(object sender, EventArgs e)
        {
            _station.Fordonlista.Remove(_fordon);
            this.Dispose();
        }
    }
}
