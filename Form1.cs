using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailTo.SRC;

namespace MailTo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

           
            string[] arguments = Environment.GetCommandLineArgs();
            Console.WriteLine("GetCommandLineArgs: {0}", string.Join(", ", arguments));
            ListViewItem itm = new ListViewItem();
            itm.Text = arguments[0];
            lst.Items.Add(itm);
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(0);
            }
        }

        public void NuevoMensaje(string[] args)
        {
            ListViewItem itm = new ListViewItem();
            itm.Text = args[0];
            lst.Items.Add(itm);
        }
    }
}
