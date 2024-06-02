using Noodle.controller;
using Noodle.model.dto;
using Noodle.view;

namespace Noodle
{
    public static class Program
    {
        /// <summary>
        /// La vista que contiene todo de la aplicaci�n
        /// Ie: los marcos, los men�s, componentes, etc.
        /// </summary>
        public static MainWindowView mW;
        /// <summary>
        /// Iniciar sesi�n Window
        /// La vista que gestiona el inicio de sesi�n y que mantiene la aplicaci�n
        /// </summary>
        public static IniciarSesionView isW;
        /// <summary>
        /// El listado total de marcos de competencias
        /// </summary>
        public static Dictionary<Int32, MarcoCompetenciasDTO> marcos;
        /// <summary>
        /// Los marcos que han compartido contigo
        /// </summary>
        public static Dictionary<Int32, MarcoCompetenciasDTO> marcosCompartidos;
        /// <summary>
        /// El marco de competencias que actualmente est� en focus
        /// </summary>
        public static MarcoCompetenciasDTO marco; 
        /// <summary>
        /// La competencia que tenemos en focus
        /// </summary>
        public static CompetenciaDTO competencia;
        public static ResultadoAprendizajeDTO ra;
        public static CriterioEvaluacionDTO ce;
        public static Label labelEditando;
        public static RichTextBox richTextBoxEditando;
        /// <summary>
        /// Almacena el RAEditableComponente o CEEditableComponente
        /// o CompetenciaEditableComponente
        /// </summary>
        public static Object objetoEditando;
        /// <summary>
        /// Id del usuario. 1 para el usuario invitado
        /// 0 Nada mas entrar a la aplicaci�n
        /// </summary>
        public static int idUsuario; 
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            isW = new IniciarSesionView();
            mW = new MainWindowView();

            //vamo a �niciar la aplicaic�n con el iniciarsesionview
            Application.Run(isW);
        }
    }
}