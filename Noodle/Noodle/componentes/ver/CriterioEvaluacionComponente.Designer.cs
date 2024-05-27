namespace Noodle.componentes.ver
{
    partial class CriterioEvaluacionComponente
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
            container = new TableLayoutPanel();
            nombre = new Label();
            descripcion = new Label();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            container.AutoSize = true;
            container.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            container.ColumnCount = 2;
            container.ColumnStyles.Add(new ColumnStyle());
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.Controls.Add(nombre, 0, 0);
            container.Controls.Add(descripcion, 1, 0);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.RowCount = 1;
            container.RowStyles.Add(new RowStyle());
            container.Size = new Size(94, 15);
            container.TabIndex = 0;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nombre.Location = new Point(3, 0);
            nombre.MaximumSize = new Size(100, 0);
            nombre.Name = "nombre";
            nombre.Size = new Size(41, 15);
            nombre.TabIndex = 0;
            nombre.Text = "label1";
            // 
            // descripcion
            // 
            descripcion.AutoSize = true;
            descripcion.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            descripcion.Location = new Point(50, 0);
            descripcion.MaximumSize = new Size(600, 0);
            descripcion.Name = "descripcion";
            descripcion.Size = new Size(41, 15);
            descripcion.TabIndex = 1;
            descripcion.Text = "label2";
            // 
            // CriterioEvaluacionComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(container);
            Name = "CriterioEvaluacionComponente";
            Size = new Size(94, 15);
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel container;
        private Label nombre;
        private Label descripcion;
    }
}
