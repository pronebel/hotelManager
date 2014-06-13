using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using HotelManagerBLL;
using HotelManagerModels;


namespace HotelManager
{
    public partial class frmRoomTypeDetail : Form
    {



        RoomTypeManage hm = new RoomTypeManage();
        int TypeID = 0;
    

        public frmRoomTypeDetail(int TypeID)
        {
            InitializeComponent();
            this.TypeID = TypeID;
        }

        public frmRoomTypeDetail(RoomType roomTypeM )
        {
            InitializeComponent();

            this.setDetail(roomTypeM);
            
        }
        public void setDetail(RoomType roomTypeM){
            this.TypeID = roomTypeM.TypeId;
            txtTypeNameDown.Text = roomTypeM.TypeName;
            txtPrice.Text = roomTypeM.TypePrice.ToString();
            txtAddBedPrice.Text = roomTypeM.AddBedPrice.ToString();
            txtRemark.Text = roomTypeM.Remark;
            if (roomTypeM.IsAddBed == "是")
                cbxIsAdd.Checked = true;
            else
                cbxIsAdd.Checked = false;

          


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
                if (string.IsNullOrEmpty(txtTypeNameDown.Text.Trim()))
                {
                    MessageBox.Show("类型名称不能为空!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
                {
                    MessageBox.Show("价格不能为空!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(txtAddBedPrice.Text.Trim()) && cbxIsAdd.Checked == true)
                {
                    MessageBox.Show("加床价格不能为空!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string message = string.Empty;

                RoomType roomTypeM = new RoomType();
                roomTypeM.TypeName = txtTypeNameDown.Text.Trim();
                try
                {
                    roomTypeM.TypePrice = Convert.ToDouble(txtPrice.Text.Trim());
                    if (cbxIsAdd.Checked == true)
                    {
                        roomTypeM.AddBedPrice = Convert.ToDouble(txtAddBedPrice.Text.Trim());
                    }
                    else
                    {
                        roomTypeM.AddBedPrice = 0;
                    }
                }
                catch
                {
                    MessageBox.Show("价格必须为数字！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                roomTypeM.IsAddBed = cbxIsAdd.Checked ? "是" : "否";
                roomTypeM.Remark = txtRemark.Text.Trim();
                roomTypeM.TypeId = TypeID;


                string strAlert = "";
                if (this.TypeID != 0)
                {
                    btnSave.Text = "修改";
                    strAlert = "确定更新该记录？";

                }
                else
                {
                    strAlert = "确定新增该记录？";

                }


                if (MessageBox.Show(strAlert, "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (roomTypeM.TypeId > 0)
                        message = hm.UpdateRoomType(roomTypeM);
                    else
                        message = hm.AddRoomType(roomTypeM);

                    this.Hide();
                    MessageBox.Show(message, "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                   // dgvShowInfoType.AutoGenerateColumns = false;
                    //dgvShowInfoType.DataSource = hm.GetRoomTypeListByTypeName(txtTypeName.Text.Trim());
                   

                }
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cbxIsAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIsAdd.Checked == false)
            {
                txtAddBedPrice.Text = "";
            }
        }

    
    }
}
