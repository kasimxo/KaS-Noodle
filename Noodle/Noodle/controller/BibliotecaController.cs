using Noodle.components;
using Noodle.model.dal;
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
            NavegacionController.navegarVer();
        }

        public static async void eliminarMarcoCompetencias(MarcoCompetenciasDTO marco) 
        {
            if (MessageBox.Show("Se va a eliminar el marco de competencias " + marco.nombreCortoCSV + ", ¿estás seguro?", "Alerta", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                MarcoCompetenciasDAL.eliminarMarcoCompetencias(marco);
                NavegacionController.navegarBiblioteca();
            }
            else 
            {
                return;
            }

        }


    }
}
