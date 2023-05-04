using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using Brushes = System.Windows.Media.Brushes;
using HorizontalAlignment = System.Windows.HorizontalAlignment;
using Panel = System.Windows.Controls.Panel;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows;
using DevExpress.XtraEditors.Filtering.Templates;
using static DevExpress.Data.Filtering.Helpers.SubExprHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using DevExpress.Data.Linq.Helpers;

namespace DT1
{
    public partial class FormDT2 : Form
    {
        public int aiBarGraphCount1 = 0;
        public int aiBarGraphCount2 = 0;
        public int aiBarGraphCount3 = 0;
        public int aiBarGraphCount4 = 0;

        private string alarmSavePath = @"C:\Users\Junha Desktop\Desktop\event.csv";

        public FormDT2()
        {
            InitializeComponent();
            sensorXYZChart.Series[0].BorderWidth = 2;
            aiResultsTable.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.SlateGray;
            aiResultsTable.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.LightGray;
            aiResultsTable.EnableHeadersVisualStyles = false;

            alarmTable.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.SlateGray;
            alarmTable.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.LightGray;
            alarmTable.EnableHeadersVisualStyles = false;

            dataTable.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.SlateGray;
            dataTable.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.LightGray;
            dataTable.EnableHeadersVisualStyles = false;

            aiBarChart.Series["Series1"].Points.Add(0);
            aiBarChart.Series["Series1"].Points.Add(0);
            aiBarChart.Series["Series1"].Points.Add(0);
            aiBarChart.Series["Series1"].Points.Add(0);

            aiBarChart.Series["Series1"].Points[0].Color = System.Drawing.Color.SkyBlue;
            aiBarChart.Series["Series1"].Points[0].AxisLabel = "비가공";
            //chart3.Series["Series1"].Points[0].ToolTip = "qqqq";
            aiBarChart.Series["Series1"].Points[1].Color = System.Drawing.Color.Green;
            aiBarChart.Series["Series1"].Points[1].AxisLabel = "Normal\nWear";
            aiBarChart.Series["Series1"].Points[2].Color = System.Drawing.Color.OrangeRed;
            aiBarChart.Series["Series1"].Points[2].AxisLabel = "Severe\nWear";
            aiBarChart.Series["Series1"].Points[3].Color = System.Drawing.Color.LightGray;
            aiBarChart.Series["Series1"].Points[3].AxisLabel = "Sample";

            alarmSavePathValue.Text = alarmSavePath;

        }

        /// <summary>
        /// 알람 발생 시 파일에 저장
        /// </summary>
        /// <param name="t">알람 시간</param>
        /// <param name="a">알람 내용</param>
        public void SaveAlarm(string t, string a)
        {
            

            var csv = new StringBuilder();
            string csvRow;
            string alarm;

            if(!File.Exists(alarmSavePath))
            {
                using (StreamWriter createStream = new StreamWriter(File.Open(alarmSavePath, FileMode.OpenOrCreate), Encoding.UTF8))
                {
                    csvRow = t + "," + a;
                    createStream.WriteLine(csvRow, Encoding.UTF8);
                }
            }
            else
            {
                csvRow = t + "," + a;
                File.AppendAllText(alarmSavePath,
                   csvRow + Environment.NewLine, Encoding.UTF8);
            }
           
        }

        /// <summary>
        /// CNC Machine Data 받아서 그래프 표현
        /// </summary>
        public async void UdpReceiveMachine()
        {
            int dt3port = 10011;
            UdpClient udp = new UdpClient(dt3port);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);
            //IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.0.49"), dt3port);
            Random rand = new Random();

            DataGridViewRow row;
            int rowId;

