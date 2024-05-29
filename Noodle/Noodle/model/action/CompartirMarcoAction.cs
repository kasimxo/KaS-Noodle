using Noodle.controller;
using Noodle.model.dto;
using Noodle.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model.action
{
    public class CompartirMarcoAction
    {
        /// <summary>
        /// Método que abre un form para compartir un marco seleccionado
        /// </summary>
        public static void compartirMarcoForm(MarcoCompetenciasDTO marco) 
        {
            CompartirMarcoView cmv = new CompartirMarcoView(marco);
            CompartirController.actualizarListaCompartidos(cmv);
            cmv.Show();
            return;
        }
    }
}
