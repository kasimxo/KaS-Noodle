using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model.dto
{
    public class CriterioEvaluacionDTO
    {
        public string nombre { get; set; }

        public CriterioEvaluacionDTO(string nombre)
        {
            this.nombre = nombre;
        }


        public string ToCSV()
        {
            string idPadre = ";";
            string id = "mc_gs_dam;";
            string nombreCorto = "CFPGS DAM;";
            string descripcion = "\"<p dir=\"\"ltr\"\" style=\"\"text-align:left;\"\">Marco de competencias del ciclo de formación profesional: CFPGM SMR.</p>\";";
            string descripcionFormato = "1;"; //Fixed: 1
            string valoresEscala = ";"; //Solo ciclo
            string configuracionEscala = ";"; //Solo ciclo
            string tipoRegla = ";"; //Opcional
            string resultadoRegla = ";"; //Opcional
            string configuracionRegla = ";"; //Opcional
            string idReferenciasCruzadasCompetencias = ";"; //Opcional
            string idExportacion = ";"; //Opcional
            string esMarcoCompetencias = ";"; //Solo ciclo
            string taxonomia = ""; //Solo ciclo

            string texto = idPadre +
                id +
                nombreCorto +
                descripcion +
                descripcionFormato +
                valoresEscala +
                configuracionEscala +
                tipoRegla +
                resultadoRegla +
                configuracionRegla +
                idReferenciasCruzadasCompetencias +
                idExportacion +
                esMarcoCompetencias +
            taxonomia;

            return texto;
        }
    }
}
