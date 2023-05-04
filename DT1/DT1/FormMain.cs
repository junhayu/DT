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
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.InteropServices;
using ComponentFactory.Krypton.Toolkit;

namespace DT1
{
    public partial class formMain : KryptonForm
    {
        public FormIntegration twinIntegration = new FormIntegration();
        formMode1 dt1 = new formMode1();
        public FormDT3 dt3 = new FormDT3();
        public FormDT2 dt2 = new FormDT2();
        FormLicense frmLicense_Vrb = new FormLicense();

        public Point mouseLocation; //창 상단바 클릭시 이동 위한 마우스 위치

        

        //UI 창의 모서리를 라운드로 만들기 위한 sys32 dll
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        /// <summary>
        /// 처음 시작 시 통합 화면 버튼 디자인 변경 및 통합 화면 보이기
        /// </summary>
        public formMain()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            navPanel.Height = menuIntegration.Height;
            navPanel.Top = menuIntegration.Top;
            navPanel.Left = menuIntegration.Left;
            menuIntegration.BackColor = Color.FromArgb(46, 51, 73);

            formTitle.Text = "Twin Integration";
            this.formPanel.Controls.Clear();
            twinIntegration.Dock = DockStyle.Fill;
            twinIntegration.TopLevel = false;
            twinIntegration.TopMost = true;
            twinIntegration.FormBorderStyle = FormBorderStyle.None;
            this.formPanel.Controls.Add(twinIntegration);
            twinIntegration.Show();
        }

        /// <summary>
        /// 상단 바 클릭시 마우스 위치 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formTopMouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        /// <summary>
        /// 상단 바의 마우스 위치따라 form 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formTopMouse_Move(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        /// <summary>
        /// 메뉴에서 통합 버튼 클릭 시 버튼 디자인 변경 및 통합 화면 보이기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuIntegration_Click(object sender, EventArgs e)
        {
            navPanel.Height = menuIntegration.Height;
            navPanel.Top = menuIntegration.Top;
            menuIntegration.BackColor = Color.FromArgb(46, 51, 73);


            formTitle.Text = "Twin Integration";
            this.formPanel.Controls.Clear();
            twinIntegration.Dock = DockStyle.Fill;
            twinIntegration.TopLevel = false;
            twinIntegration.TopMost = true;
            twinIntegration.FormBorderStyle = FormBorderStyle.None;
            this.formPanel.Controls.Add(twinIntegration);
            twinIntegration.Show();
        }

        /// <summary>
        /// 메뉴에서 Mode1 버튼 클릭 시 버튼 디자인 변경 및 Mode1 화면 보이기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMode1_Click(object sender, EventArgs e)
        {
            navPanel.Height = menuMode1.Height;
            navPanel.Top = menuMode1.Top;
            navPanel.Left = menuMode1.Left;
            menuMode1.BackColor = Color.FromArgb(46, 51, 73);
            menuIntegration.BackColor = Color.FromArgb(37, 42, 64);

            formTitle.Text = "Simulation";
            this.formPanel.Controls.Clear();
            dt1.Dock = DockStyle.Fill;
            dt1.TopLevel = false;
            dt1.TopMost = true;
            dt1.FormBorderStyle = FormBorderStyle.None;
            this.formPanel.Controls.Add(dt1);
            dt1.Show();
        }

        /// <summary>
        /// 메뉴에서 Mode2 클릭시 버튼 디자인 변경 및 Mode2 화면 보이기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMode2_Click(object sender, EventArgs e)
        {
            navPanel.Height = menuMode2.Height;
            navPanel.Top = menuMode2.Top;
            menuMode2.BackColor = Color.FromArgb(46, 51, 73);
            menuIntegration.BackColor = Color.FromArgb(37, 42, 64);

            formTitle.Text = "Monitoring";
            this.formPanel.Controls.Clear();
            dt2.Dock = DockStyle.Fill;
            dt2.TopLevel = false;
            dt2.TopMost = true;
            dt2.FormBorderStyle = FormBorderStyle.None;
            this.formPanel.Controls.Add(dt2);
            dt2.Show();
        }

