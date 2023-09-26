using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thbtnFont_Click(object sender, EventArgs e)
        {
            // 해당 Dialog 버튼을 클릭하면, Dialog를 보여준다.
            if(this.fontDIg.ShowDialog() == DialogResult.OK)
            {
                this.rtbText.SelectionFont = this.fontDIg.Font;
            }
        }

        private void tsbtnColor_Click(object sender, EventArgs e)
        {
            // 해당 Dialog 버튼을 클릭하면, Dialog를 보여준다.
            if (this.colorDIg.ShowDialog() == DialogResult.OK)
            {
                this.rtbText.SelectionColor = this.colorDIg.Color;
            }
        }
    }
}
