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
                    foreach(var linea in lineas ) {
                        System.Diagnostics.Debug.WriteLine(linea+"\n---");
                        //System.Diagnostics.Debug.WriteLine("----");



                        //Procesa una lína para asegurarse de que termina correctamente
                        if (linea.Length > 2 && linea[linea.Length - 1] == '\r')
                        {
                            
                            linea.Substring(0, linea.Length - 1);
                            linea = linea.replaceAll("\\s+$", "");

                            if (linea.Length > 1 && (linea[linea.Length - 1] == '.' || linea[linea.Length - 1] == ':'))
                            {
                                frase = "";
                                //Esto no tiene mucho sentido porque una línea puede terminar en un punto por casualidad

                            }
                        }
                        else if (linea.compareTo("") == 0)
                        {
                            frase = "";
                        }
                        frase += linea;

                        //Identifica módulos profesionales
                        if ((linea.Trim().toLowerCase().startsWith("módulo profesional") || linea.Trim().toLowerCase().startsWith("modulo profesional")) && linea.toLowerCase().contains(":"))
                        {

                            //System.out.println(linea);
                            String mod = linea.Substring(linea.indexOf(":") + 1);
                            //System.out.println(mod);

                            //Comprueba si están en el mapa y si no es así los mete
                            if (!modulos.containsKey(mod))
                            {
                                modulos.put(mod, new Modulo(mod));
                                modu = mod;
                            }
                            //modulos.add(new Modulo(mod));
                            modulo = true;

                        }

                        if (modulo)
                        {
                            //System.out.print(linea);
                            //System.out.println("PENE");
                            //System.exit(0);
                            if (linea.Trim().toLowerCase().startsWith("resultados de aprendizaje y criterios de evaluaci"))
                            {
                                resultadoAprendizaje = true;
                            }
                            if (resultadoAprendizaje)
                            {
                                //Aquí vamos a procesar la línea porque estamos dentro de los resultados de aprendizaje

                                if (linea.matches("^[1-9]\\.\\s.*"))
                                {
                                    //Aquí hacemos match de RA

                                    modulos.get(modu).addResultadoAprendizaje(linea);
                                    ultimora = linea;
                                    frase = "";
                                }
                                if (linea.Trim().toLowerCase().startsWith("criterios de evaluaci"))
                                {
                                    criteriosEvaluacion = true;
                                }
                                if (linea.Trim().toLowerCase().matches("^[a-z]\\).*"))
                                {

                                    modulos.get(modu).addCriterioEvaluacion(ultimora, linea);
                                   
                                }
                            }
                        }

                        if (linea.Trim().toLowerCase().startsWith("contenidos"))
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

            }

            return null;
        }

    }
}
