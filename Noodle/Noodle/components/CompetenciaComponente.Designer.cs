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
            container.SuspendLayout();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.AutoSize = true;
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
            container.Location = new Point(8, 8);
            container.Name = "container";
            container.Size = new Size(67, 34);
            container.TabIndex = 2;
            container.WrapContents = false;
            // 
            // CompetenciaComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            Controls.Add(container);
            MinimumSize = new Size(375, 0);
            Name = "CompetenciaComponente";
            Padding = new Padding(5);
            Size = new Size(375, 50);
            Load += CompetenciaComponente_Load;
            MouseClick += CompetenciaComponente_MouseClick;
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label nombre;
        public FlowLayoutPanel flp;
        public FlowLayoutPanel container;
    }
}
