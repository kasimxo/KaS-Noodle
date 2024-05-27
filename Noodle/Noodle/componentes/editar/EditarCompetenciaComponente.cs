using Noodle.componentes.editar;
using Noodle.model.dto;
using Noodle.view;
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
    public partial class EditarCompetenciaComponente : UserControl
    {
        public CompetenciaDTO com { get; set; }
        public EditarCompetenciaComponente(CompetenciaDTO competencia)
        {
            InitializeComponent();
            this.com = competencia;
            inciarCompetencia();
        }

        /// <summary>
        /// Carga todo el contenido de la competencia
        /// </summary>
        private void inciarCompetencia() 
        { 
            DetalleCompetenciaEditable dce = new DetalleCompetenciaEditable(this.com);
            dce.Dock = DockStyle.Fill;

            //Si no tiene el filepath, quitamos el file viewer y ampliamos todo
            if (Program.marco == null || Program.marco.filePath == null || !File.Exists(Program.marco.filePath))
            {
                container.GetControlFromPosition(0, 0).Dispose();
                container.Controls.Add(dce, 0, 0);
                container.ColumnCount--;
            }
            else 
            {
                container.Controls.Add(dce, 1, 0);
            }
        }
    }
}
