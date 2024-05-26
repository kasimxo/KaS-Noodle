using Noodle.config;
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
        public Int32 idDB { get; set; } //id en la base de datos

        public ResultadoAprendizajeDTO() {
            this.criterios = new Dictionary<string, CriterioEvaluacionDTO>();
        }

        public ResultadoAprendizajeDTO(string nombre) {
            this.nombre = nombre;
            this.criterios = new Dictionary<string, CriterioEvaluacionDTO>();
        }
        public ResultadoAprendizajeDTO(string nombre, int pag)
        {
            this.nombre = nombre;
            this.pag = pag;
            this.criterios = new Dictionary<string, CriterioEvaluacionDTO>();
        }

        public ResultadoAprendizajeDTO(Dictionary<string, CriterioEvaluacionDTO> criterios)
        {
            this.criterios = criterios;
        }

        public string ToCSV(string identificadorPadre, int cardinalidad)
        {
            iniciarVariablesCSV(identificadorPadre, cardinalidad);

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
            foreach (CriterioEvaluacionDTO ce in criterios.Values)
            {
                texto += "\n" + ce.ToCSV(idCSV,cardinalidad,cantidad);
                cantidad++;
            }
            return texto;
        }

        private void iniciarVariablesCSV(string identificadorPadre, int cardinalidad)
        {

            idPadreCSV ??= identificadorPadre.Replace("\"", "").Replace(",", "");
            idCSV ??= generarID(identificadorPadre.Replace("\"", "").Replace(",", ""), cardinalidad);
            nombreCortoCSV ??= generarNombreCorto(cardinalidad);
            descripcionCSV ??= "<p dir=\"\"ltr\"\" style=\"\"text-align:left;\"\">Marco de competencias del ciclo de formación profesional: " + generarNombreCorto(cardinalidad) + ".</p>";
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

        public string generarID(string idPadre, int cardinalidad)
        {
            return idPadre +"_"+cardinalidad.ToString();
        }

        public string generarNombreCorto(int cardinalidad) {
            return "RA " + cardinalidad.ToString()+": "+nombre;
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

        public void addCriterioEvaluacionFromCSV(string[] linea)
        {
            CriterioEvaluacionDTO ce = new CriterioEvaluacionDTO();
            ce.fromCSV(linea);
            criterios.Add(linea[1], ce);
        }
    }
}
