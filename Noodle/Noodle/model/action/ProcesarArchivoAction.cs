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

        public static CicloDTO extraerCompetencias(string filePath)
        {
            CicloDTO ciclo = new CicloDTO();
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
                for (var i = 1; i <= document.NumberOfPages; i++)
                {
                    var page = document.GetPage(i);
                    var text = ContentOrderTextExtractor.GetText(page, true);
                    text = text.Replace("\r", "");
                    var lineas = text.Split("\n");
                    string frase = "";
                    foreach (var line in lineas)
                    {
                        string linea = line;
                        //System.Diagnostics.Debug.WriteLine(linea+"\n---");
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

                        //Identifica la denominación del ciclo
                        if ((linea.Trim().ToLower().StartsWith("denominación") || linea.Trim().ToLower().StartsWith("denominacion")) && linea.ToLower().Contains(":"))
                        {
                            ciclo.denominacion = limpiar(linea.Substring(linea.IndexOf(":") + 1));
                            ciclo.siglas = ciclo.denominacionToSiglas(ciclo.denominacion);
                        }

                        if (linea.Trim().ToLower().StartsWith("nivel") && linea.ToLower().Contains(":"))
                        {
                            if (linea.ToLower().Contains("superior"))
                            {
                                ciclo.nivel = "Superior";
                            } else if (linea.ToLower().Contains("medio"))
                            {
                                ciclo.nivel = "Medio";
                            }
                            else if (linea.ToLower().Contains("basico") || linea.ToLower().Contains("básico"))
                            {
                                ciclo.nivel = "Básico";
                            }
                        }

                        //Identifica módulos profesionales
                        if ((linea.Trim().ToLower().StartsWith("módulo profesional") || linea.Trim().ToLower().StartsWith("modulo profesional")) && linea.ToLower().Contains(":"))
                        {
                            String mod = linea.Substring(linea.IndexOf(":") + 1);

                            mod = limpiar(mod);

                            //Comprueba si están en el mapa y si no es así los mete
                            if (!ciclo.competencias.ContainsKey(mod))
                            {
                                ciclo.competencias.Add(mod, new CompetenciaDTO(mod));
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
                                    ciclo.competencias[modu].ras.Add(linea, new ResultadoAprendizajeDTO(linea));
                                    ultimora = linea;
                                    frase = "";
                                }
                                if (linea.Trim().ToLower().StartsWith("criterios de evaluaci"))
                                {
                                    criteriosEvaluacion = true;
                                }

                                if (criteriosEvaluacion)
                                {
                                    Regex reg = new Regex("^[a-z]\\).*");

                                    if (reg.IsMatch(linea.Trim().ToLower()))
                                    {
                                        try
                                        {
                                            CriterioEvaluacionDTO ce = new CriterioEvaluacionDTO(linea);
                                            ciclo.competencias[modu].ras[ultimora].criterios.Add(linea, ce);
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
            return ciclo;
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

        /// <summary>
        /// Limpia una línea o palabra de artefactos al inicio y final
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string limpiar(string input)
        {
            if (input[input.Length - 1] == '.')
            {
                input = input.Substring(0, input.Length - 1);
            }

            if (input.StartsWith("\u0003"))
            {
                input = input.Replace("\u0003", "");
            }
            return input;
        }
    }

    
}
