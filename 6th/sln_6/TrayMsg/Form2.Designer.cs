namespace TrayMsg
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            plBack = new Panel();
            lblResult = new LinkLabel();
            plBack.SuspendLayout();
            SuspendLayout();
            // 
            // plBack
            // 
            plBack.BackColor = Color.FromArgb(128, 128, 255);
            plBack.BorderStyle = BorderStyle.FixedSingle;
            plBack.Controls.Add(lblResult);
            plBack.Dock = DockStyle.Fill;
            plBack.Location = new Point(0, 0);
            plBack.Name = "plBack";
            plBack.Size = new Size(170, 120);
            plBack.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.White;
            lblResult.Location = new Point(58, 50);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(31, 15);
            lblResult.TabIndex = 0;
            lblResult.TabStop = true;
            lblResult.Text = "결과";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.LinkClicked += lblResult_LinkClicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(170, 120);
            Controls.Add(plBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "메세지창";
            TopMost = true;
            Load += Form2_Load;
            plBack.ResumeLayout(false);
            plBack.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plBack;
        private LinkLabel lblResult;
    }
}