namespace Noodle.components
{
    partial class CompetenciaComponente
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
            nombre = new Label();
            flp = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(3, 11);
            nombre.Name = "nombre";
            nombre.Size = new Size(38, 15);
            nombre.TabIndex = 0;
            nombre.Text = "label1";
            // 
            // flp
            // 
            flp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flp.AutoScroll = true;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Location = new Point(3, 29);
            flp.Name = "flp";
            flp.Size = new Size(239, 118);
            flp.TabIndex = 1;
            flp.WrapContents = false;
            // 
            // CompetenciaComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flp);
            Controls.Add(nombre);
            Name = "CompetenciaComponente";
            Size = new Size(245, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombre;
        private FlowLayoutPanel flp;
    }
}
