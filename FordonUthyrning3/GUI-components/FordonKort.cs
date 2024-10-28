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
        public FordonKort(Fordon fordon, Form1 form)
        {
            InitializeComponent();
            _form1 = form;
            _fordon = fordon;
        }

        private void FordonKort_Load(object sender, EventArgs e)
        {
            lblVärdeBatteri.Text = _fordon.BatteriNivå.ToString();
            lblVärdeFStatus.Text = _fordon.FordonStatus.ToString();
            lblVärdeBStatus.Text = _fordon.BokningStatus.ToString();
            lblVärdeFTyp.Text = _fordon.FordonTyp.ToString();
            lblKostnad.Text = _fordon.kostnad.ToString() + "kr/min";
            lblFordonID.Text = _fordon.FordonID;


        }

        private void btnVälj_Click(object sender, EventArgs e)
        {
            PågåendeTurer tur = session.Instance.InloggadAnvändare.konto.tur;
            if (tur == null)
            {
                infoForm _infoForm = new();
                PågåendeTurerForm form = new(_fordon, _infoForm);
                _infoForm.Controls.Add(form);
                _infoForm.ShowDialog();
                StationController station = new();
            }
            else
            {
                MessageBox.Show("Du kan endast hyra 1 fordon åtgången" +
                    "\n" +"Avsluta pågående tur ");
            }
        }
    }
}
