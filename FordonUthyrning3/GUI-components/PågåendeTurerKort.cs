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
    public partial class PågåendeTurerKort : UserControl
    {
        private Form1 _form1 = Form1._instance;
        private Fordon _fordon;
        private PågåendeTurer _tur;
        public PågåendeTurerKort(PågåendeTurer tur, Fordon fordon)
        {
            InitializeComponent();
            _tur = tur;
            _fordon = fordon;

        }

        private void PågåendeTurerKort_Load(object sender, EventArgs e)
        {
            lblVärdeDatum.Text = _tur.Datum.ToString();
            lblVärdeStartTid.Text = _tur.StartTid.ToString();
            lblVärdeBetalningMetod.Text = _tur.BetalningsMetod.ToString();
            lblVärdeFId.Text = _tur.FordonID;


        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            PågåendeTurer tur = session.Instance.InloggadAnvändare.konto.tur;
            infoForm _InfoForm = new();
            BekräftaTurForm form = new(_fordon, _InfoForm);
            form.AvslutaTur();

            


        }
    }
}
