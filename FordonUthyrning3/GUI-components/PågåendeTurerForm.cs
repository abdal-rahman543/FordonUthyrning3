using FordonUthyrning3.UserControllers;
using System;
using System.Windows.Forms;
using Uthyrning.Entiteter;
using UthyrningSystem.Entiteter;
using static UthyrningSystem.Entiteter.Enums;

namespace FordonUthyrning3.GUI_components
{
    public partial class PågåendeTurerForm : UserControl
    {
        private Fordon _fordon;
        private infoForm _infoForm;
        private DateOnly Datum;
        private TimeOnly StartTid;
        private BetalningsMetod BetalningsMetod;
        private string FordonID;

        public PågåendeTurerForm(Fordon fordon, infoForm infoForm)
        {
            InitializeComponent();
            _fordon = fordon;
            _infoForm = infoForm;

            // Initiera variabler
            Datum = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            StartTid = new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute);
            BetalningsMetod = Enums.BetalningsMetod.Swish;
            FordonID = _fordon.FordonID;
        }

        private void PågåendeTurerForm_Load(object sender, EventArgs e)
        {
            // Sätt texten för UI-elementen när kontrollen laddas
            lblVärdeDatum.Text = Datum.ToString();
            lblVärdeStartTid.Text = StartTid.ToString();
            lblVärdeBetalningsMetod.Text = BetalningsMetod.ToString();
            lblVärdeFID.Text = FordonID;
        }

        private void lblBörjaTur_Click(object sender, EventArgs e)
        {

            PågåendeTurer tur = new(Datum, StartTid, BetalningsMetod, FordonID,_fordon);
            PågåendeTurerController Controller = new();
            Controller.RegistreraTur(tur);
            MessageBox.Show("Bokning bekräftad!");
            _infoForm.Close();
        }
    }
}
