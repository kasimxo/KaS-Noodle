using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model.dto
{
    public class CicloDTO
    {
        public string denominacion {  get; set; } //Desarrollo de Aplicaciones Multiplataforma
        public string siglas { get; set; } //DAM
        public string nivel {  get; set; } // B M S (Básico, Medio, Superior) 
        public string filePath {  get; set; }
        public Dictionary<string, CompetenciaDTO> competencias {  get; set; }

        public CicloDTO()
        {
            this.competencias = new Dictionary<string, CompetenciaDTO>();
        }
        public CicloDTO(string denominacion) { 
            this.denominacion = denominacion;
            this.siglas = denominacionToSiglas(denominacion);
            this.competencias = new Dictionary<string, CompetenciaDTO>();
        }

        public string denominacionToSiglas(string denominacion)
        {
            string siglas = "";
            foreach(string palabra in denominacion.Split(" "))
            {
                if (palabra.Length > 1 && char.IsUpper(palabra[0]))
                {
                    siglas += palabra[0];
                }
            }
            return siglas;
        }

        public string generarNombreCorto()
        {
            return "CFP" + categoria() + " " + siglas; 
        }

        /// <summary>
        /// Transforma el nivel en la categoría correspondiente:
        /// GB -> Grado Básico
        /// GM -> Grado Medio
        /// GS -> Grado Superior
        /// </summary>
        /// <returns></returns>
        public string categoria()
        {
            if (nivel == null) { return ""; }
            switch (nivel)
            {
                case "B":
                    return "GB";
                case "M":
                    return "GM";
                case "S":
                    return "GS";
                default:
                    return "";
            }
        }

        public string ID()
        {
            return "mc_" + categoria().ToLower() + "_" + siglas.ToLower() + ";";
        }

        public string ToCSV()
        {
            string idPadre = ";";
            string id = ID();
            string nombreCorto = generarNombreCorto() + ";";
            string descripcion = "\"<p dir=\"\"ltr\"\" style=\"\"text-align:left;\"\">Marco de competencias del ciclo de formación profesional: "+generarNombreCorto()+".</p>\";";
            string descripcionFormato = "1;"; //Fixed: 1
            string valoresEscala = "No competente aún,Competente;"; //Solo ciclo
            string configuracionEscala = "\"[{\"\"scaleid\"\":\"\"2\"\"},{\"\"id\"\":1,\"\"scaledefault\"\":1,\"\"proficient\"\":0},{\"\"id\"\":2,\"\"scaledefault\"\":0,\"\"proficient\"\":1}]\";"; //Solo ciclo
            string tipoRegla = ";"; //Opcional
            string resultadoRegla = ";"; //Opcional
            string configuracionRegla = ";"; //Opcional
            string idReferenciasCruzadasCompetencias = ";"; //Opcional
            string idExportacion = ";"; //Opcional
            string esMarcoCompetencias = "1;"; //Solo ciclo
            string taxonomia = "competency,outcome,indicator,level"; //Solo ciclo

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

            int cant = 0;

            foreach(CompetenciaDTO com in competencias.Values)
            {
                texto += "\n" + com.ToCSV(";", id,cant, generarNombreCorto());
                cant++;
            }

            return texto;
        }

    }
}
