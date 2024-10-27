namespace FordonUthyrning3
{
    partial class LoginController
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
            lblLoggin = new Label();
            tbxAnvändarenamn = new TextBox();
            tbxLösenord = new TextBox();
            btnLogin = new Button();
            btnRegistrera = new Button();
            SuspendLayout();
            // 
            // lblLoggin
            // 
            lblLoggin.AutoSize = true;
            lblLoggin.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblLoggin.Location = new Point(112, 16);
            lblLoggin.Name = "lblLoggin";
            lblLoggin.Size = new Size(177, 50);
            lblLoggin.TabIndex = 0;
            lblLoggin.Text = "Logga in ";
            // 
            // tbxAnvändarenamn
            // 
            tbxAnvändarenamn.Location = new Point(89, 156);
            tbxAnvändarenamn.Name = "tbxAnvändarenamn";
            tbxAnvändarenamn.PlaceholderText = "AnvändareID";
            tbxAnvändarenamn.Size = new Size(230, 23);
            tbxAnvändarenamn.TabIndex = 1;
            // 
            // tbxLösenord
            // 
            tbxLösenord.Location = new Point(89, 201);
            tbxLösenord.Name = "tbxLösenord";
            tbxLösenord.PlaceholderText = "Lösenord";
            tbxLösenord.Size = new Size(230, 23);
            tbxLösenord.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(109, 274);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(179, 42);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Logga in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegistrera
            // 
            btnRegistrera.Location = new Point(109, 341);
            btnRegistrera.Name = "btnRegistrera";
            btnRegistrera.Size = new Size(179, 42);
            btnRegistrera.TabIndex = 4;
            btnRegistrera.Text = "Registrera";
            btnRegistrera.UseVisualStyleBackColor = true;
            btnRegistrera.Click += this.btnRegistrera_Click;
            // 
            // LoginController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(btnRegistrera);
            Controls.Add(btnLogin);
            Controls.Add(tbxLösenord);
            Controls.Add(tbxAnvändarenamn);
            Controls.Add(lblLoggin);
            Name = "LoginController";
            Size = new Size(396, 430);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoggin;
        private TextBox tbxAnvändarenamn;
        private TextBox tbxLösenord;
        private Button btnLogin;
        private Button btnRegistrera;
    }
}
