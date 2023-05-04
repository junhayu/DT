using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Threading;
using System.Windows.Controls;
using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using devDept.Eyeshot.Translators;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using devDept.Graphics;

namespace DT1
{
    public partial class FormIntegration : Form
    {
        public string monitoringTime = "";
        public List<string> machineTime = new List<string>();
        public FormIntegration()
        {
            InitializeComponent();
            design1.ActiveViewport.Background.TopColor = Color.FromArgb(255, 150, 150, 150);
            design1.ActiveViewport.Background.BottomColor = Color.FromArgb(255, 40, 40, 40);
            design1.ActiveViewport.Background.StyleMode = backgroundStyleType.LinearGradient;
            design1.CompileUserInterfaceElements();
            //string path = @"c:\Users\Junha Desktop\Desktop\용역\생산연\신규\통합 깃\DT1\DT1\sample data\Placa_muestras.stp";
            //ReadSTEP ro = new ReadSTEP(path);
            //ro.DoWork();
            //Entity[] entList = ro.Entities;
            ////Dictionary<string, Material> matList = ro.Materials;

            //design1.Entities.Add(entList[0], Color.LightBlue);
        }

        public async void UdpReceiveBoth()
        {
            //int monitoringPort = 10011;
            //UdpClient monitoringUdp = new UdpClient(monitoringPort);
            //IPEndPoint monitoringEp = new IPEndPoint(IPAddress.Any, 0);

            //int machinePort = 10010;
            //UdpClient machineUdp = new UdpClient(machinePort);
            //IPEndPoint machineEp = new IPEndPoint(IPAddress.Any, 0);

            //while (true)
            //{
            //    // Receive data from the sender
            //    byte[] monitoringData = monitoringUdp.Receive(ref monitoringEp);

            //    // Convert the byte array to a string
            //    string time1 = Encoding.ASCII.GetString(monitoringData);

            //    monitoringTime = time1;

            //    // Receive data from the sender
            //    byte[] machineData = machineUdp.Receive(ref machineEp);

            //    // Convert the byte array to a string
            //    string time2 = Encoding.ASCII.GetString(machineData);

            //    machineTime.Add(time2);

            //    // Print the time to the console
            //    if (label5.InvokeRequired || label5.InvokeRequired)
            //    {
            //        label5.Invoke(new MethodInvoker(delegate
            //        {
            //            label5.Text = time1;
            //            label7.Text = time2;

            //            for (int i = machineTime.Count - 1; i >= 0; i--)
            //            {
            //                //Console.WriteLine("i is " + i);
            //                if (machineTime[i] == time1)
            //                {
            //                    label6.Text = machineTime[i];

            //                    DateTime d1 = DateTime.ParseExact(time1, "HH:mm:ss.f", CultureInfo.InvariantCulture);
            //                    DateTime d2 = DateTime.UtcNow.AddHours(9);
            //                    TimeSpan timeDiff = d2 - d1;
            //                    //String diff = timeDiff.Hours.ToString() + ":" + timeDiff.Minutes.ToString() + ":" + timeDiff.Seconds.ToString();
            //                    label9.Text = timeDiff.ToString(@"hh\:mm\:ss\.f");
            //                    machineTime.RemoveAt(i);
            //                    Console.WriteLine("length is " + machineTime.Count);
            //                    break;
            //                }
            //            }

            //        }));

            //    }

            //    // Wait for 0.1 seconds before receiving the next message
            //    //Thread.Sleep(100);
            //}
        }
    }
}
