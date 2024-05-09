using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
