using Noodle.model.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Noodle.components
{
    public partial class ResultadoAprendizajeComponente : UserControl
    {
        public string nombreRa;
        public System.Windows.Forms.Label editando;
        public ResultadoAprendizajeDTO ra;
        public Boolean editable;
        public RichTextBox texto;
        public ResultadoAprendizajeComponente(ResultadoAprendizajeDTO ra, Boolean editable=false)
        {
            InitializeComponent();
            this.ra = ra;
            this.nombreRa = ra.nombre;
            this.editable = editable;
            if (editable)
            {
                popularEditable();
            }
            else {
                popularNormal();
            }

                /*
                RichTextBox texto = new RichTextBox();

                //TextBox texto = new TextBox();
                texto.Text = ce.nombre;
                //texto.Size = new Size(200,200);
                texto.ReadOnly = true;
                texto.Dock = DockStyle.Fill;
                //texto.BackColor = Color.Transparent;
                texto.BorderStyle = BorderStyle.None;
                texto.Size = new Size(this.Width, texto.Height);
                TableLayoutPanel tlp = new TableLayoutPanel();
                tlp.RowCount = 1;
                tlp.ColumnCount = 1;
                tlp.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tlp.AutoSize = true;
                tlp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                tlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                container.Controls.Add(tlp);
                tlp.Controls.Add( texto ,0, tlp.RowCount-1);
                */
            
        }

        private void popularEditable() {
            nombre.Text = nombreRa;
            nombre.Click += (o, e) => hacerEditable(o, e, nombre);
            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.RowCount = 1;
            tlp.ColumnCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlp.AutoSize = true;
            tlp.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            container.Controls.Add(tlp);
            foreach (CriterioEvaluacionDTO ce in ra.criterios.Values)
            {

                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label.Margin = new Padding(2);
                label.Text = ce.nombre;
                label.AutoSize = true;
                int rowIndex = tlp.RowCount - 1;
                label.Click += (o, e) => hacerEditable(o, e, label, rowIndex);
                tlp.Controls.Add(label, 0, tlp.RowCount - 1);
                tlp.RowCount++;
            }
        }
        /// <summary>
        /// Si la row es -1, es porque estamos editando el nombre del RA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="label"></param>
        /// <param name="row"></param>
        private void hacerEditable(Object sender, EventArgs e, System.Windows.Forms.Label label, int row=-1)
        {
            if (texto != null) {
                editando.Text = texto.Text;
                texto.Dispose(); 
            }
            if (editando != null) { editando.Visible = true; }
            
            editando = label;
            editando.Visible = false;

            this.texto = new RichTextBox();

            texto.Text = editando.Text;
            texto.Dock = DockStyle.Fill;
            texto.BorderStyle = BorderStyle.None;
            texto.Size = new Size(this.Width, this.Height);
            if (row >= 0) {
                TableLayoutPanel tlp = container.Controls.OfType<TableLayoutPanel>().FirstOrDefault();
                if (tlp != null)
                {
                    tlp.Controls.Add(texto, 0, row);
                }
            } else
            {
                container.SuspendLayout();
                container.Controls.Add(texto);
                container.Controls.SetChildIndex(texto, 0);
                container.ResumeLayout();
            }
            
        }

        private void popularNormal() {
            nombre.Text = nombreRa;
            foreach (CriterioEvaluacionDTO ce in ra.criterios.Values)
            {


                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label.Margin = new Padding(2);
                label.Text = ce.nombre;
                label.AutoSize = true;

                TableLayoutPanel tlp = new TableLayoutPanel();
                tlp.RowCount = 1;
                tlp.ColumnCount = 1;
                tlp.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tlp.AutoSize = true;
                tlp.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                container.Controls.Add(tlp);
                tlp.Controls.Add(label, 0, tlp.RowCount - 1);
            }
        }

    }
}
