using PrimerEvaluacionAuto; // Dentro del proyecto de formulario hacer referencia con "PrimeraEvaluacionAuto"(biblioteca)
namespace Formulario_Auto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormAuto());
        }

    }
}