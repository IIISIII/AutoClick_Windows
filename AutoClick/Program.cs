using System.Runtime.InteropServices;

namespace AutoClick
{
    internal static class Program
    {
        public static List<AutoClickInput> inputList = new List<AutoClickInput>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}