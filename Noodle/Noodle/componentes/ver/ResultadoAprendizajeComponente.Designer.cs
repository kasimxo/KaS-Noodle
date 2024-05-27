namespace Noodle.components
{
    partial class ResultadoAprendizajeComponente
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
            container = new FlowLayoutPanel();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nombre.AutoSize = true;
            nombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nombre.Location = new Point(3, 0);
            nombre.Name = "nombre";
            nombre.Size = new Size(54, 18);
            nombre.TabIndex = 0;
            nombre.Text = "talabel";
            // 
            // container
            // 
            container.AutoSize = true;
            container.Controls.Add(nombre);
            container.Dock = DockStyle.Fill;
            container.FlowDirection = FlowDirection.TopDown;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.Size = new Size(346, 137);
            container.TabIndex = 2;
            // 
            // ResultadoAprendizajeComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(container);
            Name = "ResultadoAprendizajeComponente";
            Size = new Size(346, 137);
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label nombre;
        public FlowLayoutPanel container;
    }
}
