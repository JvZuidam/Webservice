namespace WinFormClient
{
    partial class addLog
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
            this.TxtBoxAth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtBoxLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TxtBoxAth
            // 
            this.TxtBoxAth.Location = new System.Drawing.Point(12, 25);
            this.TxtBoxAth.Name = "TxtBoxAth";
            this.TxtBoxAth.Size = new System.Drawing.Size(117, 20);
            this.TxtBoxAth.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Story";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 187);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(117, 32);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Submit";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // TxtBoxLog
            // 
            this.TxtBoxLog.Location = new System.Drawing.Point(12, 78);
            this.TxtBoxLog.Name = "TxtBoxLog";
            this.TxtBoxLog.Size = new System.Drawing.Size(117, 96);
            this.TxtBoxLog.TabIndex = 5;
            this.TxtBoxLog.Text = "";
            // 
            // addLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 231);
            this.Controls.Add(this.TxtBoxLog);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxAth);
            this.Name = "addLog";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxAth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.RichTextBox TxtBoxLog;
    }
}