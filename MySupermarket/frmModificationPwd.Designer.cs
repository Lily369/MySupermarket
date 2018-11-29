namespace MySupermarket
{
    partial class frmModificationPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificationPwd));
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblPwd2 = new System.Windows.Forms.Label();
            this.lblPwd3 = new System.Windows.Forms.Label();
            this.btnAmend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.txtPwd3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(74, 52);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 12);
            this.lblPwd.TabIndex = 0;
            this.lblPwd.Text = "原密码：";
            // 
            // lblPwd2
            // 
            this.lblPwd2.AutoSize = true;
            this.lblPwd2.Location = new System.Drawing.Point(74, 97);
            this.lblPwd2.Name = "lblPwd2";
            this.lblPwd2.Size = new System.Drawing.Size(53, 12);
            this.lblPwd2.TabIndex = 0;
            this.lblPwd2.Text = "新密码：";
            // 
            // lblPwd3
            // 
            this.lblPwd3.AutoSize = true;
            this.lblPwd3.Location = new System.Drawing.Point(50, 140);
            this.lblPwd3.Name = "lblPwd3";
            this.lblPwd3.Size = new System.Drawing.Size(77, 12);
            this.lblPwd3.TabIndex = 0;
            this.lblPwd3.Text = "确认新密码：";
            // 
            // btnAmend
            // 
            this.btnAmend.Location = new System.Drawing.Point(102, 185);
            this.btnAmend.Name = "btnAmend";
            this.btnAmend.Size = new System.Drawing.Size(75, 23);
            this.btnAmend.TabIndex = 4;
            this.btnAmend.Text = "修改";
            this.btnAmend.UseVisualStyleBackColor = true;
            this.btnAmend.Click += new System.EventHandler(this.btnAmend_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(206, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "返回";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(137, 48);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(144, 21);
            this.txtPwd.TabIndex = 0;
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(137, 93);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.PasswordChar = '*';
            this.txtPwd2.Size = new System.Drawing.Size(144, 21);
            this.txtPwd2.TabIndex = 1;
            // 
            // txtPwd3
            // 
            this.txtPwd3.Location = new System.Drawing.Point(137, 136);
            this.txtPwd3.Name = "txtPwd3";
            this.txtPwd3.PasswordChar = '*';
            this.txtPwd3.Size = new System.Drawing.Size(144, 21);
            this.txtPwd3.TabIndex = 3;
            // 
            // frmModificationPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 259);
            this.Controls.Add(this.txtPwd3);
            this.Controls.Add(this.txtPwd2);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAmend);
            this.Controls.Add(this.lblPwd3);
            this.Controls.Add(this.lblPwd2);
            this.Controls.Add(this.lblPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmModificationPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblPwd2;
        private System.Windows.Forms.Label lblPwd3;
        private System.Windows.Forms.Button btnAmend;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.TextBox txtPwd3;
    }
}