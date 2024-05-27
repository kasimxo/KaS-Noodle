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
    public partial class DetalleCompetenciaEditable : UserControl
    {
        public CompetenciaDTO competencia { get; set;  }
        public DetalleCompetenciaEditable(CompetenciaDTO com)
        {
            InitializeComponent();
            this.competencia = com;

            nombre.Text = competencia.nombreCortoCSV;
            popularCompetencia();

        }

        private void popularCompetencia() {
            foreach (ResultadoAprendizajeDTO ra in competencia.ras.Values) 
            {
                ResultadoAprendizajeEditableComponente raec = new ResultadoAprendizajeEditableComponente(ra);
                flp.Controls.Add(raec);
            }
        }
    }
}
