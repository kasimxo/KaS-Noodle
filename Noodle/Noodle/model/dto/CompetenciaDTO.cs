using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model.dto
{
    public class CompetenciaDTO
    {
        private List<ResultadoAprendizajeDTO> ras { get; set; }
        private string nombre {  get; set; }

        public CompetenciaDTO() { }
        public CompetenciaDTO(List<ResultadoAprendizajeDTO> ras, string nombre)
        {
            this.ras = ras;
            this.nombre = nombre;
        }
    }
}
