namespace Noodle.components
{
    partial class CompetenciaComponente
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
            nombre = new Label();
            flp = new FlowLayoutPanel();
            container = new FlowLayoutPanel();
            btn_editar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            container.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.BackColor = Color.Transparent;
            nombre.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            nombre.Location = new Point(3, 3);
            nombre.Margin = new Padding(3);
            nombre.MaximumSize = new Size(350, 0);
            nombre.Name = "nombre";
            nombre.Size = new Size(61, 22);
            nombre.TabIndex = 0;
            nombre.Text = "label1";
            nombre.MouseClick += CompetenciaComponente_MouseClick;
            // 
            // flp
            // 
            flp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flp.AutoScroll = true;
            flp.AutoSize = true;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Location = new Point(3, 31);
            flp.Name = "flp";
            flp.Size = new Size(61, 0);
            flp.TabIndex = 1;
            flp.Visible = false;
            flp.WrapContents = false;
            // 
            // container
            // 
            container.AutoSize = true;
            container.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            container.Controls.Add(nombre);
            container.Controls.Add(flp);
            container.FlowDirection = FlowDirection.TopDown;
            container.Location = new Point(3, 3);
            container.Name = "container";
            container.Size = new Size(67, 34);
            container.TabIndex = 2;
            container.WrapContents = false;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editar.AutoSize = true;
            btn_editar.Location = new Point(78, 5);
            btn_editar.Margin = new Padding(5, 5, 20, 5);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(75, 25);
            btn_editar.TabIndex = 3;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(btn_editar, 1, 0);
            tableLayoutPanel1.Controls.Add(container, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(173, 40);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // CompetenciaComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(375, 0);
            Name = "CompetenciaComponente";
            Padding = new Padding(5);
            Size = new Size(375, 48);
            Load += CompetenciaComponente_Load;
            MouseClick += CompetenciaComponente_MouseClick;
            container.ResumeLayout(false);
            container.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label nombre;
        public FlowLayoutPanel flp;
        public FlowLayoutPanel container;
        private TableLayoutPanel tableLayoutPanel1;
        public Button btn_editar;
    }
}
