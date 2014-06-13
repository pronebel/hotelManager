namespace HotelManager.Manager
{
    partial class Detail
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblGeustNumber = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblRoomNumberDown = new System.Windows.Forms.Label();
            this.pnlEveryAll = new System.Windows.Forms.Panel();
            this.pnlEveryAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(291, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(146, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(111, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(358, 21);
            this.txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(358, 21);
            this.txtPassword.TabIndex = 5;
            // 
            // lblGeustNumber
            // 
            this.lblGeustNumber.AutoSize = true;
            this.lblGeustNumber.Location = new System.Drawing.Point(67, 152);
            this.lblGeustNumber.Name = "lblGeustNumber";
            this.lblGeustNumber.Size = new System.Drawing.Size(29, 12);
            this.lblGeustNumber.TabIndex = 4;
            this.lblGeustNumber.Text = "密码";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(114, 115);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(358, 21);
            this.txtMobile.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(55, 118);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 12);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "手机号";
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(61, 81);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(35, 12);
            this.lblTypeName.TabIndex = 0;
            this.lblTypeName.Text = "Email";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(111, 36);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(361, 21);
            this.txtUserName.TabIndex = 1;
            // 
            // lblRoomNumberDown
            // 
            this.lblRoomNumberDown.AutoSize = true;
            this.lblRoomNumberDown.Location = new System.Drawing.Point(62, 39);
            this.lblRoomNumberDown.Name = "lblRoomNumberDown";
            this.lblRoomNumberDown.Size = new System.Drawing.Size(29, 12);
            this.lblRoomNumberDown.TabIndex = 0;
            this.lblRoomNumberDown.Text = "昵称";
            // 
            // pnlEveryAll
            // 
            this.pnlEveryAll.Controls.Add(this.btnCancel);
            this.pnlEveryAll.Controls.Add(this.btnSave);
            this.pnlEveryAll.Controls.Add(this.txtEmail);
            this.pnlEveryAll.Controls.Add(this.txtPassword);
            this.pnlEveryAll.Controls.Add(this.lblGeustNumber);
            this.pnlEveryAll.Controls.Add(this.txtMobile);
            this.pnlEveryAll.Controls.Add(this.lblPrice);
            this.pnlEveryAll.Controls.Add(this.lblTypeName);
            this.pnlEveryAll.Controls.Add(this.txtUserName);
            this.pnlEveryAll.Controls.Add(this.lblRoomNumberDown);
            this.pnlEveryAll.Location = new System.Drawing.Point(13, 14);
            this.pnlEveryAll.Name = "pnlEveryAll";
            this.pnlEveryAll.Size = new System.Drawing.Size(549, 276);
            this.pnlEveryAll.TabIndex = 8;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 303);
            this.Controls.Add(this.pnlEveryAll);
            this.Name = "Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员信息";
            this.pnlEveryAll.ResumeLayout(false);
            this.pnlEveryAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblGeustNumber;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblRoomNumberDown;
        private System.Windows.Forms.Panel pnlEveryAll;

    }
}