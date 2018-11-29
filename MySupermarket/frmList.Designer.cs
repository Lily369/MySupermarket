namespace MySupermarket
{
    partial class frmList
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("正价商品");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("特价商品");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("所有商品", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmList));
            this.sc = new System.Windows.Forms.SplitContainer();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.tvType = new System.Windows.Forms.TreeView();
            this.ilImage = new System.Windows.Forms.ImageList(this.components);
            this.gbShow = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.tsAmend = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tsExit = new System.Windows.Forms.ToolStripButton();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cYesNo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.gbType.SuspendLayout();
            this.gbShow.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.Location = new System.Drawing.Point(0, 0);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.gbType);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.Controls.Add(this.gbShow);
            this.sc.Size = new System.Drawing.Size(736, 376);
            this.sc.SplitterDistance = 156;
            this.sc.TabIndex = 0;
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.tvType);
            this.gbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbType.Location = new System.Drawing.Point(0, 0);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(156, 376);
            this.gbType.TabIndex = 0;
            this.gbType.TabStop = false;
            this.gbType.Text = "商品分类";
            // 
            // tvType
            // 
            this.tvType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvType.ImageIndex = 0;
            this.tvType.ImageList = this.ilImage;
            this.tvType.Location = new System.Drawing.Point(3, 17);
            this.tvType.Name = "tvType";
            treeNode1.Name = "Normal";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "正价商品";
            treeNode2.Name = "Discounts";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "特价商品";
            treeNode3.Name = "All";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "所有商品";
            this.tvType.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tvType.SelectedImageIndex = 0;
            this.tvType.Size = new System.Drawing.Size(150, 356);
            this.tvType.TabIndex = 0;
            this.tvType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvType_AfterSelect);
            // 
            // ilImage
            // 
            this.ilImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImage.ImageStream")));
            this.ilImage.TransparentColor = System.Drawing.Color.Transparent;
            this.ilImage.Images.SetKeyName(0, "file1.jpg");
            this.ilImage.Images.SetKeyName(1, "flie2.jpg");
            // 
            // gbShow
            // 
            this.gbShow.Controls.Add(this.toolStrip1);
            this.gbShow.Controls.Add(this.dgvShow);
            this.gbShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbShow.Location = new System.Drawing.Point(0, 0);
            this.gbShow.Name = "gbShow";
            this.gbShow.Size = new System.Drawing.Size(576, 376);
            this.gbShow.TabIndex = 0;
            this.gbShow.TabStop = false;
            this.gbShow.Text = "商品显示";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsAmend,
            this.tsDelete,
            this.tsExit});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(570, 64);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "怕，你";
            // 
            // tsAdd
            // 
            this.tsAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsAdd.Image")));
            this.tsAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(68, 61);
            this.tsAdd.Text = "    增加    ";
            this.tsAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // tsAmend
            // 
            this.tsAmend.Image = ((System.Drawing.Image)(resources.GetObject("tsAmend.Image")));
            this.tsAmend.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAmend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAmend.Name = "tsAmend";
            this.tsAmend.Size = new System.Drawing.Size(68, 61);
            this.tsAmend.Text = "    修改    ";
            this.tsAmend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAmend.Click += new System.EventHandler(this.tsAmend_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsDelete.Image")));
            this.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(68, 61);
            this.tsDelete.Text = "    删除    ";
            this.tsDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // tsExit
            // 
            this.tsExit.Image = ((System.Drawing.Image)(resources.GetObject("tsExit.Image")));
            this.tsExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(68, 61);
            this.tsExit.Text = "    退出    ";
            this.tsExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToResizeColumns = false;
            this.dgvShow.AllowUserToResizeRows = false;
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cName,
            this.cType,
            this.cPrice,
            this.cYesNo,
            this.cMoney});
            this.dgvShow.Location = new System.Drawing.Point(-1, 82);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(574, 286);
            this.dgvShow.TabIndex = 0;
            // 
            // cId
            // 
            this.cId.DataPropertyName = "CommodityID";
            this.cId.HeaderText = "商品编号";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "CommodityName";
            this.cName.HeaderText = "商品名称";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cType
            // 
            this.cType.DataPropertyName = "SortName";
            this.cType.HeaderText = "类别名称";
            this.cType.Name = "cType";
            this.cType.ReadOnly = true;
            // 
            // cPrice
            // 
            this.cPrice.DataPropertyName = "CommodityPrice";
            this.cPrice.HeaderText = "商品价格";
            this.cPrice.Name = "cPrice";
            this.cPrice.ReadOnly = true;
            // 
            // cYesNo
            // 
            this.cYesNo.DataPropertyName = "IsDiscount";
            this.cYesNo.HeaderText = "是否特价";
            this.cYesNo.Name = "cYesNo";
            this.cYesNo.ReadOnly = true;
            // 
            // cMoney
            // 
            this.cMoney.DataPropertyName = "ReducedPrice";
            this.cMoney.HeaderText = "打折价格";
            this.cMoney.Name = "cMoney";
            this.cMoney.ReadOnly = true;
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 376);
            this.Controls.Add(this.sc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品列表";
            this.Load += new System.EventHandler(this.frmList_Load);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.gbType.ResumeLayout(false);
            this.gbShow.ResumeLayout(false);
            this.gbShow.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.GroupBox gbType;
        public System.Windows.Forms.TreeView tvType;
        private System.Windows.Forms.GroupBox gbShow;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAdd;
        private System.Windows.Forms.ToolStripButton tsAmend;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.ToolStripButton tsExit;
        private System.Windows.Forms.ImageList ilImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cYesNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMoney;
        public System.Windows.Forms.DataGridView dgvShow;

    }
}