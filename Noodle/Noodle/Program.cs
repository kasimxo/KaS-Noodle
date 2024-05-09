using Noodle.view;

namespace Noodle
{
    public static class Program
    {

        public static ImportarArchivoView mW;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            mW = new ImportarArchivoView();

            Application.Run(mW);
        }
    }
}