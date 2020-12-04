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

        public override string ToString()
        {
            return $"{ProveedorNombre};{ProveedorId};{Email};{SmtpHost};{Puerto};";
        }

    }
}
