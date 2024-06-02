using Noodle.config;
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
        public int pag { get; set; }
        public string siglas { get; set; }
        public string nivel { get; set; } //basico medio superior

        public Int32 idDB { get; set; } // id de la competencia en la base de datos

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



        public CompetenciaDTO() 
        {
            this.ras = new Dictionary<string, ResultadoAprendizajeDTO>();
        }

        public CompetenciaDTO(string nombre, int pag)
        {
            this.nombre = nombre;
            this.pag = pag;
            this.ras = new Dictionary<string, ResultadoAprendizajeDTO>();
            this.nombreCortoCSV = nombre;
        }

        public string generarIdentificador(string idPadre, int cardinalidad) {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            return idPadre.Substring(0, idPadre.Length - 1) + "_" + abc[cardinalidad];
        }

        public string ToCSV(string identificadorPadre, string identificador, int cardinalidad, string nombreCiclo)
        {
            iniciarVariablesCSV(identificadorPadre, identificador, cardinalidad, nombreCiclo);

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

            int cantidad = 0;
            foreach(ResultadoAprendizajeDTO ra in ras.Values)
            {
                texto += "\n" + ra.ToCSV(idCSV, cantidad);
                cantidad++;
            }
            return texto;
        }

        public string NombreCorto(int cardinalidad)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            return  "CPPS " + abc[cardinalidad] + ") " + nombre;
        }


        public void fromCSV(string[] linea)
        {
            //0 Identificador padre
            idPadreCSV = linea[0];
            //1 Identificador
            idCSV = linea[1];
            //2 Nombre corto
            nombreCortoCSV = linea[2];
            nombre = nombreCortoCSV; //Al sacarlo del csv, guardamos el nombre de esta forma
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


        /// <summary>
        /// Inicia las variables para exportar CSV si no estaban iniciadas ya
        /// </summary>
        private void iniciarVariablesCSV(string identificadorPadre, string identificador, int cardinalidad, string nombreCiclo)
        {

            //Las competencias no necesitan del id padre, pero lo utilizan para generar su id propio
            idPadreCSV ??= identificadorPadre.Replace(",", "");
            idCSV ??= generarIdentificador(identificador, cardinalidad);
            nombreCortoCSV ??= NombreCorto(cardinalidad);
            //La descripción en las competencias se deja vacía
            descripcionCSV ??= "<p dir=\"\"ltr\"\" style=\"\"text-align:left;\"\">"+"</p>";
            descripcionFormatoCSV ??= "1"; //Fixed: 1
            valoresEscalaCSV ??= ""; //Solo ciclo
            configuracionEscalaCSV ??= ""; //Solo ciclo
            tipoReglaCSV ??= ""; //Opcional
            resultadoReglaCSV ??= ""; //Opcional
            configuracionReglaCSV ??= ""; //Opcional
            idReferenciasCruzadasCompetenciasCSV ??= ""; //Opcional
            idExportacionCSV ??= ""; //Opcional
            esMarcoCompetenciasCSV ??= ""; //Solo ciclo
            taxonomiaCSV ??= ""; //Solo ciclo
        }

        internal void addResultadoAprendizajeFromCSV(string[] linea)
        {
            ResultadoAprendizajeDTO resultadoAprendizaje = new ResultadoAprendizajeDTO();
            resultadoAprendizaje.fromCSV(linea);
            ras.Add(linea[1], resultadoAprendizaje);
        }
    }
}
