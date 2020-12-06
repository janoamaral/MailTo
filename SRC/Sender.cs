using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.ComponentModel;

namespace MailTo.SRC
{
    public class Sender
    {
        SmtpConfig smtpConfig = new SmtpConfig();
        SmtpClient smtp = new SmtpClient();

        public int MessageID;
        public string From = "";
        public string To = "";
        public string ReplyTo = "";
        public string Subject = "";
        public string Body = "";
        public string Attachment = "";
        public bool Sent = false;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Sender() { }

        /// <summary>
        /// Constructor inyectando la configuración del servidor SMTP
        /// </summary>
        /// <param name="server">Configuración SMTP</param>
        public Sender(SmtpConfig server)
        {
            smtpConfig = server;
        }


        /// <summary>
        /// Carga un servidor smtp en el objeto
        /// </summary>
        /// <param name="server">Servidor smtp</param>
        public void LoadServer(SmtpConfig server)
        {
            smtpConfig = server;
        }

        /// <summary>
        /// Callback del envío del mail async
        /// </summary>
        /// <param name="sender">Servidor SMTP que envió el correo</param>
        /// <param name="e">Argumentos</param>
        /// <param name="msgId">Index del ListViewIndex del listado de correos</param>
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e, int msgId)
        {
            String token = (string)e.UserState;
            SmtpClient s = (SmtpClient)sender;
            int status = 1;


            if (e.Cancelled)
            {
                Program.FrmMain.ActualizarStatus("Envío cancelado");
            }
            if (e.Error != null)
            {
                Program.FrmMain.ActualizarStatus("⚠ Error en el envío");
            }
            else
            {
                status = 0;
                Program.FrmMain.ActualizarStatus("✓ Mensaje enviado");
            }

            Program.FrmMain.ActualizarMensaje(msgId, status, s.Host);
        }

        /// <summary>
        /// Envía de manera asincrona un mail
        /// </summary>
        /// <returns>0 si la función envió el correo. -1 si hubo un error</returns>
        public int Send()
        {
            try
            {
                smtp.Port = smtpConfig.Puerto;
                smtp.Host = smtpConfig.SmtpHost;
                smtp.EnableSsl = smtpConfig.SSL;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(smtpConfig.Username, smtpConfig.Password);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage email = new MailMessage(new MailAddress(smtpConfig.Email, From), new MailAddress(To));
                if (ReplyTo.Trim().Length > 0)
                {
                    email.ReplyToList.Add(new MailAddress(ReplyTo));
                }
                
                email.Subject = Subject;
                email.IsBodyHtml = true;
                email.Body = Body;

                smtp.SendCompleted += new SendCompletedEventHandler((sender, e) => SendCompletedCallback(sender, e, MessageID));
                smtp.SendAsync(email, DateTime.Now.Ticks.ToString());
                Program.FrmMain.ActualizarStatus("Enviando prueba");

            }
            catch (Exception) {
                return -1;
            }
            return 0;
        }

        /// <summary>
        /// Cancela el envío.
        /// </summary>
        public void Cancelar()
        {
            smtp.SendAsyncCancel();
        }
    }

    
}
