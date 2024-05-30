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
            flp_marcospropios = new FlowLayoutPanel();
            label2 = new Label();
            flp_marcoscompartidos = new FlowLayoutPanel();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            container.AutoSize = true;
            container.ColumnCount = 1;
            container.ColumnStyles.Add(new ColumnStyle());
            container.Controls.Add(label1, 0, 0);
            container.Controls.Add(flp_marcospropios, 0, 1);
            container.Controls.Add(label2, 0, 2);
            container.Controls.Add(flp_marcoscompartidos, 0, 3);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Margin = new Padding(0);
            container.Name = "container";
            container.RowCount = 4;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            container.Size = new Size(446, 236);
            container.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 5);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(243, 22);
            label1.TabIndex = 0;
            label1.Text = "Marcos de competencias";
            // 
            // flp_marcospropios
            // 
            flp_marcospropios.Dock = DockStyle.Fill;
            flp_marcospropios.Location = new Point(3, 35);
            flp_marcospropios.Name = "flp_marcospropios";
            flp_marcospropios.Size = new Size(440, 85);
            flp_marcospropios.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 123);
            label2.Name = "label2";
            label2.Size = new Size(440, 22);
            label2.TabIndex = 2;
            label2.Text = "Marcos de competencias compartidos contigo";
            // 
            // flp_marcoscompartidos
            // 
            flp_marcoscompartidos.AutoSize = true;
            flp_marcoscompartidos.Dock = DockStyle.Fill;
            flp_marcoscompartidos.FlowDirection = FlowDirection.TopDown;
            flp_marcoscompartidos.Location = new Point(3, 148);
            flp_marcoscompartidos.Name = "flp_marcoscompartidos";
            flp_marcoscompartidos.Size = new Size(440, 85);
            flp_marcoscompartidos.TabIndex = 3;
            // 
            // BibliotecaComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(container);
            Name = "BibliotecaComponente";
            Size = new Size(446, 236);
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel container;
        private Label label1;
        private FlowLayoutPanel flp_marcospropios;
        private Label label2;
        private FlowLayoutPanel flp_marcoscompartidos;
    }
}
