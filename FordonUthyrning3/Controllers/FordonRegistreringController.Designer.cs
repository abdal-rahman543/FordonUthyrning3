namespace FordonUthyrning3.Controllers
{
    partial class FordonRegistreringController
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
            lblFordonRegistrering = new Label();
            lblRBatteriNivå = new Label();
            btnRegistreraFordon = new Button();
            lblRFordonStatus = new Label();
            lblRBokningStatus = new Label();
            lblRFordonTyp = new Label();
            tbxRBatteriNivå = new ComboBox();
            tbxRFordonStatus = new ComboBox();
            tbxRBokningStatus = new ComboBox();
            tbxRFordonTyp = new ComboBox();
            lblRTilldelaStation = new Label();
            tbxRTilldelaStation = new ComboBox();
            SuspendLayout();
            // 
            // lblFordonRegistrering
            // 
            lblFordonRegistrering.AutoSize = true;
            lblFordonRegistrering.Font = new Font("Segoe UI", 21.75F, FontStyle.Underline, GraphicsUnit.Point);
            lblFordonRegistrering.Location = new Point(0, 0);
            lblFordonRegistrering.Name = "lblFordonRegistrering";
            lblFordonRegistrering.Size = new Size(262, 40);
            lblFordonRegistrering.TabIndex = 0;
            lblFordonRegistrering.Text = "Fordon registrering";
            // 
            // lblRBatteriNivå
            // 
            lblRBatteriNivå.AutoSize = true;
            lblRBatteriNivå.Location = new Point(23, 79);
            lblRBatteriNivå.Name = "lblRBatteriNivå";
            lblRBatteriNivå.Size = new Size(63, 15);
            lblRBatteriNivå.TabIndex = 1;
            lblRBatteriNivå.Text = "Batterinivå";
            lblRBatteriNivå.Click += label1_Click;
            // 
            // btnRegistreraFordon
            // 
            btnRegistreraFordon.BackColor = Color.Yellow;
            btnRegistreraFordon.FlatStyle = FlatStyle.Flat;
            btnRegistreraFordon.ForeColor = Color.Black;
            btnRegistreraFordon.Location = new Point(78, 253);
            btnRegistreraFordon.Name = "btnRegistreraFordon";
            btnRegistreraFordon.Size = new Size(123, 52);
            btnRegistreraFordon.TabIndex = 2;
            btnRegistreraFordon.Text = "Registrera fordon";
            btnRegistreraFordon.UseVisualStyleBackColor = false;
            btnRegistreraFordon.Click += btnRegistreraFordon_Click;
            // 
            // lblRFordonStatus
            // 
            lblRFordonStatus.AutoSize = true;
            lblRFordonStatus.Location = new Point(22, 108);
            lblRFordonStatus.Name = "lblRFordonStatus";
            lblRFordonStatus.Size = new Size(76, 15);
            lblRFordonStatus.TabIndex = 7;
            lblRFordonStatus.Text = "Fordonstatus";
            // 
            // lblRBokningStatus
            // 
            lblRBokningStatus.AutoSize = true;
            lblRBokningStatus.Location = new Point(23, 137);
            lblRBokningStatus.Name = "lblRBokningStatus";
            lblRBokningStatus.Size = new Size(82, 15);
            lblRBokningStatus.TabIndex = 8;
            lblRBokningStatus.Text = "Bokningstatus";
            // 
            // lblRFordonTyp
            // 
            lblRFordonTyp.AutoSize = true;
            lblRFordonTyp.Location = new Point(22, 166);
            lblRFordonTyp.Name = "lblRFordonTyp";
            lblRFordonTyp.Size = new Size(62, 15);
            lblRFordonTyp.TabIndex = 9;
            lblRFordonTyp.Text = "Fordontyp";
            // 
            // tbxRBatteriNivå
            // 
            tbxRBatteriNivå.FormattingEnabled = true;
            tbxRBatteriNivå.Location = new Point(138, 76);
            tbxRBatteriNivå.Name = "tbxRBatteriNivå";
            tbxRBatteriNivå.Size = new Size(121, 23);
            tbxRBatteriNivå.TabIndex = 10;
            // 
            // tbxRFordonStatus
            // 
            tbxRFordonStatus.FormattingEnabled = true;
            tbxRFordonStatus.Location = new Point(138, 105);
            tbxRFordonStatus.Name = "tbxRFordonStatus";
            tbxRFordonStatus.Size = new Size(121, 23);
            tbxRFordonStatus.TabIndex = 11;
            // 
            // tbxRBokningStatus
            // 
            tbxRBokningStatus.FormattingEnabled = true;
            tbxRBokningStatus.Location = new Point(138, 134);
            tbxRBokningStatus.Name = "tbxRBokningStatus";
            tbxRBokningStatus.Size = new Size(121, 23);
            tbxRBokningStatus.TabIndex = 12;
            // 
            // tbxRFordonTyp
            // 
            tbxRFordonTyp.FormattingEnabled = true;
            tbxRFordonTyp.Location = new Point(138, 163);
            tbxRFordonTyp.Name = "tbxRFordonTyp";
            tbxRFordonTyp.Size = new Size(121, 23);
            tbxRFordonTyp.TabIndex = 13;
            // 
            // lblRTilldelaStation
            // 
            lblRTilldelaStation.AutoSize = true;
            lblRTilldelaStation.Location = new Point(22, 195);
            lblRTilldelaStation.Name = "lblRTilldelaStation";
            lblRTilldelaStation.Size = new Size(103, 15);
            lblRTilldelaStation.TabIndex = 14;
            lblRTilldelaStation.Text = "Tilldela en Station:";
            // 
            // tbxRTilldelaStation
            // 
            tbxRTilldelaStation.FormattingEnabled = true;
            tbxRTilldelaStation.Location = new Point(138, 192);
            tbxRTilldelaStation.Name = "tbxRTilldelaStation";
            tbxRTilldelaStation.Size = new Size(121, 23);
            tbxRTilldelaStation.TabIndex = 15;
            // 
            // FordonRegistreringController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbxRTilldelaStation);
            Controls.Add(lblRTilldelaStation);
            Controls.Add(tbxRFordonTyp);
            Controls.Add(tbxRBokningStatus);
            Controls.Add(tbxRFordonStatus);
            Controls.Add(tbxRBatteriNivå);
            Controls.Add(lblRFordonTyp);
            Controls.Add(lblRBokningStatus);
            Controls.Add(lblRFordonStatus);
            Controls.Add(btnRegistreraFordon);
            Controls.Add(lblRBatteriNivå);
            Controls.Add(lblFordonRegistrering);
            Name = "FordonRegistreringController";
            Size = new Size(293, 342);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFordonRegistrering;
        private Label lblRBatteriNivå;
        private Button btnRegistreraFordon;
        private Label lblRFordonStatus;
        private Label lblRBokningStatus;
        private Label lblRFordonTyp;
        private ComboBox tbxRBatteriNivå;
        private ComboBox tbxRFordonStatus;
        private ComboBox tbxRBokningStatus;
        private ComboBox tbxRFordonTyp;
        private Label lblRTilldelaStation;
        private ComboBox tbxRTilldelaStation;
    }
}
