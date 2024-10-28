namespace FordonUthyrning3.UserControllers
{
    partial class PågåendeTurerController
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
            pnlContent = new FlowLayoutPanel();
            lblPågåendeTurer = new Label();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.AutoScroll = true;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.FlowDirection = FlowDirection.TopDown;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(0, 0, 0, 20);
            pnlContent.Size = new Size(510, 644);
            pnlContent.TabIndex = 1;
            pnlContent.WrapContents = false;
            // 
            // lblPågåendeTurer
            // 
            lblPågåendeTurer.AutoSize = true;
            lblPågåendeTurer.Dock = DockStyle.Top;
            lblPågåendeTurer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblPågåendeTurer.Location = new Point(0, 0);
            lblPågåendeTurer.Name = "lblPågåendeTurer";
            lblPågåendeTurer.Size = new Size(246, 32);
            lblPågåendeTurer.TabIndex = 0;
            lblPågåendeTurer.Text = "Inga pågående turer...";
            // 
            // PågåendeTurerController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPågåendeTurer);
            Controls.Add(pnlContent);
            Name = "PågåendeTurerController";
            Size = new Size(510, 644);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel pnlContent;
        private Label lblPågåendeTurer;
    }
}
