namespace TrayMsg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtMsg = new TextBox();
            btnMsg = new Button();
            SuspendLayout();
            // 
            // txtMsg
            // 
            resources.ApplyResources(txtMsg, "txtMsg");
            txtMsg.Name = "txtMsg";
            // 
            // btnMsg
            // 
            resources.ApplyResources(btnMsg, "btnMsg");
            btnMsg.Name = "btnMsg";
            btnMsg.UseVisualStyleBackColor = true;
            btnMsg.Click += btnMsg_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnMsg);
            Controls.Add(txtMsg);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMsg;
        private Button btnMsg;
    }
}