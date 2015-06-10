namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessageTime = new System.Windows.Forms.TextBox();
            this.txtWorkTime = new System.Windows.Forms.TextBox();
            this.lblGiay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessageContent = new System.Windows.Forms.RichTextBox();
            this.txtMessageTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian hiển thị thông báo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời gian làm việc:";
            // 
            // txtMessageTime
            // 
            this.txtMessageTime.Location = new System.Drawing.Point(182, 29);
            this.txtMessageTime.Name = "txtMessageTime";
            this.txtMessageTime.Size = new System.Drawing.Size(100, 20);
            this.txtMessageTime.TabIndex = 1;
            this.txtMessageTime.Text = "60";
            // 
            // txtWorkTime
            // 
            this.txtWorkTime.Location = new System.Drawing.Point(182, 56);
            this.txtWorkTime.Name = "txtWorkTime";
            this.txtWorkTime.Size = new System.Drawing.Size(100, 20);
            this.txtWorkTime.TabIndex = 2;
            this.txtWorkTime.Text = "1";
            // 
            // lblGiay
            // 
            this.lblGiay.AutoSize = true;
            this.lblGiay.Location = new System.Drawing.Point(291, 32);
            this.lblGiay.Name = "lblGiay";
            this.lblGiay.Size = new System.Drawing.Size(26, 13);
            this.lblGiay.TabIndex = 0;
            this.lblGiay.Text = "giây";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "phút";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(143, 226);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(143, 258);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title của message:";
            // 
            // txtMessageContent
            // 
            this.txtMessageContent.Location = new System.Drawing.Point(182, 113);
            this.txtMessageContent.Name = "txtMessageContent";
            this.txtMessageContent.Size = new System.Drawing.Size(195, 94);
            this.txtMessageContent.TabIndex = 4;
            this.txtMessageContent.Text = "What are you doing?";
            // 
            // txtMessageTitle
            // 
            this.txtMessageTitle.Location = new System.Drawing.Point(182, 86);
            this.txtMessageTitle.Name = "txtMessageTitle";
            this.txtMessageTitle.Size = new System.Drawing.Size(195, 20);
            this.txtMessageTitle.TabIndex = 3;
            this.txtMessageTitle.Text = "Hey you!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nội dung của message:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 319);
            this.Controls.Add(this.txtMessageContent);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtMessageTitle);
            this.Controls.Add(this.txtWorkTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMessageTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGiay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mindfull Notify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessageTime;
        private System.Windows.Forms.TextBox txtWorkTime;
        private System.Windows.Forms.Label lblGiay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtMessageContent;
        private System.Windows.Forms.TextBox txtMessageTitle;
        private System.Windows.Forms.Label label5;
    }
}

