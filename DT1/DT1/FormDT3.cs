
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
using System.Windows.Controls;
using System.Windows.Forms;
using devDept.Eyeshot.Translators;
using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using System.IO;
using System.Security.AccessControl;
using devDept;
using devDept.Graphics;

namespace DT1
{
    public partial class FormDT3 : Form
    {
        public int importFileType = 0;
        public FormDT3()
        {
            InitializeComponent();
            // pictureBox1.MouseClick += new MouseEventHandler(button1_Click);

            DT3ModelView.ActiveViewport.Background.TopColor = Color.FromArgb(255, 150, 150, 150);
            DT3ModelView.ActiveViewport.Background.BottomColor = Color.FromArgb(255, 40, 40, 40);
            DT3ModelView.ActiveViewport.Background.StyleMode = backgroundStyleType.LinearGradient;
            DT3ModelView.CompileUserInterfaceElements();

        }

        /*
         * DT3 좌표 측정 데이터를 받아서
         * datagridview로 표현
         * 
         */
        public void UpdateDT3Table(Measurement mea, int index)
        {
            if (dataGridView2.InvokeRequired)
            {

                dataGridView2.Invoke(new MethodInvoker(delegate 
                {
                    int rowId = dataGridView2.Rows.Add();
                    DataGridViewRow row = dataGridView2.Rows[rowId];
                    row.Cells[0].Value = "P" + (index+1);
                    row.Cells[1].Value = "";
                    row.Cells[2].Value = "X";
                    row.Cells[3].Value = "Y";
                    row.Cells[4].Value = "Z";

                    rowId = dataGridView2.Rows.Add();
                    row = dataGridView2.Rows[rowId];
                    row.Cells[0].Value = "P" + (index+1);
                    row.Cells[1].Value = "MEA";
                    row.Cells[2].Value = mea._DesignPos[0];
                    row.Cells[3].Value = mea._DesignPos[1];
                    row.Cells[4].Value = mea._DesignPos[2];

                    rowId = dataGridView2.Rows.Add();
                    row = dataGridView2.Rows[rowId];
                    row.Cells[0].Value = "P" + (index+1);
                    row.Cells[1].Value = "DES";
                    row.Cells[2].Value = mea._MeasuredPos[0];
                    row.Cells[3].Value = mea._MeasuredPos[1];
                    row.Cells[4].Value = mea._MeasuredPos[2];
                    //row.DividerHeight = 5;

                    rowId = dataGridView2.Rows.Add();
                    row = dataGridView2.Rows[rowId];
                    row.Cells[0].Value = "P" + (index + 1);
                    row.Cells[1].Value = "DIFF";
                    row.Cells[2].Value = Math.Round((mea._DesignPos[0] - mea._MeasuredPos[0]),2);
                    row.Cells[3].Value = Math.Round((mea._DesignPos[1] - mea._MeasuredPos[1]),2);
                    row.Cells[4].Value = Math.Round((mea._DesignPos[2] - mea._MeasuredPos[2]),2);


                    dataGridView2.FirstDisplayedScrollingRowIndex = dataGridView2.RowCount - 1;
                }));
            }
            else
            {

            }

        }

        /// <summary>
        /// DT3 테이블 셀 합치기 위한 method
        /// row 위아래값 동일 체크
        /// </summary>
        /// <param name="column"> 테이블 열</param>
        /// <param name="row">테이블 행</param>
        /// <returns>테이블 값 </returns>
        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = dataGridView2[column, row];
            DataGridViewCell cell2 = dataGridView2[column, row - 1];
            if (cell1.Value == null || cell2.Value == null || column != 0)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        /*
         * DT3 테이블 셀 합치기 위한 method
         * border 스타일링
         * 첫번째 col일경우만 border 없앰
         */
        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
               e.AdvancedBorderStyle.Top = dataGridView2.AdvancedCellBorderStyle.Top;
            }

