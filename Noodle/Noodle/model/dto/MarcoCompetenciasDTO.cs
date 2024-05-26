using Noodle.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model.dto
{
    public class MarcoCompetenciasDTO
    {
        public string denominacion {  get; set; } //Desarrollo de Aplicaciones Multiplataforma
        public string siglas { get; set; } //DAM
        public string nivel {  get; set; } // B M S (Básico, Medio, Superior) 

        public string idPadreCSV { get; set; }
        public string idCSV { get; set; }
        public string nombreCortoCSV { get; set; }
        public string descripcionCSV { get; set; }
        public string descripcionFormatoCSV { get; set; }
        public string valoresEscalaCSV { get; set; }
        public string configuracionEscalaCSV { get; set; }
        public string tipoReglaCSV { get; set; }
        public string resultadoReglaCSV { get; set; }
        public string configuracionReglaCSV { get; set; }
        public string idReferenciasCruzadasCompetenciasCSV { get; set; }
        public string idExportacionCSV { get; set; }
        public string esMarcoCompetenciasCSV { get; set; }
        public string taxonomiaCSV { get; set; }

        //Id de este marco en la base de datos, se utiliza para recuperar las competencias, RA y CE
        public Int32 idDB { get; set; }

        public Dictionary<string, CompetenciaDTO> competencias {  get; set; }
        public string filePath { get; set; }


        public MarcoCompetenciasDTO()
        {
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
            return "mc_" + categoria().ToLower() + "_" + siglas.ToLower();
        }

        /// <summary>
        /// Inicia las variables para exportar CSV si no estaban iniciadas ya
        /// </summary>
        private void iniciarVariablesCSV() {
            idPadreCSV ??= "";
            idCSV ??= ID();
            nombreCortoCSV ??= generarNombreCorto();
            descripcionCSV ??= "<p dir=\"\"ltr\"\" style=\"\"text-align:left;\"\">Marco de competencias del ciclo de formación profesional: " + generarNombreCorto() + ".</p>";
            descripcionFormatoCSV ??= "1"; //Fixed: 1
            valoresEscalaCSV ??= "No competente aún,Competente"; //Solo ciclo
            configuracionEscalaCSV ??= "[{\"\"scaleid\"\":\"\"2\"\"},{\"\"id\"\":1,\"\"scaledefault\"\":1,\"\"proficient\"\":0},{\"\"id\"\":2,\"\"scaledefault\"\":0,\"\"proficient\"\":1}]"; //Solo ciclo
            tipoReglaCSV ??= ""; //Opcional
            resultadoReglaCSV ??= ""; //Opcional
            configuracionReglaCSV ??= ""; //Opcional
            idReferenciasCruzadasCompetenciasCSV ??= ""; //Opcional
            idExportacionCSV ??= ""; //Opcional
            esMarcoCompetenciasCSV ??= "1"; //Solo ciclo
            taxonomiaCSV ??= "competency,outcome,indicator,level"; //Solo ciclo
        }
        /// <summary>
        /// Metodo que exporta las variables de este marco para poder duplicarlo,
        /// se usar a la hora de exportar
        /// </summary>
        /// <returns></returns>
        public string[] CopiarVariables() 
        {
            string[] variables = {
                idPadreCSV,
                idCSV,
                nombreCortoCSV,
                descripcionCSV,
                descripcionFormatoCSV,
                valoresEscalaCSV,
                configuracionEscalaCSV,
                tipoReglaCSV,
                resultadoReglaCSV,
                configuracionReglaCSV,
                idReferenciasCruzadasCompetenciasCSV,
                idExportacionCSV,
                esMarcoCompetenciasCSV,
                taxonomiaCSV
            };
            return variables;
        }

        public string ToCSV()
        {
            iniciarVariablesCSV();
            
            string texto = "\"" + idPadreCSV + "\"" + Configuracion.CARACTER_CSV +
                "\"" + idCSV + "\"" + Configuracion.CARACTER_CSV +
                "\"" + nombreCortoCSV + "\"" + Configuracion.CARACTER_CSV +
                "\"" + descripcionCSV + "\"" + Configuracion.CARACTER_CSV +
                "\"" + descripcionFormatoCSV + "\"" + Configuracion.CARACTER_CSV +
                "\"" + valoresEscalaCSV + "\"" + Configuracion.CARACTER_CSV +
                "\"" + configuracionEscalaCSV + "\"" + Configuracion.CARACTER_CSV +
                "\"" + tipoReglaCSV + "\"" + Configuracion.CARACTER_CSV +
                "\"" + resultadoReglaCSV + "\"" + Configuracion.CARACTER_CSV +
                "\"" + configuracionReglaCSV + "\"" + Configuracion.CARACTER_CSV +
                "\"" + idReferenciasCruzadasCompetenciasCSV + "\"" + Configuracion.CARACTER_CSV +
                "\"" + idExportacionCSV + "\"" + Configuracion.CARACTER_CSV +
                "\"" + esMarcoCompetenciasCSV + "\"" + Configuracion.CARACTER_CSV +
                "\"" + taxonomiaCSV + "\"";

            int cant = 0;

            foreach(CompetenciaDTO com in competencias.Values)
            {
                texto += "\n" + com.ToCSV(",", idCSV,cant, generarNombreCorto());
                cant++;
            }

            return texto;
        }

        public void fromCSV(string[] linea)
        {
            //0 Identificador padre
            idPadreCSV = linea[0];
            //1 Identificador
            idCSV = linea[1];
            //2 Nombre corto
            nombreCortoCSV = linea[2];
            denominacion = nombreCortoCSV; //Al sacarlo del csv, guardamos el nombre de esta forma
            //3 Descripción
            descripcionCSV = linea[3];
            //4 Descripción del formato
            descripcionFormatoCSV = linea[4];
            //5 Valores de escala
            valoresEscalaCSV = linea[5];
            //6 Configuración de escala
            configuracionEscalaCSV = linea[6];
            //7 Tipo de regla (opcional)
            tipoReglaCSV = linea[7];
            //8 Resultado de la regla (opcional)
            resultadoReglaCSV = linea[8];
            //9 Configuración de regla (opcional)
            configuracionReglaCSV = linea[9];
            //10 Identificadores de referencias cruzadas de competencias
            idReferenciasCruzadasCompetenciasCSV = linea[10];
            //11 Identificador de la exportación (opcional)
            idExportacionCSV = linea[11];
            //12 Es marco de competencias
            esMarcoCompetenciasCSV = linea[12];
            //13 Taxonomía
            taxonomiaCSV = linea[13];
        }

        public void addCompetenciaFromCSV(string[] linea)
        {
            CompetenciaDTO competencia = new CompetenciaDTO();
            competencia.fromCSV(linea);
            competencias.Add(linea[1], competencia);
        }

        /// <summary>
        /// Como no se puede distinguir entre RA y CE directamente, probamos
        /// </summary>
        /// <param name="contenidos"></param>
        /// <exception cref="NotImplementedException"></exception>
        internal void addResultadoCriterioFromCSV(string[] contenidos)
        {
            string idPadreObjeto = contenidos[0];
            if (competencias.ContainsKey(idPadreObjeto))
            {
                competencias[idPadreObjeto].addResultadoAprendizajeFromCSV(contenidos);
            }
            else 
            {
                foreach(CompetenciaDTO com in competencias.Values) 
                {
                    if (com.ras.ContainsKey(idPadreObjeto))
                    {
                        com.ras[idPadreObjeto].addCriterioEvaluacionFromCSV(contenidos);
                    }
                }
            }
        }
    }
}
