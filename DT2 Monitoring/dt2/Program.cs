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
using System.Collections;
using System.Text;
using System.Diagnostics;
using dt2;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DT2_Monitoring
{
    internal static class Program
    {
        static Form1 form;
        static string[,] data1 = new string[31570, 8];
        static string readFile = @"C:\Users\Junha Desktop\Desktop\용역\생산연\신규\통합\DT2 Monitoring\dt2\SampleData\dt2\dt2 data.csv";
        static string writeFile = @"C:\Users\Junha Desktop\Desktop\용역\생산연\신규\통합\DT2 Monitoring\dt2\SampleData\dt2\machine.csv";

        /// <summary>
        /// The main entry point for the application.   
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            Task.Run(() => UdpSend());
            //Task.Run(() => CreateCSV());
            //Task.Run(() => SendTime());

            Application.Run(form);
            
        }

        /*
         * 딜레이 테스트
         */
        public static async void SendTime()
        {
            int port = 10011;
            UdpClient udp = new UdpClient();
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);

            while(true)
            {
                // Get the current time as a string
                DateTime time = DateTime.Now;
                String time2 = time.AddSeconds(5).ToString("HH:MM:ss.f");

                // Convert the string to a byte array
                byte[] data = Encoding.ASCII.GetBytes(time2);

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
             * DT2 데이터 보내기
             */
            public static async Task<String> UdpSend()
            {
                await Task.Run(() => ReadCSV());

                CustomArray<String> strings = new CustomArray<String>();

                byte[] res;
                int port = 10011;
                UdpClient udp = new UdpClient();
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                Stopwatch sw = new Stopwatch();
                string[] tmp = new string[8];
                int i = 0;
                string time;

                while (true)
                {
                    sw.Start();
                    try
                    {

                        tmp = strings.GetRow(data1, i);
                        res = Serializer.Serialize(tmp);
                        udp.Send(res, res.Length, ep);
                        if (form.richTextBox1.InvokeRequired)
                        {
                            form.richTextBox1.Invoke(new MethodInvoker(delegate
                            {
                                form.richTextBox1.AppendText($"\n {tmp[0]}-{tmp[1]} {tmp[4]} {tmp[7]}");
                                //form.richTextBox1.AppendText($"\n {tmp[8]}");
                            }));

                        }
                    }
                    catch (Exception es)
                    {
                        Console.WriteLine("Error: " + es.Message);
                    }

                    i++;
                
                    sw.Stop();
                    Console.WriteLine($"Elap {(int)sw.ElapsedMilliseconds}");
                    await Task.Delay(100 - (int)sw.ElapsedMilliseconds);
                
                
                    sw.Reset();

                }
            }

        /*
         * csv에서 데이터 읽기
         */
        public static void ReadCSV()
        {
            string readFile = @"C:\Users\Junha Desktop\Desktop\용역\생산연\신규\통합\DT2 Monitoring\dt2\SampleData\dt2\machine.csv";

            int i = 0;
            int j = 0;
            int tmp = 0;
            
            try
            {
                if (File.Exists(readFile))
                {
                    using (var stream = new StreamReader(File.Open(readFile, FileMode.Open)))
                    {
                        string[] values;
                        string line;
                        
                        while ((line = stream.ReadLine()) != null)
                        {
                            values = line.Split(',');
                            tmp = values.Length;
                            for(j = 0; j < data1.GetLength(1); j++)
                            {
                                data1[i, j] = values[j];
                            }

                            i++;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message} i is {i} and j is {j} and {data1.GetLength(1)} and tmp is {tmp}");
            }
        }
            

        /*
         * 더미 데이터 생성 확인
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
            string readFile = @"C:\Users\Junha Desktop\Desktop\용역\생산연\신규\통합\DT2 Monitoring\dt2\SampleData\dt2\dt2 data.csv";
            string writeFile = @"C:\Users\Junha Desktop\Desktop\용역\생산연\신규\통합\DT2 Monitoring\dt2\SampleData\dt2\machine.csv";
            try
            {
                if(File.Exists(readFile))
                {
                    Console.WriteLine("file exits");
                    using (var stream = new StreamReader(File.Open(readFile, FileMode.Open)))
                    {
                        string[] values;
                        string line;
                        var csv = new StringBuilder();
                        using (var createStream = File.CreateText(writeFile))
                        {
                            string date = "";
                            string time = "";
                            string acc1 = "";
                            string acc2 = "";
                            string acc3 = "";
                            string current1 = "";
                            string alarm1 = "";
                            string alarm2 = "";
                            string csvRow;
                            Random random = new Random();
                            double tmp;
                            double tmp2;

                            while ((line = stream.ReadLine()) != null)
                            {
                                values = line.Split(',');
                                date = values[0];
                                for (int i = 0; i < 10; i++)
                                {
                                    time = values[1] + "." + i;

                                    tmp = Double.Parse(values[3]);

                                    tmp2 = tmp + (random.NextDouble() * 0.1);
                                    acc1 = tmp2.ToString("#.000000");

                                    tmp2 = tmp + (random.NextDouble() * 0.2);
                                    acc2 = tmp2.ToString("#.000000");

                                    tmp2 = tmp + (random.NextDouble() * 0.3);
                                    acc3 = tmp2.ToString("#.000000");

                                    tmp2 = tmp - (random.NextDouble() * 0.1);
                                    current1 = tmp2.ToString("#.000000");

                                    alarm1 = random.Next(1000).ToString();
                                    alarm2 = random.Next(2).ToString();



                                    csvRow = string.Format($"{date},{time},{acc1},{acc2},{acc3},{current1},{alarm1},{alarm2}");
                                    csv.AppendLine(csvRow);
                                }
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
    }

    //2d 배열에서 열 또는 행 묶음의 데이터 구하기 
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
