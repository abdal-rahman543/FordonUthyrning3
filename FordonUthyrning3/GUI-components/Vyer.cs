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
            Användare användare = session.Instance.InloggadAnvändare;
            
            if(användare.konto.Behörighet == Enums.BehörighetsNivå.Användare)
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
            else if(användare.konto.Behörighet == Enums.BehörighetsNivå.Admin)
            {
                LaddaAdminVy();
            }



        }
        public static void LaddaLogginVy()
        {

            _form1.Meny.Visible = false;
            _form1.hemToolStripMenuItem.Visible = true;
            _form1.profilToolStripMenuItem.Visible = true;
            _form1.exitToolStripMenuItem.Visible = true;
            _form1.toolStripMenuBack.Visible = false;
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
            Användare användare = session.Instance.InloggadAnvändare;
            if (användare.konto.Behörighet == Enums.BehörighetsNivå.Användare)
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
            else if(användare.konto.Behörighet == Enums.BehörighetsNivå.Admin)
            {

                _form1.GbxContent_Container.Controls.Clear();
                ProfilController Pcontroller = new();
                Pcontroller.Dock = DockStyle.Left;
                Pcontroller.Width = _form1.GbxContent_Container.Width / 2;
                _form1.GbxContent_Container.Controls.Add(Pcontroller);

            }
           
        }

       

        public static void LaddaAdminVy()
        {
            // Spara referenser till knapparna
            var btnAddFordon = _form1.btnAddFordon;
            var btnAddStation = _form1.btnAddStation;

            // Ta bort alla kontroller
            _form1.GbxContent_Container.Controls.Clear();



            // Lägg till knapparna igen
            _form1.GbxContent_Container.Controls.Add(btnAddFordon);
            _form1.GbxContent_Container.Controls.Add(btnAddStation);





            int containerWidth = _form1.GbxContent_Container.Width;
            int containerHeight = _form1.GbxContent_Container.Height;

            

            _form1.btnAddFordon.Left = containerWidth - 200 - _form1.btnAddFordon.Width - 10; // 10 pixlar från högerkanten
            _form1.btnAddFordon.Top = (containerHeight / 2) - _form1.btnAddFordon.Height - 5; // Något ovan mitten


            _form1.btnAddStation.Left = containerWidth -200  - _form1.btnAddStation.Width - 10; // 10 pixlar från högerkanten
            _form1.btnAddStation.Top = (containerHeight / 2) + 10; // Något under mitten

            // Se till att knapparna är synliga
            _form1.btnAddFordon.Visible = true;
            _form1.btnAddStation.Visible = true;











            // Lägg till och konfigurera StationController
            StationController Stationer = new StationController();
            Stationer.Dock = DockStyle.Left;
            Stationer.LaddaInStationer();
            _form1.GbxContent_Container.Controls.Add(Stationer);

            // Visa andra element
            btnAddFordon.Visible = true;
            btnAddStation.Visible = true;
          
            _form1.Meny.Visible = true;

        }



    }
}