        /// <summary>
        /// 메뉴에서 Mode3 클릭시 버튼 디자인 변경 및 Mode3 화면 보이기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMode3_Click(object sender, EventArgs e)
        {
            navPanel.Height = menuMode3.Height;
            navPanel.Top = menuMode3.Top;
            menuMode3.BackColor = Color.FromArgb(46, 51, 73);
            menuIntegration.BackColor = Color.FromArgb(37, 42, 64);

            
            formTitle.Text = "Inspection";
            this.formPanel.Controls.Clear();
            dt3.Dock = DockStyle.Fill;
            dt3.TopLevel = false;
            dt3.TopMost = true;
            dt3.FormBorderStyle = FormBorderStyle.None;
            this.formPanel.Controls.Add(dt3);
            dt3.Show();
        }



        /// <summary>
        /// 메뉴에서 라이센스 클릭시 버튼 디자인 변경 및 license 화면 보이기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuLicense_Click(object sender, EventArgs e)
        {
            formTitle.Text = "DTfM Platform Ultimate Platform Software Development Kit ";
            navPanel.Height = menuLicense.Height;
            navPanel.Top = menuLicense.Top;
            menuLicense.BackColor = Color.FromArgb(46, 51, 73);
            menuMode1.BackColor = Color.FromArgb(37, 42, 64);
            this.formPanel.Controls.Clear();
            frmLicense_Vrb.Dock = DockStyle.Fill;
            frmLicense_Vrb.TopLevel = false;
            frmLicense_Vrb.TopMost = true;
            frmLicense_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.formPanel.Controls.Add(frmLicense_Vrb);
            frmLicense_Vrb.Show();
        }

        /// <summary>
        /// 메뉴에서 설정 클릭시 버튼 디자인 변경 및 설정 화면 보이기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuSettings_Click(object sender, EventArgs e)
        {
            navPanel.Height = menuSettings.Height;
            navPanel.Top = menuSettings.Top;
            menuSettings.BackColor = Color.FromArgb(46, 51, 73);
            menuMode1.BackColor = Color.FromArgb(37, 42, 64);
        }

        /// <summary>
        /// 통합 메뉴 버튼 클릭 해제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuIntegration_Leave(object sender, EventArgs e)
        {
            menuIntegration.BackColor = Color.FromArgb(37, 42, 64);
        }

        /// <summary>
        /// Mode 1 메뉴 버튼 클릭 해제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMode1_Leave(object sender, EventArgs e)
        {
            menuMode1.BackColor = Color.FromArgb(37, 42, 64);
        }

        /// <summary>
        /// Mode 2 메뉴 버튼 클릭 해제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMode2_Leave(object sender, EventArgs e)
        {
            menuMode2.BackColor = Color.FromArgb(37, 42, 64);
        }

        /// <summary>
        /// Mode 3 메뉴 버튼 클릭 해제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMode3_Leave(object sender, EventArgs e)
        {
            menuMode3.BackColor = Color.FromArgb(37, 42, 64);
        }

        /// <summary>
        /// 라이센스 메뉴 버튼 클릭 해제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuLicense_Leave(object sender, EventArgs e)
        {
            menuLicense.BackColor = Color.FromArgb(37, 42, 64);
        }

        /// <summary>
        /// 설정 메뉴 버튼 클릭 해제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuSettings_Leave(object sender, EventArgs e)
        {
            menuSettings.BackColor = Color.FromArgb(37, 42, 64);
        }

        /// <summary>
        /// 창 최소화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 창 최대화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            //if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Minimized)
            //{
            //    WindowState = FormWindowState.Maximized;
            //}
            //else
            //{
            //    WindowState = FormWindowState.Normal;
            //}
        }

        /// <summary>
        /// 창 종료
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 현재 시각 표현
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeText.Text = DateTime.UtcNow.AddHours(9).ToString("HH:mm:ss.f");
            timer1.Start();
        }

        /// <summary>
        /// 현재 날짜 표현
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timeText.Text = DateTime.UtcNow.AddHours(9).ToString("HH:mm:ss.f");
            dateText.Text = DateTime.Now.ToLongDateString();
        }

        
    }
}
