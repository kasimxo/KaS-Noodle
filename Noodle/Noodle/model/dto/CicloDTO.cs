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
        public string nivel {  get; set; } // Básico Medio Superior
        
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

            foreach(CompetenciaDTO com in competencias.Values)
            {
                texto += "\n" + com.ToCSV();
            }

            return null;
        }
    }
}
