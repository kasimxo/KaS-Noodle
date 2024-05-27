namespace Noodle.componentes.editar
{
    partial class DetalleCompetenciaEditable
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
            container = new TableLayoutPanel();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.BackColor = Color.Transparent;
            nombre.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            nombre.Location = new Point(3, 3);
            nombre.Margin = new Padding(3);
            nombre.MaximumSize = new Size(350, 0);
            nombre.Name = "nombre";
            nombre.Size = new Size(61, 22);
            nombre.TabIndex = 0;
            nombre.Text = "label1";
            nombre.Click += convertirEditable;
            // 
            // flp
            // 
            flp.AutoScroll = true;
            flp.AutoSize = true;
            flp.BackColor = Color.Transparent;
            flp.Dock = DockStyle.Fill;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Location = new Point(3, 31);
            flp.Name = "flp";
            flp.Size = new Size(144, 116);
            flp.TabIndex = 1;
            flp.WrapContents = false;
            // 
            // container
            // 
            container.AutoSize = true;
            container.ColumnCount = 1;
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.Controls.Add(nombre, 0, 0);
            container.Controls.Add(flp, 0, 1);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.RowCount = 2;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.Size = new Size(150, 150);
            container.TabIndex = 6;
            // 
            // DetalleCompetenciaEditable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(container);
            Name = "DetalleCompetenciaEditable";
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label nombre;
        public FlowLayoutPanel flp;
        private TableLayoutPanel container;
    }
}
