using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model.dto
{
    public class ResultadoAprendizajeDTO
    {
        //public List<CriterioEvaluacionDTO> criterios {  get; set; }
        public Dictionary<string, CriterioEvaluacionDTO> criterios { get; set; }
        public string nombre {  get; set; }

        public ResultadoAprendizajeDTO() {
            //this.criterios = new List<CriterioEvaluacionDTO>();
            this.criterios = new Dictionary<string, CriterioEvaluacionDTO>();
        }

        public ResultadoAprendizajeDTO(string nombre) {
            this.nombre = nombre;
            //this.criterios = new List<CriterioEvaluacionDTO>();
            this.criterios = new Dictionary<string, CriterioEvaluacionDTO>();
        }

        /*
        public ResultadoAprendizajeDTO(List<CriterioEvaluacionDTO> criterios)
        {
            this.criterios = criterios;
        }
        */
        public ResultadoAprendizajeDTO(Dictionary<string, CriterioEvaluacionDTO> criterios)
        {
            this.criterios = criterios;
        }

        public string ToCSV(string identificadorPadre, int cardinalidad)
        {
            string idPadre = identificadorPadre;
            string id = generarID(identificadorPadre, cardinalidad);
            string nombreCorto = generarNombreCorto(cardinalidad) + ";";
            string descripcion = "\"<p dir=\"\"ltr\"\" style=\"\"text-align:left;\"\">Marco de competencias del ciclo de formación profesional: "+ generarNombreCorto(cardinalidad) + ".</p>\";";
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

            int cantidad = 0;
            foreach (CriterioEvaluacionDTO ce in criterios.Values)
            {
                texto += "\n" + ce.ToCSV(id,cardinalidad,cantidad);
                cantidad++;
            }
            return texto;
        }

        public string generarID(string idPadre, int cardinalidad)
        {
            return idPadre.Substring(0, idPadre.Length-1) +"_"+cardinalidad.ToString()+";";
        }

        public string generarNombreCorto(int cardinalidad) {
            return "RA " + cardinalidad.ToString();
        }
    }
}
