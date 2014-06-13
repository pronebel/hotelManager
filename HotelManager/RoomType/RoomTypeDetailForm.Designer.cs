namespace HotelManager
{
    partial class frmRoomTypeDetail
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
            this.pnlVisible = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxIsAdd = new System.Windows.Forms.CheckBox();
            this.txtAddBedPrice = new System.Windows.Forms.TextBox();
            this.lblAddBedPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtTypeNameDown = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblTypeNameDown = new System.Windows.Forms.Label();
            this.pnlVisible.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVisible
            // 
            this.pnlVisible.Controls.Add(this.btnCancel);
            this.pnlVisible.Controls.Add(this.btnSave);
            this.pnlVisible.Controls.Add(this.cbxIsAdd);
            this.pnlVisible.Controls.Add(this.txtAddBedPrice);
            this.pnlVisible.Controls.Add(this.lblAddBedPrice);
            this.pnlVisible.Controls.Add(this.txtPrice);
            this.pnlVisible.Controls.Add(this.lblPrice);
            this.pnlVisible.Controls.Add(this.txtRemark);
            this.pnlVisible.Controls.Add(this.txtTypeNameDown);
            this.pnlVisible.Controls.Add(this.lblRemark);
            this.pnlVisible.Controls.Add(this.lblTypeNameDown);
            this.pnlVisible.Location = new System.Drawing.Point(31, 45);
            this.pnlVisible.Name = "pnlVisible";
            this.pnlVisible.Size = new System.Drawing.Size(647, 450);
            this.pnlVisible.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(332, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(176, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxIsAdd
            // 
            this.cbxIsAdd.AutoSize = true;
            this.cbxIsAdd.Checked = true;
            this.cbxIsAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxIsAdd.Location = new System.Drawing.Point(87, 184);
            this.cbxIsAdd.Name = "cbxIsAdd";
            this.cbxIsAdd.Size = new System.Drawing.Size(96, 16);
            this.cbxIsAdd.TabIndex = 2;
            this.cbxIsAdd.Text = "是否可以加床";
            this.cbxIsAdd.UseVisualStyleBackColor = true;
            this.cbxIsAdd.CheckedChanged += new System.EventHandler(this.cbxIsAdd_CheckedChanged);
            // 
            // txtAddBedPrice
            // 
            this.txtAddBedPrice.Location = new System.Drawing.Point(87, 146);
            this.txtAddBedPrice.Name = "txtAddBedPrice";
            this.txtAddBedPrice.Size = new System.Drawing.Size(339, 21);
            this.txtAddBedPrice.TabIndex = 1;
            // 
            // lblAddBedPrice
            // 
            this.lblAddBedPrice.AutoSize = true;
            this.lblAddBedPrice.Location = new System.Drawing.Point(26, 149);
            this.lblAddBedPrice.Name = "lblAddBedPrice";
            this.lblAddBedPrice.Size = new System.Drawing.Size(53, 12);
            this.lblAddBedPrice.TabIndex = 0;
            this.lblAddBedPrice.Text = "加床价格";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(85, 98);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(507, 21);
            this.txtPrice.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(50, 101);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 12);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "价格";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(85, 226);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(498, 35);
            this.txtRemark.TabIndex = 1;
            // 
            // txtTypeNameDown
            // 
            this.txtTypeNameDown.Location = new System.Drawing.Point(85, 59);
            this.txtTypeNameDown.Name = "txtTypeNameDown";
            this.txtTypeNameDown.Size = new System.Drawing.Size(507, 21);
            this.txtTypeNameDown.TabIndex = 1;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(37, 226);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(29, 12);
            this.lblRemark.TabIndex = 0;
            this.lblRemark.Text = "备注";
            // 
            // lblTypeNameDown
            // 
            this.lblTypeNameDown.AutoSize = true;
            this.lblTypeNameDown.Location = new System.Drawing.Point(26, 62);
            this.lblTypeNameDown.Name = "lblTypeNameDown";
            this.lblTypeNameDown.Size = new System.Drawing.Size(53, 12);
            this.lblTypeNameDown.TabIndex = 0;
            this.lblTypeNameDown.Text = "类型名称";
            // 
            // frmRoomTypeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 516);
            this.Controls.Add(this.pnlVisible);
            this.Name = "frmRoomTypeDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房间类型";
            this.pnlVisible.ResumeLayout(false);
            this.pnlVisible.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVisible;
        private System.Windows.Forms.CheckBox cbxIsAdd;
        private System.Windows.Forms.TextBox txtAddBedPrice;
        private System.Windows.Forms.Label lblAddBedPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtTypeNameDown;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblTypeNameDown;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}