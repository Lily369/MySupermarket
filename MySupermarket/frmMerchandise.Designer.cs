namespace MySupermarket
{
    partial class frmMerchandise
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMerchandise));
            this.msMerchandise = new System.Windows.Forms.MenuStrip();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificationPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRegard = new System.Windows.Forms.ToolStripMenuItem();
            this.pbBeijing = new System.Windows.Forms.PictureBox();
            this.pbShop = new System.Windows.Forms.PictureBox();
            this.ilImage = new System.Windows.Forms.ImageList(this.components);
            this.lblGoods = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.msMerchandise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBeijing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShop)).BeginInit();
            this.SuspendLayout();
            // 
            // msMerchandise
            // 
            this.msMerchandise.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUser,
            this.tsmiHelp,
            this.tsRegard});
            this.msMerchandise.Location = new System.Drawing.Point(0, 0);
            this.msMerchandise.Name = "msMerchandise";
            this.msMerchandise.Size = new System.Drawing.Size(580, 25);
            this.msMerchandise.TabIndex = 0;
            this.msMerchandise.Text = "menuStrip1";
            // 
            // tsmiUser
            // 
            this.tsmiUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModificationPwd,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(85, 21);
            this.tsmiUser.Text = "用户管理(&U)";
            // 
            // tsmiModificationPwd
            // 
            this.tsmiModificationPwd.Name = "tsmiModificationPwd";
            this.tsmiModificationPwd.Size = new System.Drawing.Size(139, 22);
            this.tsmiModificationPwd.Text = "修改密码(&P)";
            this.tsmiModificationPwd.Click += new System.EventHandler(this.tsmiModificationPwd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(139, 22);
            this.tsmiExit.Text = "退出(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRegard});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmiHelp.Text = "帮助(&H)";
            // 
            // tsmiRegard
            // 
            this.tsmiRegard.Name = "tsmiRegard";
            this.tsmiRegard.Size = new System.Drawing.Size(116, 22);
            this.tsmiRegard.Text = "关于(&A)";
            // 
            // tsRegard
            // 
            this.tsRegard.Name = "tsRegard";
            this.tsRegard.Size = new System.Drawing.Size(59, 21);
            this.tsRegard.Text = "关于(&Y)";
            this.tsRegard.Click += new System.EventHandler(this.tsRegard_Click);
            // 
            // pbBeijing
            // 
            this.pbBeijing.BackColor = System.Drawing.Color.White;
            this.pbBeijing.Image = ((System.Drawing.Image)(resources.GetObject("pbBeijing.Image")));
            this.pbBeijing.Location = new System.Drawing.Point(27, 109);
            this.pbBeijing.Name = "pbBeijing";
            this.pbBeijing.Size = new System.Drawing.Size(227, 203);
            this.pbBeijing.TabIndex = 1;
            this.pbBeijing.TabStop = false;
            this.pbBeijing.Click += new System.EventHandler(this.pbBeijing_Click);
            this.pbBeijing.MouseLeave += new System.EventHandler(this.pbBeijing_MouseLeave);
            this.pbBeijing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbBeijing_MouseMove);
            // 
            // pbShop
            // 
            this.pbShop.BackColor = System.Drawing.SystemColors.Control;
            this.pbShop.Image = ((System.Drawing.Image)(resources.GetObject("pbShop.Image")));
            this.pbShop.Location = new System.Drawing.Point(324, 109);
            this.pbShop.Name = "pbShop";
            this.pbShop.Size = new System.Drawing.Size(227, 203);
            this.pbShop.TabIndex = 1;
            this.pbShop.TabStop = false;
            this.pbShop.MouseLeave += new System.EventHandler(this.pbShop_MouseLeave);
            this.pbShop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbShop_MouseMove);
            // 
            // ilImage
            // 
            this.ilImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImage.ImageStream")));
            this.ilImage.TransparentColor = System.Drawing.Color.Transparent;
            this.ilImage.Images.SetKeyName(0, "2.bmp");
            this.ilImage.Images.SetKeyName(1, "2-1.bmp");
            this.ilImage.Images.SetKeyName(2, "3.bmp");
            this.ilImage.Images.SetKeyName(3, "3-1.bmp");
            // 
            // lblGoods
            // 
            this.lblGoods.AutoSize = true;
            this.lblGoods.Font = new System.Drawing.Font("黑体-繁", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGoods.Location = new System.Drawing.Point(77, 58);
            this.lblGoods.Name = "lblGoods";
            this.lblGoods.Size = new System.Drawing.Size(127, 34);
            this.lblGoods.TabIndex = 2;
            this.lblGoods.Text = "商品管理";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("黑体-繁", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblType.Location = new System.Drawing.Point(346, 58);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(183, 34);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "商品类别管理";
            // 
            // frmMerchandise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 345);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblGoods);
            this.Controls.Add(this.pbShop);
            this.Controls.Add(this.pbBeijing);
            this.Controls.Add(this.msMerchandise);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMerchandise;
            this.MaximizeBox = false;
            this.Name = "frmMerchandise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超市商品管理";
            this.msMerchandise.ResumeLayout(false);
            this.msMerchandise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBeijing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMerchandise;
        private System.Windows.Forms.ToolStripMenuItem tsmiUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificationPwd;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pbBeijing;
        private System.Windows.Forms.PictureBox pbShop;
        private System.Windows.Forms.ImageList ilImage;
        private System.Windows.Forms.Label lblGoods;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ToolStripMenuItem tsRegard;
    }
}