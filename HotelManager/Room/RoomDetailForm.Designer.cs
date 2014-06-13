namespace HotelManager
{
    partial class RoomDetailForm
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
            this.pnlEveryAll = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtBedNumber = new System.Windows.Forms.TextBox();
            this.lblBedNumber = new System.Windows.Forms.Label();
            this.txtGuestNumber = new System.Windows.Forms.TextBox();
            this.lblGeustNumber = new System.Windows.Forms.Label();
            this.cboTypeName = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtRoomNumberDown = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRoomNumberDown = new System.Windows.Forms.Label();
            this.pnlEveryAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEveryAll
            // 
            this.pnlEveryAll.Controls.Add(this.btnCancel);
            this.pnlEveryAll.Controls.Add(this.btnSave);
            this.pnlEveryAll.Controls.Add(this.cboState);
            this.pnlEveryAll.Controls.Add(this.lblState);
            this.pnlEveryAll.Controls.Add(this.txtBedNumber);
            this.pnlEveryAll.Controls.Add(this.lblBedNumber);
            this.pnlEveryAll.Controls.Add(this.txtGuestNumber);
            this.pnlEveryAll.Controls.Add(this.lblGeustNumber);
            this.pnlEveryAll.Controls.Add(this.cboTypeName);
            this.pnlEveryAll.Controls.Add(this.txtPrice);
            this.pnlEveryAll.Controls.Add(this.lblPrice);
            this.pnlEveryAll.Controls.Add(this.lblTypeName);
            this.pnlEveryAll.Controls.Add(this.txtDescription);
            this.pnlEveryAll.Controls.Add(this.txtRoomNumberDown);
            this.pnlEveryAll.Controls.Add(this.lblDescription);
            this.pnlEveryAll.Controls.Add(this.lblRoomNumberDown);
            this.pnlEveryAll.Location = new System.Drawing.Point(13, 20);
            this.pnlEveryAll.Name = "pnlEveryAll";
            this.pnlEveryAll.Size = new System.Drawing.Size(549, 404);
            this.pnlEveryAll.TabIndex = 7;
            this.pnlEveryAll.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEveryAll_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(291, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "空闲",
            "入住",
            "维修"});
            this.cboState.Location = new System.Drawing.Point(114, 221);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(358, 20);
            this.cboState.TabIndex = 9;
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(65, 221);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(29, 12);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "状态";
            this.lblState.Click += new System.EventHandler(this.lblState_Click);
            // 
            // txtBedNumber
            // 
            this.txtBedNumber.Location = new System.Drawing.Point(114, 183);
            this.txtBedNumber.Name = "txtBedNumber";
            this.txtBedNumber.Size = new System.Drawing.Size(358, 21);
            this.txtBedNumber.TabIndex = 7;
            this.txtBedNumber.TextChanged += new System.EventHandler(this.txtBedNumber_TextChanged);
            // 
            // lblBedNumber
            // 
            this.lblBedNumber.AutoSize = true;
            this.lblBedNumber.Location = new System.Drawing.Point(53, 183);
            this.lblBedNumber.Name = "lblBedNumber";
            this.lblBedNumber.Size = new System.Drawing.Size(41, 12);
            this.lblBedNumber.TabIndex = 6;
            this.lblBedNumber.Text = "床位数";
            this.lblBedNumber.Click += new System.EventHandler(this.lblBedNumber_Click);
            // 
            // txtGuestNumber
            // 
            this.txtGuestNumber.Location = new System.Drawing.Point(114, 149);
            this.txtGuestNumber.Name = "txtGuestNumber";
            this.txtGuestNumber.Size = new System.Drawing.Size(358, 21);
            this.txtGuestNumber.TabIndex = 5;
            this.txtGuestNumber.TextChanged += new System.EventHandler(this.txtGuestNumber_TextChanged);
            // 
            // lblGeustNumber
            // 
            this.lblGeustNumber.AutoSize = true;
            this.lblGeustNumber.Location = new System.Drawing.Point(41, 152);
            this.lblGeustNumber.Name = "lblGeustNumber";
            this.lblGeustNumber.Size = new System.Drawing.Size(53, 12);
            this.lblGeustNumber.TabIndex = 4;
            this.lblGeustNumber.Text = "入住人数";
            this.lblGeustNumber.Click += new System.EventHandler(this.lblGeustNumber_Click);
            // 
            // cboTypeName
            // 
            this.cboTypeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeName.FormattingEnabled = true;
            this.cboTypeName.Location = new System.Drawing.Point(111, 78);
            this.cboTypeName.Name = "cboTypeName";
            this.cboTypeName.Size = new System.Drawing.Size(361, 20);
            this.cboTypeName.TabIndex = 3;
            this.cboTypeName.SelectedIndexChanged += new System.EventHandler(this.cboTypeName_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(114, 115);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(358, 21);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(65, 118);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 12);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "价格";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(41, 81);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(53, 12);
            this.lblTypeName.TabIndex = 0;
            this.lblTypeName.Text = "类型名称";
            this.lblTypeName.Click += new System.EventHandler(this.lblTypeName_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(111, 273);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(367, 41);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtRoomNumberDown
            // 
            this.txtRoomNumberDown.Location = new System.Drawing.Point(111, 36);
            this.txtRoomNumberDown.Name = "txtRoomNumberDown";
            this.txtRoomNumberDown.Size = new System.Drawing.Size(361, 21);
            this.txtRoomNumberDown.TabIndex = 1;
            this.txtRoomNumberDown.TextChanged += new System.EventHandler(this.txtRoomNumberDown_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(65, 273);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(29, 12);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "描述";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // lblRoomNumberDown
            // 
            this.lblRoomNumberDown.AutoSize = true;
            this.lblRoomNumberDown.Location = new System.Drawing.Point(53, 39);
            this.lblRoomNumberDown.Name = "lblRoomNumberDown";
            this.lblRoomNumberDown.Size = new System.Drawing.Size(41, 12);
            this.lblRoomNumberDown.TabIndex = 0;
            this.lblRoomNumberDown.Text = "房间号";
            this.lblRoomNumberDown.Click += new System.EventHandler(this.lblRoomNumberDown_Click);
            // 
            // RoomDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 433);
            this.Controls.Add(this.pnlEveryAll);
            this.Name = "RoomDetailForm";
            this.Text = "房间信息";
            this.Load += new System.EventHandler(this.RoomDetailForm_Load);
            this.pnlEveryAll.ResumeLayout(false);
            this.pnlEveryAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEveryAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtBedNumber;
        private System.Windows.Forms.Label lblBedNumber;
        private System.Windows.Forms.TextBox txtGuestNumber;
        private System.Windows.Forms.Label lblGeustNumber;
        private System.Windows.Forms.ComboBox cboTypeName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtRoomNumberDown;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRoomNumberDown;
    }
}