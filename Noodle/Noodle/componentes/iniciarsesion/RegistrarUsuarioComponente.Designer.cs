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
            tb_password = new TextBox();
            btn_entrar = new Button();
            btn_entrarInvitado = new Button();
            btn_registrarusuario = new Button();
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
            container.Controls.Add(tb_password, 0, 2);
            container.Controls.Add(btn_entrar, 0, 3);
            container.Controls.Add(btn_entrarInvitado, 0, 5);
            container.Controls.Add(btn_registrarusuario, 0, 4);
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
            // tb_password
            // 
            tb_password.Dock = DockStyle.Fill;
            tb_password.Location = new Point(23, 115);
            tb_password.Name = "tb_password";
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
            btn_entrar.Location = new Point(23, 160);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(354, 39);
            btn_entrar.TabIndex = 4;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            // 
            // btn_entrarInvitado
            // 
            btn_entrarInvitado.BackColor = Color.Gray;
            btn_entrarInvitado.Dock = DockStyle.Fill;
            btn_entrarInvitado.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_entrarInvitado.ForeColor = Color.WhiteSmoke;
            btn_entrarInvitado.Location = new Point(23, 250);
            btn_entrarInvitado.Name = "btn_entrarInvitado";
            btn_entrarInvitado.Size = new Size(354, 39);
            btn_entrarInvitado.TabIndex = 5;
            btn_entrarInvitado.Text = "Entrar como invitado";
            btn_entrarInvitado.UseVisualStyleBackColor = false;
            // 
            // btn_registrarusuario
            // 
            btn_registrarusuario.BackColor = Color.SlateGray;
            btn_registrarusuario.Dock = DockStyle.Fill;
            btn_registrarusuario.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_registrarusuario.ForeColor = Color.WhiteSmoke;
            btn_registrarusuario.Location = new Point(23, 205);
            btn_registrarusuario.Name = "btn_registrarusuario";
            btn_registrarusuario.Size = new Size(354, 39);
            btn_registrarusuario.TabIndex = 6;
            btn_registrarusuario.Text = "Registrar nuevo usuario";
            btn_registrarusuario.UseVisualStyleBackColor = false;
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
        public TextBox tb_password;
        private Button btn_entrar;
        private Button btn_entrarInvitado;
        private Button btn_registrarusuario;
    }
}
