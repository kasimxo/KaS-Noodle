using Noodle.model.action;
using Noodle.model.dto;
using Noodle.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.controller
{
    public class ImportarArchivoController
    {
        public static void procesarArchivoBtn()
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

            CicloDTO ciclo = ProcesarArchivoAction.extraerCompetencias(selectedFileName);

            Program.mW.Hide();
            EditarCompetenciasView ecV = new EditarCompetenciasView(ciclo);
            ecV.Show();
        }

    }
}
