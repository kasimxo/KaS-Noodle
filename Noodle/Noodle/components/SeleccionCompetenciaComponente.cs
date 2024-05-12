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
    public partial class SeleccionCompetenciaComponente : UserControl
    {
        public CompetenciaDTO competencia;
        public SeleccionCompetenciaComponente()
        {
            InitializeComponent();
        }

        public SeleccionCompetenciaComponente(CompetenciaDTO com)
        {
            InitializeComponent();
            this.competencia = com;
            nombre.Text = com.nombre;
        }
    }
}
