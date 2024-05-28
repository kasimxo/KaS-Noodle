namespace Noodle.componentes.iniciarsesion
{
    partial class RegistrarUsuarioComponente
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
            label1 = new Label();
            tb_username = new TextBox();
            tb_password2 = new TextBox();
            btn_crearUsuario = new Button();
            btn_volverInicioSesion = new Button();
            tb_password1 = new TextBox();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            container.AutoSize = true;
            container.ColumnCount = 1;
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.Controls.Add(label1, 0, 0);
            container.Controls.Add(tb_username, 0, 1);
            container.Controls.Add(tb_password2, 0, 3);
            container.Controls.Add(btn_crearUsuario, 0, 4);
            container.Controls.Add(btn_volverInicioSesion, 0, 5);
            container.Controls.Add(tb_password1, 0, 2);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.Padding = new Padding(20);
            container.RowCount = 6;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            container.Size = new Size(400, 312);
            container.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 20);
            label1.Margin = new Padding(3, 0, 3, 25);
            label1.Name = "label1";
            label1.Size = new Size(171, 22);
            label1.TabIndex = 0;
            label1.Text = "Registrar usuario";
            // 
            // tb_username
            // 
            tb_username.Dock = DockStyle.Fill;
            tb_username.Location = new Point(23, 70);
            tb_username.Name = "tb_username";
            tb_username.PlaceholderText = "Nombre de usuario";
            tb_username.Size = new Size(354, 23);
            tb_username.TabIndex = 1;
            // 
            // tb_password2
            // 
            tb_password2.Dock = DockStyle.Fill;
            tb_password2.Location = new Point(23, 160);
            tb_password2.Name = "tb_password2";
            tb_password2.PlaceholderText = "Confirmar contraseña";
            tb_password2.Size = new Size(354, 23);
            tb_password2.TabIndex = 3;
            // 
            // btn_crearUsuario
            // 
            btn_crearUsuario.BackColor = Color.RoyalBlue;
            btn_crearUsuario.Dock = DockStyle.Fill;
            btn_crearUsuario.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_crearUsuario.ForeColor = Color.WhiteSmoke;
            btn_crearUsuario.Location = new Point(23, 205);
            btn_crearUsuario.Name = "btn_crearUsuario";
            btn_crearUsuario.Size = new Size(354, 39);
            btn_crearUsuario.TabIndex = 4;
            btn_crearUsuario.Text = "Crear usuario";
            btn_crearUsuario.UseVisualStyleBackColor = false;
            btn_crearUsuario.Click += crearUsuario_Click;
            // 
            // btn_volverInicioSesion
            // 
            btn_volverInicioSesion.BackColor = Color.Gray;
            btn_volverInicioSesion.Dock = DockStyle.Fill;
            btn_volverInicioSesion.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_volverInicioSesion.ForeColor = Color.WhiteSmoke;
            btn_volverInicioSesion.Location = new Point(23, 250);
            btn_volverInicioSesion.Name = "btn_volverInicioSesion";
            btn_volverInicioSesion.Size = new Size(354, 39);
            btn_volverInicioSesion.TabIndex = 5;
            btn_volverInicioSesion.Text = "¿Tienes una cuenta? Inicia sesión";
            btn_volverInicioSesion.UseVisualStyleBackColor = false;
            btn_volverInicioSesion.Click += mostrarIniciaSesion;
            // 
            // tb_password1
            // 
            tb_password1.Dock = DockStyle.Fill;
            tb_password1.Location = new Point(23, 115);
            tb_password1.Name = "tb_password1";
            tb_password1.PlaceholderText = "Contraseña";
            tb_password1.Size = new Size(354, 23);
            tb_password1.TabIndex = 6;
            // 
            // RegistrarUsuarioComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            Controls.Add(container);
            Name = "RegistrarUsuarioComponente";
            Size = new Size(400, 312);
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TableLayoutPanel container;
        private Label label1;
        public TextBox tb_username;
        public TextBox tb_password2;
        private Button btn_crearUsuario;
        private Button btn_volverInicioSesion;
        public TextBox tb_password1;
    }
}
