namespace HotelManager
{
    partial class RoomTypeForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomTypeForm));
            this.tsRoomTypeSet = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.grpShowRoomInfo = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.dgvShowInfoType = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addbedprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isaddbed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAll = new System.Windows.Forms.Button();
            this.tsRoomTypeSet.SuspendLayout();
            this.grpShowRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfoType)).BeginInit();
            this.SuspendLayout();
            // 
            // tsRoomTypeSet
            // 
            this.tsRoomTypeSet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnDelete,
            this.tsbtnExit});
            this.tsRoomTypeSet.Location = new System.Drawing.Point(20, 20);
            this.tsRoomTypeSet.Name = "tsRoomTypeSet";
            this.tsRoomTypeSet.Size = new System.Drawing.Size(863, 35);
            this.tsRoomTypeSet.TabIndex = 3;
            this.tsRoomTypeSet.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(33, 32);
            this.tsbtnAdd.Text = "新增";
            this.tsbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(33, 32);
            this.tsbtnDelete.Text = "删除";
            this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(33, 32);
            this.tsbtnExit.Text = "退出";
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // grpShowRoomInfo
            // 
            this.grpShowRoomInfo.Controls.Add(this.btnAll);
            this.grpShowRoomInfo.Controls.Add(this.btnSelect);
            this.grpShowRoomInfo.Controls.Add(this.lblTypeName);
            this.grpShowRoomInfo.Controls.Add(this.txtTypeName);
            this.grpShowRoomInfo.Controls.Add(this.dgvShowInfoType);
            this.grpShowRoomInfo.Location = new System.Drawing.Point(16, 63);
            this.grpShowRoomInfo.Name = "grpShowRoomInfo";
            this.grpShowRoomInfo.Size = new System.Drawing.Size(875, 565);
            this.grpShowRoomInfo.TabIndex = 4;
            this.grpShowRoomInfo.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::HotelManager.Properties.Resources.搜索;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(349, 18);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "查 询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(13, 22);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(65, 12);
            this.lblTypeName.TabIndex = 2;
            this.lblTypeName.Text = "类型名称：";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(81, 18);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(253, 21);
            this.txtTypeName.TabIndex = 1;
            // 
            // dgvShowInfoType
            // 
            this.dgvShowInfoType.AllowUserToAddRows = false;
            this.dgvShowInfoType.AllowUserToDeleteRows = false;
            this.dgvShowInfoType.AllowUserToResizeRows = false;
            this.dgvShowInfoType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowInfoType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowInfoType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.typename,
            this.typeprice,
            this.addbedprice,
            this.isaddbed,
            this.remark});
            this.dgvShowInfoType.Location = new System.Drawing.Point(6, 47);
            this.dgvShowInfoType.Name = "dgvShowInfoType";
            this.dgvShowInfoType.ReadOnly = true;
            this.dgvShowInfoType.RowHeadersVisible = false;
            this.dgvShowInfoType.RowTemplate.Height = 23;
            this.dgvShowInfoType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowInfoType.Size = new System.Drawing.Size(842, 512);
            this.dgvShowInfoType.TabIndex = 0;
            this.dgvShowInfoType.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvShowInfoType_MouseClick);
            // 
            // Type
            // 
            this.Type.DataPropertyName = "typeid";
            this.Type.HeaderText = "编号";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // typename
            // 
            this.typename.DataPropertyName = "typename";
            this.typename.HeaderText = "类型名称";
            this.typename.Name = "typename";
            this.typename.ReadOnly = true;
            // 
            // typeprice
            // 
            this.typeprice.DataPropertyName = "typeprice";
            this.typeprice.HeaderText = "价格";
            this.typeprice.Name = "typeprice";
            this.typeprice.ReadOnly = true;
            // 
            // addbedprice
            // 
            this.addbedprice.DataPropertyName = "addbedprice";
            this.addbedprice.HeaderText = "加床价格";
            this.addbedprice.Name = "addbedprice";
            this.addbedprice.ReadOnly = true;
            // 
            // isaddbed
            // 
            this.isaddbed.DataPropertyName = "isaddbed";
            this.isaddbed.HeaderText = "是否可以加床";
            this.isaddbed.Name = "isaddbed";
            this.isaddbed.ReadOnly = true;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "备注";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(431, 18);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "全部";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // RoomTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 651);
            this.Controls.Add(this.grpShowRoomInfo);
            this.Controls.Add(this.tsRoomTypeSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RoomTypeForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【客房类型设置】";
            this.Load += new System.EventHandler(this.RoomTypeForm_Load);
            this.tsRoomTypeSet.ResumeLayout(false);
            this.tsRoomTypeSet.PerformLayout();
            this.grpShowRoomInfo.ResumeLayout(false);
            this.grpShowRoomInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfoType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsRoomTypeSet;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.GroupBox grpShowRoomInfo;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.DataGridView dgvShowInfoType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn typename;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn addbedprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn isaddbed;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.Button btnAll;
    }
}