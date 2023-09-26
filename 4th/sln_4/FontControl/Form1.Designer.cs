namespace FontControl
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tIsMenu = new System.Windows.Forms.ToolStrip();
            this.fontDIg = new System.Windows.Forms.FontDialog();
            this.colorDIg = new System.Windows.Forms.ColorDialog();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.thbtnFont = new System.Windows.Forms.ToolStripButton();
            this.tsbtnColor = new System.Windows.Forms.ToolStripButton();
            this.tIsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tIsMenu
            // 
            this.tIsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thbtnFont,
            this.tsbtnColor});
            this.tIsMenu.Location = new System.Drawing.Point(0, 0);
            this.tIsMenu.Name = "tIsMenu";
            this.tIsMenu.Size = new System.Drawing.Size(800, 25);
            this.tIsMenu.TabIndex = 0;
            this.tIsMenu.Text = "toolStrip1";
            // 
            // rtbText
            // 
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Location = new System.Drawing.Point(0, 25);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(800, 425);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            // 
            // thbtnFont
            // 
            this.thbtnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.thbtnFont.Image = ((System.Drawing.Image)(resources.GetObject("thbtnFont.Image")));
            this.thbtnFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.thbtnFont.Name = "thbtnFont";
            this.thbtnFont.Size = new System.Drawing.Size(23, 22);
            this.thbtnFont.Text = "toolStripButton1";
            this.thbtnFont.Click += new System.EventHandler(this.thbtnFont_Click);
            // 
            // tsbtnColor
            // 
            this.tsbtnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnColor.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnColor.Image")));
            this.tsbtnColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnColor.Name = "tsbtnColor";
            this.tsbtnColor.Size = new System.Drawing.Size(23, 22);
            this.tsbtnColor.Text = "toolStripButton2";
            this.tsbtnColor.Click += new System.EventHandler(this.tsbtnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.tIsMenu);
            this.Name = "Form1";
            this.Text = "폰트 꾸미기";
            
            this.tIsMenu.ResumeLayout(false);
            this.tIsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tIsMenu;
        private System.Windows.Forms.FontDialog fontDIg;
        private System.Windows.Forms.ColorDialog colorDIg;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.ToolStripButton thbtnFont;
        private System.Windows.Forms.ToolStripButton tsbtnColor;
    }
}

