using System;
using System.Windows.Forms;

namespace Cinematik
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Uygulama yapýlandýrmasýný özelleþtirmek için (yüksek DPI ayarlarý belirlemek veya varsayýlan yazý tipi ayarlamak gibi),
            // bkz. https://aka.ms/applicationconfiguration.

            // Ana formu baþlat
            Application.Run(new GirisEkrani());
        }
    }
}
