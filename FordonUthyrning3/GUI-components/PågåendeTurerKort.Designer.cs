namespace FordonUthyrning3.GUI_components
{
    partial class PågåendeTurerKort
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
            lblVärdeFTyp = new Label();
            lblVärdeBStatus = new Label();
            lblVärdeFStatus = new Label();
            lblVärdeBatteri = new Label();
            btnAvsluta = new Button();
            lblFordonTyp = new Label();
            lblBokningstatus = new Label();
            lblFordonStatus = new Label();
            lblBatteri = new Label();
            lblFordonID = new Label();
            SuspendLayout();
            // 
            // lblVärdeFTyp
            // 
            lblVärdeFTyp.AutoSize = true;
            lblVärdeFTyp.Location = new Point(107, 120);
            lblVärdeFTyp.Name = "lblVärdeFTyp";
            lblVärdeFTyp.Size = new Size(36, 15);
            lblVärdeFTyp.TabIndex = 21;
            lblVärdeFTyp.Text = "värde";
            // 
            // lblVärdeBStatus
            // 
            lblVärdeBStatus.AutoSize = true;
            lblVärdeBStatus.Location = new Point(107, 100);
            lblVärdeBStatus.Name = "lblVärdeBStatus";
            lblVärdeBStatus.Size = new Size(36, 15);
            lblVärdeBStatus.TabIndex = 20;
            lblVärdeBStatus.Text = "värde";
            // 
            // lblVärdeFStatus
            // 
            lblVärdeFStatus.AutoSize = true;
            lblVärdeFStatus.Location = new Point(107, 78);
            lblVärdeFStatus.Name = "lblVärdeFStatus";
            lblVärdeFStatus.Size = new Size(36, 15);
            lblVärdeFStatus.TabIndex = 19;
            lblVärdeFStatus.Text = "värde";
            // 
            // lblVärdeBatteri
            // 
            lblVärdeBatteri.AutoSize = true;
            lblVärdeBatteri.Location = new Point(107, 55);
            lblVärdeBatteri.Name = "lblVärdeBatteri";
            lblVärdeBatteri.Size = new Size(36, 15);
            lblVärdeBatteri.TabIndex = 18;
            lblVärdeBatteri.Text = "värde";
            // 
            // btnAvsluta
            // 
            btnAvsluta.BackColor = Color.FromArgb(255, 255, 128);
            btnAvsluta.FlatStyle = FlatStyle.Flat;
            btnAvsluta.Location = new Point(305, 87);
            btnAvsluta.Name = "btnAvsluta";
            btnAvsluta.Size = new Size(100, 43);
            btnAvsluta.TabIndex = 17;
            btnAvsluta.Text = "Avsluta tur";
            btnAvsluta.UseVisualStyleBackColor = false;
            // 
            // lblFordonTyp
            // 
            lblFordonTyp.AutoSize = true;
            lblFordonTyp.Location = new Point(22, 120);
            lblFordonTyp.Name = "lblFordonTyp";
            lblFordonTyp.Size = new Size(65, 15);
            lblFordonTyp.TabIndex = 15;
            lblFordonTyp.Text = "Fordontyp:";
            // 
            // lblBokningstatus
            // 
            lblBokningstatus.AutoSize = true;
            lblBokningstatus.Location = new Point(22, 100);
            lblBokningstatus.Name = "lblBokningstatus";
            lblBokningstatus.Size = new Size(85, 15);
            lblBokningstatus.TabIndex = 14;
            lblBokningstatus.Text = "Bokningstatus:";
            // 
            // lblFordonStatus
            // 
            lblFordonStatus.AutoSize = true;
            lblFordonStatus.Location = new Point(22, 78);
            lblFordonStatus.Name = "lblFordonStatus";
            lblFordonStatus.Size = new Size(79, 15);
            lblFordonStatus.TabIndex = 13;
            lblFordonStatus.Text = "Fordonstatus:";
            // 
            // lblBatteri
            // 
            lblBatteri.AutoSize = true;
            lblBatteri.Location = new Point(22, 55);
            lblBatteri.Name = "lblBatteri";
            lblBatteri.Size = new Size(66, 15);
            lblBatteri.TabIndex = 12;
            lblBatteri.Text = "Batterinivå:";
            // 
            // lblFordonID
            // 
            lblFordonID.AutoSize = true;
            lblFordonID.Font = new Font("Segoe UI", 21.75F, FontStyle.Underline, GraphicsUnit.Point);
            lblFordonID.Location = new Point(0, 0);
            lblFordonID.Name = "lblFordonID";
            lblFordonID.Size = new Size(136, 40);
            lblFordonID.TabIndex = 11;
            lblFordonID.Text = "FordonID";
            // 
            // PågåendeTurerKort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblVärdeFTyp);
            Controls.Add(lblVärdeBStatus);
            Controls.Add(lblVärdeFStatus);
            Controls.Add(lblVärdeBatteri);
            Controls.Add(btnAvsluta);
            Controls.Add(lblFordonTyp);
            Controls.Add(lblBokningstatus);
            Controls.Add(lblFordonStatus);
            Controls.Add(lblBatteri);
            Controls.Add(lblFordonID);
            Name = "PågåendeTurerKort";
            Size = new Size(450, 150);
            Load += PågåendeTurerKort_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVärdeFTyp;
        private Label lblVärdeBStatus;
        private Label lblVärdeFStatus;
        private Label lblVärdeBatteri;
        private Button btnAvsluta;
        private Label lblFordonTyp;
        private Label lblBokningstatus;
        private Label lblFordonStatus;
        private Label lblBatteri;
        private Label lblFordonID;
    }
}
