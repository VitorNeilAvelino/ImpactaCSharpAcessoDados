using System;
using System.Windows.Forms;

namespace CSharp2.Capitulo03.Oficina
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
            Application.Run(new ModeloForm());
        }
    }
}