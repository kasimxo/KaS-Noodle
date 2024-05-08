using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model.dto
{
    public class ResultadoAprendizajeDTO
    {
        private List<CriterioEvaluacionDTO> criterios {  get; set; }
        private string nombre {  get; set; }

        public ResultadoAprendizajeDTO() {
            this.criterios = new List<CriterioEvaluacionDTO>();
        }

        public ResultadoAprendizajeDTO(List<CriterioEvaluacionDTO> criterios)
        {
            this.criterios = criterios;
        }
    }
}
