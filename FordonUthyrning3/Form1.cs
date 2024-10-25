namespace FordonUthyrning3
{
    public partial class Form1 : Form
    {
        private LoginController controller;

        public Form1()
        {
            InitializeComponent();

            // Ensure GbxContent_Container is initialized before adding controller
            if (GbxContent_Container != null)
            {
                controller = new LoginController(this);
                this.GbxContent_Container.Controls.Add(controller);
            }
            else
            {
                MessageBox.Show("GbxContent_Container is not initialized.");
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (GbxContent_Container != null && controller != null)
            {
                GbxContent_Container.Width = this.ClientSize.Width - 300;
                GbxContent_Container.Height = this.ClientSize.Height - 200;

                // Center GroupBox in the form’s client area
                GbxContent_Container.Location = new Point(
                    (this.ClientSize.Width / 2) - (GbxContent_Container.Width / 2),
                    (this.ClientSize.Height / 2) - (GbxContent_Container.Height / 2)
                );

            );
            // Centrerar LoginBoxen
            controller.Location = new Point(GbxContent_Container.Width / 2 - controller.Width / 2, GbxContent_Container.Height / 2 - controller.Height / 2);
        }
    }
}
