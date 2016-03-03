namespace WinFormClient
{
    partial class viewLog
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
            this.BtnView = new System.Windows.Forms.Button();
            this.LstBxView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(13, 200);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 23);
            this.BtnView.TabIndex = 0;
            this.BtnView.Text = "View log";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // LstBxView
            // 
            this.LstBxView.FormattingEnabled = true;
            this.LstBxView.Location = new System.Drawing.Point(13, 13);
            this.LstBxView.Name = "LstBxView";
            this.LstBxView.Size = new System.Drawing.Size(143, 160);
            this.LstBxView.TabIndex = 1;
            // 
            // viewLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 235);
            this.Controls.Add(this.LstBxView);
            this.Controls.Add(this.BtnView);
            this.Name = "viewLog";
            this.Text = "View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.ListBox LstBxView;
    }
}