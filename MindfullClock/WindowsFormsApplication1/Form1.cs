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
        
        int showMessageTime = 2;       
        int workTime = 5;

        string messageTitle = "";
        string messageContent = "";
        Form1 form1 = null;

        public Form1()
        {
            InitializeComponent();            
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            workTime = Int32.Parse(this.txtWorkTime.Text.ToString());
            showMessageTime = Int32.Parse(this.txtMessageTime.Text.ToString());
            this.messageTitle = this.txtMessageTitle.Text;
            this.messageContent = this.txtMessageContent.Text;

            worker = new Timer();
            worker.Tick += new EventHandler(TimerEventProcessor);
            worker.Interval = workTime * 60 * 1000;
            worker.Start();
            this.EnableControl(false);
            
        }

        private void TimerEventProcessor(object sender, EventArgs e)
        {
            
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.BalloonTipTitle = this.messageTitle; //"Đã về, đã tới!";
            notifyIcon.BalloonTipText = this.messageContent; //" Thở vào tâm tĩnh lặng.\n Thở ra miệng mỉm cười.\n An trú trong hiện tại. \n Phút giây đẹp tuyệt vời!\n";
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.Visible = true;

            int showTime = this.showMessageTime * 1000;

            notifyIcon.ShowBalloonTip(showTime);
            closer = new Timer();
            closer.Tick += new EventHandler(CloseAction);
            closer.Interval = showTime;
            closer.Start();
            worker.Stop();
        }

        private void CloseAction(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            closer.Stop();
            worker.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.worker.Stop();
            this.EnableControl(true);
        }

        private void EnableControl(bool p)
        {
            this.txtMessageTime.Enabled = p;
            this.txtWorkTime.Enabled = p;
            this.txtMessageTitle.Enabled = p;
            this.txtMessageContent.Enabled = p;
            this.btnStart.Enabled = p;
            this.btnStop.Enabled = !p;

        }

    }
}
