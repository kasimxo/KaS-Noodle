﻿using Noodle.controller;
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
            if (Program.marco.esCompartido) {
                button1.Enabled = false;
            }
            this.competencia = com;
            nombreCompetencia.Text = competencia.nombreCortoCSV;
            popularResultadosAprendizaje();
        }

        public async void popularResultadosAprendizaje()
        {
            if (competencia.ras == null || competencia.ras.Count == 0)
            {
                competencia.ras = await ResultadoAprendizajeDAL.cargarResultadosAprendizaje(competencia.idDB);

            }
            foreach (ResultadoAprendizajeDTO ra in competencia.ras.Values)
            {
                ResultadoAprendizajeComponente rac = new ResultadoAprendizajeComponente(ra);
                rac.Dock = DockStyle.Fill;
                flp.Controls.Add(rac);
            }
            flp.HorizontalScroll.Minimum = 100000;
            flp.AutoScroll = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarCompetenciaController.navegarEditarCompetencia(competencia);
        }
    }
}
