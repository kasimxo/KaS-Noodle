using Noodle.model.dal;
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
using static System.Net.WebRequestMethods;

namespace Noodle.components
{
    public partial class DetalleCompetenciaComponente : UserControl
    {
        public CompetenciaDTO competencia { get; set; }
        public DetalleCompetenciaComponente(CompetenciaDTO com)
        {
            InitializeComponent();
            this.competencia = com;
            nombreCompetencia.Text = competencia.nombreCortoCSV;
            popularResultadosAprendizaje();
        }

        public async void popularResultadosAprendizaje() 
        {
            competencia.ras = await ResultadoAprendizajeDAL.cargarResultadosAprendizaje(competencia.idDB);
            foreach (ResultadoAprendizajeDTO ra in competencia.ras.Values)
            {
                ResultadoAprendizajeComponente rac = new ResultadoAprendizajeComponente(ra);
                
                flp.Controls.Add(rac);
            }
        }
    }
}
