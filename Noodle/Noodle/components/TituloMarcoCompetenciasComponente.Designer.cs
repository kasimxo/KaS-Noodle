namespace Noodle.components
{
    partial class TituloMarcoCompetenciasComponente
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
            titulo = new Label();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Dock = DockStyle.Fill;
            titulo.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            titulo.Location = new Point(10, 10);
            titulo.Margin = new Padding(15);
            titulo.Name = "titulo";
            titulo.Size = new Size(61, 22);
            titulo.TabIndex = 0;
            titulo.Text = "label1";
            titulo.TextAlign = ContentAlignment.MiddleLeft;
            titulo.Click += titulo_Click;
            // 
            // TituloMarcoCompetenciasComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 192, 255);
            Controls.Add(titulo);
            Margin = new Padding(25);
            Name = "TituloMarcoCompetenciasComponente";
            Padding = new Padding(10);
            Size = new Size(81, 42);
            Click += titulo_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
    }
}
