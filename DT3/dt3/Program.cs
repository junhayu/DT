using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace dt3
{
    internal class Program
    {
        
        [STAThread]
        static void Main(string[] args)
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

    }
}
