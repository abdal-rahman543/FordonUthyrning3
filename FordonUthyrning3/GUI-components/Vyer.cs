using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FordonUthyrning3.GUI_components
{
    public partial class Vyer : Component
    {
        private Form1 _form1;
        public Vyer(Form1 form)
        {
            InitializeComponent();
            _form1 = form;
        }

        public Vyer(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public void LaddaHemVy()
        {
            StationController Stationer = new StationController();
            _form1.GbxContent_Container.Controls.Add(Stationer);
            Stationer.LaddaInStationer();
        }
        //Lägger funktioner för att trigga olika vyer i systemet

    }
}
