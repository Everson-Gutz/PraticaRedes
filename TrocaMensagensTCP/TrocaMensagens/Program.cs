using System;
using System.Windows.Forms;

namespace TrocaMensagens
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new Login();
            form.Closed += (s, args) => Environment.Exit(0);

            Application.Run(form);            
        }
    }
}
