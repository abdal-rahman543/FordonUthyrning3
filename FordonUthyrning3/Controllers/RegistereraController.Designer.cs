namespace FordonUthyrning3
{
    partial class RegistereraController
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
            tbxFörnamn = new TextBox();
            tbxEfternamn = new TextBox();
            tbxEpost = new TextBox();
            tbxLösenord = new TextBox();
            lblRegistrering = new Label();
            btnRegistrera = new Button();
            cboBehörighet = new ComboBox();
            lblRegistereingStatus = new Label();
            SuspendLayout();
            // 
            // tbxFörnamn
            // 
            tbxFörnamn.Location = new Point(207, 123);
            tbxFörnamn.Name = "tbxFörnamn";
            tbxFörnamn.PlaceholderText = "Förnamn";
            tbxFörnamn.Size = new Size(256, 23);
            tbxFörnamn.TabIndex = 0;
            // 
            // tbxEfternamn
            // 
            tbxEfternamn.Location = new Point(207, 176);
            tbxEfternamn.Name = "tbxEfternamn";
            tbxEfternamn.PlaceholderText = "Efternamn";
            tbxEfternamn.Size = new Size(256, 23);
            tbxEfternamn.TabIndex = 1;
            // 
            // tbxEpost
            // 
            tbxEpost.Location = new Point(207, 226);
            tbxEpost.Name = "tbxEpost";
            tbxEpost.PlaceholderText = "Epost";
            tbxEpost.Size = new Size(256, 23);
            tbxEpost.TabIndex = 2;
            // 
            // tbxLösenord
            // 
            tbxLösenord.Location = new Point(207, 278);
            tbxLösenord.Name = "tbxLösenord";
            tbxLösenord.PlaceholderText = "Lösenord";
            tbxLösenord.Size = new Size(256, 23);
            tbxLösenord.TabIndex = 3;
            // 
            // lblRegistrering
            // 
            lblRegistrering.AutoSize = true;
            lblRegistrering.Font = new Font("Segoe UI", 27.75F, FontStyle.Underline, GraphicsUnit.Point);
            lblRegistrering.Location = new Point(240, 27);
            lblRegistrering.Name = "lblRegistrering";
            lblRegistrering.Size = new Size(186, 50);
            lblRegistrering.TabIndex = 4;
            lblRegistrering.Text = "Registrera";
            // 
            // btnRegistrera
            // 
            btnRegistrera.BackColor = Color.Yellow;
            btnRegistrera.FlatStyle = FlatStyle.Flat;
            btnRegistrera.Location = new Point(266, 403);
            btnRegistrera.Name = "btnRegistrera";
            btnRegistrera.Size = new Size(134, 46);
            btnRegistrera.TabIndex = 5;
            btnRegistrera.Text = "Registrera";
            btnRegistrera.UseVisualStyleBackColor = false;
            btnRegistrera.Click += btnRegistrera_Click;
            // 
            // cboBehörighet
            // 
            cboBehörighet.FormattingEnabled = true;
            cboBehörighet.Items.AddRange(new object[] { "Admin", "kund" });
            cboBehörighet.Location = new Point(271, 346);
            cboBehörighet.Name = "cboBehörighet";
            cboBehörighet.Size = new Size(121, 23);
            cboBehörighet.TabIndex = 6;
            cboBehörighet.DropDownClosed += cboBehörighet_DropDownClosed;
            // 
            // lblRegistereingStatus
            // 
            lblRegistereingStatus.AutoSize = true;
            lblRegistereingStatus.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblRegistereingStatus.Location = new Point(258, 189);
            lblRegistereingStatus.Name = "lblRegistereingStatus";
            lblRegistereingStatus.Size = new Size(154, 65);
            lblRegistereingStatus.TabIndex = 7;
            lblRegistereingStatus.Text = "label1";
            lblRegistereingStatus.Visible = false;
            // 
            // RegistereraController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblRegistereingStatus);
            Controls.Add(cboBehörighet);
            Controls.Add(btnRegistrera);
            Controls.Add(lblRegistrering);
            Controls.Add(tbxLösenord);
            Controls.Add(tbxEpost);
            Controls.Add(tbxEfternamn);
            Controls.Add(tbxFörnamn);
            Name = "RegistereraController";
            Size = new Size(692, 540);
            SizeChanged += RegistereraController_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxFörnamn;
        private TextBox tbxEfternamn;
        private TextBox tbxEpost;
        private TextBox tbxLösenord;
        private Label lblRegistrering;
        private Button btnRegistrera;
        private ComboBox cboBehörighet;
        private Label lblRegistereingStatus;
    }
}
