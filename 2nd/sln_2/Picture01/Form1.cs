using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 초기화 구성 - 왜 초기화 시킬까 ? = 메모리 공간의 확보 - 컴파일러 한테 알려주는 것.
            InitializeComponent();
        }

        int x1, y1, x2, y2;

        private void btnClickThis_Click_1(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // 끝 지점 설정
            x2 = e.X;
            y2 = e.Y;

            // 시작점과 끝 지점을 설정을 했으면 마우스 업 할때 그려주어라

            
            Graphics g = CreateGraphics(); // 그래픽을 생성해준다
            Pen pen = new Pen(Color.Blue, 10);
            g.DrawLine(pen, x1, y1, x2, y2); // 변수 g는 델리게이트 대리자 (데이터 형)이다. - 그래서 함수를 담을 수 있는 것이다,
        }

       private void Form1_MouseDown(object sender, MouseEventArgs e)
       {
            // 시작점 설정
            x1 = e.X;
            y1 = e.Y;
       }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
