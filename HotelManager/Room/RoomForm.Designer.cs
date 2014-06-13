namespace HotelManager
{
    partial class RoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.tsRoomSet = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.grpShowRoomInfo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combType = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lbRoomNumber = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.dgvShowInfoRoom = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bednumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFindNumber = new System.Windows.Forms.Button();
            this.tsRoomSet.SuspendLayout();
            this.grpShowRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfoRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // tsRoomSet
            // 
            this.tsRoomSet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnDelete,
            this.tsbtnExit});
            this.tsRoomSet.Location = new System.Drawing.Point(20, 20);
            this.tsRoomSet.Name = "tsRoomSet";
            this.tsRoomSet.Size = new System.Drawing.Size(879, 35);
            this.tsRoomSet.TabIndex = 4;
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
            this.grpShowRoomInfo.Controls.Add(this.btnFindNumber);
            this.grpShowRoomInfo.Controls.Add(this.button1);
            this.grpShowRoomInfo.Controls.Add(this.btnShowAll);
            this.grpShowRoomInfo.Controls.Add(this.label2);
            this.grpShowRoomInfo.Controls.Add(this.cbxState);
            this.grpShowRoomInfo.Controls.Add(this.label1);
            this.grpShowRoomInfo.Controls.Add(this.combType);
            this.grpShowRoomInfo.Controls.Add(this.btnSelect);
            this.grpShowRoomInfo.Controls.Add(this.lbRoomNumber);
            this.grpShowRoomInfo.Controls.Add(this.txtRoomNumber);
            this.grpShowRoomInfo.Controls.Add(this.dgvShowInfoRoom);
            this.grpShowRoomInfo.Location = new System.Drawing.Point(21, 57);
            this.grpShowRoomInfo.Name = "grpShowRoomInfo";
            this.grpShowRoomInfo.Size = new System.Drawing.Size(857, 381);
            this.grpShowRoomInfo.TabIndex = 5;
            this.grpShowRoomInfo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(764, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "入住";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(560, 18);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 14;
            this.btnShowAll.Text = "全部";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "使用状态";
            // 
            // cbxState
            // 
            this.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Items.AddRange(new object[] {
            "全部",
            "空闲",
            "入住",
            "维修"});
            this.cbxState.Location = new System.Drawing.Point(388, 17);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(83, 20);
            this.cbxState.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "类型";
            // 
            // combType
            // 
            this.combType.BackColor = System.Drawing.SystemColors.Window;
            this.combType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combType.FormattingEnabled = true;
            this.combType.Items.AddRange(new object[] {
            "全部",
            "空闲",
            "入住",
            "维修"});
            this.combType.Location = new System.Drawing.Point(236, 18);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(83, 20);
            this.combType.TabIndex = 10;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.LightBlue;
            this.btnSelect.Image = global::HotelManager.Properties.Resources.搜索;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(477, 18);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "查 询";
            this.btnSelect.UseVisualStyleBackColor = false;
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
            this.txtRoomNumber.Size = new System.Drawing.Size(45, 21);
            this.txtRoomNumber.TabIndex = 1;
            // 
            // dgvShowInfoRoom
            // 
            this.dgvShowInfoRoom.AllowUserToAddRows = false;
            this.dgvShowInfoRoom.AllowUserToDeleteRows = false;
            this.dgvShowInfoRoom.AllowUserToResizeRows = false;
            this.dgvShowInfoRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowInfoRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowInfoRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.bednumber,
            this.state,
            this.guestnumber,
            this.description,
            this.roomid,
            this.typeid});
            this.dgvShowInfoRoom.Location = new System.Drawing.Point(6, 47);
            this.dgvShowInfoRoom.Name = "dgvShowInfoRoom";
            this.dgvShowInfoRoom.ReadOnly = true;
            this.dgvShowInfoRoom.RowHeadersVisible = false;
            this.dgvShowInfoRoom.RowTemplate.Height = 23;
            this.dgvShowInfoRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowInfoRoom.Size = new System.Drawing.Size(851, 328);
            this.dgvShowInfoRoom.TabIndex = 0;
            this.dgvShowInfoRoom.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvShowInfoRoom_MouseDoubleClick);
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.FillWeight = 88.76595F;
            this.number.HeaderText = "房间号";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // bednumber
            // 
            this.bednumber.DataPropertyName = "bednumber";
            this.bednumber.FillWeight = 84.67425F;
            this.bednumber.HeaderText = "床位数";
            this.bednumber.Name = "bednumber";
            this.bednumber.ReadOnly = true;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.FillWeight = 71.06599F;
            this.state.HeaderText = "状态";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // guestnumber
            // 
            this.guestnumber.DataPropertyName = "guestnumber";
            this.guestnumber.FillWeight = 88.76595F;
            this.guestnumber.HeaderText = "入住人数";
            this.guestnumber.Name = "guestnumber";
            this.guestnumber.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.FillWeight = 166.7279F;
            this.description.HeaderText = "描述";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // roomid
            // 
            this.roomid.DataPropertyName = "roomid";
            this.roomid.HeaderText = "roomid";
            this.roomid.Name = "roomid";
            this.roomid.ReadOnly = true;
            this.roomid.Visible = false;
            // 
            // typeid
            // 
            this.typeid.DataPropertyName = "typeid";
            this.typeid.HeaderText = "typeid";
            this.typeid.Name = "typeid";
            this.typeid.ReadOnly = true;
            this.typeid.Visible = false;
            // 
            // btnFindNumber
            // 
            this.btnFindNumber.BackColor = System.Drawing.Color.LightBlue;
            this.btnFindNumber.Location = new System.Drawing.Point(121, 17);
            this.btnFindNumber.Name = "btnFindNumber";
            this.btnFindNumber.Size = new System.Drawing.Size(46, 23);
            this.btnFindNumber.TabIndex = 15;
            this.btnFindNumber.Text = "查找";
            this.btnFindNumber.UseVisualStyleBackColor = false;
            this.btnFindNumber.Click += new System.EventHandler(this.button2_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(919, 575);
            this.Controls.Add(this.grpShowRoomInfo);
            this.Controls.Add(this.tsRoomSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【客房信息设置】";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.tsRoomSet.ResumeLayout(false);
            this.tsRoomSet.PerformLayout();
            this.grpShowRoomInfo.ResumeLayout(false);
            this.grpShowRoomInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfoRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsRoomSet;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.GroupBox grpShowRoomInfo;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lbRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.DataGridView dgvShowInfoRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn bednumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomid;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeid;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFindNumber;
    }
}