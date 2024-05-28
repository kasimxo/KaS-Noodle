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
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_compartir = new Button();
            btn_cancelar = new Button();
            label3 = new Label();
            tb_username = new TextBox();
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
            container.Controls.Add(label1, 0, 0);
            container.Controls.Add(tableLayoutPanel2, 0, 1);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.Padding = new Padding(5);
            container.RowCount = 2;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            container.Size = new Size(434, 161);
            container.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(330, 22);
            label1.TabIndex = 0;
            label1.Text = "Compartir marco de competencias";
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
            tableLayoutPanel2.Location = new Point(25, 47);
            tableLayoutPanel2.Margin = new Padding(20);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(384, 89);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_compartir
            // 
            btn_compartir.AutoSize = true;
            btn_compartir.BackColor = Color.RoyalBlue;
            btn_compartir.Dock = DockStyle.Fill;
            btn_compartir.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_compartir.ForeColor = Color.WhiteSmoke;
            btn_compartir.Location = new Point(211, 56);
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
            btn_cancelar.Location = new Point(72, 56);
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
            label3.Location = new Point(74, 29);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre de usuario";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(211, 27);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(100, 23);
            tb_username.TabIndex = 7;
            toolTip1.SetToolTip(tb_username, "Escribe aquí el nombre de usuario con quien deseas compartir este marco de competencias");
            // 
            // CompartirMarcoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(434, 161);
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
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private ToolTip toolTip1;
        public Button btn_compartir;
        public Button btn_cancelar;
        public TextBox tb_username;
    }
}