using Noodle.model.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noodle.componentes.editar
{
    public partial class ResultadoAprendizajeEditableComponente : UserControl
    {
        public ResultadoAprendizajeDTO ra { get; set; }
        public ResultadoAprendizajeEditableComponente(ResultadoAprendizajeDTO resultadoaprendizaje)
        {
            InitializeComponent();
            this.ra = resultadoaprendizaje;
            nombre.Text = ra.nombreCortoCSV;
            popularCriteriosEvaluacion();
        }

        private void popularCriteriosEvaluacion() 
        {
            foreach (CriterioEvaluacionDTO ce in ra.criterios.Values) 
            {
                CriterioEvaluacionEditableComponente ceec = new CriterioEvaluacionEditableComponente(ce);
                flowLayoutPanel1.Controls.Add(ceec);
            }
        }
    }
}
