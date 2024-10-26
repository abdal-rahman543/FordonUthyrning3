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
using UthyrningSystem.Entiteter;

namespace FordonUthyrning3
{
    public partial class LoginController : UserControl
    {
        LoginService loginService { get; set; }
        private Form1 _form1;
        public LoginController(Form1 form)
        {
            InitializeComponent();
            loginService =  new LoginService();
            _form1 = form;
            // Centrerar LoginBoxen
            this.Location = new Point(_form1.GbxContent_Container.Width / 2 - this.Width / 2, _form1.GbxContent_Container.Height / 2 - this.Height / 2);
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string userID = tbxAnvändarenamn.Text;
            string password = tbxLösenord.Text;
            Användare LoggedUser = loginService.Login(userID, password);
            if (LoggedUser != null)
            {
                this.Dispose();
                StationController station = new StationController(_form1);
                station.LaddaInStationer();
                _form1.splitContainer.Visible = true;
                _form1.splitContainer.Panel1.Controls.Add(station);
                _form1.Meny.Visible = true;
               
                
                
                

            }
            else
            {
                MessageBox.Show("Fel användarenamn eller lösenord");
            }
          
            
        }
        public void btnRegistrera_Click(object sender, EventArgs e)
        {
            RegistereraController registereraController = new RegistereraController(_form1);
            this.Dispose();
            _form1.GbxContent_Container.Controls.Add(registereraController);
            registereraController.Dock = DockStyle.Fill;
        }
    }

    
}
