using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        NotifyIcon notifyIcon;
        Timer closer;
        Timer worker;
        //secomd
        int restInit = 2;

        //second
        int workInit = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            workInit = Int32.Parse(this.txtWork.Text.ToString());
            restInit = Int32.Parse(this.txtRest.Text.ToString());
            worker = new Timer();
            worker.Tick += new EventHandler(TimerEventProcessor);
            worker.Interval = workInit * 1000;
            worker.Start();
            this.EnableControl(false);
            
        }

        private void TimerEventProcessor(object sender, EventArgs e)
        {
            
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.BalloonTipTitle = "Đã về, đã tới!";
            notifyIcon.BalloonTipText = " Thở vào tâm tĩnh lặng.\n Thở ra miệng mỉm cười.\n An trú trong hiện tại. \n Phút giây đẹp tuyệt vời!\n";
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.Visible = true;

            int showTime = this.restInit * 1000;

            notifyIcon.ShowBalloonTip(showTime);
            closer = new Timer();
            closer.Tick += new EventHandler(CloseAction);
            closer.Interval = showTime;
            closer.Start();
        }

        private void CloseAction(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            closer.Stop();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.worker.Stop();
            this.EnableControl(true);
        }

        private void EnableControl(bool p)
        {
            this.txtRest.Enabled = p;
            this.txtWork.Enabled = p;
            this.btnStart.Enabled = p;
            this.btnStop.Enabled = !p;

        }
    }
}
