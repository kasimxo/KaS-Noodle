namespace Noodle.view
{
    partial class EditarCompetenciasView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flp = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flp
            // 
            flp.AutoScroll = true;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Location = new Point(12, 12);
            flp.Name = "flp";
            flp.Size = new Size(776, 426);
            flp.TabIndex = 0;
            flp.WrapContents = false;
            // 
            // EditarCompetenciasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flp);
            Name = "EditarCompetenciasView";
            Text = "EditarCompetenciasView";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flp;
    }
}