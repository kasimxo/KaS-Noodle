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

namespace Noodle.componentes.ver
{
    public partial class CriterioEvaluacionComponente : UserControl
    {
        public CriterioEvaluacionDTO ce { get; set; }
        public CriterioEvaluacionComponente(CriterioEvaluacionDTO criterio)
        {
            InitializeComponent();
            this.ce = criterio;
            nombre.Text = ce.nombreCortoCSV;
            descripcion.Text = Regex.Replace(ce.descripcionCSV, @"<[^>]+>|&nbsp;", "");
        }
    }
}
