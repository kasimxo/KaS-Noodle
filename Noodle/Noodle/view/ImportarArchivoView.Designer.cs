namespace Noodle.view
{
    partial class ImportarArchivoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportarArchivoView));
            importarPdfComponente = new components.ImportarArchivoPdfComponente();
            importarCsvComponente = new components.ImportarArchivoCsvComponente();
            cargar_archivo_label = new Label();
            container = new TableLayoutPanel();
            flp = new FlowLayoutPanel();
            agregar_archivo_label = new Label();
            arrastrarArchivoComponente1 = new components.ArrastrarArchivoComponente();
            menuComponente1 = new components.MenuComponente();
            table_background = new TableLayoutPanel();
            container.SuspendLayout();
            flp.SuspendLayout();
            table_background.SuspendLayout();
            SuspendLayout();
            // 
            // importarPdfComponente
            // 
            importarPdfComponente.AutoSize = true;
            importarPdfComponente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            importarPdfComponente.BackColor = Color.White;
            importarPdfComponente.Location = new Point(25, 25);
            importarPdfComponente.Margin = new Padding(25);
            importarPdfComponente.Name = "importarPdfComponente";
            importarPdfComponente.Size = new Size(146, 159);
            importarPdfComponente.TabIndex = 1;
            // 
            // importarCsvComponente
            // 
            importarCsvComponente.AutoSize = true;
            importarCsvComponente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            importarCsvComponente.BackColor = Color.White;
            importarCsvComponente.Location = new Point(221, 25);
            importarCsvComponente.Margin = new Padding(25);
            importarCsvComponente.Name = "importarCsvComponente";
            importarCsvComponente.Size = new Size(146, 159);
            importarCsvComponente.TabIndex = 2;
            // 
            // cargar_archivo_label
            // 
            cargar_archivo_label.AutoSize = true;
            cargar_archivo_label.Dock = DockStyle.Fill;
            cargar_archivo_label.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            cargar_archivo_label.Location = new Point(5, 5);
            cargar_archivo_label.Margin = new Padding(5);
            cargar_archivo_label.Name = "cargar_archivo_label";
            cargar_archivo_label.Size = new Size(442, 22);
            cargar_archivo_label.TabIndex = 3;
            cargar_archivo_label.Text = "Cargar archivo";
            // 
            // container
            // 
            container.AllowDrop = true;
            container.AutoSize = true;
            container.ColumnCount = 1;
            container.ColumnStyles.Add(new ColumnStyle());
            container.Controls.Add(flp, 0, 1);
            container.Controls.Add(cargar_archivo_label, 0, 0);
            container.Controls.Add(agregar_archivo_label, 0, 2);
            container.Controls.Add(arrastrarArchivoComponente1, 0, 3);
            container.Location = new Point(250, 3);
            container.Margin = new Padding(50, 3, 3, 3);
            container.Name = "container";
            container.RowCount = 4;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle());
            container.Size = new Size(452, 444);
            container.TabIndex = 4;
            // 
            // flp
            // 
            flp.Anchor = AnchorStyles.None;
            flp.AutoSize = true;
            flp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flp.Controls.Add(importarPdfComponente);
            flp.Controls.Add(importarCsvComponente);
            flp.Location = new Point(30, 35);
            flp.Name = "flp";
            flp.Size = new Size(392, 209);
            flp.TabIndex = 4;
            // 
            // agregar_archivo_label
            // 
            agregar_archivo_label.AutoSize = true;
            agregar_archivo_label.Dock = DockStyle.Fill;
            agregar_archivo_label.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            agregar_archivo_label.Location = new Point(5, 252);
            agregar_archivo_label.Margin = new Padding(5);
            agregar_archivo_label.Name = "agregar_archivo_label";
            agregar_archivo_label.Size = new Size(442, 22);
            agregar_archivo_label.TabIndex = 5;
            agregar_archivo_label.Text = "Agregar archivo";
            // 
            // arrastrarArchivoComponente1
            // 
            arrastrarArchivoComponente1.AllowDrop = true;
            arrastrarArchivoComponente1.Anchor = AnchorStyles.None;
            arrastrarArchivoComponente1.AutoSize = true;
            arrastrarArchivoComponente1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            arrastrarArchivoComponente1.BorderStyle = BorderStyle.FixedSingle;
            arrastrarArchivoComponente1.Location = new Point(25, 282);
            arrastrarArchivoComponente1.Margin = new Padding(25, 3, 25, 3);
            arrastrarArchivoComponente1.Name = "arrastrarArchivoComponente1";
            arrastrarArchivoComponente1.Padding = new Padding(20);
            arrastrarArchivoComponente1.Size = new Size(402, 163);
            arrastrarArchivoComponente1.TabIndex = 6;
            arrastrarArchivoComponente1.DragDrop += arrastrarArchivoComponente1_DragDrop;
            arrastrarArchivoComponente1.DragEnter += arrastrarArchivoComponente1_DragEnter;
            arrastrarArchivoComponente1.DragOver += arrastrarArchivoComponente1_DragOver;
            // 
            // menuComponente1
            // 
            menuComponente1.BackColor = Color.FromArgb(23, 21, 22);
            menuComponente1.Dock = DockStyle.Fill;
            menuComponente1.Location = new Point(0, 0);
            menuComponente1.Margin = new Padding(0);
            menuComponente1.Name = "menuComponente1";
            menuComponente1.Size = new Size(200, 450);
            menuComponente1.TabIndex = 5;
            // 
            // table_background
            // 
            table_background.ColumnCount = 2;
            table_background.ColumnStyles.Add(new ColumnStyle());
            table_background.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            table_background.Controls.Add(menuComponente1, 0, 0);
            table_background.Controls.Add(container, 1, 0);
            table_background.Dock = DockStyle.Fill;
            table_background.Location = new Point(0, 0);
            table_background.Margin = new Padding(0);
            table_background.Name = "table_background";
            table_background.RowCount = 1;
            table_background.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            table_background.Size = new Size(800, 450);
            table_background.TabIndex = 6;
            // 
            // ImportarArchivoView
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(240, 240, 220);
            ClientSize = new Size(800, 450);
            Controls.Add(table_background);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ImportarArchivoView";
            Text = "Noodle";
            container.ResumeLayout(false);
            container.PerformLayout();
            flp.ResumeLayout(false);
            flp.PerformLayout();
            table_background.ResumeLayout(false);
            table_background.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private components.ImportarArchivoPdfComponente importarPdfComponente;
        private components.ImportarArchivoCsvComponente importarCsvComponente;
        private Label cargar_archivo_label;
        private TableLayoutPanel container;
        private FlowLayoutPanel flp;
        private Label agregar_archivo_label;
        private components.ArrastrarArchivoComponente arrastrarArchivoComponente1;
        private components.MenuComponente menuComponente1;
        private TableLayoutPanel table_background;
    }
}