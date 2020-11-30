using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailTo.SRC
{
    class ArgParser
    {
        public string[] Args { get; set; }

        public ArgParser() 
        {

        }

        public ArgParser(string[] args)
        {
            Args = args;
        }
    }
}
