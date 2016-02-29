namespace WinFormClient
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
            this.BtnAddLg = new System.Windows.Forms.Button();
            this.BtnVwLg = new System.Windows.Forms.Button();
            this.BtnEdtLg = new System.Windows.Forms.Button();
            this.BtnDelLg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddLg
            // 
            this.BtnAddLg.Location = new System.Drawing.Point(12, 12);
            this.BtnAddLg.Name = "BtnAddLg";
            this.BtnAddLg.Size = new System.Drawing.Size(75, 23);
            this.BtnAddLg.TabIndex = 0;
            this.BtnAddLg.Text = "Add a log";
            this.BtnAddLg.UseVisualStyleBackColor = true;
            this.BtnAddLg.Click += new System.EventHandler(this.BtnAddLg_Click);
            // 
            // BtnVwLg
            // 
            this.BtnVwLg.Location = new System.Drawing.Point(12, 59);
            this.BtnVwLg.Name = "BtnVwLg";
            this.BtnVwLg.Size = new System.Drawing.Size(75, 23);
            this.BtnVwLg.TabIndex = 1;
            this.BtnVwLg.Text = "View a log";
            this.BtnVwLg.UseVisualStyleBackColor = true;
            this.BtnVwLg.Click += new System.EventHandler(this.BtnVwLg_Click);
            // 
            // BtnEdtLg
            // 
            this.BtnEdtLg.Location = new System.Drawing.Point(146, 12);
            this.BtnEdtLg.Name = "BtnEdtLg";
            this.BtnEdtLg.Size = new System.Drawing.Size(75, 23);
            this.BtnEdtLg.TabIndex = 2;
            this.BtnEdtLg.Text = "Edit a log";
            this.BtnEdtLg.UseVisualStyleBackColor = true;
            this.BtnEdtLg.Click += new System.EventHandler(this.BtnEdtLg_Click);
            // 
            // BtnDelLg
            // 
            this.BtnDelLg.Location = new System.Drawing.Point(146, 59);
            this.BtnDelLg.Name = "BtnDelLg";
            this.BtnDelLg.Size = new System.Drawing.Size(75, 23);
            this.BtnDelLg.TabIndex = 3;
            this.BtnDelLg.Text = "Delete a log";
            this.BtnDelLg.UseVisualStyleBackColor = true;
            this.BtnDelLg.Click += new System.EventHandler(this.BtnDelLg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 101);
            this.Controls.Add(this.BtnDelLg);
            this.Controls.Add(this.BtnEdtLg);
            this.Controls.Add(this.BtnVwLg);
            this.Controls.Add(this.BtnAddLg);
            this.Name = "Form1";
            this.Text = "Captain\'s Log";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddLg;
        private System.Windows.Forms.Button BtnVwLg;
        private System.Windows.Forms.Button BtnEdtLg;
        private System.Windows.Forms.Button BtnDelLg;
    }
}

