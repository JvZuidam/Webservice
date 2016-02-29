namespace WinFormClient
{
    partial class editLog
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
            this.BtnEdit = new System.Windows.Forms.Button();
            this.LstBxEdit = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(12, 200);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 0;
            this.BtnEdit.Text = "Edit log";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // LstBxEdit
            // 
            this.LstBxEdit.FormattingEnabled = true;
            this.LstBxEdit.Location = new System.Drawing.Point(12, 12);
            this.LstBxEdit.Name = "LstBxEdit";
            this.LstBxEdit.Size = new System.Drawing.Size(154, 173);
            this.LstBxEdit.TabIndex = 1;
            // 
            // editLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 238);
            this.Controls.Add(this.LstBxEdit);
            this.Controls.Add(this.BtnEdit);
            this.Name = "editLog";
            this.Text = "Edit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.ListBox LstBxEdit;
    }
}