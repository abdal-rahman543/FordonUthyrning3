using FordonUthyrning3.UserControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FordonUthyrning3.GUI_components
{
    public static class Vyer
    {
        private static Form1 _form1 = Form1._instance;
        public static void LaddaHemVy()
        {
            _form1.GbxContent_Container.Controls.Clear();
            StationController Stationer = new StationController();
            PågåendeTurerController turer = new PågåendeTurerController();
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

            _form1.GbxContent_Container.Controls.Clear();
            LoginController controller = new LoginController();
            _form1.GbxContent_Container.Controls.Add(controller);
            _form1.Refresh();
            

        }
        public static void LaddaRegistreringsForm()
        {
            _form1.GbxContent_Container.Controls.Clear();
            RegistereraController registereraController = new RegistereraController();
            _form1.GbxContent_Container.Controls.Add(registereraController);
            registereraController.Dock = DockStyle.Fill;
        }

        
    }
}
