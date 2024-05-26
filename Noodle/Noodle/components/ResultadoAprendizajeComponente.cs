using Noodle.model.dal;
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
using static System.Net.WebRequestMethods;

namespace Noodle.components
{
    public partial class ResultadoAprendizajeComponente : UserControl
    {
        public string nombreRa;
        public System.Windows.Forms.Label editando;
        public ResultadoAprendizajeDTO ra;
        public Boolean editable;
        public Boolean editado; //Controla si se ha editado almenos una cosa para mostrar mensaje de confirmación
        public RichTextBox texto;
        public CompetenciaComponente parent;

        public ResultadoAprendizajeComponente(ResultadoAprendizajeDTO ra) 
        {
            InitializeComponent();
            this.ra = ra;
            this.nombreRa = ra.nombre;
            nombre.Text = ra.nombreCortoCSV;
            cargarCriteriosEvaluacionBaseDeDatos();
        }

        public async void cargarCriteriosEvaluacionBaseDeDatos() 
        {
            ra.criterios = await CriterioEvaluacionDAL.cargarCriteriosEvaluacion(ra.idDB);

            

            foreach (CriterioEvaluacionDTO ce in ra.criterios.Values)
            {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label.Margin = new Padding(2);
                label.Text = ce.nombreCortoCSV;
                label.AutoSize = true;
                //Aqui hay que meter un CriterioEvaluacionComponente, para que pueda tener 
                //Tanto el identificador (nombre corto) como la descripcion
                container.Controls.Add(label);
            }
        }
        // IGNORA --------------------------
        public ResultadoAprendizajeComponente(ResultadoAprendizajeDTO ra, Boolean editable=false, CompetenciaComponente parent=null)
        {
            InitializeComponent();
            this.ra = ra;
            this.nombreRa = ra.nombre;
            this.editable = editable;
            if (parent != null) {
                this.parent = parent;
            }
            if (editable)
            {
                popularEditable();
            }
            else {
                popularNormal();
            }
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
                label.Text = ce.contenido;
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
                try {
                    if (ra.criterios[editando.Text].contenido != texto.Text) {
                        ra.criterios[editando.Text].contenido = texto.Text;
                        parent.editarView.hayCambios = true;
                    }
                } catch (KeyNotFoundException ex) {
                    //Comprobamos si hemos editado el label del título de ra
                    if (nombreRa == editando.Text) {
                        ra.nombre = texto.Text;
                        nombreRa = texto.Text;
                        parent.editarView.hayCambios = true;
                    }
                }
                
                if(editando.Text != texto.Text)
                {
                    editando.Text = texto.Text;
                    editando.BackColor = Color.LightYellow;
                    parent.editarView.hayCambios = true;
                }
                texto.Dispose(); 
            }
            if (editando != null) { editando.Visible = true; }
            if(parent.enModificacion != null && parent.enModificacion != this)
            {
                parent.enModificacion.saveChanges();
            }
            parent.enModificacion = this;
            editando = label;
            editando.Visible = false;

            this.texto = new RichTextBox();

            texto.Text = editando.Text;
            texto.Dock = DockStyle.Fill;
            texto.BorderStyle = BorderStyle.None;
            texto.Size = new Size(this.Width, this.Height);
            if (row >= 0)
            {
                TableLayoutPanel tlp = container.Controls.OfType<TableLayoutPanel>().FirstOrDefault();
                if (tlp != null)
                {
                    tlp.Controls.Add(texto, 0, row);
                }
            }
            else
            {
                container.SuspendLayout();
                container.Controls.Add(texto);
                container.Controls.SetChildIndex(texto, 0);
                container.ResumeLayout();
            }
        }

        private void saveChanges() {
            if (texto != null)
            {
                try
                {
                    if (ra.criterios[editando.Text].contenido != texto.Text)
                    {
                        ra.criterios[editando.Text].contenido = texto.Text;
                        parent.editarView.hayCambios = true;
                    }
                }
                catch (KeyNotFoundException ex)
                {
                    //Comprobamos si hemos editado el label del título de ra
                    if (nombreRa == editando.Text)
                    {
                        ra.nombre = texto.Text;
                        nombreRa = texto.Text;
                        parent.editarView.hayCambios = true;
                    }
                }
                if (editando.Text != texto.Text)
                {
                    editando.Text = texto.Text;
                    editando.BackColor = Color.LightYellow;
                    parent.editarView.hayCambios = true;
                }
                texto.Dispose();
            }
            if (editando != null) { editando.Visible = true; }
        }

        private void popularNormal() {
            nombre.Text = nombreRa;
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
                label.Text = ce.contenido;
                label.AutoSize = true;
                int rowIndex = tlp.RowCount - 1;
                label.Click += (o, e) => hacerEditable(o, e, label, rowIndex);
                tlp.Controls.Add(label, 0, tlp.RowCount - 1);
                tlp.RowCount++;
            }
        }
        //IGNORA LO DE ARRIBA
    }
}
