using Noodle.model.dto;
using Noodle.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noodle.components
{
    public partial class CompetenciaComponente : UserControl
    {
        public CompetenciaDTO competencia { get; set; }
        public string nombreCom { get; set; }
        public Boolean editable { get; set; }
        public EditarCompetenciaView editarView;
        public ResultadoAprendizajeComponente enModificacion;
        public CompetenciaComponente()
        {
            InitializeComponent();
        }
        public CompetenciaComponente(CompetenciaDTO com, Boolean autoWidth=false, Boolean editable=false, EditarCompetenciaView editarView=null)
        {
            InitializeComponent();

            this.nombreCom = com.nombre;
            this.competencia = com;
            this.editable = editable;
            if(editarView != null)
            {
                this.editarView = editarView;
            }
            if (autoWidth) { nombre.MaximumSize = new Size(0, 0); }
            nombre.Text = competencia.nombre;
        }

        private void CompetenciaComponente_Load(object sender, EventArgs e)
        {

        }

        public void listarDetalles()
        {
            flp.Controls.Clear();
            foreach (ResultadoAprendizajeDTO ra in competencia.ras.Values)
            {
                if (editarView != null) {
                    ResultadoAprendizajeComponente rac = new ResultadoAprendizajeComponente(ra, editable, this);
                    flp.Controls.Add(rac);
                    flp.Visible = true;
                } else
                {
                    ResultadoAprendizajeComponente rac = new ResultadoAprendizajeComponente(ra, editable);
                    flp.Controls.Add(rac);
                    flp.Visible = true;
                }
                
            }
        }

        /// <summary>
        /// Método que hace que todas las labels que componen este componente
        /// adopten un método on clic que las sustituya por textArea para que el usuario 
        /// pueda editarlas
        /// </summary>
        public void hacerEditable()
        {

        }

        public void CompetenciaComponente_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ResultadoAprendizajeDTO ra in competencia.ras.Values)
            {
                ResultadoAprendizajeComponente rac = new ResultadoAprendizajeComponente(ra);
                flp.Controls.Add(rac);
            }
        }

        /// <summary>
        /// Elimina todo el contenido del componente y lo oculta
        /// </summary>
        public void limpiar()
        {
            nombre.Text = "";
            flp.Controls.Clear();
            this.Visible = false;
        }


    }
}
