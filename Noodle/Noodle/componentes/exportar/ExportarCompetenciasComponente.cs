using Noodle.config;
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
    public partial class ExportarCompetenciasComponente : UserControl
    {
        public MarcoCompetenciasDTO marco { get; set; }
        public List<CompetenciaDTO> competencias;
        public ExportarCompetenciasComponente(MarcoCompetenciasDTO marco)
        {
            InitializeComponent();
            this.marco = marco;
            listarCompetencias();
        }

        public void listarCompetencias()
        {
            foreach (CompetenciaDTO com in marco.competencias.Values)
            {
                SeleccionCompetenciaComponente scc = new SeleccionCompetenciaComponente(com);
                flp.Controls.Add(scc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos un ciclo en el que almacenamos únicamente las variables que vamos a exportar
            MarcoCompetenciasDTO competenciasExportar = new MarcoCompetenciasDTO();
            competenciasExportar.fromCSV(marco.CopiarVariables());
            //Copiamos las variables que necesitamos del ciclo actual
            competenciasExportar.nivel = marco.nivel;
            competenciasExportar.siglas = marco.siglas;
            competenciasExportar.denominacion = marco.denominacion;

            foreach (SeleccionCompetenciaComponente scc in flp.Controls.OfType<SeleccionCompetenciaComponente>())
            {
                if (scc.cb.Checked)
                {
                    competenciasExportar.competencias.Add(scc.competencia.nombre, scc.competencia);
                }
            }

            //Comprobamos que se haya seleccionado por lo menos una competencia
            if (competenciasExportar.competencias.Count < 1)
            {
                MessageBox.Show("No se ha seleccionado ninguna competencia");
                return;
            }

            //Permitimos al usuario seleccionar el directorio en el que se va a guardar el archivo
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV .csv|*.csv";
            sfd.Title = "Exportar Competencias";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName, true))
                {
                    //Hardcode de las cabeceras
                    sw.WriteLine(Configuracion.CABECERAS_CSV);
                    sw.WriteLine(competenciasExportar.ToCSV());
                }
            }
        }

        private void btn_deseleccionar_Click(object sender, EventArgs e)
        {
            foreach (SeleccionCompetenciaComponente cc in flp.Controls.OfType<SeleccionCompetenciaComponente>())
            {
                cc.cb.Checked = false;
            }
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            foreach (SeleccionCompetenciaComponente cc in flp.Controls.OfType<SeleccionCompetenciaComponente>())
            {
                cc.cb.Checked = true;
            }
        }

    }
}
