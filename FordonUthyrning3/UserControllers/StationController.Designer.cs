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
            pnlStationContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStationContainer
            // 
            pnlStationContainer.AutoScroll = true;
            pnlStationContainer.Controls.Add(lblNamn);
            pnlStationContainer.Controls.Add(pnlSection);
            pnlStationContainer.Dock = DockStyle.Fill;
            pnlStationContainer.FlowDirection = FlowDirection.TopDown;
            pnlStationContainer.Location = new Point(0, 0);
            pnlStationContainer.Name = "pnlStationContainer";
            pnlStationContainer.Padding = new Padding(0, 20, 20, 20);
            pnlStationContainer.Size = new Size(450, 550);
            pnlStationContainer.TabIndex = 0;
            pnlStationContainer.WrapContents = false;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Dock = DockStyle.Top;
            lblNamn.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point);
            lblNamn.Location = new Point(3, 20);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(147, 45);
            lblNamn.TabIndex = 0;
            lblNamn.Text = "Stationer";
            // 
            // pnlSection
            // 
            pnlSection.AutoSize = true;
            pnlSection.Dock = DockStyle.Left;
            pnlSection.Location = new Point(3, 68);
            pnlSection.Name = "pnlSection";
            pnlSection.Padding = new Padding(0, 0, 0, 10);
            pnlSection.Size = new Size(0, 10);
            pnlSection.TabIndex = 1;
            pnlSection.Visible = false;
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
    }
}
