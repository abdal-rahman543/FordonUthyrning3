﻿namespace FordonUthyrning3.GUI_components
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
            btnBörjaTur = new Button();
            lblDatum = new Label();
            lblStartTid = new Label();
            lblBetalningsMetod = new Label();
            lblFordonID = new Label();
            lblVärdeDatum = new Label();
            lblVärdeStartTid = new Label();
            lblVärdeBetalningsMetod = new Label();
            lblVärdeFID = new Label();
            label1 = new Label();
            lblSluttid = new Label();
            lblTurttid = new Label();
            lblVärdeSlutTid = new Label();
            lblVärdeTurTid = new Label();
            lblTotalKostnad = new Label();
            lblVärdeKostnad = new Label();
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
            // btnBörjaTur
            // 
            btnBörjaTur.BackColor = Color.FromArgb(255, 255, 128);
            btnBörjaTur.FlatStyle = FlatStyle.Flat;
            btnBörjaTur.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            btnBörjaTur.Location = new Point(228, 354);
            btnBörjaTur.Name = "btnBörjaTur";
            btnBörjaTur.Size = new Size(121, 46);
            btnBörjaTur.TabIndex = 1;
            btnBörjaTur.Text = "Börja tur";
            btnBörjaTur.UseVisualStyleBackColor = false;
            btnBörjaTur.Click += lblBörjaTur_Click;
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Location = new Point(150, 86);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(46, 15);
            lblDatum.TabIndex = 2;
            lblDatum.Text = "Datum:";
            // 
            // lblStartTid
            // 
            lblStartTid.AutoSize = true;
            lblStartTid.Location = new Point(150, 120);
            lblStartTid.Name = "lblStartTid";
            lblStartTid.Size = new Size(48, 15);
            lblStartTid.TabIndex = 3;
            lblStartTid.Text = "Starttid:";
            // 
            // lblBetalningsMetod
            // 
            lblBetalningsMetod.AutoSize = true;
            lblBetalningsMetod.Location = new Point(150, 153);
            lblBetalningsMetod.Name = "lblBetalningsMetod";
            lblBetalningsMetod.Size = new Size(100, 15);
            lblBetalningsMetod.TabIndex = 4;
            lblBetalningsMetod.Text = "Betalningsmetod:";
            // 
            // lblFordonID
            // 
            lblFordonID.AutoSize = true;
            lblFordonID.Location = new Point(150, 181);
            lblFordonID.Name = "lblFordonID";
            lblFordonID.Size = new Size(59, 15);
            lblFordonID.TabIndex = 5;
            lblFordonID.Text = "FordonID:";
            // 
            // lblVärdeDatum
            // 
            lblVärdeDatum.AutoSize = true;
            lblVärdeDatum.Location = new Point(202, 86);
            lblVärdeDatum.Name = "lblVärdeDatum";
            lblVärdeDatum.Size = new Size(38, 15);
            lblVärdeDatum.TabIndex = 6;
            lblVärdeDatum.Text = "label1";
            // 
            // lblVärdeStartTid
            // 
            lblVärdeStartTid.AutoSize = true;
            lblVärdeStartTid.Location = new Point(204, 120);
            lblVärdeStartTid.Name = "lblVärdeStartTid";
            lblVärdeStartTid.Size = new Size(38, 15);
            lblVärdeStartTid.TabIndex = 7;
            lblVärdeStartTid.Text = "label2";
            // 
            // lblVärdeBetalningsMetod
            // 
            lblVärdeBetalningsMetod.AutoSize = true;
            lblVärdeBetalningsMetod.Location = new Point(256, 153);
            lblVärdeBetalningsMetod.Name = "lblVärdeBetalningsMetod";
            lblVärdeBetalningsMetod.Size = new Size(38, 15);
            lblVärdeBetalningsMetod.TabIndex = 8;
            lblVärdeBetalningsMetod.Text = "label3";
            // 
            // lblVärdeFID
            // 
            lblVärdeFID.AutoSize = true;
            lblVärdeFID.Location = new Point(215, 181);
            lblVärdeFID.Name = "lblVärdeFID";
            lblVärdeFID.Size = new Size(38, 15);
            lblVärdeFID.TabIndex = 9;
            lblVärdeFID.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(83, 263);
            label1.Name = "label1";
            label1.Size = new Size(427, 15);
            label1.TabIndex = 10;
            label1.Text = "____________________________________________________________________________________";
            // 
            // lblSluttid
            // 
            lblSluttid.AutoSize = true;
            lblSluttid.Location = new Point(158, 209);
            lblSluttid.Name = "lblSluttid";
            lblSluttid.Size = new Size(44, 15);
            lblSluttid.TabIndex = 11;
            lblSluttid.Text = "Sluttid:";
            lblSluttid.Visible = false;
            // 
            // lblTurttid
            // 
            lblTurttid.AutoSize = true;
            lblTurttid.Location = new Point(160, 239);
            lblTurttid.Name = "lblTurttid";
            lblTurttid.Size = new Size(44, 15);
            lblTurttid.TabIndex = 12;
            lblTurttid.Text = "Tur tid:";
            lblTurttid.Visible = false;
            // 
            // lblVärdeSlutTid
            // 
            lblVärdeSlutTid.AutoSize = true;
            lblVärdeSlutTid.Location = new Point(212, 209);
            lblVärdeSlutTid.Name = "lblVärdeSlutTid";
            lblVärdeSlutTid.Size = new Size(38, 15);
            lblVärdeSlutTid.TabIndex = 13;
            lblVärdeSlutTid.Text = "label4";
            lblVärdeSlutTid.Visible = false;
            // 
            // lblVärdeTurTid
            // 
            lblVärdeTurTid.AutoSize = true;
            lblVärdeTurTid.Location = new Point(215, 239);
            lblVärdeTurTid.Name = "lblVärdeTurTid";
            lblVärdeTurTid.Size = new Size(38, 15);
            lblVärdeTurTid.TabIndex = 14;
            lblVärdeTurTid.Text = "label4";
            lblVärdeTurTid.Visible = false;
            // 
            // lblTotalKostnad
            // 
            lblTotalKostnad.AutoSize = true;
            lblTotalKostnad.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalKostnad.Location = new Point(157, 296);
            lblTotalKostnad.Name = "lblTotalKostnad";
            lblTotalKostnad.Size = new Size(141, 30);
            lblTotalKostnad.TabIndex = 15;
            lblTotalKostnad.Text = "Total kostnad:";
            lblTotalKostnad.Visible = false;
            // 
            // lblVärdeKostnad
            // 
            lblVärdeKostnad.AutoSize = true;
            lblVärdeKostnad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVärdeKostnad.Location = new Point(304, 300);
            lblVärdeKostnad.Name = "lblVärdeKostnad";
            lblVärdeKostnad.Size = new Size(78, 25);
            lblVärdeKostnad.TabIndex = 16;
            lblVärdeKostnad.Text = "kostnad";
            lblVärdeKostnad.Visible = false;
            // 
            // PågåendeTurerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblVärdeKostnad);
            Controls.Add(lblTotalKostnad);
            Controls.Add(lblVärdeTurTid);
            Controls.Add(lblVärdeSlutTid);
            Controls.Add(lblTurttid);
            Controls.Add(lblSluttid);
            Controls.Add(label1);
            Controls.Add(lblVärdeFID);
            Controls.Add(lblVärdeBetalningsMetod);
            Controls.Add(lblVärdeStartTid);
            Controls.Add(lblVärdeDatum);
            Controls.Add(lblFordonID);
            Controls.Add(lblBetalningsMetod);
            Controls.Add(lblStartTid);
            Controls.Add(lblDatum);
            Controls.Add(btnBörjaTur);
            Controls.Add(lblTitel);
            Name = "PågåendeTurerForm";
            Size = new Size(602, 427);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private Button btnBörjaTur;
        private Label lblDatum;
        private Label lblStartTid;
        private Label lblBetalningsMetod;
        private Label lblFordonID;
        private Label lblVärdeDatum;
        private Label lblVärdeStartTid;
        private Label lblVärdeBetalningsMetod;
        private Label lblVärdeFID;
        private Label label1;
        private Label lblSluttid;
        private Label lblTurttid;
        private Label lblVärdeSlutTid;
        private Label lblVärdeTurTid;
        private Label lblTotalKostnad;
        private Label lblVärdeKostnad;
    }
}
