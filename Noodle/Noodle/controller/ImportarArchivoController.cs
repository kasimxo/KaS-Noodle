using Noodle.model.action;
using Noodle.model.dal;
using Noodle.model.dto;
using Noodle.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UglyToad.PdfPig.Actions;

namespace Noodle.controller
{
    public class ImportarArchivoController
    {
        private const Boolean PDF = true;
        private const Boolean CSV = false;
        /// <summary>
        /// Llama al action correspondiente según sea pdf o csv
        /// </summary>
        /// <param name="tipoArchivo">true -> pdf, false -> csv</param>
        public static void procesarArchivoBtn(Boolean tipoArchivo)
        {
            if (tipoArchivo==PDF) { 
                procesarArchivoPDF(); 
            } else if (tipoArchivo == CSV)
            {
                procesarArchivoCSV();
            }

        }

        private static void procesarArchivoCSV()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "CSV *.csv|*.csv";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string selectedFileName = openFileDialog1.FileName;

            MarcoCompetenciasDTO marco = ProcesarArchivoCsvAction.extraerCompetencias(selectedFileName);
            MarcoCompetenciasDAL.guardarMarcoCompetencias(marco);
            BibliotecaController.verMarco(marco);

        }
        private static void procesarArchivoPDF()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "PDF *.pdf|*.pdf";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string selectedFileName = openFileDialog1.FileName;

            MarcoCompetenciasDTO marco = ProcesarArchivoPdfAction.extraerCompetencias(selectedFileName);
            MarcoCompetenciasDAL.guardarMarcoCompetencias(marco);
            BibliotecaController.verMarco(marco);
        }

        public static void procesarArchivoGenerico(string filePath)
        {
            MarcoCompetenciasDTO marco = ProcesarArchivoAction.procesarArchivoSegunFormato(filePath);
            MarcoCompetenciasDAL.guardarMarcoCompetencias(marco);
            BibliotecaController.verMarco(marco);
        }
    }
}
