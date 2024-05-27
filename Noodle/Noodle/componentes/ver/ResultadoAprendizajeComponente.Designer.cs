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
            flp = new FlowLayoutPanel();
            container = new TableLayoutPanel();
            nombre = new Label();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // flp
            // 
            flp.AutoSize = true;
            flp.Dock = DockStyle.Fill;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Location = new Point(3, 21);
            flp.Name = "flp";
            flp.Padding = new Padding(5);
            flp.Size = new Size(50, 10);
            flp.TabIndex = 2;
            flp.WrapContents = false;
            // 
            // container
            // 
            container.AutoSize = true;
            container.ColumnCount = 1;
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.Controls.Add(flp, 0, 1);
            container.Controls.Add(nombre, 0, 0);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.RowCount = 2;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.Size = new Size(56, 34);
            container.TabIndex = 3;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nombre.Location = new Point(3, 0);
            nombre.MaximumSize = new Size(650, 0);
            nombre.Name = "nombre";
            nombre.Size = new Size(50, 18);
            nombre.TabIndex = 3;
            nombre.Text = "label1";
            // 
            // ResultadoAprendizajeComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(container);
            Name = "ResultadoAprendizajeComponente";
            Size = new Size(56, 34);
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public FlowLayoutPanel flp;
        private TableLayoutPanel container;
        private Label nombre;
    }
}
