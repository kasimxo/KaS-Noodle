using Noodle.components;
using Noodle.model.dto;
using System;
using System.Collections.Generic;
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
            MenuComponente menu = (MenuComponente) Program.mW.layout.GetControlFromPosition(0, 0);
            menu.marcarEstado(2);
            Program.mW.layout.GetControlFromPosition(1, 0).Dispose();
        }
    }
}
