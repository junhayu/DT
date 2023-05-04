using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Xml;
using Newtonsoft.Json;
using System.Diagnostics;

namespace dt3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await SendDT3Data();
            richTextBox1.Text += "\n DT3 sent!";
        }

        /*
         * DT3 더미 데이터 생성 후 보내기
         */
        public async Task<String> SendDT3Data()
        {
            int port = 10001;
            Random random= new Random();
            UdpClient udp = new UdpClient();
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            udp.Connect(ep);
            Measurement m1 = null;
            List<Measurement> mList= new List<Measurement>();

            string numPart = "500 - 1";
            double[] wcs = { 1000.0, 515.0, 45.0 };
            int numInspection = 6;
            string[] inspectionID = { "Dimensional Tolerance - DT1", "Dimensional Tolerance - DT2", "Geometric - Straightness 1", "Geometric - Straightness 2", "Geometric - Squareness 1", "Geometric - Roundness 1" };
            int[] numPoint = { 10, 10, 10, 10, 10, 10 };
            double[] inspectionResult = new double[10] { 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0 };
            //double[,] inspectionTolerance = new double[6, 2] { { 20.0, 30.0 } , { 20.0, 30.0 }, { 20.0, 30.0 }, { 20.0, 30.0 }, { 20.0, 30.0 }, { 20.0, 30.0 } };
            double[] inspectionTolerance = new double[6] { 25.0,25.0,25.0,25.0,25.0,25.0 };

            double x1, y1, z1;
            double x2, y2, z2;
            int t = 0;
            for (int i = 0; i < 10; i++)
            {
                t = random.Next(0, 2);
                x1 = Math.Round(random.NextDouble() * (101 - 0) + 0, 2);
                y1 = Math.Round(random.NextDouble() * (101 - 0) + 0, 2);
                if (t == 0)
                {
                    y1 = -y1;
                }
                z1 = -x1;
                double[] des = { x1, y1, z1 };

                t = random.Next(0, 2);
                x2 = Math.Round(random.NextDouble() * (101 - 0) + 0, 2);
                y2 = Math.Round(random.NextDouble() * (101 - 0) + 0, 2);
                if (t == 0)
                {
                    y2 = -y2;
                }
                z2 = -x2;

                double[] gdt = { x2, y2, z2};
                //double[] est = { (x1-x2), (y1-y2), (z1-z2) };
                m1 = new Measurement(numPart,wcs,numInspection,inspectionID, numPoint, des, gdt, inspectionResult, inspectionTolerance);
                mList.Add(m1);
            }
            
            try
            {
                byte[] res = Serializer.Serialize(mList);
                //udp.Send(res, res.Length, ep);
                udp.Send(res, res.Length);
                udp.Close();
            }
            catch(SocketException ex)
            {
                richTextBox1.Text += "\n socket error" + ex.Message;
            }


            return "ss";
        }
    }
}
