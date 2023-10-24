using System.Runtime.Versioning;

namespace FormView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.SetText = this.btnModal.Text + " 실행";
            frm2.ShowDialog(); // 모달 옵션으로 폼 실행.
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.SetText = this.btnModaless.Text + " 실행";
            frm3.Show(); // 모달리스 옵션으로 폼 실행
        }
    }
}