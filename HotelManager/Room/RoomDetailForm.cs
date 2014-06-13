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
    public partial class RoomDetailForm : Form
    {
        RoomManage rm = new RoomManage();
        Room thisRoom = new Room();
        public RoomDetailForm(Room roomM)
        {
            InitializeComponent();

            thisRoom = roomM;

            thisRoomID = roomM.RoomID;
       

        }

        int thisRoomID;
        public RoomDetailForm(int TypeID)
        {

            InitializeComponent();

            thisRoomID = 0;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                if (txtRoomNumberDown.Text.Trim() == "")
                {
                    MessageBox.Show("请输入房间号!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cboTypeName.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择房型!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtGuestNumber.Text.Trim() == "")
                {
                    MessageBox.Show("请输入入住人数!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtBedNumber.Text.Trim() == "")
                {
                    MessageBox.Show("请输入床位数!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cboState.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择状态!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                if (txtDescription.Text.Trim() == "")
                {
                    MessageBox.Show("请输入描述内容!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string message = string.Empty;
                Room room = new Room();


                for (int i = 0; i < txtRoomNumberDown.Text.Length; i++)
                {
                    if (char.IsDigit(txtRoomNumberDown.Text[i]) == false)
                    {
                        MessageBox.Show("房间号输入不合法!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                room.Number = txtRoomNumberDown.Text.Trim();
                try
                {
                    room.BedNumber = Convert.ToInt32(txtBedNumber.Text.Trim());
                    room.GuestNumber = Convert.ToInt32(txtGuestNumber.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("请输入数字!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                room.State = cboState.Text;
                room.Description = txtDescription.Text.Trim();
                room.TypeID = rm.GetTypeIDByTypeName(cboTypeName.Text);
                room.RoomID = thisRoomID;

                string strAlert;

                if (thisRoomID > 0)
                {
                    strAlert = "确定更新该项?";
                }
                else
                {
                    strAlert = "确定新增该项?";
                }

                if (MessageBox.Show(strAlert, "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (thisRoomID > 0)
                    {
                        message = rm.UpdateRoom(room);
                    }
                    else
                    {
                        message = rm.AddRoom(room);
                    }
                    MessageBox.Show(message, "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    this.Dispose();
                }
              

        }

        private void cboTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Text = (rm.GetTypePriceByTypeName(cboTypeName.Text)).ToString();
        }

        private void RoomDetailForm_Load(object sender, EventArgs e)
        {

            txtPrice.Enabled = false;
            cboTypeName.DataSource = rm.GetRoomType();
            cboTypeName.DisplayMember = "TypeName";

            if (thisRoomID!=0)
            {
                txtRoomNumberDown.Text = thisRoom.Number.ToString();
                txtGuestNumber.Text = thisRoom.GuestNumber.ToString();
                txtBedNumber.Text = thisRoom.BedNumber.ToString();
                cboState.Text = thisRoom.State.ToString();
                txtDescription.Text = thisRoom.Description;
                cboTypeName.Text = rm.GetTypeNameByTypeID(Convert.ToInt32(thisRoom.TypeID)).ToString();
                txtPrice.Text = rm.GetTypePriceByTypeID(Convert.ToInt32(thisRoom.TypeID)).ToString();
            }else{
                     cboState.SelectedIndex = cboTypeName.SelectedIndex = -1;
            }

       

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
            this.Dispose();
        }

        private void pnlEveryAll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void txtBedNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBedNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtGuestNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGeustNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblTypeName_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRoomNumberDown_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblRoomNumberDown_Click(object sender, EventArgs e)
        {

        }

      
        
    }
}
