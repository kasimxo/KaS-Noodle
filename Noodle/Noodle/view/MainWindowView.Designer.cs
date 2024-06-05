namespace Noodle.view
{
    partial class MainWindowView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowView));
            layout = new TableLayoutPanel();
            menu = new components.MenuComponente();
            bibliotecaComponente1 = new components.BibliotecaComponente();
            layout.SuspendLayout();
            SuspendLayout();
            // 
            // layout
            // 
            layout.ColumnCount = 2;
            layout.ColumnStyles.Add(new ColumnStyle());
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.Controls.Add(menu, 0, 0);
            layout.Controls.Add(bibliotecaComponente1, 1, 0);
            layout.Dock = DockStyle.Fill;
            layout.Location = new Point(0, 0);
            layout.Margin = new Padding(0);
            layout.Name = "layout";
            layout.RowCount = 1;
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.Size = new Size(800, 450);
            layout.TabIndex = 0;
            // 
            // menu
            // 
            menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            menu.BackColor = Color.FromArgb(23, 21, 22);
            menu.Location = new Point(0, 0);
            menu.Margin = new Padding(0);
            menu.Name = "menu";
            menu.Size = new Size(200, 450);
            menu.TabIndex = 0;
            // 
            // bibliotecaComponente1
            // 
            bibliotecaComponente1.AutoSize = true;
            bibliotecaComponente1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bibliotecaComponente1.Dock = DockStyle.Fill;
            bibliotecaComponente1.Location = new Point(203, 3);
            bibliotecaComponente1.Name = "bibliotecaComponente1";
            bibliotecaComponente1.Size = new Size(594, 444);
            bibliotecaComponente1.TabIndex = 1;
            // 
            // MainWindowView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(layout);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindowView";
            Text = "Noodle";
            WindowState = FormWindowState.Maximized;
            FormClosing += hideForm;
            layout.ResumeLayout(false);
            layout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private components.BibliotecaComponente bibliotecaComponente1;
        public TableLayoutPanel layout;
        public components.MenuComponente menu;
    }
}