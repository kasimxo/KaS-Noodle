namespace Noodle.componentes.editar
{
    partial class CriterioEvaluacionEditableComponente
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
            identificador = new Label();
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
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            container.Controls.Add(identificador, 0, 0);
            container.Controls.Add(descripcion, 1, 0);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.RowCount = 1;
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.Size = new Size(94, 15);
            container.TabIndex = 0;
            // 
            // identificador
            // 
            identificador.AutoSize = true;
            identificador.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            identificador.Location = new Point(3, 0);
            identificador.Name = "identificador";
            identificador.Size = new Size(41, 15);
            identificador.TabIndex = 0;
            identificador.Text = "label1";
            identificador.Click += convertirEditable;
            // 
            // descripcion
            // 
            descripcion.AutoSize = true;
            descripcion.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            descripcion.Location = new Point(50, 0);
            descripcion.MaximumSize = new Size(475, 0);
            descripcion.Name = "descripcion";
            descripcion.Size = new Size(41, 15);
            descripcion.TabIndex = 1;
            descripcion.Text = "label1";
            descripcion.Click += convertirEditable;
            // 
            // CriterioEvaluacionEditableComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(container);
            Name = "CriterioEvaluacionEditableComponente";
            Size = new Size(94, 15);
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel container;
        private Label identificador;
        private Label descripcion;
    }
}
