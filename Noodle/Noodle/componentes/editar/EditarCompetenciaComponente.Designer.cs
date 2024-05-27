namespace Noodle.components
{
    partial class EditarCompetenciaComponente
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
            viewer = new Microsoft.Web.WebView2.WinForms.WebView2();
            container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewer).BeginInit();
            SuspendLayout();
            // 
            // container
            // 
            container.ColumnCount = 2;
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            container.Controls.Add(viewer, 0, 0);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.RowCount = 1;
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.Size = new Size(150, 150);
            container.TabIndex = 3;
            // 
            // viewer
            // 
            viewer.AllowExternalDrop = true;
            viewer.CreationProperties = null;
            viewer.DefaultBackgroundColor = Color.Transparent;
            viewer.Dock = DockStyle.Fill;
            viewer.Location = new Point(3, 3);
            viewer.Name = "viewer";
            viewer.Size = new Size(69, 144);
            viewer.TabIndex = 0;
            viewer.ZoomFactor = 1D;
            // 
            // EditarCompetenciaComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(container);
            Name = "EditarCompetenciaComponente";
            container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel container;
        private Microsoft.Web.WebView2.WinForms.WebView2 viewer;
    }
}
