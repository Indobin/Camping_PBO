using Projek_Akhir_PBO.View.Admin;
using Projek_Akhir_PBO.View.Pemilik;
using Projek_Akhir_PBO.View.Penyewa;

namespace Projek_Akhir_PBO
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
            Application.Run(new FormLogin());
                    }
    }
}