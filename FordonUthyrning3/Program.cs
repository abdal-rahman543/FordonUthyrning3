using Uthyrning.Affärslager;
using Uthyrning.Databas;

namespace FordonUthyrning3
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
            //Container that holds an instance of the repositories and services 
            Custom_RepostioryContainer.RegistreraService(new LoginRepository());
            Custom_RepostioryContainer.RegistreraService(new StationRepository());
            Custom_RepostioryContainer.RegistreraService(new RegistreraRepository());
            Custom_ServiceContainer.RegistreraService(new StationService());
            Custom_ServiceContainer.RegistreraService(new LoginService());
            Custom_ServiceContainer.RegistreraService(new RegistreraService());
            Custom_ServiceContainer.RegistreraService(new PågåendeTurerService());



            ApplicationConfiguration.Initialize();
            // Kör applikationen med Singleton-instansen
            Application.Run(new Form1());
        }
    }
}