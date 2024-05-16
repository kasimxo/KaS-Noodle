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
    public partial class EditarCompetenciaView : Form
    {
        public VerCompetenciasView parent;
        public CicloDTO ciclo;
        public CompetenciaDTO competencia;

        public EditarCompetenciaView()
        {
            InitializeComponent();
        }

        public EditarCompetenciaView(VerCompetenciasView parent, CicloDTO ciclo, CompetenciaDTO competencia)
        {
            InitializeComponent();
            this.parent = parent;
            this.ciclo = ciclo;
            this.competencia = competencia;
            
            initViewer();
        }

        private async void initViewer()
        {
            await viewer.EnsureCoreWebView2Async(null);
            viewer.CoreWebView2.Navigate(ciclo.filePath);
        }
    }
}
