using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailTo.SRC
{
    public class State
    {
        private List<SmtpConfig> ServidoresDisponibles = new List<SmtpConfig>();

        private Stack<SmtpConfig> Servidores = new Stack<SmtpConfig>();
        private Queue<Sender> Mensajes = new Queue<Sender>();

        /// <summary>
        /// Estado del envío.
        /// 0=Detenido
        /// 1=Enviando
        /// 2=Pausado
        /// </summary>
        public int Estado = 0;
        public bool QueueLoaded = false;

        /// <summary>
        /// Agrega un servidor a la lista de serdidores
        /// </summary>
        /// <param name="server">Servidor SMTP a agregar</param>
        public void AddServer(SmtpConfig server)
        {
            ServidoresDisponibles.Add(server);
        }

        /// <summary>
        /// Agrega un mensaje a la lista de envíos
        /// </summary>
        /// <param name="messaje">El mensaje a enviar</param>
        public void AddMessage(Sender messaje)
        {
            Mensajes.Enqueue(messaje);
            QueueLoaded = true;
        }

        /// <summary>
        /// Ordena los servidores a utilizar al azar en grupos, para evitar que nunca haya más de 
        /// dos envíos seguidos del mismo servidor.
        /// </summary>
        private void Roulette()
        {
            if (ServidoresDisponibles.Count > 0 && !Servidores.Any())
            {
                List<SmtpConfig> servidoresSorteo = new List<SmtpConfig>();
                servidoresSorteo.AddRange(ServidoresDisponibles.ToArray());
                while (servidoresSorteo.Count > 0)
                {
                    Random random = new Random();
                    int winner = random.Next(0, servidoresSorteo.Count);
                    Servidores.Push(servidoresSorteo[winner]);
                    servidoresSorteo.RemoveAt(winner);
                }
            }
        }

        /// <summary>
        /// Envía el próximo mensaje de la fila
        /// </summary>
        public void SendNextMessage() {
            Roulette();
            if (Mensajes.Any()) {
                Estado = 1;
                Mensajes.Peek().LoadServer(Servidores.Pop());
                Mensajes.Dequeue().Send();
                if (!Mensajes.Any())
                {
                    Estado = 0;
                    QueueLoaded = false;
                }
            } else
            {
                Estado = 0;
                QueueLoaded = false;
            }
        }

        /// <summary>
        /// Limpia todos los servidores de la lista de servidores disponibles
        /// </summary>
        public void ClearServers()
        {
            ServidoresDisponibles.Clear();
        }

        /// <summary>
        /// Quita todos los mensajes de la lista de mensajes
        /// </summary>
        public void DequeueAll()
        {
            Mensajes.Clear();
        }
    }
}
