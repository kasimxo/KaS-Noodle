namespace Noodle.view
{
    partial class CompartirMarcoView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompartirMarcoView));
            container = new TableLayoutPanel();
            titulo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_compartir = new Button();
            btn_cancelar = new Button();
            label3 = new Label();
            tb_username = new TextBox();
            texto_compartidocon = new Label();
            flp = new FlowLayoutPanel();
            toolTip1 = new ToolTip(components);
            container.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            container.AutoSize = true;
            container.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            container.ColumnCount = 1;
            container.ColumnStyles.Add(new ColumnStyle());
            container.Controls.Add(titulo, 0, 0);
            container.Controls.Add(tableLayoutPanel2, 0, 3);
            container.Controls.Add(texto_compartidocon, 0, 1);
            container.Controls.Add(flp, 0, 2);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.Padding = new Padding(5);
            container.RowCount = 4;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.Size = new Size(434, 361);
            container.TabIndex = 0;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            titulo.Location = new Point(8, 5);
            titulo.Name = "titulo";
            titulo.Size = new Size(330, 22);
            titulo.TabIndex = 0;
            titulo.Text = "Compartir marco de competencias";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btn_compartir, 3, 2);
            tableLayoutPanel2.Controls.Add(btn_cancelar, 1, 2);
            tableLayoutPanel2.Controls.Add(label3, 1, 1);
            tableLayoutPanel2.Controls.Add(tb_username, 3, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(25, 68);
            tableLayoutPanel2.Margin = new Padding(20);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(384, 268);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_compartir
            // 
            btn_compartir.AutoSize = true;
            btn_compartir.BackColor = Color.RoyalBlue;
            btn_compartir.Dock = DockStyle.Fill;
            btn_compartir.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_compartir.ForeColor = Color.WhiteSmoke;
            btn_compartir.Location = new Point(211, 133);
            btn_compartir.Name = "btn_compartir";
            btn_compartir.Size = new Size(100, 30);
            btn_compartir.TabIndex = 2;
            btn_compartir.Text = "Compartir";
            btn_compartir.UseVisualStyleBackColor = false;
            btn_compartir.Click += btn_compartir_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.AutoSize = true;
            btn_cancelar.BackColor = Color.Gray;
            btn_cancelar.Dock = DockStyle.Fill;
            btn_cancelar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.WhiteSmoke;
            btn_cancelar.Location = new Point(72, 133);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(113, 30);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 106);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre de usuario";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(211, 104);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(100, 23);
            tb_username.TabIndex = 7;
            toolTip1.SetToolTip(tb_username, "Escribe aquí el nombre de usuario con quien deseas compartir este marco de competencias");
            // 
            // texto_compartidocon
            // 
            texto_compartidocon.AutoSize = true;
            texto_compartidocon.Location = new Point(25, 27);
            texto_compartidocon.Margin = new Padding(20, 0, 3, 0);
            texto_compartidocon.Name = "texto_compartidocon";
            texto_compartidocon.Size = new Size(251, 15);
            texto_compartidocon.TabIndex = 2;
            texto_compartidocon.Text = "Actualmente este marco está compartido con:";
            // 
            // flp
            // 
            flp.AutoSize = true;
            flp.Dock = DockStyle.Fill;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Location = new Point(8, 45);
            flp.MaximumSize = new Size(0, 100);
            flp.Name = "flp";
            flp.Size = new Size(418, 1);
            flp.TabIndex = 3;
            // 
            // CompartirMarcoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(434, 361);
            Controls.Add(container);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CompartirMarcoView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Noodle";
            container.ResumeLayout(false);
            container.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel container;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private ToolTip toolTip1;
        public Button btn_compartir;
        public Button btn_cancelar;
        public TextBox tb_username;
        public Label titulo;
        public Label texto_compartidocon;
        public FlowLayoutPanel flp;
    }
}