using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model.dto
{
    public class CompetenciaDTO
    {
        //public List<ResultadoAprendizajeDTO> ras { get; set; }
        public Dictionary<string, ResultadoAprendizajeDTO> ras { get; set; }
        public string nombre {  get; set; }

        public string siglas;
        public string nivel; //basico medio superior

        public CompetenciaDTO() { }
        public CompetenciaDTO(string nombre)
        {
            this.nombre = nombre;
            this.siglas = "DAM";
            this.nivel = "GS";
            //this.ras = new List<ResultadoAprendizajeDTO>();
            this.ras = new Dictionary<string, ResultadoAprendizajeDTO>();
        }
        public CompetenciaDTO(List<ResultadoAprendizajeDTO> ras, string nombre)
        {
            this.ras = new Dictionary<string, ResultadoAprendizajeDTO>();
            this.nombre = nombre;
        }



        public string ToCSV(string identificadorPadre, string identificador, int cardinalidad, string nombreCiclo)
        {
            //Las competencias no necesitan del id padre, pero lo utilizan para generar su id propio
            string idPadre = identificadorPadre;
            string id = identificador;
            string nombreCorto = NombreCorto(cardinalidad);
            string descripcion = "\"<p dir=\"\"ltr\"\" style=\"\"text-align:left;\"\">Marco de competencias del ciclo de formación profesional: "+nombreCiclo+".</p>\";";
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
            foreach(ResultadoAprendizajeDTO ra in ras.Values)
            {
                texto += "\n" + ra.ToCSV(id, cantidad);
                cantidad++;
            }
            return texto;
        }

        public string NombreCorto(int cardinalidad)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            return  "CPPS " + abc[cardinalidad] + ");";
        }
    }
}
