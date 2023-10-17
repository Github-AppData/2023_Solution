namespace FormView
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
            btnModal = new Button();
            btnModaless = new Button();
            SuspendLayout();
            // 
            // btnModal
            // 
            btnModal.Location = new Point(212, 24);
            btnModal.Name = "btnModal";
            btnModal.Size = new Size(75, 23);
            btnModal.TabIndex = 0;
            btnModal.Text = "모달";
            btnModal.UseVisualStyleBackColor = true;
            // 
            // btnModaless
            // 
            btnModaless.Location = new Point(218, 78);
            btnModaless.Name = "btnModaless";
            btnModaless.Size = new Size(75, 23);
            btnModaless.TabIndex = 1;
            btnModaless.Text = "모달리스";
            btnModaless.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModaless);
            Controls.Add(btnModal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "폼 꾸미기";
            ResumeLayout(false);
        }

        #endregion

        private Button btnModal;
        private Button btnModaless;
    }
}