using Comedor_Asados_La_Flaca.Catalogos;
using System.Runtime.Versioning;

namespace Comedor_Asados_La_Flaca
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
            Application.Run(new Frm_Clientes());
        }
    }
}