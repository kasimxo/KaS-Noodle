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


        public string ToCSV(string identificadorPadre, int numeroPadre, int cardinalidad)
        {
            string idPadre = identificadorPadre+";";
            string id = generarID(identificadorPadre, cardinalidad);
            string nombreCorto = generarNombreCorto(numeroPadre, cardinalidad);
            string descripcion = "\"<p dir=\"\"ltr\"\" style=\"\"text-align:left;\"\">Marco de competencias del ciclo de formación profesional: "+nombreCorto+".</p>\";";
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

        public string generarID(string idPadre, int cardinalidad)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            return idPadre + "_" + abc[cardinalidad] + ";";
        }

        public string generarNombreCorto(int numeroPadre, int cardinalidad) {
            return "CE "+ numeroPadre.ToString()+"."+cardinalidad.ToString()+";";
        }
    }
}
