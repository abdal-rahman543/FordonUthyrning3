namespace FordonUthyrning3.Controllers
{
    partial class StationRegistreringController
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
            tbxStationNamn = new TextBox();
            btnRegistreraStation = new Button();
            tbxStationAdress = new TextBox();
            tbxStationOrt = new TextBox();
            tbxStationKapacitet = new TextBox();
            lblStationRegistrering = new Label();
            lblStationNamn = new Label();
            lblStationAdress = new Label();
            lblStationOrt = new Label();
            lblStationKapacitet = new Label();
            SuspendLayout();
            // 
            // tbxStationNamn
            // 
            tbxStationNamn.Location = new Point(296, 59);
            tbxStationNamn.Name = "tbxStationNamn";
            tbxStationNamn.Size = new Size(100, 23);
            tbxStationNamn.TabIndex = 0;
            tbxStationNamn.TextChanged += tbxStationNamn_TextChanged;
            // 
            // btnRegistreraStation
            // 
            btnRegistreraStation.BackColor = Color.Yellow;
            btnRegistreraStation.FlatStyle = FlatStyle.Flat;
            btnRegistreraStation.ForeColor = SystemColors.ActiveCaptionText;
            btnRegistreraStation.Location = new Point(296, 259);
            btnRegistreraStation.Name = "btnRegistreraStation";
            btnRegistreraStation.Size = new Size(143, 39);
            btnRegistreraStation.TabIndex = 1;
            btnRegistreraStation.Text = "Registrera Station";
            btnRegistreraStation.UseVisualStyleBackColor = false;
            btnRegistreraStation.Click += btnRegistrera_Click;
            // 
            // tbxStationAdress
            // 
            tbxStationAdress.Location = new Point(296, 109);
            tbxStationAdress.Name = "tbxStationAdress";
            tbxStationAdress.Size = new Size(100, 23);
            tbxStationAdress.TabIndex = 2;
            // 
            // tbxStationOrt
            // 
            tbxStationOrt.Location = new Point(296, 154);
            tbxStationOrt.Name = "tbxStationOrt";
            tbxStationOrt.Size = new Size(100, 23);
            tbxStationOrt.TabIndex = 3;
            // 
            // tbxStationKapacitet
            // 
            tbxStationKapacitet.Location = new Point(296, 199);
            tbxStationKapacitet.Name = "tbxStationKapacitet";
            tbxStationKapacitet.Size = new Size(36, 23);
            tbxStationKapacitet.TabIndex = 4;
            // 
            // lblStationRegistrering
            // 
            lblStationRegistrering.AutoSize = true;
            lblStationRegistrering.Font = new Font("Segoe UI", 21.75F, FontStyle.Underline, GraphicsUnit.Point);
            lblStationRegistrering.Location = new Point(181, 16);
            lblStationRegistrering.Name = "lblStationRegistrering";
            lblStationRegistrering.Size = new Size(260, 40);
            lblStationRegistrering.TabIndex = 5;
            lblStationRegistrering.Text = "Station registrering";
            lblStationRegistrering.Click += label1_Click;
            // 
            // lblStationNamn
            // 
            lblStationNamn.AutoSize = true;
            lblStationNamn.Location = new Point(181, 62);
            lblStationNamn.Name = "lblStationNamn";
            lblStationNamn.Size = new Size(43, 15);
            lblStationNamn.TabIndex = 6;
            lblStationNamn.Text = "Namn:";
            // 
            // lblStationAdress
            // 
            lblStationAdress.AutoSize = true;
            lblStationAdress.Location = new Point(181, 112);
            lblStationAdress.Name = "lblStationAdress";
            lblStationAdress.Size = new Size(45, 15);
            lblStationAdress.TabIndex = 7;
            lblStationAdress.Text = "Adress:";
            // 
            // lblStationOrt
            // 
            lblStationOrt.AutoSize = true;
            lblStationOrt.Location = new Point(181, 157);
            lblStationOrt.Name = "lblStationOrt";
            lblStationOrt.Size = new Size(27, 15);
            lblStationOrt.TabIndex = 8;
            lblStationOrt.Text = "Ort:";
            // 
            // lblStationKapacitet
            // 
            lblStationKapacitet.AutoSize = true;
            lblStationKapacitet.Location = new Point(181, 202);
            lblStationKapacitet.Name = "lblStationKapacitet";
            lblStationKapacitet.Size = new Size(105, 15);
            lblStationKapacitet.TabIndex = 9;
            lblStationKapacitet.Text = "Fordons Kapacitet:";
            // 
            // StationRegistreringController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblStationKapacitet);
            Controls.Add(lblStationOrt);
            Controls.Add(lblStationAdress);
            Controls.Add(lblStationNamn);
            Controls.Add(lblStationRegistrering);
            Controls.Add(tbxStationKapacitet);
            Controls.Add(tbxStationOrt);
            Controls.Add(tbxStationAdress);
            Controls.Add(btnRegistreraStation);
            Controls.Add(tbxStationNamn);
            Name = "StationRegistreringController";
            Size = new Size(641, 539);
            Load += StationRegistreringController_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxStationNamn;
        private Button btnRegistreraStation;
        private TextBox tbxStationAdress;
        private TextBox tbxStationOrt;
        private TextBox tbxStationKapacitet;
        private Label lblStationRegistrering;
        private Label lblStationNamn;
        private Label lblStationAdress;
        private Label lblStationOrt;
        private Label lblStationKapacitet;
    }
}
