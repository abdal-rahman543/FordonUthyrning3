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
            label1 = new Label();
            pnlStationContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStationContainer
            // 
            pnlStationContainer.AutoScroll = true;
            pnlStationContainer.AutoSize = true;
            pnlStationContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlStationContainer.Controls.Add(label1);
            pnlStationContainer.Dock = DockStyle.Fill;
            pnlStationContainer.FlowDirection = FlowDirection.TopDown;
            pnlStationContainer.Location = new Point(0, 0);
            pnlStationContainer.Name = "pnlStationContainer";
            pnlStationContainer.Size = new Size(430, 560);
            pnlStationContainer.TabIndex = 0;
            pnlStationContainer.WrapContents = false;
            pnlStationContainer.HorizontalScroll.Enabled = false;
            pnlStationContainer.HorizontalScroll.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 45);
            label1.TabIndex = 0;
            label1.Text = "Stationer";
            // 
            // StationController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlStationContainer);
            Name = "StationController";
            Size = new Size(430, 560);
            Load += pnlStationContainer_Load;
            pnlStationContainer.ResumeLayout(false);
            pnlStationContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel pnlStationContainer;
        private Label label1;
    }
}
