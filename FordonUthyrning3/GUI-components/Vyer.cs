using FordonUthyrning3.Controllers;
using FordonUthyrning3.UserControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uthyrning.Entiteter;
using UthyrningSystem.Entiteter;

namespace FordonUthyrning3.GUI_components
{
    public static class Vyer
    {
        private static Form1 _form1 = Form1._instance;
        public static void LaddaHemVy()
        {
            _form1.GbxContent_Container.Controls.Clear();
            StationController Stationer = new StationController();
            TurController turer = new TurController();
            turer.Dock = DockStyle.Right;
            Stationer.Dock = DockStyle.Left;
            _form1.splitContainer.Visible = true;
            Stationer.LaddaInStationer();
            turer.LaddaKort();
            _form1.splitContainer.Panel1.Controls.Clear();
            _form1.splitContainer.Panel2.Controls.Clear();
            _form1.GbxContent_Container.Controls.Add(Stationer);
            _form1.GbxContent_Container.Controls.Add(turer);
            _form1.Meny.Visible = true;




        }
        public static void LaddaLogginVy()
        {

            _form1.Meny.Visible = false;
            _form1.hemToolStripMenuItem.Visible = true;
            _form1.profilToolStripMenuItem.Visible = true;
            _form1.exitToolStripMenuItem.Visible = true;
            _form1.toolStripMenuBack.Visible = true;
            _form1.GbxContent_Container.Controls.Clear();
            LoginController controller = new LoginController();
            _form1.GbxContent_Container.Controls.Add(controller);
            _form1.Refresh();


        }
        public static void LaddaRegistreringsForm()
        {
            _form1.Meny.Visible = true;
            _form1.hemToolStripMenuItem.Visible = false;
            _form1.profilToolStripMenuItem.Visible = false;
            _form1.exitToolStripMenuItem.Visible = false;
            _form1.toolStripMenuBack.Visible = true;

            _form1.GbxContent_Container.Controls.Clear();
            RegistereraController registereraController = new RegistereraController();
            _form1.GbxContent_Container.Controls.Add(registereraController);
           
            registereraController.Dock = DockStyle.Fill;
        }


        public static void LaddaStationRegistrering()
        {
            _form1.GbxContent_Container.Controls.Clear();
            StationRegistreringController stationRegistreringController = new StationRegistreringController();
            _form1.GbxContent_Container.Controls.Add(stationRegistreringController);
            stationRegistreringController.Dock = DockStyle.Fill;
        }

        public static void LaddaFordonRegistrering()
        {
            _form1.GbxContent_Container.Controls.Clear();
            FordonRegistreringController fordonRegistreringController = new FordonRegistreringController();
            _form1.GbxContent_Container.Controls.Add(fordonRegistreringController);
            fordonRegistreringController.Dock = DockStyle.Fill;

        }

        public static void LaddaProfil()
        {
            _form1.GbxContent_Container.Controls.Clear();
            Användare _användare = session.Instance.InloggadAnvändare;
            HistorikController Hcontroller = new HistorikController();
            ProfilController Pcontroller = new();
            Hcontroller.LaddaHistorik();
            Hcontroller.Dock = DockStyle.Right;
            Pcontroller.Dock = DockStyle.Left;
            Pcontroller.Width = _form1.GbxContent_Container.Width / 2;
            _form1.GbxContent_Container.Controls.Add(Hcontroller);
            _form1.GbxContent_Container.Controls.Add(Pcontroller);
        }

        

    }
}
