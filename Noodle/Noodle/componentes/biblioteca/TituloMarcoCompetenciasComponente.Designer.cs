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
            pictureBox1 = new PictureBox();
            container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            container.ColumnCount = 2;
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.ColumnStyles.Add(new ColumnStyle());
            container.Controls.Add(titulo, 0, 0);
            container.Controls.Add(pictureBox1, 1, 0);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(10, 10);
            container.Name = "container";
            container.RowCount = 1;
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.Size = new Size(147, 56);
            container.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.img_eliminar;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(94, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += eliminarMarco_Click;
            pictureBox1.MouseEnter += hoverEffect;
            pictureBox1.MouseLeave += resetColorEffect;
            pictureBox1.MouseHover += hoverEffect;
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
            Size = new Size(167, 76);
            Click += titulo_Click;
            container.ResumeLayout(false);
            container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private TableLayoutPanel container;
        private PictureBox pictureBox1;
    }
}
