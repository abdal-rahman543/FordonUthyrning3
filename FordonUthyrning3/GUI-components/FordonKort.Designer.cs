namespace FordonUthyrning3.GUI_components
{
    partial class FordonKort
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
            lblFordonID = new Label();
            lblBatteri = new Label();
            lblFordonStatus = new Label();
            lblBokningstatus = new Label();
            lblFordonTyp = new Label();
            lblKostnad = new Label();
            btnVälj = new Button();
            lblVärdeBatteri = new Label();
            lblVärdeFStatus = new Label();
            lblVärdeBStatus = new Label();
            lblVärdeFTyp = new Label();
            SuspendLayout();
            // 
            // lblFordonID
            // 
            lblFordonID.AutoSize = true;
            lblFordonID.Font = new Font("Segoe UI", 21.75F, FontStyle.Underline, GraphicsUnit.Point);
            lblFordonID.Location = new Point(0, 0);
            lblFordonID.Name = "lblFordonID";
            lblFordonID.Size = new Size(136, 40);
            lblFordonID.TabIndex = 0;
            lblFordonID.Text = "FordonID";
            // 
            // lblBatteri
            // 
            lblBatteri.AutoSize = true;
            lblBatteri.Location = new Point(19, 50);
            lblBatteri.Name = "lblBatteri";
            lblBatteri.Size = new Size(66, 15);
            lblBatteri.TabIndex = 1;
            lblBatteri.Text = "Batterinivå:";
            // 
            // lblFordonStatus
            // 
            lblFordonStatus.AutoSize = true;
            lblFordonStatus.Location = new Point(19, 73);
            lblFordonStatus.Name = "lblFordonStatus";
            lblFordonStatus.Size = new Size(79, 15);
            lblFordonStatus.TabIndex = 2;
            lblFordonStatus.Text = "Fordonstatus:";
            // 
            // lblBokningstatus
            // 
            lblBokningstatus.AutoSize = true;
            lblBokningstatus.Location = new Point(19, 95);
            lblBokningstatus.Name = "lblBokningstatus";
            lblBokningstatus.Size = new Size(85, 15);
            lblBokningstatus.TabIndex = 3;
            lblBokningstatus.Text = "Bokningstatus:";
            // 
            // lblFordonTyp
            // 
            lblFordonTyp.AutoSize = true;
            lblFordonTyp.Location = new Point(19, 115);
            lblFordonTyp.Name = "lblFordonTyp";
            lblFordonTyp.Size = new Size(65, 15);
            lblFordonTyp.TabIndex = 4;
            lblFordonTyp.Text = "Fordontyp:";
            // 
            // lblKostnad
            // 
            lblKostnad.AutoSize = true;
            lblKostnad.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblKostnad.Location = new Point(292, 8);
            lblKostnad.Name = "lblKostnad";
            lblKostnad.Size = new Size(87, 30);
            lblKostnad.TabIndex = 5;
            lblKostnad.Text = "Kostnad";
            // 
            // btnVälj
            // 
            btnVälj.BackColor = Color.FromArgb(255, 255, 128);
            btnVälj.FlatStyle = FlatStyle.Flat;
            btnVälj.Location = new Point(279, 81);
            btnVälj.Name = "btnVälj";
            btnVälj.Size = new Size(100, 43);
            btnVälj.TabIndex = 6;
            btnVälj.Text = "Välj";
            btnVälj.UseVisualStyleBackColor = false;
            // 
            // lblVärdeBatteri
            // 
            lblVärdeBatteri.AutoSize = true;
            lblVärdeBatteri.Location = new Point(104, 50);
            lblVärdeBatteri.Name = "lblVärdeBatteri";
            lblVärdeBatteri.Size = new Size(36, 15);
            lblVärdeBatteri.TabIndex = 7;
            lblVärdeBatteri.Text = "värde";
            // 
            // lblVärdeFStatus
            // 
            lblVärdeFStatus.AutoSize = true;
            lblVärdeFStatus.Location = new Point(104, 73);
            lblVärdeFStatus.Name = "lblVärdeFStatus";
            lblVärdeFStatus.Size = new Size(36, 15);
            lblVärdeFStatus.TabIndex = 8;
            lblVärdeFStatus.Text = "värde";
            // 
            // lblVärdeBStatus
            // 
            lblVärdeBStatus.AutoSize = true;
            lblVärdeBStatus.Location = new Point(104, 95);
            lblVärdeBStatus.Name = "lblVärdeBStatus";
            lblVärdeBStatus.Size = new Size(36, 15);
            lblVärdeBStatus.TabIndex = 9;
            lblVärdeBStatus.Text = "värde";
            // 
            // lblVärdeFTyp
            // 
            lblVärdeFTyp.AutoSize = true;
            lblVärdeFTyp.Location = new Point(104, 115);
            lblVärdeFTyp.Name = "lblVärdeFTyp";
            lblVärdeFTyp.Size = new Size(36, 15);
            lblVärdeFTyp.TabIndex = 10;
            lblVärdeFTyp.Text = "värde";
            // 
            // FordonKort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblVärdeFTyp);
            Controls.Add(lblVärdeBStatus);
            Controls.Add(lblVärdeFStatus);
            Controls.Add(lblVärdeBatteri);
            Controls.Add(btnVälj);
            Controls.Add(lblKostnad);
            Controls.Add(lblFordonTyp);
            Controls.Add(lblBokningstatus);
            Controls.Add(lblFordonStatus);
            Controls.Add(lblBatteri);
            Controls.Add(lblFordonID);
            Name = "FordonKort";
            Size = new Size(418, 139);
            Load += FordonKort_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFordonID;
        private Label lblBatteri;
        private Label lblFordonStatus;
        private Label lblBokningstatus;
        private Label lblFordonTyp;
        private Label lblKostnad;
        private Button btnVälj;
        private Label lblVärdeBatteri;
        private Label lblVärdeFStatus;
        private Label lblVärdeBStatus;
        private Label lblVärdeFTyp;
    }
}
