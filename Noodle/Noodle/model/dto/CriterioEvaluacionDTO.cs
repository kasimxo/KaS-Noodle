using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model.dto
{
    public class CriterioEvaluacionDTO
    {
        public string nombre {  get; set; }

        public CriterioEvaluacionDTO(string nombre) { 
            this.nombre = nombre;
        }
    }
}
