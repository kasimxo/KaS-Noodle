namespace Noodle.components
{
    partial class TituloMarcoCompetenciasComponente
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
            titulo = new Label();
            container = new TableLayoutPanel();
            pb_eliminar = new PictureBox();
            pb_compartir = new PictureBox();
            container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_eliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_compartir).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            titulo.Location = new Point(15, 15);
            titulo.Margin = new Padding(15);
            titulo.Name = "titulo";
            titulo.Size = new Size(61, 22);
            titulo.TabIndex = 0;
            titulo.Text = "label1";
            titulo.TextAlign = ContentAlignment.MiddleLeft;
            titulo.Click += titulo_Click;
            titulo.MouseEnter += hoverEffect;
            titulo.MouseLeave += resetColorEffect;
            // 
            // container
            // 
            container.AutoSize = true;
            container.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            container.ColumnCount = 3;
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.ColumnStyles.Add(new ColumnStyle());
            container.ColumnStyles.Add(new ColumnStyle());
            container.Controls.Add(titulo, 0, 0);
            container.Controls.Add(pb_eliminar, 2, 0);
            container.Controls.Add(pb_compartir, 1, 0);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(10, 10);
            container.Name = "container";
            container.RowCount = 1;
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.Size = new Size(203, 56);
            container.TabIndex = 1;
            // 
            // pb_eliminar
            // 
            pb_eliminar.BackgroundImage = Properties.Resources.img_eliminar;
            pb_eliminar.BackgroundImageLayout = ImageLayout.Zoom;
            pb_eliminar.Location = new Point(150, 3);
            pb_eliminar.Name = "pb_eliminar";
            pb_eliminar.Size = new Size(50, 50);
            pb_eliminar.TabIndex = 1;
            pb_eliminar.TabStop = false;
            pb_eliminar.Click += eliminarMarco_Click;
            pb_eliminar.MouseEnter += hoverEffect;
            pb_eliminar.MouseLeave += resetColorEffect;
            pb_eliminar.MouseHover += hoverEffect;
            // 
            // pb_compartir
            // 
            pb_compartir.BackgroundImage = Properties.Resources.img_compartir;
            pb_compartir.BackgroundImageLayout = ImageLayout.Zoom;
            pb_compartir.Location = new Point(94, 3);
            pb_compartir.Name = "pb_compartir";
            pb_compartir.Size = new Size(50, 50);
            pb_compartir.TabIndex = 2;
            pb_compartir.TabStop = false;
            pb_compartir.Click += compartirMarco_Click;
            pb_compartir.MouseEnter += hoverEffect;
            pb_compartir.MouseLeave += resetColorEffect;
            // 
            // TituloMarcoCompetenciasComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 192, 255);
            Controls.Add(container);
            Margin = new Padding(25);
            Name = "TituloMarcoCompetenciasComponente";
            Padding = new Padding(10);
            Size = new Size(223, 76);
            Click += titulo_Click;
            container.ResumeLayout(false);
            container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_eliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_compartir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private TableLayoutPanel container;
        private PictureBox pb_eliminar;
        private PictureBox pb_compartir;
    }
}
