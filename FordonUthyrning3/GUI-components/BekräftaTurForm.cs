using FordonUthyrning3.UserControllers;
using System;
using System.Windows.Forms;
using Uthyrning.Entiteter;
using UthyrningSystem.Entiteter;
using static UthyrningSystem.Entiteter.Enums;

namespace FordonUthyrning3.GUI_components
{
    public partial class BekräftaTurForm : UserControl
    {
        private Fordon _fordon;
        private infoForm _infoForm;
        private DateOnly Datum;
        private TimeOnly StartTid;
        TimeOnly slutTid;
        float Kostnad;
        BetalningsMetod betalningsMetod;
        string fordonID;
        Användare hyresTagare = session.Instance.InloggadAnvändare;
        private BetalningsMetod BetalningsMetod;
        private string FordonID;
        private TimeSpan TurTid;
        private TurController _turController;

        public BekräftaTurForm(Fordon fordon, infoForm infoForm)
        {
            InitializeComponent();
            _fordon = fordon;
            _infoForm = infoForm;
            _turController = new TurController();

            // Initiera variabler
            Datum = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            StartTid = new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute);
            FordonID = _fordon.FordonID;
           
        }

        public void PågåendeTurerFormLoad()
        {
            Konto _konto = session.Instance.InloggadAnvändare.konto;
            // Sätt texten för UI-elementen när kontrollen laddas
            lblVärdeDatum.Text = Datum.ToString();
            lblVärdeStartTid.Text = StartTid.ToString();
            lblVärdeFID.Text = _fordon.FordonID;

            if (_konto.BetalningsMetod.Contains(Enums.BetalningsMetod.Swish)) 
            {
                cbxBetalningsMetod.Items.Add("Swish");
            }
            if (_konto.BetalningsMetod.Contains(Enums.BetalningsMetod.Kort))
            {
                cbxBetalningsMetod.Items.Add("Kort");
            }
        }

        private void lblBörjaTur_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbxBetalningsMetod.SelectedItem?.ToString(), out Enums.BetalningsMetod selectedMetod))
            {
                BetalningsMetod = selectedMetod;
            }
           

            PågåendeTurer tur = new(Datum, StartTid, BetalningsMetod, FordonID, _fordon);
           
           _turController.RegistreraTur(tur);
            MessageBox.Show("Bokning bekräftad!");
            _infoForm.Close();
            Vyer.LaddaHemVy();
        }

        public void AvslutaTur()
        {
            _fordon.BokningStatus = BokningStatus.Tillgänglig;
            PågåendeTurer tur = hyresTagare.konto.tur;
            Konto _konto = hyresTagare.konto;
            lblTitel.Text = "Avsluta tur";
          

            
             slutTid = new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute);
             TurTid = slutTid - tur.StartTid;
             Kostnad = _fordon.kostnad * (float)TurTid.TotalSeconds / 60;

            // Tar in värde från fälten
            lblVärdeDatum.Text = tur.Datum.ToString();
            lblVärdeStartTid.Text = tur.StartTid.ToString();
            cbxBetalningsMetod.Text = tur.BetalningsMetod.ToString();

            // visar fälten
            lblSluttid.Visible = true;
            lblTurttid.Visible = true;
            lblTotalKostnad.Visible = true;

            // fyller nya fällt med ny info
            lblVärdeSlutTid.Text = slutTid.ToString();
            lblVärdeTurTid.Text = TurTid.ToString();
            lblVärdeKostnad.Text = Kostnad.ToString() + "kr";
            lblVärdeFID.Text = _fordon.FordonID.ToString();
            btnBörjaTur.Visible = false;
            btnAvsluta.Visible = true;

            lblVärdeKostnad.Visible = true;
            lblVärdeSlutTid.Visible = true;
            lblVärdeTurTid.Visible = true;


            _infoForm.Controls.Add(this);
            _infoForm.Show();
        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            PågåendeTurer tur = hyresTagare.konto.tur;
            _infoForm.Close();
            hyresTagare.konto.tur = null;
            _turController.LaddaKort();
            Vyer.LaddaHemVy();   
            _turController.RegistreraHistorik(Datum, tur.StartTid,slutTid,Kostnad,tur.BetalningsMetod,_fordon.FordonID,hyresTagare);

        }
    }
}
