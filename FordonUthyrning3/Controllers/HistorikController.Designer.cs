namespace FordonUthyrning3.Controllers
{
    partial class HistorikController
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
            pnlContent_Container = new FlowLayoutPanel();
            lblIngenHistorik = new Label();
            pnlContent_Container.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point);
            lblTitel.Location = new Point(123, 0);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(205, 45);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Hyreshistorik";
            // 
            // pnlContent_Container
            // 
            pnlContent_Container.AutoScroll = true;
            pnlContent_Container.Controls.Add(lblIngenHistorik);
            pnlContent_Container.Dock = DockStyle.Bottom;
            pnlContent_Container.FlowDirection = FlowDirection.TopDown;
            pnlContent_Container.Location = new Point(0, 48);
            pnlContent_Container.Name = "pnlContent_Container";
            pnlContent_Container.Size = new Size(451, 428);
            pnlContent_Container.TabIndex = 1;
            pnlContent_Container.WrapContents = false;
            // 
            // lblIngenHistorik
            // 
            lblIngenHistorik.AutoSize = true;
            lblIngenHistorik.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIngenHistorik.Location = new Point(3, 0);
            lblIngenHistorik.Name = "lblIngenHistorik";
            lblIngenHistorik.Size = new Size(386, 20);
            lblIngenHistorik.TabIndex = 0;
            lblIngenHistorik.Text = "Ingen historik tillgänglig... (Testa att hyra ett fordon först)";
            // 
            // HistorikController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContent_Container);
            Controls.Add(lblTitel);
            Name = "HistorikController";
            Size = new Size(451, 476);
            pnlContent_Container.ResumeLayout(false);
            pnlContent_Container.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private FlowLayoutPanel pnlContent_Container;
        private Label lblIngenHistorik;
    }
}
