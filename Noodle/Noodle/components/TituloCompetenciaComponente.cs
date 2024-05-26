using Noodle.controller;
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

namespace Noodle.components
{
    public partial class TituloCompetenciaComponente : UserControl
    {
        public CompetenciaDTO competencia { get; set; }
        public TituloCompetenciaComponente(CompetenciaDTO com)
        {
            InitializeComponent();
            this.competencia = com;
            nombreCompetencia.Text = competencia.nombreCortoCSV;
        }

        private void abrirDetalleCompetencia_Click(object sender, EventArgs e)
        {
            VerCompetenciasController.abrirDetalleCompetencia(competencia);
        }
    }
}
