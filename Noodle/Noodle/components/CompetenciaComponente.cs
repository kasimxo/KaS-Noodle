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
        public CompetenciaComponente()
        {
            InitializeComponent();
        }
        public CompetenciaComponente(CompetenciaDTO com)
        {
            InitializeComponent();

            this.nombreCom = com.nombre;
            this.competencia = com;
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
                ResultadoAprendizajeComponente rac = new ResultadoAprendizajeComponente(ra);
                flp.Controls.Add(rac);
                flp.Visible = true;
            }
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
