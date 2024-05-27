using Noodle.components;
using Noodle.model.dto;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.controller
{
    public class BibliotecaController
    {
        //Navega a VerCompetencias del marco clicado
        public static void verMarco(MarcoCompetenciasDTO marco) 
        {
            //Establecemos el marco como marco en focus
            Program.marco = marco;
            Program.competencia = null; //Si huebiera alguna competencia anterior en focus, la quitamos
            MenuComponente menu = (MenuComponente) Program.mW.layout.GetControlFromPosition(0, 0);
            menu.marcarEstado(3);
            if (Program.mW.layout.GetControlFromPosition(1, 0) != null) 
            {
                Program.mW.layout.GetControlFromPosition(1, 0).Dispose();
            }
            
            VerCompetenciasComponente vcc = new VerCompetenciasComponente(Program.marco);
            vcc.Dock = DockStyle.Fill;
            Program.mW.layout.Controls.Add(vcc, 1, 0);
        }
    }
}
