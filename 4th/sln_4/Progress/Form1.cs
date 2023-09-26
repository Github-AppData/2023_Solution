using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Num = 0;
        string OrgStr = ""; // 결과 저장
        

        private void btnRun_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled= false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Num++;
            if(Num >100)
            {
                this.Timer.Enabled = false;
                return;
            }
            // progressBar가 목적인 100을 달성하지 않으면, 
            this.pbStatus.Value = Num;
            this.lblStatus.Text = OrgStr + Num.ToString() + "%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblStatus.Text; 
        }

        
    }
}
