using Noodle.controller;
using Noodle.model.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noodle.componentes.editar
{
    public partial class CriterioEvaluacionEditableComponente : UserControl
    {
        public CriterioEvaluacionDTO ce { get; set; }
        public CriterioEvaluacionEditableComponente(CriterioEvaluacionDTO criterioEvaluacion)
        {
            InitializeComponent();
            this.ce = criterioEvaluacion;
            identificador.Text = ce.nombreCortoCSV;
            descripcion.Text = Regex.Replace(ce.descripcionCSV, @"<[^>]+>|&nbsp;", "");
        }

        private void convertirEditable(object sender, EventArgs e)
        {
            EditarCompetenciaController.convertirEditable(sender, e);
            Program.ce = ce;
        }

    }
}