            while (true)
            {
                try
                {
                    byte[] data = udp.Receive(ref ep);
                    string[] msg = Serializer.Deserialize<string[]>(data);

                    string t = msg[1];
                    double xRms = Convert.ToDouble(msg[2]);
                    double yRms = Convert.ToDouble(msg[3]);
                    double zRms = Convert.ToDouble(msg[4]);
                    double current = Convert.ToDouble(msg[5]);
                    if (machineXYZChart.InvokeRequired || machineSpindleChart.InvokeRequired)
                    {
                        machineXYZChart.Invoke(new MethodInvoker(delegate
                        {
                            machineXYZChart.Series[0].Points.AddXY(t, xRms);
                            machineXYZChart.Series[1].Points.AddXY(t, yRms);
                            machineXYZChart.Series[2].Points.AddXY(t, zRms);

                            machineSpindleChart.Series[0].Points.AddXY(t, current);

                            if (machineXYZChart.Series[0].Points.Count > 100)
                            {
                                machineXYZChart.Series[2].Points.RemoveAt(0);
                                machineXYZChart.Series[1].Points.RemoveAt(0);
                                machineXYZChart.Series[0].Points.RemoveAt(0);
                            }
                            if (machineSpindleChart.Series[0].Points.Count > 100)
                            {
                                machineSpindleChart.Series[0].Points.RemoveAt(0);

                            }

                            machineTimingValue.Text = msg[6];

                            toolNoValue.Text = Math.Round(Convert.ToDouble(msg[3]) * 100, 2).ToString();
                            feedRateValue.Text = Math.Round(Convert.ToDouble(msg[4]) * 100, 2).ToString();
                            rpmValue.Text = Math.Round(Convert.ToDouble(msg[5]) * 100, 2).ToString();

                            machineLoadXValue.Text = msg[6];
                            
                            machineRpmValue.Text = Math.Round(Convert.ToDouble(msg[3]) * 100, 2).ToString();
                            machineFeedValue.Text = Math.Round(Convert.ToDouble(msg[4]) * 100, 2).ToString();
                            machineCurrentValue.Text = Math.Round(Convert.ToDouble(msg[5]) * 100, 2).ToString();

                            xLoadValue.Text = Math.Round(Convert.ToDouble(msg[3]) * 100, 2).ToString();
                            yLoadValue.Text = Math.Round(Convert.ToDouble(msg[4]) * 100, 2).ToString();
                            zLoadValue.Text = Math.Round(Convert.ToDouble(msg[5]) * 100, 2).ToString();

                            rowId = dataTable.Rows.Add();
                            row = dataTable.Rows[rowId];
                            row.Cells[0].Value = msg[0] + ";" + t;
                            row.Cells[1].Value = Math.Round(Convert.ToDouble(msg[2]) * 100, 2).ToString();
                            row.Cells[2].Value = Math.Round(Convert.ToDouble(msg[3]) * 100, 2).ToString();
                            row.Cells[3].Value = msg[6];
                            row.Cells[4].Value = Math.Round(Convert.ToDouble(msg[4]) * 100, 2).ToString();
                            row.Cells[5].Value = Math.Round(Convert.ToDouble(msg[5]) * 100, 2).ToString();
                            row.Cells[6].Value = Math.Round(Convert.ToDouble(msg[2]) * 100, 2).ToString();
                            row.Cells[7].Value = msg[7];
                            dataTable.FirstDisplayedScrollingRowIndex = rowId;
                        }));
                    }
                    //await Task.Delay(100);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n receive " + ex.Message);
                }
            }

        }

        /// <summary>
        /// Labview Monitoring에서 센서 데이터 받아서 그래프 및 알람 테이블 표현
        /// </summary>
        public async void UdpReceiveMonitoring()
        {
            int dt3port = 10009;
            UdpClient udp = new UdpClient(dt3port);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);
            //IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.0.49"), dt3port);
            
            DataGridViewRow row;
            int rowId;
            string alarm;

