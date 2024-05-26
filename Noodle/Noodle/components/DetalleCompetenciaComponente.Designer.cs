namespace Noodle.components
{
    partial class DetalleCompetenciaComponente
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
            absolutLayout = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            nombreCompetencia = new Label();
            button1 = new Button();
            flp = new FlowLayoutPanel();
            absolutLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // absolutLayout
            // 
            absolutLayout.AutoSize = true;
            absolutLayout.ColumnCount = 1;
            absolutLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            absolutLayout.Controls.Add(tableLayoutPanel1, 0, 0);
            absolutLayout.Controls.Add(flp, 0, 1);
            absolutLayout.Dock = DockStyle.Fill;
            absolutLayout.Location = new Point(0, 0);
            absolutLayout.Name = "absolutLayout";
            absolutLayout.RowCount = 2;
            absolutLayout.RowStyles.Add(new RowStyle());
            absolutLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            absolutLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            absolutLayout.Size = new Size(154, 150);
            absolutLayout.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(nombreCompetencia, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(148, 29);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // nombreCompetencia
            // 
            nombreCompetencia.AutoSize = true;
            nombreCompetencia.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            nombreCompetencia.Location = new Point(3, 0);
            nombreCompetencia.Name = "nombreCompetencia";
            nombreCompetencia.Size = new Size(61, 22);
            nombreCompetencia.TabIndex = 0;
            nombreCompetencia.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(70, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // flp
            // 
            flp.AutoSize = true;
            flp.Dock = DockStyle.Fill;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Location = new Point(3, 38);
            flp.Name = "flp";
            flp.Size = new Size(148, 109);
            flp.TabIndex = 2;
            // 
            // DetalleCompetenciaComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(absolutLayout);
            Name = "DetalleCompetenciaComponente";
            Size = new Size(154, 150);
            absolutLayout.ResumeLayout(false);
            absolutLayout.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TableLayoutPanel absolutLayout;
        public Label nombreCompetencia;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private FlowLayoutPanel flp;
    }
}
