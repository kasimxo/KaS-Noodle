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
    public partial class CompetenciaComponente : UserControl
    {
        public CompetenciaComponente()
        {
            InitializeComponent();
        }
        public CompetenciaComponente(CompetenciaDTO com)
        {
            InitializeComponent();

            nombre.Text = com.nombre;

            foreach (ResultadoAprendizajeDTO ra in com.ras.Values) {
                Label label = new Label();
                label.Text = ra.nombre;
                label.AutoSize = true;
                flp.Controls.Add(label);
            }
        }
    }
}
