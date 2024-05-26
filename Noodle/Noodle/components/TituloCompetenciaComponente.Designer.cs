namespace Noodle.components
{
    partial class TituloCompetenciaComponente
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
            nombreCompetencia = new Label();
            SuspendLayout();
            // 
            // nombreCompetencia
            // 
            nombreCompetencia.AutoSize = true;
            nombreCompetencia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nombreCompetencia.Location = new Point(10, 10);
            nombreCompetencia.MaximumSize = new Size(320, 0);
            nombreCompetencia.Name = "nombreCompetencia";
            nombreCompetencia.Size = new Size(50, 18);
            nombreCompetencia.TabIndex = 0;
            nombreCompetencia.Text = "label1";
            nombreCompetencia.Click += abrirDetalleCompetencia_Click;
            // 
            // TituloCompetenciaComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(nombreCompetencia);
            Margin = new Padding(10);
            MaximumSize = new Size(350, 0);
            MinimumSize = new Size(350, 0);
            Name = "TituloCompetenciaComponente";
            Padding = new Padding(10);
            Size = new Size(350, 38);
            Click += abrirDetalleCompetencia_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label nombreCompetencia;
    }
}
