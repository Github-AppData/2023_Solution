using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int CountOrgNum = 0;

        private void btnCount_Click(object sender, EventArgs e)
        {
            if(IntCheck() == true)
            {
                // textBox로 입력을 받으면, 무조건 String으로 된다.
                CountOrgNum = Convert.ToInt32(this.txtNum.Text);

                // 오직 읽는 것만 가능하다, 편집 불 가능
                this.txtNum.ReadOnly = true;
                this.Timer.Enabled = true; // 타이머 재생
            }
        }

        // 숫자가 입력이 되어 있는지...
        private bool IntCheck()
        {
            if(Information.IsNumeric(this.txtNum.Text))
            {
                return true;
            }
            else
            {
                
                 MessageBox.Show("숫자를 입력하세요", "알림",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            // Timer가 멈추었을 때 = 남은 값이 1 보다 적을 때
            if(CountOrgNum < 1)
            {
                this.Timer.Enabled = false;
                this.txtNum.ReadOnly = false;
                this.txtNum.Text = "";
                MessageBox.Show("펑", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
            else
            {
                CountOrgNum--; // 1 보다 크면, Time인 CountOrgNum을 하나 다운 시킨다.
                this.txtCountDown.Text = Convert.ToString(CountOrgNum); 
            }
        }

        
    }
}
