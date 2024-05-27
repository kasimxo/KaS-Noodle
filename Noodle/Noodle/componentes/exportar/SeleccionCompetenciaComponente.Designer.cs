namespace Noodle.components
{
    partial class SeleccionCompetenciaComponente
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
            cb = new CheckBox();
            nombre = new Label();
            SuspendLayout();
            // 
            // cb
            // 
            cb.AutoSize = true;
            cb.Location = new Point(3, 3);
            cb.Name = "cb";
            cb.Size = new Size(15, 14);
            cb.TabIndex = 0;
            cb.UseVisualStyleBackColor = true;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nombre.Location = new Point(24, 3);
            nombre.Name = "nombre";
            nombre.Size = new Size(50, 18);
            nombre.TabIndex = 1;
            nombre.Text = "label1";
            // 
            // SeleccionCompetenciaComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(nombre);
            Controls.Add(cb);
            Name = "SeleccionCompetenciaComponente";
            Size = new Size(77, 21);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public CheckBox cb;
        public Label nombre;
    }
}
