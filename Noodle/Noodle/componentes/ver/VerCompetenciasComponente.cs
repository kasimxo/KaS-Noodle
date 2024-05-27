using Noodle.controller;
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

namespace Noodle.components
{
    public partial class VerCompetenciasComponente : UserControl
    {

        public MarcoCompetenciasDTO marco { get; set; }
        public VerCompetenciasComponente()
        {
            InitializeComponent();
        }

        public VerCompetenciasComponente(MarcoCompetenciasDTO marco)
        {
            InitializeComponent();
            this.marco = marco;
            NombreMarco.Text = marco.nombreCortoCSV;
            popularCompetencias();
        }

        public async void popularCompetencias()
        {
            if (marco.competencias == null || marco.competencias.Count == 0) {
                marco.competencias = await CompetenciaDAL.cargarCompetencia(marco.idDB);
            }


            foreach (CompetenciaDTO com in marco.competencias.Values)
            {
                TituloCompetenciaComponente tcc = new TituloCompetenciaComponente(com);
                flp.Controls.Add(tcc);
            }
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            ExportarController.navegarExportarController(marco);
        }
    }
}
