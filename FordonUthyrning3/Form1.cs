namespace FordonUthyrning3
{
    public partial class Form1 : Form
    {
        private LoginController controller;
        public Form1()
        {
            InitializeComponent();
            controller = new LoginController(this);
            this.GbxContent_Container.Controls.Add(controller);
           
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            GbxContent_Container.Width = this.ClientSize.Width - 300;
            GbxContent_Container.Height = this.ClientSize.Height - 200;

            // Centrera GroupBox i formens klientområde
            GbxContent_Container.Location = new Point(
                (this.ClientSize.Width / 2) - (GbxContent_Container.Width / 2),
                (this.ClientSize.Height / 2) - (GbxContent_Container.Height / 2)

            );
           
          
        }

        
    }
}
