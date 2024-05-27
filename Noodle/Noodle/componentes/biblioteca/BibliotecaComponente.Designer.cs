namespace Noodle.components
{
    partial class BibliotecaComponente
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
            flp = new FlowLayoutPanel();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            container.ColumnCount = 1;
            container.ColumnStyles.Add(new ColumnStyle());
            container.Controls.Add(label1, 0, 0);
            container.Controls.Add(flp, 0, 1);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Margin = new Padding(0);
            container.Name = "container";
            container.RowCount = 2;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.Size = new Size(219, 123);
            container.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 5);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(265, 22);
            label1.TabIndex = 0;
            label1.Text = "Biblioteca de competencias";
            // 
            // flp
            // 
            flp.Dock = DockStyle.Fill;
            flp.Location = new Point(3, 35);
            flp.Name = "flp";
            flp.Size = new Size(269, 85);
            flp.TabIndex = 1;
            // 
            // BibliotecaComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(container);
            Name = "BibliotecaComponente";
            Size = new Size(219, 123);
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel container;
        private Label label1;
        private FlowLayoutPanel flp;
    }
}
