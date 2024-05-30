using Noodle.components;
using Noodle.model.dto;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Noodle.controller
{
    public static class VerCompetenciasController
    {
        public static void abrirDetalleCompetencia() 
        {
            //Primero limpia por si hubiera una ya abierta
            VerCompetenciasComponente vcc = (VerCompetenciasComponente) Program.mW.layout.GetControlFromPosition(1, 0);

            if (vcc.container.GetControlFromPosition(1, 0) != null) {
                vcc.container.GetControlFromPosition(1, 0).Dispose();
            }
            

            DetalleCompetenciaComponente dcc = new DetalleCompetenciaComponente(Program.competencia);
            dcc.Dock = DockStyle.Fill;
            vcc.container.Controls.Add(dcc, 1, 0);
        }

    }
}
