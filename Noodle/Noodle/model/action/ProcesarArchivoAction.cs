using Noodle.model.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor;
using UglyToad.PdfPig;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Noodle.model.action
{
    public class ProcesarArchivoAction
    {
        public ProcesarArchivoAction(string filename) { }

        public static List<CompetenciaDTO> extraerCompetencias(string filePath)
        {
            Dictionary<string, CompetenciaDTO> competencias = new Dictionary<string, CompetenciaDTO>();
            string modu = "";
            string ultimora = "";
            Boolean modulo = false;
            Boolean resultadoAprendizaje = false;
            Boolean criteriosEvaluacion = false;

            using (var document = PdfDocument.Open(filePath))
            {
                //Recorremos todas las páginas una a una
                //Empieza en la página 1
                for (var i = 1; i <= document.NumberOfPages; i++) {
                    var page = document.GetPage(i);
                    var text = ContentOrderTextExtractor.GetText(page, true);

                    var lineas = text.Split("\n");
                    string frase = "";
                    foreach(var line in lineas ) {
                        string linea = line;
                        System.Diagnostics.Debug.WriteLine(linea+"\n---");
                        //System.Diagnostics.Debug.WriteLine("----");



                        //Procesa una lína para asegurarse de que termina correctamente
                        if (linea.Length > 2 && linea[linea.Length - 1] == '\r')
                        {
                            
                            linea.Substring(0, linea.Length - 1);
                            linea = linea.Replace("\\s+$", "");

                            if (linea.Length > 1 && (linea[linea.Length - 1] == '.' || linea[linea.Length - 1] == ':'))
                            {
                                frase = "";
                                //Esto no tiene mucho sentido porque una línea puede terminar en un punto por casualidad

                            }
                        }
                        else if (linea.Equals(""))
                        {
                            frase = "";
                        }
                        frase += linea;

                        //Identifica módulos profesionales
                        if ((linea.Trim().ToLower().StartsWith("módulo profesional") || linea.Trim().ToLower().StartsWith("modulo profesional")) && linea.ToLower().Contains(":"))
                        {

                            //System.out.println(linea);
                            String mod = linea.Substring(linea.IndexOf(":") + 1);
                            //System.out.println(mod);

                            //Comprueba si están en el mapa y si no es así los mete
                            if (!competencias.ContainsKey(mod))
                            {
                                competencias.Add(mod, new CompetenciaDTO(mod));
                                modu = mod;
                            }
                            //modulos.add(new Modulo(mod));
                            modulo = true;

                        }

                        if (modulo)
                        {
                            
                            if (linea.Trim().ToLower().StartsWith("resultados de aprendizaje y criterios de evaluaci"))
                            {
                                resultadoAprendizaje = true;
                            }
                            if (resultadoAprendizaje)
                            {
                                //Aquí vamos a procesar la línea porque estamos dentro de los resultados de aprendizaje

                                Regex reg1 = new Regex("^[1-9]\\.\\s.*");
                                if (reg1.IsMatch(linea))
                                {
                                    //Aquí hacemos match de RA
                                    competencias[modu].ras.Add(linea, new ResultadoAprendizajeDTO(linea));
                                    ultimora = linea;
                                    frase = "";
                                }
                                if (linea.Trim().ToLower().StartsWith("criterios de evaluaci"))
                                {
                                    criteriosEvaluacion = true;
                                }

                                if (criteriosEvaluacion) {
                                    Regex reg = new Regex("^[a-z]\\).*");

                                    if (reg.IsMatch(linea.Trim().ToLower()))
                                    {
                                        try
                                        {
                                            CriterioEvaluacionDTO ce = new CriterioEvaluacionDTO(linea);
                                            competencias[modu].ras[ultimora].criterios.Add(linea, ce);
                                        }
                                        catch (Exception e) { }
                                    }
                                }
                                
                            }
                        }

                        if (linea.Trim().ToLower().StartsWith("contenidos"))
                        {
                            modulo = false;
                            resultadoAprendizaje = false;
                            criteriosEvaluacion = false;
                            ultimora = "";
                            modu = "";
                        
                    }
                }

                    
                }

            }

            

            

            return diccionarioToList(competencias);
        }
        private static List<CompetenciaDTO> diccionarioToList(Dictionary<string, CompetenciaDTO> competencias)
        {
            List<CompetenciaDTO> resultado = new List<CompetenciaDTO>();

            foreach (CompetenciaDTO c in competencias.Values)
            {
                resultado.Add(c);
            }

            return resultado;
        }
    }

    
}
