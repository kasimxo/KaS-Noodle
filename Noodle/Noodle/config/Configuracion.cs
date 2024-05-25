using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.config
{
    /// <summary>
    /// Clase que se utiliza para establecer y leer variables en la aplicacion
    /// </summary>
    public class Configuracion
    {

        public const string CARACTER_CSV = ",";
        public const string CABECERAS_CSV = "\"Identificador padre\",\"Identificador\",\"Nombre corto\",\"Descripción\",\"Descripción del formato\",\"Valores de escala\",\"Configuración de escala\",\"Tipo de regla (opcional)\",\"Resultado de la regla (opcional)\",\"Configuración de regla (opcional)\",\"Identificadores de referencias cruzadas de competencias\",\"Identificador de la exportación (opcional)\",\"Es marco de competencias\",\"Taxonomía\"";
        public const string CONNECTION_STRING = "Host=localhost;Username=postgres;Password=1234;Database=noodleDB";
    
    }
}
