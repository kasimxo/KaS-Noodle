namespace Noodle.componentes.iniciarsesion
{
    partial class IniciarSesionComponente
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
            tb_password = new TextBox();
            btn_entrar = new Button();
            btn_entrarInvitado = new Button();
            btn_registrarusuario = new Button();
            label2 = new Label();
            label3 = new Label();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            container.ColumnCount = 1;
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.Controls.Add(label1, 0, 0);
            container.Controls.Add(tb_username, 0, 2);
            container.Controls.Add(tb_password, 0, 4);
            container.Controls.Add(btn_entrar, 0, 5);
            container.Controls.Add(btn_entrarInvitado, 0, 7);
            container.Controls.Add(btn_registrarusuario, 0, 6);
            container.Controls.Add(label2, 0, 1);
            container.Controls.Add(label3, 0, 3);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.Padding = new Padding(20);
            container.RowCount = 8;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            container.Size = new Size(400, 300);
            container.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 20);
            label1.Margin = new Padding(3, 0, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(134, 22);
            label1.TabIndex = 0;
            label1.Text = "Iniciar sesión";
            // 
            // tb_username
            // 
            tb_username.Dock = DockStyle.Fill;
            tb_username.Location = new Point(23, 80);
            tb_username.Name = "tb_username";
            tb_username.PlaceholderText = "Nombre de usuario";
            tb_username.Size = new Size(354, 23);
            tb_username.TabIndex = 1;
            // 
            // tb_password
            // 
            tb_password.Dock = DockStyle.Fill;
            tb_password.Location = new Point(23, 124);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.PlaceholderText = "Contraseña";
            tb_password.Size = new Size(354, 23);
            tb_password.TabIndex = 3;
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.RoyalBlue;
            btn_entrar.Dock = DockStyle.Fill;
            btn_entrar.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_entrar.ForeColor = Color.WhiteSmoke;
            btn_entrar.Location = new Point(23, 153);
            btn_entrar.MaximumSize = new Size(0, 37);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(354, 37);
            btn_entrar.TabIndex = 4;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += iniciarSesion;
            // 
            // btn_entrarInvitado
            // 
            btn_entrarInvitado.BackColor = Color.Gray;
            btn_entrarInvitado.Dock = DockStyle.Fill;
            btn_entrarInvitado.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_entrarInvitado.ForeColor = Color.WhiteSmoke;
            btn_entrarInvitado.Location = new Point(23, 239);
            btn_entrarInvitado.MaximumSize = new Size(0, 37);
            btn_entrarInvitado.Name = "btn_entrarInvitado";
            btn_entrarInvitado.Size = new Size(354, 37);
            btn_entrarInvitado.TabIndex = 5;
            btn_entrarInvitado.Text = "Entrar como invitado";
            btn_entrarInvitado.UseVisualStyleBackColor = false;
            btn_entrarInvitado.Click += entrarInvitado;
            // 
            // btn_registrarusuario
            // 
            btn_registrarusuario.BackColor = Color.SlateGray;
            btn_registrarusuario.Dock = DockStyle.Fill;
            btn_registrarusuario.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_registrarusuario.ForeColor = Color.WhiteSmoke;
            btn_registrarusuario.Location = new Point(23, 196);
            btn_registrarusuario.MaximumSize = new Size(0, 37);
            btn_registrarusuario.Name = "btn_registrarusuario";
            btn_registrarusuario.Size = new Size(354, 37);
            btn_registrarusuario.TabIndex = 6;
            btn_registrarusuario.Text = "Registrar nuevo usuario";
            btn_registrarusuario.UseVisualStyleBackColor = false;
            btn_registrarusuario.Click += abrirFormRegistrarUsuario;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 62);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre de usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 106);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 8;
            label3.Text = "Contraseña";
            // 
            // IniciarSesionComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(container);
            Name = "IniciarSesionComponente";
            Size = new Size(400, 300);
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button btn_entrar;
        private Button btn_entrarInvitado;
        private Button btn_registrarusuario;
        public TextBox tb_username;
        public TextBox tb_password;
        public TableLayoutPanel container;
        private Label label2;
        private Label label3;
    }
}
