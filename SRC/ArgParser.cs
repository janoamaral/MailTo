using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MailTo.SRC
{
    class ArgParser
    {
        public string[] Args { get; set; }
        public string RawCompose = "";

        /// <summary>
        /// Estado de envío
        /// 0 = Detenido
        /// 1 = iniciar
        /// 2 = pausar
        /// </summary>
        public int State = 0;

        public ArgParser() 
        {

        }

        public ArgParser(string[] args)
        {
            Args = args;
        }

        /// <summary>
        /// Parsea un array de argumentos y extrae los campos.
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public int Parse(ref Sender sender)
        {
            // Buscar los parametros
            if (Args[Args.Length - 1] == "start") State = 1;
            if (Args[Args.Length - 1] == "pause") State = 2;



            int index = 0;
            for (int i = 0; i < Args.Length; i++)
            {
                if (Args[i] == "-compose" && (i+1 < Args.Length))
                {
                    index = i + 1;
                    break;
                }
            }

            string args = Args[index];

            sender.To = GetField("to", args);
            sender.Subject = GetField("subject", args);
            sender.Body = GetField("body", args);
            sender.Attachment = GetField("attachment", args);
            sender.HTML = GetField("html", args);

            if (sender.To.Length > 0 && sender.Subject.Length > 0 && sender.Body.Length > 0)
            {
                RawCompose = args;
                return 0;
            }

            return -1;
        }

        public int Parse(ref Sender sender, string rawArgument)
        {
            sender.To = GetField("to", rawArgument);
            sender.Subject = GetField("subject", rawArgument);
            sender.Body = GetField("body", rawArgument);
            sender.Attachment = GetField("attachment", rawArgument);
            sender.HTML = GetField("html", rawArgument);

            if (sender.To.Length > 0 && sender.Subject.Length > 0 && sender.Body.Length > 0)
            {
                RawCompose = rawArgument;
                return 0;
            }

            return -1;
        }

        private string GetField(string field, string text)
        {
            string pattern = $"{field}='[^']*'";
            Regex rg = new Regex(pattern);

            MatchCollection found = rg.Matches(text);
            return (found.Count > 0 ? found[0].Value.Substring(field.Length + 2, found[0].Value.Length - (field.Length + 3)) : "");
        }
    }
}
