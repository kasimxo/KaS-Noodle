namespace Noodle.view
{
    partial class EditarCompetenciasView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCompetenciasView));
            flp = new FlowLayoutPanel();
            detalleCompetencia = new components.CompetenciaComponente();
            container = new FlowLayoutPanel();
            button1 = new Button();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // flp
            // 
            flp.AutoScroll = true;
            flp.AutoSize = true;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Location = new Point(3, 3);
            flp.Name = "flp";
            flp.Size = new Size(0, 0);
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
            detalleCompetencia.Location = new Point(9, 3);
            detalleCompetencia.MinimumSize = new Size(360, 0);
            detalleCompetencia.Name = "detalleCompetencia";
            detalleCompetencia.nombreCom = null;
            detalleCompetencia.Size = new Size(360, 34);
            detalleCompetencia.TabIndex = 1;
            detalleCompetencia.Visible = false;
            // 
            // container
            // 
            container.AutoSize = true;
            container.Controls.Add(flp);
            container.Controls.Add(detalleCompetencia);
            container.Location = new Point(12, 12);
            container.Name = "container";
            container.Size = new Size(372, 100);
            container.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(706, 395);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Siguiente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditarCompetenciasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(container);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditarCompetenciasView";
            Text = "Editar";
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp;
        private components.CompetenciaComponente detalleCompetencia;
        private FlowLayoutPanel container;
        private Button button1;
    }
}