using InternetTime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//11월 10일 릴리즈
namespace Project
{
    public partial class MainForm : Form
    {
        public static DateTime dt;
        public static string year_str;
        dynamic d = null;
        int cnt = 0;
        public MainForm()
        {

            InitializeComponent();
            Time_read();        //인터넷 시간 불러오기
            time_timer.Start();
        }

        private void Time_read()
        {
            SNTPClient client;
            String str = "";
            try
            {
                client = new SNTPClient("kr.pool.ntp.org");    //참조할 NTP 서버 주소
                client.Connect(false);
                str = client.TransmitTimestamp + "";
            }
            catch (Exception)
            {
                time_time.Text = "Failed to get the time.";
                return;
            } 
            dt = Convert.ToDateTime(str);
            year_str = dt.ToString("yyyy");
        }

        private void tick(object sender, EventArgs e)
        {
            dt = dt.AddSeconds(1);
            year_str = dt.ToString("yyyy");
            time_year.Text = dt.ToString("yyyy년 MM월 dd일");
            time_time.Text = dt.ToString("HH시 mm분 ss초");
            
        }
        
        private void Frame_button(object sender, EventArgs e)
        {
            if (!(d == null)) d.Dispose();

           if (sender.Equals(f1Btn)) d = new Frame1();
           else if (sender.Equals(f2Btn)) d = new Frame2();
           else if (sender.Equals(f3Btn)) d = new Frame3();
           else d = new Frame4();
            panel1.Controls.Clear();    //추가 컨테이너 삭제
            panel1.Controls.Add(d);
            d.Show();
        }



    }
}
