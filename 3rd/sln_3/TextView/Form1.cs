using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string OrgStr = ""; // 결과 : 문자 저장

        // Form1이 열때, lblResult가 OrgStr에 저장이 된다.
        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblResult.Text; 
        }

        // 버튼을 클릭하면, 결과 라벨에 입력 값과 OrgStr의 합친 값이 같이 들어가게 된다.
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(Textcheck() == true)
            {
                this.lblResult.Text = OrgStr + this.txtEdit.Text; 
            }
        }

        // 
        private void txtEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13) // 엔터키를 누를 때
            {
                e.Handled = true;
                if(Textcheck() == true) 
                {
                    this.lblResult.Text = OrgStr + this.txtEdit.Text;
                }
            }
        }

        private bool Textcheck()
        {
            if (this.txtEdit.Text != "") // textEdit의 Text가 문자가 있으면, true를 반환한다.
            {
                return true;
            }
            else
            {
                // 없으면, Messagbox를 출력한다.
                MessageBox.Show("텍스트를 입력하세요 !", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEdit.Focus(); // Focus를 txtEdit으로 !
                return false; 
            }
        }
    }
}
