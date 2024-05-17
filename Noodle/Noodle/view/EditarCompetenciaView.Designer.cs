namespace Noodle.view
{
    partial class EditarCompetenciaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCompetenciaView));
            button1 = new Button();
            container = new TableLayoutPanel();
            viewer = new Microsoft.Web.WebView2.WinForms.WebView2();
            container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewer).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // container
            // 
            container.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            container.ColumnCount = 2;
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            container.Controls.Add(viewer, 0, 0);
            container.Location = new Point(12, 12);
            container.Name = "container";
            container.RowCount = 1;
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            container.Size = new Size(776, 397);
            container.TabIndex = 2;
            // 
            // viewer
            // 
            viewer.AllowExternalDrop = true;
            viewer.CreationProperties = null;
            viewer.DefaultBackgroundColor = Color.Transparent;
            viewer.Dock = DockStyle.Fill;
            viewer.Location = new Point(3, 3);
            viewer.Name = "viewer";
            viewer.Size = new Size(382, 391);
            viewer.TabIndex = 0;
            viewer.ZoomFactor = 1D;
            // 
            // EditarCompetenciaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(container);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditarCompetenciaView";
            Text = "Noodle";
            WindowState = FormWindowState.Maximized;
            container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TableLayoutPanel container;
        private components.CompetenciaComponente competencia;
        private Microsoft.Web.WebView2.WinForms.WebView2 viewer;
    }
}