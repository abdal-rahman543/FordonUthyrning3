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
using Uthyrning.Entiteter;
using UthyrningSystem.Entiteter;

namespace FordonUthyrning3.Controllers
{
    public partial class HistorikController : UserControl
    {
        Användare _användare = session.Instance.InloggadAnvändare;
        public HistorikController()
        {
            InitializeComponent();
        }

        public void LaddaHistorik()
        {
            List<HyresHistorik> historik = _användare.konto.HyresHistorik;
            if (historik.Count > 0) 
            {
                lblIngenHistorik.Visible = false;
                foreach (HyresHistorik _historik in historik)
                {
                    HistorikKort kort = new(_historik);
                    kort.Width = this.Width - 30;
                    pnlContent_Container.Controls.Add(kort);

                }
            }
        }
    }
}
