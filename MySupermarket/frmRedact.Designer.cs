namespace MySupermarket
{
    partial class frmRedact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRedact));
            this.gbBasic = new System.Windows.Forms.GroupBox();
            this.nuPrice = new System.Windows.Forms.NumericUpDown();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbElse = new System.Windows.Forms.GroupBox();
            this.nuMoney = new System.Windows.Forms.NumericUpDown();
            this.cbYN = new System.Windows.Forms.CheckBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnSava = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrice)).BeginInit();
            this.gbElse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBasic
            // 
            this.gbBasic.Controls.Add(this.nuPrice);
            this.gbBasic.Controls.Add(this.cboType);
            this.gbBasic.Controls.Add(this.txtName);
            this.gbBasic.Controls.Add(this.lblType);
            this.gbBasic.Controls.Add(this.lblPrice);
            this.gbBasic.Controls.Add(this.label3);
            this.gbBasic.Controls.Add(this.label2);
            this.gbBasic.Controls.Add(this.lblName);
            this.gbBasic.Location = new System.Drawing.Point(12, 12);
            this.gbBasic.Name = "gbBasic";
            this.gbBasic.Size = new System.Drawing.Size(361, 165);
            this.gbBasic.TabIndex = 0;
            this.gbBasic.TabStop = false;
            this.gbBasic.Text = "基本信息";
            // 
            // nuPrice
            // 
            this.nuPrice.DecimalPlaces = 2;
            this.nuPrice.Location = new System.Drawing.Point(130, 115);
            this.nuPrice.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nuPrice.Name = "nuPrice";
            this.nuPrice.Size = new System.Drawing.Size(198, 21);
            this.nuPrice.TabIndex = 2;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(130, 74);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(198, 20);
            this.cboType.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 21);
            this.txtName.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(57, 78);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 12);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "商品类别：";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(57, 119);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 12);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "预售价格：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(57, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "商品名称：";
            // 
            // gbElse
            // 
            this.gbElse.Controls.Add(this.nuMoney);
            this.gbElse.Controls.Add(this.cbYN);
            this.gbElse.Controls.Add(this.lblMoney);
            this.gbElse.Location = new System.Drawing.Point(12, 183);
            this.gbElse.Name = "gbElse";
            this.gbElse.Size = new System.Drawing.Size(361, 116);
            this.gbElse.TabIndex = 1;
            this.gbElse.TabStop = false;
            this.gbElse.Text = "其他信息";
            // 
            // nuMoney
            // 
            this.nuMoney.DecimalPlaces = 2;
            this.nuMoney.Enabled = false;
            this.nuMoney.Location = new System.Drawing.Point(130, 74);
            this.nuMoney.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nuMoney.Name = "nuMoney";
            this.nuMoney.Size = new System.Drawing.Size(198, 21);
            this.nuMoney.TabIndex = 4;
            // 
            // cbYN
            // 
            this.cbYN.AutoSize = true;
            this.cbYN.Location = new System.Drawing.Point(130, 36);
            this.cbYN.Name = "cbYN";
            this.cbYN.Size = new System.Drawing.Size(84, 16);
            this.cbYN.TabIndex = 3;
            this.cbYN.Text = "是否为特价";
            this.cbYN.UseVisualStyleBackColor = true;
            this.cbYN.CheckedChanged += new System.EventHandler(this.cbYN_CheckedChanged);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(57, 78);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(65, 12);
            this.lblMoney.TabIndex = 0;
            this.lblMoney.Text = "特价价格：";
            // 
            // btnSava
            // 
            this.btnSava.Location = new System.Drawing.Point(167, 315);
            this.btnSava.Name = "btnSava";
            this.btnSava.Size = new System.Drawing.Size(75, 23);
            this.btnSava.TabIndex = 5;
            this.btnSava.Text = "保存";
            this.btnSava.UseVisualStyleBackColor = true;
            this.btnSava.Click += new System.EventHandler(this.btnSava_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(281, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmRedact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 350);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSava);
            this.Controls.Add(this.gbElse);
            this.Controls.Add(this.gbBasic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRedact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑商品信息";
            this.Load += new System.EventHandler(this.frmRedact_Load);
            this.gbBasic.ResumeLayout(false);
            this.gbBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrice)).EndInit();
            this.gbElse.ResumeLayout(false);
            this.gbElse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBasic;
        private System.Windows.Forms.GroupBox gbElse;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown nuPrice;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nuMoney;
        private System.Windows.Forms.CheckBox cbYN;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnSava;
        private System.Windows.Forms.Button btnExit;
    }
}