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

        public CompetenciaDTO() { }
        public CompetenciaDTO(string nombre)
        {
            this.nombre = nombre;
            //this.ras = new List<ResultadoAprendizajeDTO>();
            this.ras = new Dictionary<string, ResultadoAprendizajeDTO>();
        }
        public CompetenciaDTO(List<ResultadoAprendizajeDTO> ras, string nombre)
        {
            this.ras = new Dictionary<string, ResultadoAprendizajeDTO>();
            this.nombre = nombre;
        }
    }
}