            while (true)
            {
                try
                {
                    byte[] data = udp.Receive(ref ep);
                    string[] msg = Serializer.Deserialize<string[]>(data);

                    bool flag = false;
                    string t = msg[1];
                    string d = msg[0] + ";" + t;
                    double xRms = Convert.ToDouble(msg[2]);
                    double yRms = Convert.ToDouble(msg[3]);
                    double zRms = Convert.ToDouble(msg[4]);
                    double current = Convert.ToDouble(msg[5]);
                    if (sensorXYZChart.InvokeRequired || sensorCurrentChart.InvokeRequired)
                    {
                        sensorXYZChart.Invoke(new MethodInvoker(delegate
                        {
                            //if (xRms > graph1Alarm || yRms > graph1Alarm || zRms > graph1Alarm)
                            //{
                            //    flag = true;
                            //    alarm = "가속도 센서 알람 발생";
                            //    pictureBox2.Show();
                            //    pictureBox1.Hide();

                            //    rowId = alarmTable.Rows.Add();
                            //    row = alarmTable.Rows[rowId];
                            //    row.Cells[0].Value = d;

                            //    row.Cells[1].Value = alarm;
                            //    alarmTable.FirstDisplayedScrollingRowIndex = rowId;

                            //    SaveAlarm(t, alarm);
                            //}
                            //else
                            //{
                            //    pictureBox1.Show();
                            //    pictureBox2.Hide();
                            //}

                            //if (current > graph2Alarm)
                            //{
                            //    flag = true;
                            //    alarm = "전류 센서 알람 발생";
                            //    pictureBox3.Show();
                            //    pictureBox4.Hide();

                            //    rowId = alarmTable.Rows.Add();
                            //    row = alarmTable.Rows[rowId];
                            //    row.Cells[0].Value = d;
                            //    row.Cells[1].Value = alarm;
                            //    alarmTable.FirstDisplayedScrollingRowIndex = rowId;

                            //    SaveAlarm(t, alarm);
                            //}
                            //else
                            //{
                            //    pictureBox4.Show();
                            //    pictureBox3.Hide();
                            //}

                            sensorXYZChart.Series[0].Points.AddXY(t, xRms);
                            sensorXYZChart.Series[1].Points.AddXY(t, yRms);
                            sensorXYZChart.Series[2].Points.AddXY(t, zRms);
                            //sensorXYZChart.Series[3].Points.AddY(graph1Alarm);

                            sensorCurrentChart.Series[0].Points.AddXY(t, current);
                            //sensorCurrentChart.Series[1].Points.AddY(graph2Alarm);

                            if (sensorXYZChart.Series[0].Points.Count > 100)
                            {
                                sensorXYZChart.Series[2].Points.RemoveAt(0);
                                sensorXYZChart.Series[1].Points.RemoveAt(0);
                                sensorXYZChart.Series[0].Points.RemoveAt(0);
                            }
                            if (sensorCurrentChart.Series[0].Points.Count > 100)
                            {
                                sensorCurrentChart.Series[0].Points.RemoveAt(0);
                            }

                            machineLoadYValue.Text = Math.Round(Convert.ToDouble(msg[4]) * 100, 2).ToString();
                            machineLoadZValue.Text = Math.Round(Convert.ToDouble(msg[5]) * 100, 2).ToString();

                            machineXPosValue.Text = Math.Round(Convert.ToDouble(msg[2]) * 100, 2).ToString();
                            machineYPosValue.Text = Math.Round(Convert.ToDouble(msg[3]) * 100, 2).ToString();
                            machineZPosValue.Text = Math.Round(Convert.ToDouble(msg[4]) * 100, 2).ToString();

                        }));
                    }
                    //await Task.Delay(100);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n receive " + ex.Message);
                }
            }

        }


        //public async void UdpReceiveAI()
        //{
        //    int dt3port = 10013;
        //    UdpClient udp = new UdpClient(dt3port);
        //    IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);
        //    //IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.0.49"), dt3port);
        //    Console.WriteLine("Why1");
        //    DataGridViewRow row;
        //    int rowId;

        //    while (true)
        //    {
        //        byte[] data = udp.Receive(ref ep);
        //        string[] msg = Serializer.Deserialize<string[]>(data);

        //        Console.WriteLine($"sss : data");
        //        await Task.Delay(1000);
        //    }

        //}
        /// <summary>
        /// Labview AI에서 예측결과 테이블 표현
        /// </summary>
        public async void UdpReceiveAI()
        {
            int dt3port = 10013;
            UdpClient udp = new UdpClient(dt3port);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);
            //IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.0.49"), dt3port);
            Console.WriteLine("Why1");
            DataGridViewRow row;
            int rowId;

            while (true)
            {
                try
                {
                    Console.WriteLine("Why2");
                    byte[] data = udp.Receive(ref ep);
                    string[] msg = Serializer.Deserialize<string[]>(data);

                    string t = msg[1];
                    Console.WriteLine("Why55");
                    if (aiResultsTable.InvokeRequired)
                    {
                        aiResultsTable.Invoke(new MethodInvoker(delegate
                        {
                            Console.WriteLine("Why3");
                            rowId = aiResultsTable.Rows.Add();
                            row = aiResultsTable.Rows[rowId];
                            row.Cells[0].Value = msg[0] + ";" + t;

                            if (Convert.ToInt32(msg[2]) == 1)
                            {
                                aiBarGraphCount1++;
                                aiBarChart.Series["Series1"].Points[0].SetValueY(aiBarGraphCount1);
                                row.Cells[1].Value = "Normal Wear";
                                //Console.WriteLine("ee is " + chart3.Series["Series1"].Points[0].YValues[0]);
                            }
                            else if (Convert.ToInt32(msg[2]) == 2)
                            {
                                aiBarGraphCount2++;
                                aiBarChart.Series["Series1"].Points[1].SetValueY(aiBarGraphCount2);
                                row.Cells[1].Value = "Severe Wear";
                                //Console.WriteLine("ee is " + chart3.Series["Series1"].Points[1].YValues[0]);
                            }
                            else if (Convert.ToInt32(msg[2]) == 3)
                            {
                                aiBarGraphCount3++;
                                aiBarChart.Series["Series1"].Points[2].SetValueY(aiBarGraphCount3);
                                row.Cells[1].Value = "비가공";
                                //Console.WriteLine("ee is " + chart3.Series["Series1"].Points[2].YValues[0]);
                            }
                            else
                            {
                                aiBarGraphCount4++;
                                aiBarChart.Series["Series1"].Points[3].SetValueY(aiBarGraphCount4);
                                row.Cells[1].Value = "Else";
                                //Console.WriteLine("ee is " + chart3.Series["Series1"].Points[3].YValues[0]);
                            }
                            double min = aiBarChart.Series["Series1"].Points[0].YValues[0];
                            double max = aiBarChart.Series["Series1"].Points[0].YValues[0];
                            for (int i = 0; i < aiBarChart.Series["Series1"].Points.Count; i++)
                            {
                                if (min > aiBarChart.Series["Series1"].Points[i].YValues[0])
                                {
                                    min = aiBarChart.Series["Series1"].Points[i].YValues[0];
                                }

                                if (max < aiBarChart.Series["Series1"].Points[i].YValues[0])
                                {
                                    max = aiBarChart.Series["Series1"].Points[i].YValues[0];
                                }
                            }

                            if (max * 2 > aiBarChart.ChartAreas[0].AxisY.Maximum)
                            {
                                aiBarChart.ChartAreas[0].AxisY.Maximum = max * 2;

                            }

                            aiBarChart.Refresh();
                            aiBarChart.Update();

                            aiResultsTable.FirstDisplayedScrollingRowIndex = rowId;
                        }));
                    }
                    else
                    {
                    //    Console.WriteLine("Why4");
                    //    rowId = aiResultsTable.Rows.Add();
                    //    row = aiResultsTable.Rows[rowId];
                    //    row.Cells[0].Value = msg[0] + ";" + t;

                    //    if (Convert.ToInt32(msg[2]) == 1)
                    //    {
                    //        aiBarGraphCount1++;
                    //        aiBarChart.Series["Series1"].Points[0].SetValueY(aiBarGraphCount1);
                    //        row.Cells[1].Value = "Normal Wear";
                    //        //Console.WriteLine("ee is " + chart3.Series["Series1"].Points[0].YValues[0]);
                    //    }
                    //    else if (Convert.ToInt32(msg[2]) == 2)
                    //    {
                    //        aiBarGraphCount2++;
                    //        aiBarChart.Series["Series1"].Points[1].SetValueY(aiBarGraphCount2);
                    //        row.Cells[1].Value = "Severe Wear";
                    //        //Console.WriteLine("ee is " + chart3.Series["Series1"].Points[1].YValues[0]);
                    //    }
                    //    else if (Convert.ToInt32(msg[2]) == 3)
                    //    {
                    //        aiBarGraphCount3++;
                    //        aiBarChart.Series["Series1"].Points[2].SetValueY(aiBarGraphCount3);
                    //        row.Cells[1].Value = "비가공";
                    //        //Console.WriteLine("ee is " + chart3.Series["Series1"].Points[2].YValues[0]);
                    //    }
                    //    else
                    //    {
                    //        aiBarGraphCount4++;
                    //        aiBarChart.Series["Series1"].Points[3].SetValueY(aiBarGraphCount4);
                    //        row.Cells[1].Value = "Else";
                    //        //Console.WriteLine("ee is " + chart3.Series["Series1"].Points[3].YValues[0]);
                    //    }
                    //    double min = aiBarChart.Series["Series1"].Points[0].YValues[0];
                    //    double max = aiBarChart.Series["Series1"].Points[0].YValues[0];
                    //    for (int i = 0; i < aiBarChart.Series["Series1"].Points.Count; i++)
                    //    {
                    //        if (min > aiBarChart.Series["Series1"].Points[i].YValues[0])
                    //        {
                    //            min = aiBarChart.Series["Series1"].Points[i].YValues[0];
                    //        }

                    //        if (max < aiBarChart.Series["Series1"].Points[i].YValues[0])
                    //        {
                    //            max = aiBarChart.Series["Series1"].Points[i].YValues[0];
                    //        }
                    //    }

                    //    if (max * 2 > aiBarChart.ChartAreas[0].AxisY.Maximum)
                    //    {
                    //        aiBarChart.ChartAreas[0].AxisY.Maximum = max * 2;
                    //    }

                    //    aiBarChart.Refresh();
                    //    aiBarChart.Update();

                    //    aiResultsTable.FirstDisplayedScrollingRowIndex = rowId;
                    }
                    //await Task.Delay(1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n receive " + ex.Message);
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void machineChartTab_Click(object sender, EventArgs e)
        {
            //machineChartPanel.Show();
            //machineNoChartPanel.Hide();
        }

        private void machineNoChartTab_Click(object sender, EventArgs e)
        {
            //machineChartPanel.Hide();
            //machineNoChartPanel.Show();
        }

        private void sensorChartTab_Click(object sender, EventArgs e)
        {
            //dataTablePanel.Hide();
            //sensorChartPanel.Show();
        }

        private void dataTableTab_Click(object sender, EventArgs e)
        {
            //dataTablePanel.Show();
            //sensorChartPanel.Hide();
        }

        private void aiResultsTab_Click(object sender, EventArgs e)
        {
            //aiResultsPanel.Show();
            //aiBarPanel.Hide();
        }

        private void aiBarTab_Click(object sender, EventArgs e)
        {
            //aiBarPanel.Show();
            //aiResultsPanel.Hide();
        }

        private void alarmTab_Click(object sender, EventArgs e)
        {
            //alarmTablePanel.Show();
            //settingsPanel.Hide();
        }

        private void settingsTab_Click(object sender, EventArgs e)
        {
            //settingsPanel.Show();
            //alarmTablePanel.Hide();
        }

        /// <summary>
        /// 화면 리셋
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_Click(object sender, EventArgs e)
        {
            ClearGraph(sensorXYZChart);
            ClearGraph(sensorCurrentChart);
            ClearGraph(machineXYZChart);
            ClearGraph(machineSpindleChart);

            aiBarChart.Series["Series1"].Points[0].SetValueY(0);
            aiBarChart.Series["Series1"].Points[1].SetValueY(0);
            aiBarChart.Series["Series1"].Points[2].SetValueY(0);
            aiBarChart.Series["Series1"].Points[3].SetValueY(0);

            aiBarChart.ChartAreas[0].AxisY.Maximum = 10;

            aiResultsTable.Rows.Clear();
            alarmTable.Rows.Clear();
            dataTable.Rows.Clear();
        }

        /// <summary>
        /// 차트 포인트 초기화
        /// </summary>
        /// <param name="c"></param>
        private void ClearGraph(Chart c)
        {
            for (int i = 0; i < c.Series.Count; i++)
            {
                c.Series[i].Points.Clear();

            }
        }

        /// <summary>
        /// 알람 저장 경로 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alarmSavePathChange_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    alarmSavePathValue.Text = fbd.SelectedPath + "\\event1.csv";
                    alarmSavePath = fbd.SelectedPath + "\\event1.csv";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
