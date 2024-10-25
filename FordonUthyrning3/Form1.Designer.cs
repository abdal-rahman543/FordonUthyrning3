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
            menuStrip1 = new MenuStrip();
            hemToolStripMenuItem = new ToolStripMenuItem();
            profilToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            BackgrundsBild_Container = new PictureBox();
            GbxContent_Container = new GroupBox();
            splitContainer = new SplitContainer();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackgrundsBild_Container).BeginInit();
            GbxContent_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hemToolStripMenuItem, profilToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1205, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hemToolStripMenuItem
            // 
            hemToolStripMenuItem.Name = "hemToolStripMenuItem";
            hemToolStripMenuItem.Size = new Size(45, 20);
            hemToolStripMenuItem.Text = "Hem";
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(47, 20);
            profilToolStripMenuItem.Text = "Profil";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // BackgrundsBild_Container
            // 
            BackgrundsBild_Container.BackgroundImage = Properties.Resources.BackgrundsBild_Login;
            BackgrundsBild_Container.BackgroundImageLayout = ImageLayout.Stretch;
            BackgrundsBild_Container.Dock = DockStyle.Fill;
            BackgrundsBild_Container.Location = new Point(0, 24);
            BackgrundsBild_Container.Name = "BackgrundsBild_Container";
            BackgrundsBild_Container.Size = new Size(1205, 647);
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
            splitContainer.Size = new Size(984, 540);
            splitContainer.SplitterDistance = 489;
            splitContainer.TabIndex = 0;
            splitContainer.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 671);
            Controls.Add(GbxContent_Container);
            Controls.Add(BackgrundsBild_Container);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            SizeChanged += Form1_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackgrundsBild_Container).EndInit();
            GbxContent_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hemToolStripMenuItem;
        private ToolStripMenuItem profilToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private PictureBox BackgrundsBild_Container;
        public GroupBox GbxContent_Container;
        public SplitContainer splitContainer;
        private Splitter splitter1;
    }
}
