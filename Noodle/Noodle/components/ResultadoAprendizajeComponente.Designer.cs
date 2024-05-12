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
            flp = new FlowLayoutPanel();
            container = new FlowLayoutPanel();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(3, 0);
            nombre.MaximumSize = new Size(400, 1000);
            nombre.Name = "nombre";
            nombre.Size = new Size(38, 15);
            nombre.TabIndex = 0;
            nombre.Text = "label1";
            // 
            // flp
            // 
            flp.AutoSize = true;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Location = new Point(3, 18);
            flp.Name = "flp";
            flp.Size = new Size(0, 0);
            flp.TabIndex = 1;
            // 
            // container
            // 
            container.AutoSize = true;
            container.Controls.Add(nombre);
            container.Controls.Add(flp);
            container.FlowDirection = FlowDirection.TopDown;
            container.Location = new Point(3, 3);
            container.Name = "container";
            container.Size = new Size(200, 100);
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
        public FlowLayoutPanel flp;
        public FlowLayoutPanel container;
    }
}
