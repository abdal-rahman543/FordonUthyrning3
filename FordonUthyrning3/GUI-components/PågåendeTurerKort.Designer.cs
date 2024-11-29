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
            lblVärdeFId = new Label();
            lblVärdeBetalningMetod = new Label();
            lblVärdeStartTid = new Label();
            lblVärdeDatum = new Label();
            btnAvsluta = new Button();
            lblFordonID = new Label();
            lblBetalningsmetod = new Label();
            lblStartTid = new Label();
            lblDatum = new Label();
            SuspendLayout();
            // 
            // lblVärdeFId
            // 
            lblVärdeFId.AutoSize = true;
            lblVärdeFId.Location = new Point(102, 104);
            lblVärdeFId.Name = "lblVärdeFId";
            lblVärdeFId.Size = new Size(36, 15);
            lblVärdeFId.TabIndex = 21;
            lblVärdeFId.Text = "värde";
            // 
            // lblVärdeBetalningMetod
            // 
            lblVärdeBetalningMetod.AutoSize = true;
            lblVärdeBetalningMetod.Location = new Point(123, 84);
            lblVärdeBetalningMetod.Name = "lblVärdeBetalningMetod";
            lblVärdeBetalningMetod.Size = new Size(36, 15);
            lblVärdeBetalningMetod.TabIndex = 20;
            lblVärdeBetalningMetod.Text = "värde";
            // 
            // lblVärdeStartTid
            // 
            lblVärdeStartTid.AutoSize = true;
            lblVärdeStartTid.Location = new Point(102, 62);
            lblVärdeStartTid.Name = "lblVärdeStartTid";
            lblVärdeStartTid.Size = new Size(36, 15);
            lblVärdeStartTid.TabIndex = 19;
            lblVärdeStartTid.Text = "värde";
            // 
            // lblVärdeDatum
            // 
            lblVärdeDatum.AutoSize = true;
            lblVärdeDatum.Location = new Point(102, 39);
            lblVärdeDatum.Name = "lblVärdeDatum";
            lblVärdeDatum.Size = new Size(36, 15);
            lblVärdeDatum.TabIndex = 18;
            lblVärdeDatum.Text = "värde";
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
            btnAvsluta.Click += btnAvsluta_Click;
            // 
            // lblFordonID
            // 
            lblFordonID.AutoSize = true;
            lblFordonID.Location = new Point(17, 104);
            lblFordonID.Name = "lblFordonID";
            lblFordonID.Size = new Size(61, 15);
            lblFordonID.TabIndex = 15;
            lblFordonID.Text = "Fordon id:";
            // 
            // lblBetalningsmetod
            // 
            lblBetalningsmetod.AutoSize = true;
            lblBetalningsmetod.Location = new Point(17, 84);
            lblBetalningsmetod.Name = "lblBetalningsmetod";
            lblBetalningsmetod.Size = new Size(100, 15);
            lblBetalningsmetod.TabIndex = 14;
            lblBetalningsmetod.Text = "betalningsmetod:";
            // 
            // lblStartTid
            // 
            lblStartTid.AutoSize = true;
            lblStartTid.Location = new Point(17, 62);
            lblStartTid.Name = "lblStartTid";
            lblStartTid.Size = new Size(51, 15);
            lblStartTid.TabIndex = 13;
            lblStartTid.Text = "Start tid:";
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Location = new Point(17, 39);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(46, 15);
            lblDatum.TabIndex = 12;
            lblDatum.Text = "Datum:";
            // 
            // PågåendeTurerKort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblVärdeFId);
            Controls.Add(lblVärdeBetalningMetod);
            Controls.Add(lblVärdeStartTid);
            Controls.Add(lblVärdeDatum);
            Controls.Add(btnAvsluta);
            Controls.Add(lblFordonID);
            Controls.Add(lblBetalningsmetod);
            Controls.Add(lblStartTid);
            Controls.Add(lblDatum);
            Name = "PågåendeTurerKort";
            Size = new Size(450, 150);
            Load += PågåendeTurerKort_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVärdeFId;
        private Label lblVärdeBetalningMetod;
        private Label lblVärdeStartTid;
        private Label lblVärdeDatum;
        private Button btnAvsluta;
        private Label lblBetalningsmetod;
        private Label lblStartTid;
        private Label lblDatum;
        private Label lblFordonID;
    }
}
