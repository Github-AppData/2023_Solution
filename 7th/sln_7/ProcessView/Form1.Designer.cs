namespace ProcessView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvView = new ListView();
            chName = new ColumnHeader();
            chPid = new ColumnHeader();
            chTime = new ColumnHeader();
            chMemory = new ColumnHeader();
            btnKill = new Button();
            ssBar = new StatusStrip();
            tsslProcess = new ToolStripStatusLabel();
            tsslCpu = new ToolStripStatusLabel();
            tsslMem = new ToolStripStatusLabel();
            ssBar.SuspendLayout();
            SuspendLayout();
            // 
            // lvView
            // 
            lvView.Columns.AddRange(new ColumnHeader[] { chName, chPid, chTime, chMemory });
            lvView.FullRowSelect = true;
            lvView.GridLines = true;
            lvView.Location = new Point(0, -1);
            lvView.Name = "lvView";
            lvView.Size = new Size(800, 397);
            lvView.TabIndex = 0;
            lvView.UseCompatibleStateImageBehavior = false;
            lvView.View = View.Details;
            // 
            // chName
            // 
            chName.Text = "프로세스 이름";
            chName.Width = 108;
            // 
            // chPid
            // 
            chPid.Text = "PID";
            chPid.TextAlign = HorizontalAlignment.Center;
            // 
            // chTime
            // 
            chTime.Text = "Time";
            chTime.TextAlign = HorizontalAlignment.Center;
            chTime.Width = 90;
            // 
            // chMemory
            // 
            chMemory.Text = "메모리 사용";
            chMemory.TextAlign = HorizontalAlignment.Right;
            chMemory.Width = 100;
            // 
            // btnKill
            // 
            btnKill.Location = new Point(646, 402);
            btnKill.Name = "btnKill";
            btnKill.Size = new Size(154, 23);
            btnKill.TabIndex = 1;
            btnKill.Text = "프로세스 끝내기";
            btnKill.UseMnemonic = false;
            btnKill.UseVisualStyleBackColor = true;
            btnKill.Click += btnKill_Click;
            // 
            // ssBar
            // 
            ssBar.Items.AddRange(new ToolStripItem[] { tsslProcess, tsslCpu, tsslMem });
            ssBar.Location = new Point(0, 428);
            ssBar.Name = "ssBar";
            ssBar.Size = new Size(800, 22);
            ssBar.TabIndex = 2;
            ssBar.Text = "statusStrip1";
            // 
            // tsslProcess
            // 
            tsslProcess.Name = "tsslProcess";
            tsslProcess.Size = new Size(78, 17);
            tsslProcess.Text = "프로세스 0개";
            // 
            // tsslCpu
            // 
            tsslCpu.Name = "tsslCpu";
            tsslCpu.Size = new Size(86, 17);
            tsslCpu.Text = "CPU 사용 : 0%";
            // 
            // tsslMem
            // 
            tsslMem.Name = "tsslMem";
            tsslMem.Size = new Size(99, 17);
            tsslMem.Text = "실제 메모리 : 0%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ssBar);
            Controls.Add(btnKill);
            Controls.Add(lvView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "프로세스 보기";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ssBar.ResumeLayout(false);
            ssBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvView;
        private ColumnHeader chName;
        private ColumnHeader chPid;
        private ColumnHeader chTime;
        private ColumnHeader chMemory;
        private Button btnKill;
        private StatusStrip ssBar;
        private ToolStripStatusLabel tsslProcess;
        private ToolStripStatusLabel tsslCpu;
        private ToolStripStatusLabel tsslMem;
    }
}