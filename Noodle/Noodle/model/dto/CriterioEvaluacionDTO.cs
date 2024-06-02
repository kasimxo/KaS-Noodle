using Noodle.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Noodle.model.dto
{
    public class CriterioEvaluacionDTO
    {
        public string contenido { get; set; }
        public int pag { get; set; }

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
        public Int32 idDB { get; set; }

        public CriterioEvaluacionDTO(string nombre, int pag)
        {
            this.contenido = nombre;
            this.descripcionCSV = nombre;
            this.pag = pag;
        }

        public CriterioEvaluacionDTO() { }


        public string ToCSV(string identificadorPadre, int numeroPadre, int cardinalidad)
        {
            iniciarVariablesCSV(identificadorPadre, numeroPadre, cardinalidad);


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

            return texto;
        }

        private void iniciarVariablesCSV(string identificadorPadre, int numeroPadre, int cardinalidad)
        {
            idPadreCSV ??= identificadorPadre.Replace("\"", "").Replace(",", "");
            idCSV ??= generarID(identificadorPadre.Replace("\"", "").Replace(",", ""), cardinalidad);
            nombreCortoCSV ??= generarNombreCorto(numeroPadre, cardinalidad);
            descripcionCSV ??= "<p dir=\"\"ltr\"\" style=\"\"text-align:left;\"\">" + contenido + "</p>";
            descripcionFormatoCSV ??= "1"; //Fixed: 1
            valoresEscalaCSV ??= ""; //Solo ciclo
            configuracionEscalaCSV ??= ""; //Solo ciclo
            tipoReglaCSV ??= ""; //Opcional
            resultadoReglaCSV ??= ""; //Opcional
            configuracionReglaCSV ??= ""; //Opcional
            idReferenciasCruzadasCompetenciasCSV ??= ""; //Opcional
            idExportacionCSV ??= ""; //Opcional
            esMarcoCompetenciasCSV ??= ""; //Solo ciclo
            taxonomiaCSV ??= ""; //Opcional
        }

        public string generarID(string idPadre, int cardinalidad)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            return idPadre + "_" + abc[cardinalidad];
        }

        public string generarNombreCorto(int numeroPadre, int cardinalidad) {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            return "CE "+ numeroPadre.ToString()+"."+ abc[cardinalidad];
        }

        internal void fromCSV(string[] linea)
        {
            //0 Identificador padre
            idPadreCSV = linea[0];
            //1 Identificador
            idCSV = linea[1];
            //2 Nombre corto
            nombreCortoCSV = linea[2];
            //3 Descripción
            descripcionCSV = linea[3];
            contenido = limpiarDescripcion(linea[3]);
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

        private string limpiarDescripcion(string descripcion)
        {
            return Regex.Replace(descripcion, @"<[^>]+>|&nbsp;", "");
        }
    }
}
