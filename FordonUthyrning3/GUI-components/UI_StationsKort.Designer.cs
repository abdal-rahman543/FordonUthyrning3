namespace FordonUthyrning3.UserControllers
{
    partial class UI_StationsKort
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStationNamn = new Label();
            lblAntalFordon = new Label();
            lblKapacitet = new Label();
            lblAdress = new Label();
            btnVälj = new Button();
            lblVärdeAntal = new Label();
            lblVärdeAdress = new Label();
            lblVärdeKapacitet = new Label();
            SuspendLayout();
            // 
            // lblStationNamn
            // 
            lblStationNamn.AutoSize = true;
            lblStationNamn.Font = new Font("Segoe UI", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            lblStationNamn.Location = new Point(0, 0);
            lblStationNamn.Name = "lblStationNamn";
            lblStationNamn.Size = new Size(89, 37);
            lblStationNamn.TabIndex = 0;
            lblStationNamn.Text = "Namn";
            // 
            // lblAntalFordon
            // 
            lblAntalFordon.AutoSize = true;
            lblAntalFordon.Location = new Point(24, 50);
            lblAntalFordon.Name = "lblAntalFordon";
            lblAntalFordon.Size = new Size(76, 15);
            lblAntalFordon.TabIndex = 1;
            lblAntalFordon.Text = "AntalFordon:";
            // 
            // lblKapacitet
            // 
            lblKapacitet.AutoSize = true;
            lblKapacitet.Location = new Point(24, 104);
            lblKapacitet.Name = "lblKapacitet";
            lblKapacitet.Size = new Size(59, 15);
            lblKapacitet.TabIndex = 2;
            lblKapacitet.Text = "Kapacitet:";
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Location = new Point(24, 76);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(45, 15);
            lblAdress.TabIndex = 3;
            lblAdress.Text = "Adress:";
            // 
            // btnVälj
            // 
            btnVälj.BackColor = Color.FromArgb(255, 255, 128);
            btnVälj.FlatStyle = FlatStyle.Flat;
            btnVälj.Location = new Point(288, 76);
            btnVälj.Name = "btnVälj";
            btnVälj.Size = new Size(93, 38);
            btnVälj.TabIndex = 4;
            btnVälj.Text = "Välj";
            btnVälj.UseVisualStyleBackColor = false;
            // 
            // lblVärdeAntal
            // 
            lblVärdeAntal.AutoSize = true;
            lblVärdeAntal.Location = new Point(99, 51);
            lblVärdeAntal.Name = "lblVärdeAntal";
            lblVärdeAntal.Size = new Size(36, 15);
            lblVärdeAntal.TabIndex = 5;
            lblVärdeAntal.Text = "Värde";
            // 
            // lblVärdeAdress
            // 
            lblVärdeAdress.AutoSize = true;
            lblVärdeAdress.Location = new Point(68, 76);
            lblVärdeAdress.Name = "lblVärdeAdress";
            lblVärdeAdress.Size = new Size(36, 15);
            lblVärdeAdress.TabIndex = 6;
            lblVärdeAdress.Text = "värde";
            // 
            // lblVärdeKapacitet
            // 
            lblVärdeKapacitet.AutoSize = true;
            lblVärdeKapacitet.Location = new Point(81, 104);
            lblVärdeKapacitet.Name = "lblVärdeKapacitet";
            lblVärdeKapacitet.Size = new Size(36, 15);
            lblVärdeKapacitet.TabIndex = 7;
            lblVärdeKapacitet.Text = "värde";
            // 
            // UI_StationsKort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblVärdeKapacitet);
            Controls.Add(lblVärdeAdress);
            Controls.Add(lblVärdeAntal);
            Controls.Add(btnVälj);
            Controls.Add(lblAdress);
            Controls.Add(lblKapacitet);
            Controls.Add(lblAntalFordon);
            Controls.Add(lblStationNamn);
            Name = "UI_StationsKort";
            Size = new Size(422, 125);
            Load += UI_StationsKort_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStationNamn;
        private Label lblAntalFordon;
        private Label lblKapacitet;
        private Label lblAdress;
        private Button btnVälj;
        private Label lblVärdeAntal;
        private Label lblVärdeAdress;
        private Label lblVärdeKapacitet;
    }
}