            if(e.RowIndex % 4 == 0)
            {

            }
        }

        /*
         * DT3 테이블 셀 합치기 위한 method
         * 위아래 셀이 값이 같을 경우 셀 value 없앰
         * 
         */
        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }

        /*
         * DT3 데이터를 UDP로 받는 함수
         * 데이터 받아서 form의 내부 함수로 전달 
         */
        public async void UdpReceiveDT3()
        {
            int dt3port = 10001;
            UdpClient udp = new UdpClient(dt3port);
            //IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.0.16"), dt3port);

            while (true)
            {
                try
                {
                    byte[] data = udp.Receive(ref ep);
                    List<Measurement> msg = Serializer.Deserialize<List<Measurement>>(data);

                    if (dataGridView2.InvokeRequired)
                    {

                        dataGridView2.Invoke(new MethodInvoker(delegate
                        {
                            label7.Text = msg[0]._NumPart;

                            label26.Text = msg[0]._WCS[0].ToString();
                            label25.Text = msg[0]._WCS[1].ToString();
                            label21.Text = msg[0]._WCS[2].ToString();

                            label6.Text = msg[0]._InspectionID[0];
                        }));
                    }
                            for (int i = 0; i < msg.Count; i++)
                    {
                        UpdateDT3Table(msg[i], i);
                        await Task.Delay(1000);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n receive " + ex.Message);
                }
            }

        }

        /*
         * 세번째 Row마다 border 강조함
         * 
         */
        private void dataGridView2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if ((e.RowIndex+1) % 4== 0)
            {
                dataGridView2.Rows[e.RowIndex].DividerHeight = 5;
            }
        }

        /*
         * Eyeshot CAD Import
         */
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "3D Model Import";
            ofd.Filter = "모델 파일 (*.obj,*.stp,*.step,*.iges) | *.obj; *.stp; *.step; *.iges; | 모든 파일 (*.*) | *.*";

            DialogResult dr = ofd.ShowDialog();

            if(dr == DialogResult.OK)
            {
                string fileFullName = ofd.FileName;
                string ext = Path.GetExtension(fileFullName);

                Console.WriteLine("ext " + ext);

                
                try
                {
                    if(ext == ".obj")
                    {
                        importFileType = 0;
                        DT3ModelView.WorkCompleted += ViewportLayout1OnWorkCompleted;
                        ReadOBJ cadModel = new ReadOBJ(fileFullName);
                        DT3ModelView.Clear();
                        DT3ModelView.StartWork(cadModel);
                    }
                    else if(ext == ".stp" || ext == ".step")
                    {
                        importFileType = 1;
                        DT3ModelView.WorkCompleted += ViewportLayout1OnWorkCompleted;
                        ReadSTEP cadModel = new ReadSTEP(fileFullName);
                        DT3ModelView.Clear();
                        DT3ModelView.StartWork(cadModel);
                    }
                    else
                    {
                        Console.WriteLine("Not supported");
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }

        private void ViewportLayout1OnWorkCompleted(object sender, WorkCompletedEventArgs workCompletedEventArgs)
        {
            if(importFileType == 1)
            {
                ReadSTEP stepModel = (ReadSTEP)workCompletedEventArgs.WorkUnit;
                stepModel.AddToScene(DT3ModelView);
                DT3ModelView.Invalidate();
            }
            else
            {
                ReadOBJ stepModel = (ReadOBJ)workCompletedEventArgs.WorkUnit;
                stepModel.AddToScene(DT3ModelView);
                DT3ModelView.Invalidate();
            }

        }

        private void pnlPanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);
            //Pen p = new Pen(Color.Blue, 2);
            //e.Graphics.DrawRectangle(p, r);

            ControlPaint.DrawBorder(e.Graphics, r, Color.DarkGray, ButtonBorderStyle.Solid);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);
            //Pen p = new Pen(Color.Blue, 2);
            //e.Graphics.DrawRectangle(p, r);

            ControlPaint.DrawBorder(e.Graphics, r, Color.DarkGray, ButtonBorderStyle.Solid);
        }

        private void kryptonSeparator7_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void kryptonSeparator2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

    }
}
