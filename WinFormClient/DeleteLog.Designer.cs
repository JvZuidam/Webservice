namespace WinFormClient
{
    partial class deleteLog
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
            this.LstBxDel = new System.Windows.Forms.ListBox();
            this.BtnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstBxDel
            // 
            this.LstBxDel.FormattingEnabled = true;
            this.LstBxDel.Location = new System.Drawing.Point(13, 13);
            this.LstBxDel.Name = "LstBxDel";
            this.LstBxDel.Size = new System.Drawing.Size(142, 160);
            this.LstBxDel.TabIndex = 0;
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(13, 198);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 1;
            this.BtnDel.Text = "Delete log";
            this.BtnDel.UseVisualStyleBackColor = true;
            // 
            // deleteLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 244);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.LstBxDel);
            this.Name = "deleteLog";
            this.Text = "Delete";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstBxDel;
        private System.Windows.Forms.Button BtnDel;
    }
}