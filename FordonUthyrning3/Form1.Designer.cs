using FordonUthyrning3.Controllers;

namespace FordonUthyrning3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>


        private void InitializeComponent()
        {
            Meny = new MenuStrip();
            toolStripMenuBack = new ToolStripMenuItem();
            hemToolStripMenuItem = new ToolStripMenuItem();
            profilToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            BackgrundsBild_Container = new PictureBox();
            GbxContent_Container = new GroupBox();
            splitContainer = new SplitContainer();
            btnAddStation = new Button();
            btnAddFordon = new Button();
            Meny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackgrundsBild_Container).BeginInit();
            GbxContent_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // Meny
            // 
            Meny.Items.AddRange(new ToolStripItem[] { toolStripMenuBack, hemToolStripMenuItem, profilToolStripMenuItem, exitToolStripMenuItem });
            Meny.Location = new Point(0, 0);
            Meny.Name = "Meny";
            Meny.Size = new Size(1205, 24);
            Meny.TabIndex = 0;
            Meny.Text = "menuStrip1";
            Meny.Visible = false;
            // 
            // toolStripMenuBack
            // 
            toolStripMenuBack.Name = "toolStripMenuBack";
            toolStripMenuBack.Size = new Size(44, 20);
            toolStripMenuBack.Text = "Back";
            toolStripMenuBack.Visible = false;
            toolStripMenuBack.Click += toolStripMenuBack_Click;
            // 
            // hemToolStripMenuItem
            // 
            hemToolStripMenuItem.Name = "hemToolStripMenuItem";
            hemToolStripMenuItem.Size = new Size(45, 20);
            hemToolStripMenuItem.Text = "Hem";
            hemToolStripMenuItem.Visible = false;
            hemToolStripMenuItem.Click += hemToolStripMenuItem_Click;
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(47, 20);
            profilToolStripMenuItem.Text = "Profil";
            profilToolStripMenuItem.Visible = false;
            profilToolStripMenuItem.Click += profilToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Visible = false;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // BackgrundsBild_Container
            // 
            BackgrundsBild_Container.BackgroundImage = Properties.Resources.BackgrundsBild_Login;
            BackgrundsBild_Container.BackgroundImageLayout = ImageLayout.Stretch;
            BackgrundsBild_Container.Dock = DockStyle.Fill;
            BackgrundsBild_Container.Location = new Point(0, 0);
            BackgrundsBild_Container.Name = "BackgrundsBild_Container";
            BackgrundsBild_Container.Size = new Size(1205, 671);
            BackgrundsBild_Container.TabIndex = 1;
            BackgrundsBild_Container.TabStop = false;
            // 
            // GbxContent_Container
            // 
            GbxContent_Container.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GbxContent_Container.BackColor = Color.DarkGray;
            GbxContent_Container.Controls.Add(splitContainer);
            GbxContent_Container.Location = new Point(93, 45);
            GbxContent_Container.Name = "GbxContent_Container";
            GbxContent_Container.Padding = new Padding(15);
            GbxContent_Container.Size = new Size(1014, 586);
            GbxContent_Container.TabIndex = 2;
            GbxContent_Container.TabStop = false;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(15, 31);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(btnAddStation);
            splitContainer.Panel2.Controls.Add(btnAddFordon);
            splitContainer.Size = new Size(984, 540);
            splitContainer.SplitterDistance = 489;
            splitContainer.TabIndex = 0;
            splitContainer.Visible = false;
            // 
            // btnAddStation
            // 
            btnAddStation.Anchor = AnchorStyles.Right;
            btnAddStation.BackColor = Color.FromArgb(255, 255, 128);
            btnAddStation.FlatStyle = FlatStyle.Flat;
            btnAddStation.Location = new Point(193, 223);
            btnAddStation.Name = "btnAddStation";
            btnAddStation.Size = new Size(148, 64);
            btnAddStation.TabIndex = 4;
            btnAddStation.Text = "Lägg till station";
            btnAddStation.UseVisualStyleBackColor = false;
            btnAddStation.Visible = false;
            btnAddStation.Click += btnAddStation_Click;
            // 
            // btnAddFordon
            // 
            btnAddFordon.BackColor = Color.FromArgb(255, 255, 128);
            btnAddFordon.FlatStyle = FlatStyle.Flat;
            btnAddFordon.Location = new Point(193, 343);
            btnAddFordon.Name = "btnAddFordon";
            btnAddFordon.Size = new Size(148, 64);
            btnAddFordon.TabIndex = 5;
            btnAddFordon.Text = "Lägg till Fordon";
            btnAddFordon.UseVisualStyleBackColor = false;
            btnAddFordon.Visible = false;
            btnAddFordon.Click += btnAddFordon_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 671);
            Controls.Add(GbxContent_Container);
            Controls.Add(BackgrundsBild_Container);
            Controls.Add(Meny);
            MainMenuStrip = Meny;
            Name = "Form1";
            Text = "Form1";
            SizeChanged += Form1_Resize;
            Meny.ResumeLayout(false);
            Meny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackgrundsBild_Container).EndInit();
            GbxContent_Container.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        public ToolStripMenuItem hemToolStripMenuItem;
        public ToolStripMenuItem profilToolStripMenuItem;
        public ToolStripMenuItem exitToolStripMenuItem;
        private PictureBox BackgrundsBild_Container;
        public GroupBox GbxContent_Container;
        public SplitContainer splitContainer;
        
        public MenuStrip Meny;
        public ToolStripMenuItem toolStripMenuBack;
        public Button btnAddStation;
        public Button btnAddFordon;
    }
}
