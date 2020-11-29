using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailTo
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        private static Mutex mutex = null;

        [STAThread]

        static void Main(string[] args)
        {
            bool createdNew;
            const string appName = "MailTo";

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                //TODO: Agregar el parametro a la lista
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
