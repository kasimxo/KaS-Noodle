namespace Noodle.view
{
    partial class ExportarCompetenciasView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportarCompetenciasView));
            flp = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // flp
            // 
            flp.AutoSize = true;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Location = new Point(11, 14);
            flp.Name = "flp";
            flp.Size = new Size(200, 100);
            flp.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(602, 187);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Exportar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ExportarCompetenciasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(flp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ExportarCompetenciasView";
            Text = "Noodle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp;
        private Button button1;
    }
}