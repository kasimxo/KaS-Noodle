using Noodle.componentes.editar;
using Noodle.components;
using Noodle.model.dto;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Noodle.controller
{
    public class EditarCompetenciaController
    {
        public static void navegarEditarCompetencia(CompetenciaDTO com) 
        {
            MenuComponente menu = (MenuComponente)Program.mW.layout.GetControlFromPosition(0, 0);
            menu.marcarEstado(3);
            
            if (Program.mW.layout.GetControlFromPosition(1, 0) != null)
            {
                Program.mW.layout.GetControlFromPosition(1, 0).Dispose();
            }

            EditarCompetenciaComponente vcc = new EditarCompetenciaComponente(com);
            vcc.Dock = DockStyle.Fill;
            Program.mW.layout.Controls.Add(vcc, 1, 0);
        }

        public static void convertirEditable(object sender, EventArgs e)
        {
            if (Program.richTextBoxEditando != null)
            {

                if (Program.objetoEditando is CriterioEvaluacionEditableComponente)
                {
                    CriterioEvaluacionEditableComponente ceec = (CriterioEvaluacionEditableComponente)Program.objetoEditando;
                    ceec.ce.descripcionCSV = Program.richTextBoxEditando.Text;

                    Debug.WriteLine("");
                }
                else if (Program.objetoEditando is ResultadoAprendizajeEditableComponente)
                {
                    ResultadoAprendizajeEditableComponente raec = (ResultadoAprendizajeEditableComponente)Program.objetoEditando;
                    raec.ra.descripcionCSV = Program.richTextBoxEditando.Text;
                    Debug.WriteLine("");
                }
                else if (Program.objetoEditando is DetalleCompetenciaEditable)
                { 
                    DetalleCompetenciaEditable dce = (DetalleCompetenciaEditable) Program.objetoEditando;
                    dce.competencia.nombreCortoCSV = Program.richTextBoxEditando.Text;
                    Debug.WriteLine("");
                }
                Program.labelEditando.Text = Program.richTextBoxEditando.Text;
                Program.richTextBoxEditando.Dispose();
                Program.labelEditando.Visible = true;
            }

            Program.labelEditando = (Label)sender;
            Program.objetoEditando = Program.labelEditando.Parent.Parent;
            Program.richTextBoxEditando = new RichTextBox();
            Program.richTextBoxEditando.Dock = DockStyle.Fill;
            Program.richTextBoxEditando.Size = new Size(400, 100);
            Program.richTextBoxEditando.Text = Program.labelEditando.Text;
            Program.labelEditando.Visible = false;
            //Program.richTextBoxEditando.Leave += guardarCambios;
            var contenedor = Program.labelEditando.Parent;
            contenedor.Controls.Add(Program.richTextBoxEditando);
        }


    }
}
