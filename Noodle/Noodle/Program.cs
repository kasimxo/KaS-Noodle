using Noodle.model.dto;
using Noodle.view;

namespace Noodle
{
    public static class Program
    {

        public static MainWindowView mW;
        public static Dictionary<Int32, MarcoCompetenciasDTO> marcos; //El listado total de marcos de competencias
        public static MarcoCompetenciasDTO marco; //El marco de competencias que actualmente está en focus
        public static CompetenciaDTO competencia; //La competencia que tenemos en focus
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            mW = new MainWindowView();

            Application.Run(mW);
        }
    }
}