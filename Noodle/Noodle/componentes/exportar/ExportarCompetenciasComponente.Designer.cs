namespace Noodle.components
{
    partial class ExportarCompetenciasComponente
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
            flp_top = new FlowLayoutPanel();
            titulo = new Label();
            btn_deseleccionar = new Button();
            btn_seleccionar = new Button();
            button1 = new Button();
            flp = new FlowLayoutPanel();
            container.SuspendLayout();
            flp_top.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            container.AutoSize = true;
            container.ColumnCount = 1;
            container.ColumnStyles.Add(new ColumnStyle());
            container.Controls.Add(flp_top, 0, 0);
            container.Controls.Add(flp, 0, 1);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.RowCount = 2;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle());
            container.Size = new Size(600, 150);
            container.TabIndex = 5;
            // 
            // flp_top
            // 
            flp_top.AutoSize = true;
            flp_top.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flp_top.Controls.Add(titulo);
            flp_top.Controls.Add(btn_deseleccionar);
            flp_top.Controls.Add(btn_seleccionar);
            flp_top.Controls.Add(button1);
            flp_top.Dock = DockStyle.Fill;
            flp_top.Location = new Point(3, 3);
            flp_top.Name = "flp_top";
            flp_top.Size = new Size(594, 32);
            flp_top.TabIndex = 5;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            titulo.Location = new Point(5, 5);
            titulo.Margin = new Padding(5);
            titulo.Name = "titulo";
            titulo.Size = new Size(205, 22);
            titulo.TabIndex = 5;
            titulo.Text = "Exportar competencias";
            // 
            // btn_deseleccionar
            // 
            btn_deseleccionar.AutoSize = true;
            btn_deseleccionar.Location = new Point(240, 3);
            btn_deseleccionar.Margin = new Padding(25, 3, 3, 3);
            btn_deseleccionar.Name = "btn_deseleccionar";
            btn_deseleccionar.Size = new Size(112, 25);
            btn_deseleccionar.TabIndex = 2;
            btn_deseleccionar.Text = "Eliminar selección";
            btn_deseleccionar.UseVisualStyleBackColor = true;
            btn_deseleccionar.Click += btn_deseleccionar_Click;
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.AutoSize = true;
            btn_seleccionar.Location = new Point(358, 3);
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.Size = new Size(105, 25);
            btn_seleccionar.TabIndex = 3;
            btn_seleccionar.Text = "Seleccionar todo";
            btn_seleccionar.UseVisualStyleBackColor = true;
            btn_seleccionar.Click += btn_seleccionar_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(516, 3);
            button1.Margin = new Padding(50, 3, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 1;
            button1.Text = "Exportar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flp
            // 
            flp.AutoSize = true;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Location = new Point(3, 41);
            flp.Name = "flp";
            flp.Size = new Size(0, 0);
            flp.TabIndex = 0;
            // 
            // ExportarCompetenciasComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(container);
            Name = "ExportarCompetenciasComponente";
            Size = new Size(600, 150);
            container.ResumeLayout(false);
            container.PerformLayout();
            flp_top.ResumeLayout(false);
            flp_top.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel container;
        private FlowLayoutPanel flp_top;
        private Label titulo;
        private Button btn_deseleccionar;
        private Button btn_seleccionar;
        private Button button1;
        private FlowLayoutPanel flp;
    }
}
