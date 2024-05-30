namespace Noodle.components
{
    partial class MenuComponente
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
            pictureBox1 = new PictureBox();
            lbl_cargar = new Label();
            lbl_editar = new Label();
            lbl_exportar = new Label();
            lbl_biblioteca = new Label();
            img_biblioteca = new PictureBox();
            img_cargar = new PictureBox();
            img_editar = new PictureBox();
            img_exportar = new PictureBox();
            absolutlayout = new TableLayoutPanel();
            container = new TableLayoutPanel();
            lbl_ver = new Label();
            img_ver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_biblioteca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_cargar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_editar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_exportar).BeginInit();
            absolutlayout.SuspendLayout();
            container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_ver).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.img_logotipoNoodleExtendidoInvertido;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 110);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_cargar
            // 
            lbl_cargar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cargar.ForeColor = Color.White;
            lbl_cargar.Location = new Point(95, 50);
            lbl_cargar.Margin = new Padding(5);
            lbl_cargar.Name = "lbl_cargar";
            lbl_cargar.Size = new Size(91, 32);
            lbl_cargar.TabIndex = 1;
            lbl_cargar.Text = "Cargar";
            lbl_cargar.TextAlign = ContentAlignment.MiddleLeft;
            lbl_cargar.Click += btn_cargar;
            // 
            // lbl_editar
            // 
            lbl_editar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_editar.ForeColor = Color.White;
            lbl_editar.Location = new Point(95, 134);
            lbl_editar.Margin = new Padding(5);
            lbl_editar.Name = "lbl_editar";
            lbl_editar.Size = new Size(91, 32);
            lbl_editar.TabIndex = 2;
            lbl_editar.Text = "Editar";
            lbl_editar.TextAlign = ContentAlignment.MiddleLeft;
            lbl_editar.Click += btn_editar;
            // 
            // lbl_exportar
            // 
            lbl_exportar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_exportar.ForeColor = Color.White;
            lbl_exportar.Location = new Point(95, 176);
            lbl_exportar.Margin = new Padding(5);
            lbl_exportar.Name = "lbl_exportar";
            lbl_exportar.Size = new Size(91, 32);
            lbl_exportar.TabIndex = 3;
            lbl_exportar.Text = "Exportar";
            lbl_exportar.TextAlign = ContentAlignment.MiddleLeft;
            lbl_exportar.Click += btn_exportar;
            // 
            // lbl_biblioteca
            // 
            lbl_biblioteca.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_biblioteca.ForeColor = Color.White;
            lbl_biblioteca.Location = new Point(95, 8);
            lbl_biblioteca.Margin = new Padding(5);
            lbl_biblioteca.Name = "lbl_biblioteca";
            lbl_biblioteca.Size = new Size(91, 32);
            lbl_biblioteca.TabIndex = 4;
            lbl_biblioteca.Text = "Biblioteca";
            lbl_biblioteca.TextAlign = ContentAlignment.MiddleLeft;
            lbl_biblioteca.Click += btn_biblioteca;
            // 
            // img_biblioteca
            // 
            img_biblioteca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            img_biblioteca.BackColor = Color.FromArgb(23, 21, 22);
            img_biblioteca.BackgroundImage = Properties.Resources.img_biblioteca;
            img_biblioteca.BackgroundImageLayout = ImageLayout.Zoom;
            img_biblioteca.Location = new Point(53, 8);
            img_biblioteca.Margin = new Padding(5);
            img_biblioteca.Name = "img_biblioteca";
            img_biblioteca.Size = new Size(32, 32);
            img_biblioteca.TabIndex = 5;
            img_biblioteca.TabStop = false;
            img_biblioteca.Click += btn_biblioteca;
            // 
            // img_cargar
            // 
            img_cargar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            img_cargar.BackColor = Color.FromArgb(23, 21, 22);
            img_cargar.BackgroundImage = Properties.Resources.img_cargar;
            img_cargar.BackgroundImageLayout = ImageLayout.Zoom;
            img_cargar.Location = new Point(53, 50);
            img_cargar.Margin = new Padding(5);
            img_cargar.Name = "img_cargar";
            img_cargar.Size = new Size(32, 32);
            img_cargar.TabIndex = 6;
            img_cargar.TabStop = false;
            img_cargar.Click += btn_cargar;
            // 
            // img_editar
            // 
            img_editar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            img_editar.BackColor = Color.FromArgb(23, 21, 22);
            img_editar.BackgroundImage = Properties.Resources.img_editar;
            img_editar.BackgroundImageLayout = ImageLayout.Zoom;
            img_editar.Location = new Point(53, 134);
            img_editar.Margin = new Padding(5);
            img_editar.Name = "img_editar";
            img_editar.Size = new Size(32, 32);
            img_editar.TabIndex = 7;
            img_editar.TabStop = false;
            img_editar.Click += btn_editar;
            // 
            // img_exportar
            // 
            img_exportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            img_exportar.BackColor = Color.FromArgb(23, 21, 22);
            img_exportar.BackgroundImage = Properties.Resources.img_exportar;
            img_exportar.BackgroundImageLayout = ImageLayout.Zoom;
            img_exportar.Location = new Point(53, 176);
            img_exportar.Margin = new Padding(5);
            img_exportar.Name = "img_exportar";
            img_exportar.Size = new Size(32, 32);
            img_exportar.TabIndex = 8;
            img_exportar.TabStop = false;
            img_exportar.Click += btn_exportar;
            // 
            // absolutlayout
            // 
            absolutlayout.AutoSize = true;
            absolutlayout.ColumnCount = 1;
            absolutlayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            absolutlayout.Controls.Add(pictureBox1, 0, 0);
            absolutlayout.Controls.Add(container, 0, 1);
            absolutlayout.Dock = DockStyle.Fill;
            absolutlayout.Location = new Point(0, 0);
            absolutlayout.Name = "absolutlayout";
            absolutlayout.RowCount = 2;
            absolutlayout.RowStyles.Add(new RowStyle());
            absolutlayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            absolutlayout.Size = new Size(200, 395);
            absolutlayout.TabIndex = 9;
            // 
            // container
            // 
            container.ColumnCount = 2;
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.ColumnStyles.Add(new ColumnStyle());
            container.Controls.Add(lbl_ver, 1, 2);
            container.Controls.Add(lbl_biblioteca, 1, 0);
            container.Controls.Add(img_biblioteca, 0, 0);
            container.Controls.Add(img_ver, 0, 2);
            container.Controls.Add(img_editar, 0, 3);
            container.Controls.Add(img_exportar, 0, 4);
            container.Controls.Add(lbl_editar, 1, 3);
            container.Controls.Add(lbl_exportar, 1, 4);
            container.Controls.Add(img_cargar, 0, 1);
            container.Controls.Add(lbl_cargar, 1, 1);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(3, 136);
            container.Margin = new Padding(3, 20, 3, 3);
            container.Name = "container";
            container.Padding = new Padding(3);
            container.RowCount = 6;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.Size = new Size(194, 256);
            container.TabIndex = 1;
            // 
            // lbl_ver
            // 
            lbl_ver.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ver.ForeColor = Color.White;
            lbl_ver.Location = new Point(95, 92);
            lbl_ver.Margin = new Padding(5);
            lbl_ver.Name = "lbl_ver";
            lbl_ver.Size = new Size(91, 32);
            lbl_ver.TabIndex = 10;
            lbl_ver.Text = "Ver";
            lbl_ver.TextAlign = ContentAlignment.MiddleLeft;
            lbl_ver.Click += btn_ver;
            // 
            // img_ver
            // 
            img_ver.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            img_ver.BackColor = Color.FromArgb(23, 21, 22);
            img_ver.BackgroundImage = Properties.Resources.img_editar;
            img_ver.BackgroundImageLayout = ImageLayout.Zoom;
            img_ver.Location = new Point(53, 92);
            img_ver.Margin = new Padding(5);
            img_ver.Name = "img_ver";
            img_ver.Size = new Size(32, 32);
            img_ver.TabIndex = 9;
            img_ver.TabStop = false;
            img_ver.Click += btn_ver;
            // 
            // MenuComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 22);
            Controls.Add(absolutlayout);
            Name = "MenuComponente";
            Size = new Size(200, 395);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_biblioteca).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_cargar).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_editar).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_exportar).EndInit();
            absolutlayout.ResumeLayout(false);
            container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_ver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_cargar;
        private Label lbl_editar;
        private Label lbl_exportar;
        private Label lbl_biblioteca;
        private PictureBox img_biblioteca;
        private PictureBox img_cargar;
        private PictureBox img_editar;
        private PictureBox img_exportar;
        public TableLayoutPanel absolutlayout;
        public TableLayoutPanel container;
        private Label lbl_ver;
        public PictureBox img_ver;
    }
}
