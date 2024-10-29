using FordonUthyrning3.GUI_components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uthyrning.Affärslager;
using Uthyrning.Entiteter;
using static UthyrningSystem.Entiteter.Enums;
using UthyrningSystem.Entiteter;

namespace FordonUthyrning3.UserControllers
{
    public partial class TurController : UserControl
    {
        private static Form1 _form1 = Form1._instance;
        private static TurService _service;
        public TurController()
        {
            InitializeComponent();
            _service = Custom_ServiceContainer.GetService<TurService>();
        }

        public void LaddaKort()
        {
            PågåendeTurer tur =  session.Instance.InloggadAnvändare.konto.tur;
            if (tur != null) 
            {
                lblPågåendeTurer.Text = "Pågående tur";
                PågåendeTurerKort kort = new(tur,tur._fordon);
                pnlContent.Controls.Add(kort);
              
            }
        }
        public void RegistreraHistorik(DateOnly uthyrningsDatum, TimeOnly startTid, TimeOnly slutTid, float Kostnad, BetalningsMetod betalningsMetod, string fordonID, Användare hyresTagare)
        {
            _service.RegistreraHistorik(uthyrningsDatum,startTid,slutTid,Kostnad,betalningsMetod,fordonID,hyresTagare);
        }
        public void RegistreraTur(PågåendeTurer tur)
        {
            _service.RegistreraTur(tur);
        }
    }
}
