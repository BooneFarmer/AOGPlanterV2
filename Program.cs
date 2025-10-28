using AOGPlanterV2.Properties;
using Microsoft.Win32;
using System;
using System.Threading;
using System.Windows.Forms;


namespace AOGPlanterV2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();   
            Application.SetCompatibleTextRenderingDefault(false);  
            ApplicationConfiguration.Initialize();
            Application.Run(new FormAOP());
//            Application.Run(new Form_First());
        }
    }
}