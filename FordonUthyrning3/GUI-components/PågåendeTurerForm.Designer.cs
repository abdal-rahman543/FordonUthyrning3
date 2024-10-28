namespace FordonUthyrning3.GUI_components
{
    partial class PågåendeTurerForm
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
            lblTitel = new Label();
            lblBörjaTur = new Button();
            lblDatum = new Label();
            lblStartTid = new Label();
            lblBetalningsMetod = new Label();
            lblFordonID = new Label();
            lblVärdeDatum = new Label();
            lblVärdeStartTid = new Label();
            lblVärdeBetalningsMetod = new Label();
            lblVärdeFID = new Label();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point);
            lblTitel.Location = new Point(169, 25);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(252, 45);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Bekräftabokning";
            // 
            // lblBörjaTur
            // 
            lblBörjaTur.BackColor = Color.FromArgb(255, 255, 128);
            lblBörjaTur.FlatStyle = FlatStyle.Flat;
            lblBörjaTur.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblBörjaTur.Location = new Point(226, 341);
            lblBörjaTur.Name = "lblBörjaTur";
            lblBörjaTur.Size = new Size(121, 46);
            lblBörjaTur.TabIndex = 1;
            lblBörjaTur.Text = "Börja tur";
            lblBörjaTur.UseVisualStyleBackColor = false;
            lblBörjaTur.Click += lblBörjaTur_Click;
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Location = new Point(154, 119);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(46, 15);
            lblDatum.TabIndex = 2;
            lblDatum.Text = "Datum:";
            // 
            // lblStartTid
            // 
            lblStartTid.AutoSize = true;
            lblStartTid.Location = new Point(154, 153);
            lblStartTid.Name = "lblStartTid";
            lblStartTid.Size = new Size(48, 15);
            lblStartTid.TabIndex = 3;
            lblStartTid.Text = "Starttid:";
            // 
            // lblBetalningsMetod
            // 
            lblBetalningsMetod.AutoSize = true;
            lblBetalningsMetod.Location = new Point(154, 186);
            lblBetalningsMetod.Name = "lblBetalningsMetod";
            lblBetalningsMetod.Size = new Size(100, 15);
            lblBetalningsMetod.TabIndex = 4;
            lblBetalningsMetod.Text = "Betalningsmetod:";
            // 
            // lblFordonID
            // 
            lblFordonID.AutoSize = true;
            lblFordonID.Location = new Point(154, 214);
            lblFordonID.Name = "lblFordonID";
            lblFordonID.Size = new Size(59, 15);
            lblFordonID.TabIndex = 5;
            lblFordonID.Text = "FordonID:";
            // 
            // lblVärdeDatum
            // 
            lblVärdeDatum.AutoSize = true;
            lblVärdeDatum.Location = new Point(206, 119);
            lblVärdeDatum.Name = "lblVärdeDatum";
            lblVärdeDatum.Size = new Size(38, 15);
            lblVärdeDatum.TabIndex = 6;
            lblVärdeDatum.Text = "label1";
            // 
            // lblVärdeStartTid
            // 
            lblVärdeStartTid.AutoSize = true;
            lblVärdeStartTid.Location = new Point(208, 153);
            lblVärdeStartTid.Name = "lblVärdeStartTid";
            lblVärdeStartTid.Size = new Size(38, 15);
            lblVärdeStartTid.TabIndex = 7;
            lblVärdeStartTid.Text = "label2";
            // 
            // lblVärdeBetalningsMetod
            // 
            lblVärdeBetalningsMetod.AutoSize = true;
            lblVärdeBetalningsMetod.Location = new Point(260, 186);
            lblVärdeBetalningsMetod.Name = "lblVärdeBetalningsMetod";
            lblVärdeBetalningsMetod.Size = new Size(38, 15);
            lblVärdeBetalningsMetod.TabIndex = 8;
            lblVärdeBetalningsMetod.Text = "label3";
            // 
            // lblVärdeFID
            // 
            lblVärdeFID.AutoSize = true;
            lblVärdeFID.Location = new Point(219, 214);
            lblVärdeFID.Name = "lblVärdeFID";
            lblVärdeFID.Size = new Size(38, 15);
            lblVärdeFID.TabIndex = 9;
            lblVärdeFID.Text = "label4";
            // 
            // PågåendeTurerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblVärdeFID);
            Controls.Add(lblVärdeBetalningsMetod);
            Controls.Add(lblVärdeStartTid);
            Controls.Add(lblVärdeDatum);
            Controls.Add(lblFordonID);
            Controls.Add(lblBetalningsMetod);
            Controls.Add(lblStartTid);
            Controls.Add(lblDatum);
            Controls.Add(lblBörjaTur);
            Controls.Add(lblTitel);
            Name = "PågåendeTurerForm";
            Size = new Size(602, 427);
            Load += PågåendeTurerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private Button lblBörjaTur;
        private Label lblDatum;
        private Label lblStartTid;
        private Label lblBetalningsMetod;
        private Label lblFordonID;
        private Label lblVärdeDatum;
        private Label lblVärdeStartTid;
        private Label lblVärdeBetalningsMetod;
        private Label lblVärdeFID;
    }
}
