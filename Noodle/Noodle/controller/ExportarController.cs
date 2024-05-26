using Noodle.components;
using Noodle.model.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.controller
{
    public class ExportarController
    {

        public static void navegarExportarController(MarcoCompetenciasDTO marco) 
        {
            MenuComponente menu = (MenuComponente)Program.mW.layout.GetControlFromPosition(0, 0);
            menu.marcarEstado(4);
            if (Program.mW.layout.GetControlFromPosition(1, 0) != null)
            {
                Program.mW.layout.GetControlFromPosition(1, 0).Dispose();
            }
            ExportarCompetenciasComponente ecc = new ExportarCompetenciasComponente(marco);
            Program.mW.layout.Controls.Add(ecc, 1, 0);
        }
    }
}
