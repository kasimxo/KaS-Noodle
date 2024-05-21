using Noodle.components;
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

namespace Noodle.view
{
    public partial class ExportarCompetenciasView : Form
    {
        public CicloDTO ciclo { get; set; }
        public List<CompetenciaDTO> competencias;
        public ExportarCompetenciasView(CicloDTO ciclo)
        {
            InitializeComponent();
            this.ciclo = ciclo;
            listarCompetencias();
        }

        public void listarCompetencias()
        {
            foreach (CompetenciaDTO com in ciclo.competencias.Values)
            {
                SeleccionCompetenciaComponente scc = new SeleccionCompetenciaComponente(com);
                flp.Controls.Add(scc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos un ciclo en el que almacenamos únicamente las variables que vamos a exportar
            CicloDTO competenciasExportar = new CicloDTO();

            //Copiamos las variables que necesitamos del ciclo actual
            competenciasExportar.nivel = ciclo.nivel;
            competenciasExportar.siglas = ciclo.siglas;
            competenciasExportar.denominacion = ciclo.denominacion;

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
                    sw.WriteLine("Identificador padre;Identificador;Nombre corto;Descripción;Descripción del formato;Valores de escala;Configuración de escala;Tipo de regla (opcional);Resultado de la regla (opcional);Configuración de regla (opcional);Identificadores de referencias cruzadas de competencias;Identificador de la exportación (opcional);Es marco de competencias;Taxonomía");
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

        private void btn_volver_Click(object sender, EventArgs e)
        {
            VerCompetenciasView vcv = new VerCompetenciasView(ciclo);
            vcv.Show();
            this.Close();
        }
    }
}
