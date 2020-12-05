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
        public string From;
        public string To;
        public string ReplyTo;
        public string Subject;
        public string Body;
        public string Attachment;

        static bool mailSent = false;


        public Sender() { }
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

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            String token = (string)e.UserState;

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
                Program.FrmMain.ActualizarStatus("✓ Mensaje enviado");
            }
            mailSent = true;
        }

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

                smtp.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                smtp.SendAsync(email, DateTime.Now.Ticks.ToString());
                Program.FrmMain.ActualizarStatus("Enviando prueba");

            }
            catch (Exception) {
                return -1;
            }
            return 0;
        }

        public void Cancelar()
        {
            smtp.SendAsyncCancel();
        }
    }

    
}
