namespace Noodle.componentes.biblioteca
{
    partial class MarcoCompartido
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
            nombre = new Label();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            container.AutoSize = true;
            container.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            container.ColumnCount = 1;
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            container.Controls.Add(nombre, 0, 0);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(5, 5);
            container.Name = "container";
            container.RowCount = 1;
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            container.Size = new Size(81, 42);
            container.TabIndex = 0;
            // 
            // nombre
            // 
            nombre.Anchor = AnchorStyles.None;
            nombre.AutoSize = true;
            nombre.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            nombre.Location = new Point(10, 10);
            nombre.Margin = new Padding(10);
            nombre.Name = "nombre";
            nombre.Size = new Size(61, 22);
            nombre.TabIndex = 0;
            nombre.Text = "label1";
            nombre.Click += marcoCompartido_Click;
            // 
            // MarcoCompartido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 192, 255);
            Controls.Add(container);
            Margin = new Padding(10);
            Name = "MarcoCompartido";
            Padding = new Padding(5);
            Size = new Size(91, 52);
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TableLayoutPanel container;
        private Label nombre;
    }
}
