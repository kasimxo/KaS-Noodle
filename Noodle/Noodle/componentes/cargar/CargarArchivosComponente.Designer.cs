namespace Noodle.componentes.cargar
{
    partial class CargarArchivosComponente
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
            flp = new FlowLayoutPanel();
            importarPdfComponente = new components.ImportarArchivoPdfComponente();
            importarCsvComponente = new components.ImportarArchivoCsvComponente();
            cargar_archivo_label = new Label();
            agregar_archivo_label = new Label();
            arrastrarArchivoComponente1 = new components.ArrastrarArchivoComponente();
            tableLayoutPanel1 = new TableLayoutPanel();
            container.SuspendLayout();
            flp.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            container.Dock = DockStyle.Fill;
            container.Location = new Point(11, 50);
            container.Margin = new Padding(3, 50, 3, 3);
            container.Name = "container";
            container.RowCount = 4;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            container.Size = new Size(477, 494);
            container.TabIndex = 5;
            // 
            // flp
            // 
            flp.AutoSize = true;
            flp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flp.Controls.Add(importarPdfComponente);
            flp.Controls.Add(importarCsvComponente);
            flp.Dock = DockStyle.Fill;
            flp.Location = new Point(25, 35);
            flp.Margin = new Padding(25, 3, 3, 3);
            flp.Name = "flp";
            flp.Size = new Size(449, 209);
            flp.TabIndex = 4;
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
            cargar_archivo_label.Size = new Size(467, 22);
            cargar_archivo_label.TabIndex = 3;
            cargar_archivo_label.Text = "Cargar archivo";
            // 
            // agregar_archivo_label
            // 
            agregar_archivo_label.AutoSize = true;
            agregar_archivo_label.Dock = DockStyle.Fill;
            agregar_archivo_label.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            agregar_archivo_label.Location = new Point(5, 252);
            agregar_archivo_label.Margin = new Padding(5);
            agregar_archivo_label.Name = "agregar_archivo_label";
            agregar_archivo_label.Size = new Size(467, 22);
            agregar_archivo_label.TabIndex = 5;
            agregar_archivo_label.Text = "Agregar archivo";
            // 
            // arrastrarArchivoComponente1
            // 
            arrastrarArchivoComponente1.AllowDrop = true;
            arrastrarArchivoComponente1.AutoSize = true;
            arrastrarArchivoComponente1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            arrastrarArchivoComponente1.BorderStyle = BorderStyle.FixedSingle;
            arrastrarArchivoComponente1.Location = new Point(50, 304);
            arrastrarArchivoComponente1.Margin = new Padding(50, 25, 25, 3);
            arrastrarArchivoComponente1.Name = "arrastrarArchivoComponente1";
            arrastrarArchivoComponente1.Padding = new Padding(20);
            arrastrarArchivoComponente1.Size = new Size(402, 163);
            arrastrarArchivoComponente1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(container, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(505, 547);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // CargarArchivosComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Name = "CargarArchivosComponente";
            Size = new Size(505, 547);
            container.ResumeLayout(false);
            container.PerformLayout();
            flp.ResumeLayout(false);
            flp.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel container;
        private FlowLayoutPanel flp;
        private components.ImportarArchivoPdfComponente importarPdfComponente;
        private components.ImportarArchivoCsvComponente importarCsvComponente;
        private Label cargar_archivo_label;
        private Label agregar_archivo_label;
        private components.ArrastrarArchivoComponente arrastrarArchivoComponente1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
