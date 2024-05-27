namespace Noodle.components
{
    partial class VerCompetenciasComponente
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
            flp = new FlowLayoutPanel();
            absolutLayout = new TableLayoutPanel();
            NombreMarco = new Label();
            btn_exportar = new Button();
            container.SuspendLayout();
            absolutLayout.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            container.AutoSize = true;
            container.ColumnCount = 2;
            container.ColumnStyles.Add(new ColumnStyle());
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.Controls.Add(flp, 0, 0);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(3, 35);
            container.Name = "container";
            container.RowCount = 1;
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.Size = new Size(144, 83);
            container.TabIndex = 0;
            // 
            // flp
            // 
            flp.AutoSize = true;
            flp.Dock = DockStyle.Fill;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Location = new Point(3, 3);
            flp.Name = "flp";
            flp.Size = new Size(1, 1);
            flp.TabIndex = 0;
            // 
            // absolutLayout
            // 
            absolutLayout.AutoSize = true;
            absolutLayout.ColumnCount = 1;
            absolutLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            absolutLayout.Controls.Add(NombreMarco, 0, 0);
            absolutLayout.Controls.Add(container, 0, 1);
            absolutLayout.Controls.Add(btn_exportar, 0, 2);
            absolutLayout.Dock = DockStyle.Fill;
            absolutLayout.Location = new Point(0, 0);
            absolutLayout.Name = "absolutLayout";
            absolutLayout.RowCount = 3;
            absolutLayout.RowStyles.Add(new RowStyle());
            absolutLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            absolutLayout.RowStyles.Add(new RowStyle());
            absolutLayout.Size = new Size(150, 150);
            absolutLayout.TabIndex = 2;
            // 
            // NombreMarco
            // 
            NombreMarco.AutoSize = true;
            NombreMarco.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            NombreMarco.Location = new Point(5, 5);
            NombreMarco.Margin = new Padding(5);
            NombreMarco.Name = "NombreMarco";
            NombreMarco.Size = new Size(65, 22);
            NombreMarco.TabIndex = 1;
            NombreMarco.Text = "label1";
            // 
            // btn_exportar
            // 
            btn_exportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_exportar.Location = new Point(72, 124);
            btn_exportar.Name = "btn_exportar";
            btn_exportar.Size = new Size(75, 23);
            btn_exportar.TabIndex = 2;
            btn_exportar.Text = "Export";
            btn_exportar.UseVisualStyleBackColor = true;
            btn_exportar.Click += btn_exportar_Click;
            // 
            // VerCompetenciasComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(absolutLayout);
            Name = "VerCompetenciasComponente";
            container.ResumeLayout(false);
            container.PerformLayout();
            absolutLayout.ResumeLayout(false);
            absolutLayout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TableLayoutPanel container;
        private FlowLayoutPanel flp;
        public Label NombreMarco;
        public TableLayoutPanel absolutLayout;
        private Button btn_exportar;
    }
}
