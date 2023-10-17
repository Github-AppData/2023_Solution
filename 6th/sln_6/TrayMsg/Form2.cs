using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace TrayMsg
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 20;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;

            DesktopLocation = new Point(x, y);
            this.Size = new Size(170, 0);

            InitializeComponent();
        }

        private static System.Timers.Timer TimeEvent; // Timer 개체 생성

        public string MsgText
        {
            set
            {
                this.lblResult.Text = value;
            }
        }

        private delegate void OnDelegateHeight(int Flag); // 델리게이트 선언
        private OnDelegateHeight OnHeight = null; // 델리게이트 개체 생성

        private void lblResult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            TimeEvent.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OnHeight = new OnDelegateHeight(MsgView);
            this.Size = new System.Drawing.Size(170, 0);
            this.Location =
                new System.Drawing.Point(Screen.PrimaryScreen.WorkingArea.Width
                - this.Width - 20, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            TimeEvent = new System.Timers.Timer(2);
            TimeEvent.Elapsed += new ElapsedEventHandler(OnPopUp);
            TimeEvent.Start();
        }

        private void MsgView(int Flag)
        {
            if (Flag == 0)
            {
                Height++;
                Top--;
            }
            else if (Flag == 1)
            {
                Height++;
                Top++;
            }
            else if (Flag == 2)
            {
                this.Close();
            }
        }

        private void OnPopUp(object sender, EventArgs e)
        {
            if (Height < 120)
            {
                Invoke(OnHeight, 0);
            }
            // Height가 120보다 작다면 실행하는 문장으로, 
            // Invoke()메서드를 이용하여 delegate와 연결된 - 
            // OnHeight 메서드를 호출하여 폼을 올리는 작업을 수행한다.
            else
            {
                TimeEvent.Stop();
                TimeEvent.Elapsed -= new ElapsedEventHandler(OnPopUp);

                TimeEvent.Elapsed += new ElapsedEventHandler(OnPopOut);
                TimeEvent.Interval = 3000;
                TimeEvent.Start();
            }
            Application.DoEvents();
        }

        private void OnPopOut(object sender, EventArgs e)
        {
            while (Height > 2)
            {
                Invoke(OnHeight, 1);

            }
            TimeEvent.Stop();
            Application.DoEvents();
            Invoke(OnHeight, 2);
        }
    }
}
