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

        [STAThread]

        static void Main(string[] args)
        {
            // we need to get our app name so that we can create unique names for our mutex and our pipe

            var notAlreadyRunning = true;
            // wrap the meat of the application code with a named mutex so it runs only once
            using (var mutex = new Mutex(true, _AppName + "Singleton", out notAlreadyRunning))
            {
                if (notAlreadyRunning)
                {
                    // do additional work here, startup stuff
                    Console.WriteLine("Running. Press any key to exit...");
                    // ...
                    // now process our initial main command line
                    _ProcessCommandLine(args);
                    // start the IPC sink.
                    var srv = new NamedPipeServerStream(_AppName + "IPC", PipeDirection.InOut, 1, PipeTransmissionMode.Message, PipeOptions.Asynchronous);
                    // it's easier to use the AsyncCallback than it is to use Tasks here:
                    // this can't block, so some form of async is a must

                    srv.BeginWaitForConnection(new AsyncCallback(_ConnectionHandler), srv);

                    // block here until exit
                    //Console.ReadKey();
                    // if this was a windows forms app you would put your "" here
                    // finally, run any teardown code and exit
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new frmMain());
                    srv.Close();
                }
                else // another instance is running
                {
                    // connect to the main app
                    var cli = new NamedPipeClientStream(".", _AppName + "IPC", PipeDirection.InOut);
                    cli.Connect();
                    var bf = new BinaryFormatter();
                    // serialize and send the command line
                    bf.Serialize(cli, args);
                    cli.Close();
                    // and exit
                }
            }
        }
        static void _ConnectionHandler(IAsyncResult result)
        {
            var srv = result.AsyncState as NamedPipeServerStream;
            srv.EndWaitForConnection(result);
            // we're connected, now deserialize the incoming command line
            var bf = new BinaryFormatter();
            var inargs = bf.Deserialize(srv) as string[];

            // process incoming command line
            _ProcessCommandLine(inargs);
            srv.Close();
            srv = new NamedPipeServerStream(_AppName + "IPC", PipeDirection.InOut, 1, PipeTransmissionMode.Message, PipeOptions.Asynchronous);

            srv.BeginWaitForConnection(new AsyncCallback(_ConnectionHandler), srv);
        }
        static void _ProcessCommandLine(string[] args)
        {
            // we received some command line
            // arguments.
            // do actual work here
            
        }
    }
}
