using Noodle.model.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model.action
{
    public class ProcesarArchivoAction
    {
        public static CicloDTO procesarArchivoSegunFormato(string filePath)
        {
            try
            {
                string fileExtension = Path.GetExtension(filePath);
                switch (fileExtension)
                {
                    case ".pdf":
                        return ProcesarArchivoPdfAction.extraerCompetencias(filePath);
                    case ".csv":
                        return ProcesarArchivoCsvAction.extraerCompetencias(filePath);
                    default:
                        MessageBox.Show("Error: Formato no reconocido");
                        return null;
                }
            }
            catch (ArgumentException ae) {
                MessageBox.Show("Error: Se ha producido un error procesando el archivo");
                return null;
            }
        }
    }
}
