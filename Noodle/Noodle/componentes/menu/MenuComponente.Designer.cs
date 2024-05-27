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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_biblioteca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_cargar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_editar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_exportar).BeginInit();
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
            lbl_cargar.Location = new Point(69, 204);
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
            lbl_editar.Location = new Point(69, 270);
            lbl_editar.Name = "lbl_editar";
            lbl_editar.Size = new Size(91, 32);
            lbl_editar.TabIndex = 2;
            lbl_editar.Text = "Editar";
            lbl_editar.TextAlign = ContentAlignment.MiddleLeft;
            lbl_editar.Click += btn_ver;
            // 
            // lbl_exportar
            // 
            lbl_exportar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_exportar.ForeColor = Color.White;
            lbl_exportar.Location = new Point(69, 340);
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
            lbl_biblioteca.Location = new Point(69, 145);
            lbl_biblioteca.Name = "lbl_biblioteca";
            lbl_biblioteca.Size = new Size(91, 32);
            lbl_biblioteca.TabIndex = 4;
            lbl_biblioteca.Text = "Biblioteca";
            lbl_biblioteca.TextAlign = ContentAlignment.MiddleLeft;
            lbl_biblioteca.Click += btn_biblioteca;
            // 
            // img_biblioteca
            // 
            img_biblioteca.BackColor = Color.FromArgb(23, 21, 22);
            img_biblioteca.BackgroundImage = Properties.Resources.img_biblioteca;
            img_biblioteca.BackgroundImageLayout = ImageLayout.Zoom;
            img_biblioteca.Location = new Point(29, 145);
            img_biblioteca.Name = "img_biblioteca";
            img_biblioteca.Size = new Size(32, 32);
            img_biblioteca.TabIndex = 5;
            img_biblioteca.TabStop = false;
            img_biblioteca.Click += btn_biblioteca;
            // 
            // img_cargar
            // 
            img_cargar.BackColor = Color.FromArgb(23, 21, 22);
            img_cargar.BackgroundImage = Properties.Resources.img_cargar;
            img_cargar.BackgroundImageLayout = ImageLayout.Zoom;
            img_cargar.Location = new Point(29, 204);
            img_cargar.Name = "img_cargar";
            img_cargar.Size = new Size(32, 32);
            img_cargar.TabIndex = 6;
            img_cargar.TabStop = false;
            img_cargar.Click += btn_cargar;
            // 
            // img_editar
            // 
            img_editar.BackColor = Color.FromArgb(23, 21, 22);
            img_editar.BackgroundImage = Properties.Resources.img_editar;
            img_editar.BackgroundImageLayout = ImageLayout.Zoom;
            img_editar.Location = new Point(29, 270);
            img_editar.Name = "img_editar";
            img_editar.Size = new Size(32, 32);
            img_editar.TabIndex = 7;
            img_editar.TabStop = false;
            img_editar.Click += btn_ver;
            // 
            // img_exportar
            // 
            img_exportar.BackColor = Color.FromArgb(23, 21, 22);
            img_exportar.BackgroundImage = Properties.Resources.img_exportar;
            img_exportar.BackgroundImageLayout = ImageLayout.Zoom;
            img_exportar.Location = new Point(33, 340);
            img_exportar.Name = "img_exportar";
            img_exportar.Size = new Size(32, 32);
            img_exportar.TabIndex = 8;
            img_exportar.TabStop = false;
            img_exportar.Click += btn_exportar;
            // 
            // MenuComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 22);
            Controls.Add(img_exportar);
            Controls.Add(img_editar);
            Controls.Add(img_cargar);
            Controls.Add(img_biblioteca);
            Controls.Add(lbl_biblioteca);
            Controls.Add(lbl_exportar);
            Controls.Add(lbl_editar);
            Controls.Add(lbl_cargar);
            Controls.Add(pictureBox1);
            Name = "MenuComponente";
            Size = new Size(200, 395);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_biblioteca).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_cargar).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_editar).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_exportar).EndInit();
            ResumeLayout(false);
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
    }
}
