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

namespace FordonUthyrning3.UserControllers
{
    public partial class PågåendeTurerController : UserControl
    {
        private static Form1 _form1 = Form1._instance;
        private static PågåendeTurerService _service;
        public PågåendeTurerController()
        {
            InitializeComponent();
            _service = Custom_ServiceContainer.GetService<PågåendeTurerService>();
        }

        public void LaddaKort()
        {
            PågåendeTurer tur =  session.Instance.InloggadAnvändare.konto.tur;
            if (tur != null) 
            {
                    PågåendeTurerKort kort = new(tur);
                    pnlContent.Controls.Add(kort);
              
            }
        }

        public void RegistreraTur(PågåendeTurer tur)
        {
            _service.RegistreraTur(tur);
        }
    }
}
