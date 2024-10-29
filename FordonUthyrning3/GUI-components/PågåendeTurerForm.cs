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
            BetalningsMetod = BetalningsMetod.Swish;
            FordonID = _fordon.FordonID;
            PågåendeTurerFormLoad();
        }

        private void PågåendeTurerFormLoad()
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
            Vyer.LaddaHemVy();
        }

       public void AvslutaTur()
        {
            PågåendeTurer tur = session.Instance.InloggadAnvändare.konto.tur;
            Konto _konto = session.Instance.InloggadAnvändare.konto;
            lblTitel.Text = "Avsluta tur";
            btnBörjaTur.Text = "Bekräfta avslutning";

            TimeOnly sluttid = new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute);

            lblVärdeDatum.Text = tur.Datum.ToString();
            lblVärdeStartTid.Text = tur.StartTid.ToString();
            lblVärdeBetalningsMetod.Text = tur.BetalningsMetod.ToString();

            TimeSpan TurTid = sluttid - tur.StartTid;
            float kostnad = _fordon.kostnad * (float)TurTid.TotalSeconds/60;
            lblSluttid.Visible = true;
            lblTurttid.Visible = true;
            lblTotalKostnad.Visible = true;

            lblVärdeSlutTid.Text = sluttid.ToString();
            lblVärdeTurTid.Text = TurTid.ToString();
            lblVärdeKostnad.Text = kostnad.ToString()+"kr";


            lblVärdeKostnad.Visible=true;
            lblVärdeSlutTid.Visible = true;
            lblVärdeTurTid.Visible = true;

            _konto.HyresHistorik.Add();
            _infoForm.Controls.Add(this);
            _infoForm.Show();
        }
    }
}
