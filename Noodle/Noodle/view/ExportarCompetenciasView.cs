﻿using Noodle.components;
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
            initView();
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
            List<CompetenciaDTO> competenciasExportar = new List<CompetenciaDTO>();
            foreach (SeleccionCompetenciaComponente scc in flp.Controls.OfType<SeleccionCompetenciaComponente>())
            {
                if (scc.cb.Checked)
                {
                    competenciasExportar.Add(scc.competencia);
                }
            }

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
                    sw.WriteLine(ciclo.ToCSV());
                }
            }

            //hay que abrir el file chooser para poder elegir donde guardar el archivo
            //hay que generar los métodos competenciaToText que le den el formato correcto
        }

        public void initView()
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
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
