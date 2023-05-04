using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Xml.Linq;

namespace DT2_AI
{
    internal static class Program
    {
        static Form1 form;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            //CreateCSV(); //더미 데이터 생성
            Task.Run(() => UdpSend()); //AI데이터 보내기
            Task.Run(() => UdpSendSensor()); //센서 데이터 보내기
            //Task.Run(() => SendTime());
            Application.Run(form);
        }

        /*
         * 딜레이 테스트
         */
        public static async void SendTime()
        {
            int port = 10010;
            UdpClient udp = new UdpClient();
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);

            while (true)
            {
                // Get the current time as a string
                string time = DateTime.Now.ToString("HH:MM:ss.f");

                // Convert the string to a byte array
                byte[] data = Encoding.ASCII.GetBytes(time);

                // Send the data to the destination endpoint
                udp.Send(data, data.Length, ep);

                if (form.richTextBox1.InvokeRequired)
                {
                    form.richTextBox1.Invoke(new MethodInvoker(delegate
                    {
                        form.richTextBox1.AppendText($"\n Current time is : {time}");
                    }));

                }

                // Wait for 0.1 seconds before sending the next message
                Thread.Sleep(100);
            }
        }

        /*
         * 더미데이터 생성 확인
         */
        public static async void CreateCSV()
        {
            var task1 = Task.Run(() => MakeCSV());
            int result = await task1;

            if (form.richTextBox1.InvokeRequired)
            {
                form.richTextBox1.Invoke(new MethodInvoker(delegate
                {
                    form.richTextBox1.Text += "\n" + "success" + result;
                }));

            }
            else
            {
                form.richTextBox1.Text += "\nss" + "success" + result;
            }
        }

        /*
         * 더미 데이터 생성
         */
        public static int MakeCSV()
        {
            var readFile = @"C:\Users\Junha Desktop\Desktop\용역\생산연\신규\통합\DT2 AI\DT2 Labview\sample data\dt2\dt2 data.csv";
            var writeFile = @"C:\Users\Junha Desktop\Desktop\용역\생산연\신규\통합\DT2 AI\DT2 Labview\sample data\dt2\test1.csv";

            Random random = new Random();
            try
            {
                if (File.Exists(readFile))
                {
                    Console.WriteLine("file exits");
                    using (var stream = new StreamReader(File.Open(readFile, FileMode.Open)))
                    {
                        string[] values;
                        string line;
                        var csv = new StringBuilder();
                        string csvRow;
                        using (var createStream = File.CreateText(writeFile))
                        {
                            string date = "";
                            string time = "";
                            string ai1 = "";

                            while ((line = stream.ReadLine()) != null)
                            {
                                values = line.Split(',');
                                date = values[0];
                                time = values[1];
                                ai1 = random.Next(4).ToString();

                                csvRow = string.Format($"{date},{time},{ai1}");
                                csv.AppendLine(csvRow);
                            }

                        }
                        File.WriteAllText(writeFile, csv.ToString());

                    }
                }
                else
                {
                    Console.WriteLine("No file");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Read Error :  " + ex.Message);
            }

            return 1;
        }

        /*
         * 센서 데이터 보내기 0.1초에 1번
         */
        public static async Task<String> UdpSendSensor()
        {
            string path = @"C:\Users\Junha Desktop\Desktop\용역\생산연\신규\통합\DT2 AI\DT2 Labview\sample data\dt2\sensor.csv";
            string[,] SensorData = new string[31570, 8];
            await Task.Run(() => ReadCSV(path, SensorData));

            CustomArray<String> strings = new CustomArray<String>();

            byte[] res;
            int port = 10009;
            UdpClient udp = new UdpClient();
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            //udp.Connect(ep);

            Stopwatch sw = new Stopwatch();
            string[] tmp = new string[8];
            int i = 0;

            while (true)
            {
                sw.Restart();
                try
                {

                    tmp = strings.GetRow(SensorData, i);
                    res = Serializer.Serialize(tmp);
                    udp.Send(res, res.Length, ep);
                    if (form.richTextBox1.InvokeRequired)
                    {
                        form.richTextBox1.Invoke(new MethodInvoker(delegate
                        {
                            // form.richTextBox1.AppendText($"\n Current time is : {time}");
                            form.richTextBox1.AppendText($"\n {tmp[0]}-{tmp[1]} {tmp[4]} {tmp[7]}");
                        }));

                    }
                }
                catch (Exception es)
                {
                    Console.WriteLine("sensor " + es.Message);
                }

                i++;

                sw.Stop();
                //Console.WriteLine($"Elap {(int)sw.ElapsedMilliseconds}");
                await Task.Delay(100 - (int)sw.ElapsedMilliseconds);
            }
        }

        /*
         * AI 데이터 보내기 1초에 1번
         */
        public static async Task<String> UdpSend()
        {
            string path = @"C:\Users\Junha Desktop\Desktop\용역\생산연\신규\통합\DT2 AI\DT2 Labview\sample data\dt2\ai.csv";
            string[,] aiData = new string[3157, 3];
            await Task.Run(() => ReadCSV(path, aiData));

            CustomArray<String> strings = new CustomArray<String>();

            byte[] res;
            int port = 10013;
            UdpClient udp = new UdpClient();
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);

            Stopwatch sw = new Stopwatch();
            string[] tmp = new string[3];
            int i = 0;

            while (true)
            {
                sw.Restart();
                try
                {

                    tmp = strings.GetRow(aiData, i);
                    res = Serializer.Serialize(tmp);
                    udp.Send(res, res.Length, ep);
                    if (form.richTextBox1.InvokeRequired)
                    {
                        form.richTextBox1.Invoke(new MethodInvoker(delegate
                        {
                            form.richTextBox1.AppendText($"\n {tmp[0]} {tmp[1]} {tmp[2]}");
                        }));

                    }
                }
                catch (Exception es)
                {
                    Console.WriteLine("ai " + es.Message);
                }

                i++;

                sw.Stop();
                //Console.WriteLine($"Elap {(int)sw.ElapsedMilliseconds}");
                await Task.Delay(1000 - (int)sw.ElapsedMilliseconds);
            }
        }

        /*
         * csv에서 데이터 읽기
         */
        public static string[,] ReadCSV(string filePath, string[,] data)
        {
            int i = 0;
            int j = 0;
            int tmp = 0;
            try
            {
                if (File.Exists(filePath))
                {
                    using (var stream = new StreamReader(File.Open(filePath, FileMode.Open)))
                    {
                        string[] values;
                        string line;

                        while ((line = stream.ReadLine()) != null)
                        {
                            values = line.Split(',');
                            tmp = values.Length;
                            for (j = 0; j < data.GetLength(1); j++)
                            {
                                data[i, j] = values[j];
                            }

                            i++;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message} i is {i} and j is {j} and {data.GetLength(1)} and tmp is {tmp}");
            }

            return data;
        }

        /*
         * 2d 배열에서 데이터 추출
         */
        public class CustomArray<T>
        {
            public T[] GetColumn(T[,] matrix, int columnNumber)
            {
                return Enumerable.Range(0, matrix.GetLength(0))
                        .Select(x => matrix[columnNumber, x])
                        .ToArray();
            }

            public T[] GetRow(T[,] matrix, int rowNumber)
            {
                return Enumerable.Range(0, matrix.GetLength(1))
                        .Select(x => matrix[rowNumber, x])
                        .ToArray();
            }
        }
    }
}
