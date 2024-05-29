namespace Noodle.componentes.compartir
{
    partial class UsuarioCompartidoComponente
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
            pb_eliminar = new PictureBox();
            nombre = new Label();
            container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_eliminar).BeginInit();
            SuspendLayout();
            // 
            // container
            // 
            container.AutoSize = true;
            container.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            container.ColumnCount = 2;
            container.ColumnStyles.Add(new ColumnStyle());
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.Controls.Add(pb_eliminar, 0, 0);
            container.Controls.Add(nombre, 1, 0);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.RowCount = 1;
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.Size = new Size(89, 38);
            container.TabIndex = 0;
            // 
            // pb_eliminar
            // 
            pb_eliminar.BackgroundImage = Properties.Resources.img_eliminar;
            pb_eliminar.BackgroundImageLayout = ImageLayout.Zoom;
            pb_eliminar.Dock = DockStyle.Fill;
            pb_eliminar.Location = new Point(3, 3);
            pb_eliminar.Name = "pb_eliminar";
            pb_eliminar.Size = new Size(32, 32);
            pb_eliminar.TabIndex = 0;
            pb_eliminar.TabStop = false;
            // 
            // nombre
            // 
            nombre.Anchor = AnchorStyles.None;
            nombre.AutoSize = true;
            nombre.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nombre.Location = new Point(41, 11);
            nombre.Name = "nombre";
            nombre.Size = new Size(45, 16);
            nombre.TabIndex = 1;
            nombre.Text = "label1";
            // 
            // UsuarioCompartidoComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(container);
            Name = "UsuarioCompartidoComponente";
            Size = new Size(89, 38);
            container.ResumeLayout(false);
            container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_eliminar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TableLayoutPanel container;
        private PictureBox pb_eliminar;
        public Label nombre;
    }
}
