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
    public partial class PågåendeTurerKort : UserControl
    {
        private Form1 _form1;
        private Fordon _fordon;
        public PågåendeTurerKort(Form1 form, Fordon fordon)
        {
            InitializeComponent();
            _form1 = form;
            _fordon = fordon;
        }

        private void PågåendeTurerKort_Load(object sender, EventArgs e)
        {
            lblVärdeBatteri.Text = _fordon.BatteriNivå.ToString();
            lblVärdeFStatus.Text = _fordon.FordonStatus.ToString();
            lblVärdeBStatus.Text = _fordon.BokningStatus.ToString();
            lblVärdeFTyp.Text = _fordon.FordonTyp.ToString();
            lblFordonID.Text = _fordon.FordonID;
        }
    }
}
