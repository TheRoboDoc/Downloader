using static System.Net.WebRequestMethods;

namespace Downloader
{
    internal static class Program
    {
        public static MainWindow? mainWindow;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            mainWindow = new MainWindow();
            Application.Run(mainWindow);
        }
    }
}