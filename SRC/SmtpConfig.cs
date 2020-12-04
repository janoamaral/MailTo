using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailTo.SRC
{
    public class SmtpConfig
    {
        public string ProveedorNombre;
        public int ProveedorId;
        public string Email;
        public string SmtpHost;
        public int Puerto;
        public bool SSL;
        public string Username;
        public string Password;

        public SmtpConfig()
        {

        }

        public SmtpConfig(string config)
        {
            ProveedorNombre = config.Split(';')[0];
            ProveedorId = Convert.ToInt16(config.Split(';')[1]);
            Email = config.Split(';')[2];
            SmtpHost = config.Split(';')[3];
            Puerto = Convert.ToInt16(config.Split(';')[4]);
            SSL = Convert.ToInt16(config.Split(';')[5]) == 0 ? false : true;
            Username = config.Split(';')[6];
            Password = config.Split(';')[7];
        }

        public override string ToString()
        {
            return $"{ProveedorNombre};{ProveedorId};{Email};{SmtpHost};{Puerto};{(SSL ? "1" : "0")};{Username};{Password}";
        }
    }
}
