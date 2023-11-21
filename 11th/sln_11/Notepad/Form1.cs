using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Boolean txtNodeChange; // 내용 변경 체크
        private string fWord; // 찾기 문자열
        private Form2 frm2; // 폼 2 개체 생성

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.txtNodeChange == true)
            {
                var msg = this.Text + " 파일의 내용이 변경되었습니다. \r\n 변경된 내용을 저장하시겠습니까 ?";

                var dir = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if(dir == DialogResult.Yes)
                {
                    textSave();
                    this.txtNote.ResetText();
                    this.Text = "제목 없음";
                    this.txtNodeChange = false;
                } else if (dir == DialogResult.No)
                {
                    this.txtNote.ResetText();
                    this.txtNodeChange = false;
                } else if (dir == DialogResult.Cancel)
                {
                    return;
                } else
                {
                    this.txtNote.ResetText();
                    this.Text = "제목 없음";
                    this.txtNodeChange = false;
                } 
            } else
            {
                this.txtNote.ResetText();
                this.Text = "제목 없음";
                this.txtNodeChange = false;
            }
        }

        private void textSave()
        {
            if(this.Text == "제목 없음") // 제목이 없으면, 처리 해주는 로직이다.
            {
                var dir = this.sfdFile.ShowDialog();
                if(dir != DialogResult.Cancel) 
                {
                    var str = this.sfdFile.FileName;
                    var sw = new StreamWriter(str, false, System.Text.Encoding.Default);
                    sw.Write(this.txtNote.Text);
                    sw.Flush();
                    sw.Close();
                    this.Text = str;
                    this.txtNodeChange= false;
                }
            } else // 제목이 설정이 되어 있으면,
            {
                var strt = this.Text;
                var sw = new StreamWriter(strt, false, System.Text.Encoding.Default);
                sw.Write(this.txtNote.Text);
                sw.Flush();
                sw.Close ();
                this.Text = strt;
                this.txtNodeChange= false;
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.txtNodeChange == true)
            {
                var msg = this.Text + "파일의 내용이 변경되었습니다. \r\n 변경된 내용을 저장하시겠습니까 ?";
                var dir = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(dir == DialogResult.Yes)
                {
                    textSave();// 데이터 저장 메소드
                    textOpen(); // 파일 열기 메서드
                } else if (dir == DialogResult.No)
                {
                    textOpen(); // 저장하지 않고, 파일 열기 메서드 호출
                } else if (dir == DialogResult.Cancel)
                {
                    return; // 저장 및 열기 하지 않고, 모든 작업을 취소한다.
                }
            }
            else
            {
                textOpen(); // [txtNote] 컨트롤의 입력 데이터가 수정 및 추가 되지 않았다.
            }
        }

        private void textOpen()
        {
            var dr = this.ofdFile.ShowDialog();
            if(dr != DialogResult.Cancel)
            {
                var str = this.ofdFile.FileName;
                var sr = new StreamReader(str, System.Text.Encoding.Default);
                this.txtNote.Text = sr.ReadToEnd(); 
                sr.Close();
                this.Text = str;
                this.txtNodeChange = false;
            }
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            this.txtNodeChange = true; // 데이터 추가
        }



        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 실행취소ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
