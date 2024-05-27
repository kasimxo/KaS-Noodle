using Noodle.model.dal;
using Noodle.model.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noodle.components
{
    public partial class BibliotecaComponente : UserControl
    {
        public BibliotecaComponente()
        {
            InitializeComponent();
            popularBibliotecaCompetencias();
        }

        public async void popularBibliotecaCompetencias() 
        {
            var numeroMarcos = await MarcoCompetenciasDAL.numeroMarcosCompetencias();
            if (Program.marcos == null || Program.marcos.Count == 0 || Program.marcos.Count != numeroMarcos) 
            {
                Program.marcos = await MarcoCompetenciasDAL.cargarMarcosCompetencias();
            }

            foreach (MarcoCompetenciasDTO marco in Program.marcos.Values) 
            {
                TituloMarcoCompetenciasComponente tmcc = new TituloMarcoCompetenciasComponente(marco);
                flp.Controls.Add(tmcc);
            }
            
        }
    }
}
