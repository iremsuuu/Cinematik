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
            // Uygulama yap�land�rmas�n� �zelle�tirmek i�in (y�ksek DPI ayarlar� belirlemek veya varsay�lan yaz� tipi ayarlamak gibi),
            // bkz. https://aka.ms/applicationconfiguration.

            // Ana formu ba�lat
            Application.Run(new GirisEkrani());
        }
    }
}
