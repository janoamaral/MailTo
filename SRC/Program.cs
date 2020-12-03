using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailTo.SRC;


namespace MailTo
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        static string _AppName = Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().GetName().Name);

        public static frmMain FrmMain;

        [STAThread]

        static void Main(string[] args)
        {
            var notAlreadyRunning = true;
            using (var mutex = new Mutex(true, _AppName + "Singleton", out notAlreadyRunning))
            {
                if (notAlreadyRunning)
                {
                    var srv = new NamedPipeServerStream(_AppName + "IPC", PipeDirection.InOut, 1, PipeTransmissionMode.Message, PipeOptions.Asynchronous);

                    srv.BeginWaitForConnection(new AsyncCallback(_ConnectionHandler), srv);


                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    FrmMain = new frmMain();
                    Application.Run(FrmMain);
                    srv.Close();
                }
                else
                {
                    var cli = new NamedPipeClientStream(".", _AppName + "IPC", PipeDirection.InOut);
                    cli.Connect();
                    var bf = new BinaryFormatter();
                    bf.Serialize(cli, args);
                    cli.Close();
                }
            }
        }
        static void _ConnectionHandler(IAsyncResult result)
        {
            var srv = result.AsyncState as NamedPipeServerStream;
            srv.EndWaitForConnection(result);
            var bf = new BinaryFormatter();
            var inargs = bf.Deserialize(srv) as string[];

            _ProcessCommandLine(inargs);
            srv.Close();
            srv = new NamedPipeServerStream(_AppName + "IPC", PipeDirection.InOut, 1, PipeTransmissionMode.Message, PipeOptions.Asynchronous);

            srv.BeginWaitForConnection(new AsyncCallback(_ConnectionHandler), srv);
        }

        static void _ProcessCommandLine(string[] args)
        {
            Program.FrmMain.NuevoMensaje(args);
        }
    }
}
