namespace Noodle.view
{
    partial class VerCompetenciasView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerCompetenciasView));
            flp = new FlowLayoutPanel();
            detalleCompetencia = new components.CompetenciaComponente();
            container = new FlowLayoutPanel();
            button1 = new Button();
            titulo = new Label();
            btn_volver = new Button();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // flp
            // 
            flp.AutoScroll = true;
            flp.AutoSize = true;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Location = new Point(0, 0);
            flp.Margin = new Padding(0);
            flp.MaximumSize = new Size(0, 300);
            flp.Name = "flp";
            flp.Padding = new Padding(5, 5, 20, 5);
            flp.Size = new Size(25, 10);
            flp.TabIndex = 0;
            flp.WrapContents = false;
            // 
            // detalleCompetencia
            // 
            detalleCompetencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            detalleCompetencia.AutoScroll = true;
            detalleCompetencia.AutoSize = true;
            detalleCompetencia.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            detalleCompetencia.BackColor = Color.FromArgb(170, 255, 220);
            detalleCompetencia.competencia = null;
            detalleCompetencia.Location = new Point(33, 8);
            detalleCompetencia.Margin = new Padding(8);
            detalleCompetencia.MaximumSize = new Size(0, 300);
            detalleCompetencia.MinimumSize = new Size(360, 0);
            detalleCompetencia.Name = "detalleCompetencia";
            detalleCompetencia.nombreCom = null;
            detalleCompetencia.Padding = new Padding(5);
            detalleCompetencia.Size = new Size(360, 42);
            detalleCompetencia.TabIndex = 1;
            detalleCompetencia.Visible = false;
            // 
            // container
            // 
            container.AutoSize = true;
            container.Controls.Add(flp);
            container.Controls.Add(detalleCompetencia);
            container.Location = new Point(37, 78);
            container.Name = "container";
            container.Size = new Size(401, 100);
            container.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(1263, 677);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Siguiente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            titulo.Location = new Point(37, 34);
            titulo.Margin = new Padding(10);
            titulo.Name = "titulo";
            titulo.Size = new Size(0, 22);
            titulo.TabIndex = 4;
            // 
            // btn_volver
            // 
            btn_volver.Location = new Point(1157, 677);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(75, 23);
            btn_volver.TabIndex = 5;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // VerCompetenciasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 220);
            ClientSize = new Size(1366, 728);
            Controls.Add(btn_volver);
            Controls.Add(titulo);
            Controls.Add(button1);
            Controls.Add(container);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VerCompetenciasView";
            Padding = new Padding(25);
            Text = "Editar";
            WindowState = FormWindowState.Maximized;
            container.ResumeLayout(false);
            container.PerformLayout();
            ClientSize = Screen.PrimaryScreen.WorkingArea.Size;
            flp.MaximumSize = new Size(0, this.Height - 175);
            detalleCompetencia.MaximumSize = new Size(0, this.Height - 175);
            flp.HorizontalScroll.Visible = false;
            flp.HorizontalScroll.Minimum = 100000;
            flp.VerticalScroll.Enabled = true;
            flp.VerticalScroll.Visible = true;
            flp.AutoScroll = true;
            detalleCompetencia.HorizontalScroll.Visible = false;
            detalleCompetencia.HorizontalScroll.Minimum = 100000;
            detalleCompetencia.VerticalScroll.Enabled = true;
            detalleCompetencia.VerticalScroll.Visible = true;
            detalleCompetencia.AutoScroll = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp;
        private components.CompetenciaComponente detalleCompetencia;
        private FlowLayoutPanel container;
        private Button button1;
        private Label titulo;
        private Button btn_volver;
    }
}