using System.Windows.Forms;

namespace FordonUthyrning3
{
    partial class StationController
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
            pnlStationContainer = new FlowLayoutPanel();
            lblNamn = new Label();
            pnlSection = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            pnlStationContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStationContainer
            // 
            pnlStationContainer.AutoScroll = true;
            pnlStationContainer.Controls.Add(lblNamn);
            pnlStationContainer.Controls.Add(pnlSection);
            pnlStationContainer.Controls.Add(button1);
            pnlStationContainer.Controls.Add(button2);
            pnlStationContainer.Dock = DockStyle.Fill;
            pnlStationContainer.FlowDirection = FlowDirection.TopDown;
            pnlStationContainer.Location = new Point(0, 0);
            pnlStationContainer.Name = "pnlStationContainer";
            pnlStationContainer.Padding = new Padding(0, 0, 0, 10);
            pnlStationContainer.Size = new Size(450, 550);
            pnlStationContainer.TabIndex = 0;
            pnlStationContainer.WrapContents = false;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Dock = DockStyle.Top;
            lblNamn.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point);
            lblNamn.Location = new Point(3, 0);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(147, 45);
            lblNamn.TabIndex = 0;
            lblNamn.Text = "Stationer";
            // 
            // pnlSection
            // 
            pnlSection.AutoSize = true;
            pnlSection.Dock = DockStyle.Left;
            pnlSection.Location = new Point(3, 48);
            pnlSection.Name = "pnlSection";
            pnlSection.Padding = new Padding(0, 0, 0, 10);
            pnlSection.Size = new Size(0, 10);
            pnlSection.TabIndex = 1;
            pnlSection.Visible = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.Location = new Point(50, 64);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 2;
            button1.Text = "Läggtillstation";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 102);
            button2.Name = "button2";
            button2.Size = new Size(102, 23);
            button2.TabIndex = 3;
            button2.Text = "LäggtillFordon";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // StationController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlStationContainer);
            Name = "StationController";
            Size = new Size(450, 550);
            pnlStationContainer.ResumeLayout(false);
            pnlStationContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlStationContainer;
        private Label lblNamn;
        private FlowLayoutPanel pnlSection;
        private Button button1;
        private Button button2;
    }
}
