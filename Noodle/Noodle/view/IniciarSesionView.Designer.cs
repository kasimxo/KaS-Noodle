namespace Noodle.view
{
    partial class IniciarSesionView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesionView));
            container = new TableLayoutPanel();
            logo = new PictureBox();
            iniciarSesionComponente1 = new componentes.iniciarsesion.IniciarSesionComponente();
            container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // container
            // 
            container.Anchor = AnchorStyles.None;
            container.AutoSize = true;
            container.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            container.ColumnCount = 1;
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.Controls.Add(logo, 0, 0);
            container.Controls.Add(iniciarSesionComponente1, 0, 1);
            container.Location = new Point(197, 29);
            container.Name = "container";
            container.RowCount = 2;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.Size = new Size(406, 392);
            container.TabIndex = 0;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            logo.BackgroundImage = Properties.Resources.img_logotipoNoodleExtendidoInvertido;
            logo.BackgroundImageLayout = ImageLayout.Zoom;
            logo.Location = new Point(3, 3);
            logo.Name = "logo";
            logo.Size = new Size(400, 80);
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // iniciarSesionComponente1
            // 
            iniciarSesionComponente1.BackColor = Color.WhiteSmoke;
            iniciarSesionComponente1.Location = new Point(3, 89);
            iniciarSesionComponente1.Name = "iniciarSesionComponente1";
            iniciarSesionComponente1.Size = new Size(400, 300);
            iniciarSesionComponente1.TabIndex = 1;
            // 
            // IniciarSesionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 22);
            ClientSize = new Size(800, 450);
            Controls.Add(container);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IniciarSesionView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Noodle";
            container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public PictureBox logo;
        public componentes.iniciarsesion.IniciarSesionComponente iniciarSesionComponente1;
        public TableLayoutPanel container;
    }
}