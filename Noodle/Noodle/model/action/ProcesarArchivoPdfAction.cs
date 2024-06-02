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
    public class ProcesarArchivoPdfAction
    {
        public static MarcoCompetenciasDTO extraerCompetencias(string filePath)
        {
            MarcoCompetenciasDTO marco = new MarcoCompetenciasDTO();
            marco.filePath = filePath;
            Dictionary<string, CompetenciaDTO> competencias = new Dictionary<string, CompetenciaDTO>();
            string modu = "";
            string ultimora = "";
            CriterioEvaluacionDTO ce = null;
            ResultadoAprendizajeDTO ra = null;
            Boolean modulo = false;
            Boolean resultadoAprendizaje = false;
            Boolean criteriosEvaluacion = false;
            Regex regCabecera = new Regex(".*\\/.*\\/.*");
            //Comprueba que la línea contenga algo de texto
            Regex regPie = new Regex(".*[a-zA-z]+.*");

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

                    //Recorremos las líneas que componen el texto
                    foreach (var line in lineas)
                    {
                        string linea = line;
                        //Procesa una lína para asegurarse de que termina correctamente
                        if (linea.Length > 2)
                        {

                            linea.Substring(0, linea.Length - 1);
                            //Eliminamos los espacios en blanco al final de la línea
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

                        //Identifica la denominación del marco
                        if ((linea.Trim().ToLower().StartsWith("denominación") || linea.Trim().ToLower().StartsWith("denominacion")) && linea.ToLower().Contains(":"))
                        {
                            marco.denominacion = limpiar(linea.Substring(linea.IndexOf(":") + 1));
                            marco.siglas = marco.denominacionToSiglas(marco.denominacion);
                            marco.nombreCortoCSV = marco.generarNombreCorto();
                            marco.descripcionCSV = "Marco de competencias del ciclo de formación profesional: " + marco.denominacion + ".";
                        }

                        if (linea.Trim().ToLower().StartsWith("nivel") && linea.ToLower().Contains(":"))
                        {
                            if (linea.ToLower().Contains("superior"))
                            {
                                marco.nivel = "S";
                            } else if (linea.ToLower().Contains("medio"))
                            {
                                marco.nivel = "M";
                            }
                            else if (linea.ToLower().Contains("basico") || linea.ToLower().Contains("básico"))
                            {
                                marco.nivel = "B";
                            }
                        }

                        //Identifica módulos profesionales
                        if ((linea.Trim().ToLower().StartsWith("módulo profesional") || linea.Trim().ToLower().StartsWith("modulo profesional")) && linea.ToLower().Contains(":"))
                        {
                            String mod = linea.Substring(linea.IndexOf(":") + 1);

                            mod = limpiar(mod);

                            //Comprueba si están en el mapa y si no es así los mete
                            if (!marco.competencias.ContainsKey(mod))
                            {
                                marco.competencias.Add(mod, new CompetenciaDTO(mod, i));
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
                                    //Si detectamos un nuevo RA tras procesar los CEs del anterior
                                    if (ce != null)
                                    {
                                        try
                                        {
                                            marco.competencias[modu].ras[ultimora].criterios.Add(ce.contenido, ce);
                                            ce = null;
                                        }
                                        catch (Exception e) { }
                                    }

                                    //Al crear un nuevo resultado de aprendizaje, limpiamos la numeración que lleve al principio
                                    Regex limpiarRA = new Regex("^[1-9]\\.\\s");
                                    string cleanRA = limpiarRA.Replace(linea, "");
                                    ra = new ResultadoAprendizajeDTO(cleanRA, i) ;

                                    //Marcamos los criterios de evaluación como false
                                    //hasta que lleguemos a los ces de este ra
                                    criteriosEvaluacion = false;

                                    frase = "";
                                }
                                else if (!criteriosEvaluacion 
                                    && linea.CompareTo("") != 0 && ra != null && !linea.Trim().ToLower().StartsWith("criterios de evaluaci")
                                    && !regCabecera.IsMatch(linea) 
                                    && regPie.IsMatch(linea)) 
                                {
                                    ra.nombre += " " +linea;
                                    //ra.nombreCortoCSV += " " + linea;
                                    ra.descripcionCSV += " " + linea;
                                }
                                else if (linea.Trim().ToLower().StartsWith("criterios de evaluaci"))
                                {
                                    //como vamos a empezar a meter los criterios de evaluación, el ra ya se ha formado

                                    marco.competencias[modu].ras.Add(ra.nombre, ra);
                                    ultimora = ra.nombre;
                                    criteriosEvaluacion = true;
                                }
                                else if (criteriosEvaluacion)
                                {
                                    Regex reg = new Regex("^[a-z]\\).*");

                                    if (reg.IsMatch(linea.Trim().ToLower()))
                                    {
                                        if (ce != null)
                                        {
                                            try
                                            {
                                                marco.competencias[modu].ras[ultimora].criterios.Add(ce.descripcionCSV, ce);
                                            }
                                            catch (Exception e) { }
                                        }

                                        //Al crear un CE primero lo limpiamos
                                        Regex limpiarCE = new Regex("^[a-z]\\)\\s");
                                        string cleanRA = limpiarCE.Replace(linea, "");
                                        ce = new CriterioEvaluacionDTO(cleanRA, i);
                                    }
                                    else if (!linea.Trim().ToLower().StartsWith("contenidos")
                                        && ce != null)
                                    {


                                        if (!regCabecera.IsMatch(linea) && regPie.IsMatch(linea))
                                        {
                                            ce.contenido += " " + linea;
                                            ce.descripcionCSV += " " + linea;
                                        }
                                    }
                                }
                            }
                        }

                        if (linea.Trim().ToLower().StartsWith("contenidos"))
                        {
                            modulo = false;
                            resultadoAprendizaje = false;
                            criteriosEvaluacion = false;
                            ra = null;
                            ce = null;
                            ultimora = "";
                            modu = "";

                        }
                    }
                }
            }
            return marco;
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
