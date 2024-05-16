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
    public partial class ResultadoAprendizajeComponente : UserControl
    {
        public string nombreRa;
        public ResultadoAprendizajeDTO ra;
        public ResultadoAprendizajeComponente(ResultadoAprendizajeDTO ra)
        {
            InitializeComponent();
            this.ra = ra;
            this.nombreRa = ra.nombre;
            nombre.Text = nombreRa;
            foreach (CriterioEvaluacionDTO ce in ra.criterios.Values)
            {
                Label label = new Label();
                label.Margin = new Padding(2);
                label.Text = ce.nombre;
                label.AutoSize = true;
                flp.Controls.Add(label);
            }

        }
    }
}
