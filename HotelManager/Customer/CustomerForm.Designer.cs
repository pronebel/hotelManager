namespace HotelManager
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsRoomSet = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.grpShowRoomInfo = new System.Windows.Forms.GroupBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCardNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterByRoomNumber = new System.Windows.Forms.Button();
            this.btnCharge = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lbRoomNumber = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.dgvShowUserList = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIdentifyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCheckinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCheckoutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUserNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIsAddBen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ispayoff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsRoomSet.SuspendLayout();
            this.grpShowRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // tsRoomSet
            // 
            this.tsRoomSet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnDelete,
            this.tsbtnExit});
            this.tsRoomSet.Location = new System.Drawing.Point(0, 0);
            this.tsRoomSet.Name = "tsRoomSet";
            this.tsRoomSet.Size = new System.Drawing.Size(1007, 35);
            this.tsRoomSet.TabIndex = 7;
            this.tsRoomSet.Text = "toolStrip1";
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
            this.grpShowRoomInfo.Controls.Add(this.tbTel);
            this.grpShowRoomInfo.Controls.Add(this.label2);
            this.grpShowRoomInfo.Controls.Add(this.tbCardNo);
            this.grpShowRoomInfo.Controls.Add(this.label1);
            this.grpShowRoomInfo.Controls.Add(this.btnFilterByRoomNumber);
            this.grpShowRoomInfo.Controls.Add(this.btnCharge);
            this.grpShowRoomInfo.Controls.Add(this.btnShowAll);
            this.grpShowRoomInfo.Controls.Add(this.btnSelect);
            this.grpShowRoomInfo.Controls.Add(this.lbRoomNumber);
            this.grpShowRoomInfo.Controls.Add(this.txtRoomNumber);
            this.grpShowRoomInfo.Controls.Add(this.dgvShowUserList);
            this.grpShowRoomInfo.Location = new System.Drawing.Point(6, 52);
            this.grpShowRoomInfo.Name = "grpShowRoomInfo";
            this.grpShowRoomInfo.Size = new System.Drawing.Size(989, 420);
            this.grpShowRoomInfo.TabIndex = 8;
            this.grpShowRoomInfo.TabStop = false;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(501, 20);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(105, 21);
            this.tbTel.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "手机号";
            // 
            // tbCardNo
            // 
            this.tbCardNo.Location = new System.Drawing.Point(308, 22);
            this.tbCardNo.Name = "tbCardNo";
            this.tbCardNo.Size = new System.Drawing.Size(135, 21);
            this.tbCardNo.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "身份证";
            // 
            // btnFilterByRoomNumber
            // 
            this.btnFilterByRoomNumber.BackColor = System.Drawing.Color.LightBlue;
            this.btnFilterByRoomNumber.Location = new System.Drawing.Point(138, 18);
            this.btnFilterByRoomNumber.Name = "btnFilterByRoomNumber";
            this.btnFilterByRoomNumber.Size = new System.Drawing.Size(75, 23);
            this.btnFilterByRoomNumber.TabIndex = 16;
            this.btnFilterByRoomNumber.Text = "查找";
            this.btnFilterByRoomNumber.UseVisualStyleBackColor = false;
            this.btnFilterByRoomNumber.Click += new System.EventHandler(this.btnFilterByRoomNumber_Click);
            // 
            // btnCharge
            // 
            this.btnCharge.BackColor = System.Drawing.Color.LightGreen;
            this.btnCharge.Location = new System.Drawing.Point(897, 18);
            this.btnCharge.Name = "btnCharge";
            this.btnCharge.Size = new System.Drawing.Size(75, 23);
            this.btnCharge.TabIndex = 15;
            this.btnCharge.Text = "结账";
            this.btnCharge.UseVisualStyleBackColor = false;
            this.btnCharge.Click += new System.EventHandler(this.btnCharge_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.LightBlue;
            this.btnShowAll.Location = new System.Drawing.Point(708, 16);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 14;
            this.btnShowAll.Text = "全部";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::HotelManager.Properties.Resources.搜索;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(612, 18);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "查 询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lbRoomNumber
            // 
            this.lbRoomNumber.AutoSize = true;
            this.lbRoomNumber.Location = new System.Drawing.Point(6, 23);
            this.lbRoomNumber.Name = "lbRoomNumber";
            this.lbRoomNumber.Size = new System.Drawing.Size(53, 12);
            this.lbRoomNumber.TabIndex = 2;
            this.lbRoomNumber.Text = "房间号：";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(65, 18);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(67, 21);
            this.txtRoomNumber.TabIndex = 1;
            // 
            // dgvShowUserList
            // 
            this.dgvShowUserList.AllowUserToAddRows = false;
            this.dgvShowUserList.AllowUserToDeleteRows = false;
            this.dgvShowUserList.AllowUserToResizeRows = false;
            this.dgvShowUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.addtime,
            this.dgRoomId,
            this.dgName,
            this.dgSex,
            this.dgIdentifyNumber,
            this.dgPhone,
            this.dgCheckinDate,
            this.dgCheckoutDate,
            this.dgUserNum,
            this.dgIsAddBen,
            this.dCharge,
            this.ispayoff});
            this.dgvShowUserList.Location = new System.Drawing.Point(6, 47);
            this.dgvShowUserList.Name = "dgvShowUserList";
            this.dgvShowUserList.ReadOnly = true;
            this.dgvShowUserList.RowHeadersVisible = false;
            this.dgvShowUserList.RowTemplate.Height = 23;
            this.dgvShowUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowUserList.Size = new System.Drawing.Size(977, 367);
            this.dgvShowUserList.TabIndex = 0;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.FillWeight = 47.43327F;
            this.CustomerId.HeaderText = "ID";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            // 
            // addtime
            // 
            this.addtime.DataPropertyName = "addtime";
            this.addtime.FillWeight = 71.94724F;
            this.addtime.HeaderText = "登记时间";
            this.addtime.Name = "addtime";
            this.addtime.ReadOnly = true;
            // 
            // dgRoomId
            // 
            this.dgRoomId.DataPropertyName = "RoomId";
            this.dgRoomId.FillWeight = 116.0973F;
            this.dgRoomId.HeaderText = "房间号";
            this.dgRoomId.Name = "dgRoomId";
            this.dgRoomId.ReadOnly = true;
            // 
            // dgName
            // 
            this.dgName.DataPropertyName = "Name";
            this.dgName.FillWeight = 95.45865F;
            this.dgName.HeaderText = "姓名";
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            // 
            // dgSex
            // 
            this.dgSex.DataPropertyName = "Sex";
            this.dgSex.FillWeight = 94.72682F;
            this.dgSex.HeaderText = "性别";
            this.dgSex.Name = "dgSex";
            this.dgSex.ReadOnly = true;
            // 
            // dgIdentifyNumber
            // 
            this.dgIdentifyNumber.DataPropertyName = "IdentifyNumber";
            this.dgIdentifyNumber.FillWeight = 111.6511F;
            this.dgIdentifyNumber.HeaderText = "身份证";
            this.dgIdentifyNumber.Name = "dgIdentifyNumber";
            this.dgIdentifyNumber.ReadOnly = true;
            // 
            // dgPhone
            // 
            this.dgPhone.DataPropertyName = "Phone";
            this.dgPhone.FillWeight = 91.97409F;
            this.dgPhone.HeaderText = "电话";
            this.dgPhone.Name = "dgPhone";
            this.dgPhone.ReadOnly = true;
            // 
            // dgCheckinDate
            // 
            this.dgCheckinDate.DataPropertyName = "CheckinDate";
            this.dgCheckinDate.HeaderText = "入住时间";
            this.dgCheckinDate.Name = "dgCheckinDate";
            this.dgCheckinDate.ReadOnly = true;
            this.dgCheckinDate.Visible = false;
            // 
            // dgCheckoutDate
            // 
            this.dgCheckoutDate.DataPropertyName = "CheckoutDate";
            this.dgCheckoutDate.HeaderText = "离开时间";
            this.dgCheckoutDate.Name = "dgCheckoutDate";
            this.dgCheckoutDate.ReadOnly = true;
            this.dgCheckoutDate.Visible = false;
            // 
            // dgUserNum
            // 
            this.dgUserNum.DataPropertyName = "UserNum";
            this.dgUserNum.FillWeight = 114.2963F;
            this.dgUserNum.HeaderText = "入住人数";
            this.dgUserNum.Name = "dgUserNum";
            this.dgUserNum.ReadOnly = true;
            // 
            // dgIsAddBen
            // 
            this.dgIsAddBen.DataPropertyName = "IsAddBed";
            this.dgIsAddBen.FillWeight = 113.1648F;
            this.dgIsAddBen.HeaderText = "是否加床";
            this.dgIsAddBen.Name = "dgIsAddBen";
            this.dgIsAddBen.ReadOnly = true;
            // 
            // dCharge
            // 
            this.dCharge.DataPropertyName = "charge";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.dCharge.DefaultCellStyle = dataGridViewCellStyle2;
            this.dCharge.FillWeight = 112.1042F;
            this.dCharge.HeaderText = "需付费";
            this.dCharge.Name = "dCharge";
            this.dCharge.ReadOnly = true;
            // 
            // ispayoff
            // 
            this.ispayoff.DataPropertyName = "isPayOff";
            this.ispayoff.FillWeight = 131.1463F;
            this.ispayoff.HeaderText = "是否已结账";
            this.ispayoff.Name = "ispayoff";
            this.ispayoff.ReadOnly = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 622);
            this.Controls.Add(this.tsRoomSet);
            this.Controls.Add(this.grpShowRoomInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.tsRoomSet.ResumeLayout(false);
            this.tsRoomSet.PerformLayout();
            this.grpShowRoomInfo.ResumeLayout(false);
            this.grpShowRoomInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsRoomSet;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.GroupBox grpShowRoomInfo;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lbRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.DataGridView dgvShowUserList;
        private System.Windows.Forms.Button btnCharge;
        private System.Windows.Forms.Button btnFilterByRoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn addtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdentifyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCheckinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCheckoutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUserNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIsAddBen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ispayoff;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCardNo;
    }
}