using Microsoft.VisualBasic.FileIO;
using Noodle.model.dto;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model.action
{
    /// <summary>
    /// Clase encargada de procesar un archivo CSV con competencias y devolver un Ciclo
    /// Puede fallar si el formato del csv no es el correcto
    /// </summary>
    public class ProcesarArchivoCsvAction
    {
        public static MarcoCompetenciasDTO extraerCompetencias(string filePath) {
            MarcoCompetenciasDTO marco = new MarcoCompetenciasDTO();

            using (TextFieldParser csvParser = new TextFieldParser(filePath))
            {
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                //Ignoramos la línea de cabeceras
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    string[] contenidos = csvParser.ReadFields();

                    //En la posicion 12 está el indicador de marco competencias
                    if (contenidos[12].CompareTo("1") == 0)
                    {
                        marco.fromCSV(contenidos);
                    } else if (contenidos[0] == "")
                    {
                        //Al no tener un identificador padre es una competencia
                        marco.addCompetenciaFromCSV(contenidos);
                    }else {
                        //No se puede distinguir entre RA y CE
                        marco.addResultadoCriterioFromCSV(contenidos);
                    }


                    Debug.WriteLine(contenidos);
                }
            }
            

            return marco;
        }
    }
}
