namespace Noodle.components
{
    partial class ImportarArchivoPdfComponente
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
            btn = new Button();
            pb = new PictureBox();
            container = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Anchor = AnchorStyles.None;
            btn.Location = new Point(35, 131);
            btn.Margin = new Padding(5);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 0;
            btn.Text = "Seleccionar";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // pb
            // 
            pb.Anchor = AnchorStyles.None;
            pb.BackgroundImage = Properties.Resources.img_pdf;
            pb.BackgroundImageLayout = ImageLayout.Zoom;
            pb.InitialImage = null;
            pb.Location = new Point(3, 3);
            pb.Name = "pb";
            pb.Size = new Size(140, 120);
            pb.TabIndex = 1;
            pb.TabStop = false;
            // 
            // container
            // 
            container.AutoSize = true;
            container.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            container.ColumnCount = 1;
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.Controls.Add(pb, 0, 0);
            container.Controls.Add(btn, 0, 1);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.RowCount = 2;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle());
            container.Size = new Size(146, 159);
            container.TabIndex = 2;
            // 
            // ImportarArchivoPdfComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            Controls.Add(container);
            Name = "ImportarArchivoPdfComponente";
            Size = new Size(146, 159);
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            container.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn;
        private PictureBox pb;
        public TableLayoutPanel container;
    }
}
