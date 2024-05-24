using Noodle.config;
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
        public int pag { get; set; }

        public CriterioEvaluacionDTO(string nombre)
        {
            this.nombre = nombre;
        }

        public CriterioEvaluacionDTO(string nombre, int pag)
        {
            this.nombre = nombre;
            this.pag = pag;
        }


        public string ToCSV(string identificadorPadre, int numeroPadre, int cardinalidad)
        {
            string idPadre = identificadorPadre;
            string id = generarID(identificadorPadre, cardinalidad);
            string nombreCorto = generarNombreCorto(numeroPadre, cardinalidad) + Configuracion.CARACTER_CSV;
            string descripcion = "\"<p dir=\"\"ltr\"\" style=\"\"text-align:left;\"\">"+nombre+"</p>\""+ Configuracion.CARACTER_CSV;
            string descripcionFormato = "1"+ Configuracion.CARACTER_CSV; //Fixed: 1
            string valoresEscala = Configuracion.CARACTER_CSV; //Solo ciclo
            string configuracionEscala = Configuracion.CARACTER_CSV; //Solo ciclo
            string tipoRegla = Configuracion.CARACTER_CSV; //Opcional
            string resultadoRegla = Configuracion.CARACTER_CSV; //Opcional
            string configuracionRegla = Configuracion.CARACTER_CSV; //Opcional
            string idReferenciasCruzadasCompetencias = Configuracion.CARACTER_CSV; //Opcional
            string idExportacion = Configuracion.CARACTER_CSV; //Opcional
            string esMarcoCompetencias = Configuracion.CARACTER_CSV; //Solo ciclo
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
            return idPadre.Substring(0, idPadre.Length - 1) + "_" + abc[cardinalidad] + Configuracion.CARACTER_CSV;
        }

        public string generarNombreCorto(int numeroPadre, int cardinalidad) {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            return "CE "+ numeroPadre.ToString()+"."+ abc[cardinalidad];
        }
    }
}
