﻿namespace FordonUthyrning3.Controllers
{
    partial class ProfilController
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
            label1 = new Label();
            tbxEpost = new TextBox();
            tbxEfternamn = new TextBox();
            tbxLösenord = new TextBox();
            tbxBehörighet = new TextBox();
            button1 = new Button();
            label2 = new Label();
            tbxSwishnr = new TextBox();
            tbxKortNr = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // tbxFörnamn
            // 
            tbxFörnamn.Location = new Point(51, 67);
            tbxFörnamn.Name = "tbxFörnamn";
            tbxFörnamn.PlaceholderText = "Förnamn";
            tbxFörnamn.Size = new Size(231, 23);
            tbxFörnamn.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(33, 12);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 1;
            label1.Text = "Profil";
            // 
            // tbxEpost
            // 
            tbxEpost.Location = new Point(51, 175);
            tbxEpost.Name = "tbxEpost";
            tbxEpost.PlaceholderText = "Epost";
            tbxEpost.Size = new Size(231, 23);
            tbxEpost.TabIndex = 2;
            // 
            // tbxEfternamn
            // 
            tbxEfternamn.Location = new Point(51, 116);
            tbxEfternamn.Name = "tbxEfternamn";
            tbxEfternamn.PlaceholderText = "Efternamn";
            tbxEfternamn.Size = new Size(231, 23);
            tbxEfternamn.TabIndex = 3;
            // 
            // tbxLösenord
            // 
            tbxLösenord.Location = new Point(51, 231);
            tbxLösenord.Name = "tbxLösenord";
            tbxLösenord.PlaceholderText = "Lösenord";
            tbxLösenord.Size = new Size(231, 23);
            tbxLösenord.TabIndex = 4;
            // 
            // tbxBehörighet
            // 
            tbxBehörighet.Location = new Point(51, 282);
            tbxBehörighet.Name = "tbxBehörighet";
            tbxBehörighet.PlaceholderText = "Behörighet:";
            tbxBehörighet.ReadOnly = true;
            tbxBehörighet.Size = new Size(231, 23);
            tbxBehörighet.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(335, 461);
            button1.Name = "button1";
            button1.Size = new Size(131, 55);
            button1.TabIndex = 6;
            button1.Text = "Spara";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(33, 319);
            label2.Name = "label2";
            label2.Size = new Size(240, 31);
            label2.TabIndex = 7;
            label2.Text = "BetalningsMetoder";
            // 
            // tbxSwishnr
            // 
            tbxSwishnr.Location = new Point(84, 367);
            tbxSwishnr.Name = "tbxSwishnr";
            tbxSwishnr.PlaceholderText = "Swish-Telenr";
            tbxSwishnr.Size = new Size(189, 23);
            tbxSwishnr.TabIndex = 8;
            // 
            // tbxKortNr
            // 
            tbxKortNr.Location = new Point(84, 411);
            tbxKortNr.Name = "tbxKortNr";
            tbxKortNr.PlaceholderText = "kort-nr";
            tbxKortNr.Size = new Size(189, 23);
            tbxKortNr.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 370);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 11;
            label3.Text = "Swish";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 414);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 12;
            label4.Text = "kort-Nr";
            // 
            // ProfilController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbxKortNr);
            Controls.Add(tbxSwishnr);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(tbxBehörighet);
            Controls.Add(tbxLösenord);
            Controls.Add(tbxEfternamn);
            Controls.Add(tbxEpost);
            Controls.Add(label1);
            Controls.Add(tbxFörnamn);
            Name = "ProfilController";
            Size = new Size(509, 548);
            Load += ProfilController_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxFörnamn;
        private Label label1;
        private TextBox tbxEpost;
        private TextBox tbxEfternamn;
        private TextBox tbxLösenord;
        private TextBox tbxBehörighet;
        private Button button1;
        private Label label2;
        private TextBox tbxSwishnr;
        private TextBox tbxKortNr;
        private Label label3;
        private Label label4;
    }
}