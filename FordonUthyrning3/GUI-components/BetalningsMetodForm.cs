using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uthyrning.Entiteter;

namespace FordonUthyrning3.GUI_components
{
    public partial class BetalningsMetodForm : UserControl
    {
        private RegistereraController _controller;
        public BetalningsMetodForm(RegistereraController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void InitializeComponent()
        {
            cbxMetod = new ComboBox();
            tbxVärde = new TextBox();
            lblTitel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cbxMetod
            // 
            cbxMetod.FormattingEnabled = true;
            cbxMetod.Items.AddRange(new object[] { "Swish", "Faktura", "kort" });
            cbxMetod.Location = new Point(165, 130);
            cbxMetod.Name = "cbxMetod";
            cbxMetod.Size = new Size(255, 23);
            cbxMetod.TabIndex = 0;
            cbxMetod.TextChanged += comboBox1_DropDownClosed;
            // 
            // tbxVärde
            // 
            tbxVärde.Location = new Point(172, 180);
            tbxVärde.Name = "tbxVärde";
            tbxVärde.PlaceholderText = "Telenummer, kortnr etc...";
            tbxVärde.Size = new Size(238, 23);
            tbxVärde.TabIndex = 1;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Segoe UI", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            lblTitel.Location = new Point(127, 16);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(344, 37);
            lblTitel.TabIndex = 2;
            lblTitel.Text = "Registrera betalningsmetod";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(238, 325);
            button1.Name = "button1";
            button1.Size = new Size(116, 50);
            button1.TabIndex = 3;
            button1.Text = "Registrera";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BetalningsMetodForm
            // 
            Controls.Add(button1);
            Controls.Add(lblTitel);
            Controls.Add(tbxVärde);
            Controls.Add(cbxMetod);
            Name = "BetalningsMetodForm";
            Size = new Size(603, 429);
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox cbxMetod;
        private TextBox tbxVärde;
        private Label lblTitel;
        private Button button1;

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (cbxMetod.SelectedItem == "Swish")
            {
                tbxVärde.PlaceholderText = "Skriv in ditt telefonnummer";
                
            }
            else if (cbxMetod.SelectedItem == "Faktura")
            {
                tbxVärde.ReadOnly = true;
                tbxVärde.PlaceholderText = "Fakturor skickas till din epost";
            }
            else if (cbxMetod.SelectedItem == "kort")
            {
                tbxVärde.PlaceholderText = "Skriv in ditt kort-nummer 16 siffror";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cbxMetod.SelectedItem == "Swish")
            {
                string Telenr = tbxVärde.Text;
                _controller.Registrera(Telenr,"swish");
               
                
            }
            else if (cbxMetod.SelectedItem == "Faktura")
            {
                _controller.Registrera();
                
            }
            else if (cbxMetod.SelectedItem == "kort")
            {
                _controller.Registrera(tbxVärde.Text,"kort");
            }
        }
    }
}
