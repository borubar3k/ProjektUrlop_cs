using ProjektUrlop.Data;
using ProjektUrlop.Models;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ProjektUrlop
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
            Application.Run(new Form1());

                // -----------------------------------------------
                //      ADMIN    e-mail: admin, haslo: admin
                //      USER     e-mail: user,  haslo: user
                // -----------------------------------------------
                // ustawic zadanie w harmonogramie zadan sys Windows
        }
    }
}