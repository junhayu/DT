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
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace DT1
{
    internal static class Program
    {
        static formMain form;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            devDept.LicenseManager.Unlock(typeof(devDept.Eyeshot.Workspace), "FS22-3JX12-EF0TY-TU79-RDAE"); //Eyeshot 라이센스

            form = new formMain();
            Task.Run(() => form.dt3.UdpReceiveDT3()); // DT3 받기
            //Task.Run(() => form.twinIntegration.UdpReceiveBoth());
            //Task.Run(() => form.twinIntegration.UdpReceiveMonitoring());
            Task.Run(() => form.dt2.UdpReceiveMachine()); // CNC Machine Data 받기
            Task.Run(() => form.dt2.UdpReceiveMonitoring()); // Labview Monitoring 받기
            Task.Run(() => form.dt2.UdpReceiveAI()); // Labview AI 받기

            Application.Run(form);

        }



    }
}
