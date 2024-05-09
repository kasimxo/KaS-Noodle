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
    public partial class EditarCompetenciasView : Form
    {
        public EditarCompetenciasView()
        {
            InitializeComponent();
        }

        public EditarCompetenciasView(List<CompetenciaDTO> competencias) {

            InitializeComponent();
            foreach(CompetenciaDTO com in competencias)
            {
                CompetenciaComponente container = new CompetenciaComponente(com);
                container.Width = flp.Width;
                flp.Controls.Add(container);
            }
        }
    }
}
