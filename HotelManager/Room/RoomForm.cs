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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }
        RoomManage rm = new RoomManage();
        int thisRoomID = 0;
        /// <summary>
        /// 根据房间类型，房间状态查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            dgvShowInfoRoom.AutoGenerateColumns = false;
            RoomType selectRoomType = (RoomType)combType.SelectedValue;
            string strState = cbxState.SelectedItem.ToString();
            dgvShowInfoRoom.DataSource = rm.GetRoomByRoomNumber("", selectRoomType.TypeId, strState);
            dgvShowInfoRoom.ClearSelection();

        }

        private void ShowAllInfo()
        {
            dgvShowInfoRoom.AutoGenerateColumns = false;
            dgvShowInfoRoom.DataSource = rm.GetAllRoom();
            dgvShowInfoRoom.ClearSelection();
        }


       

        private void RoomForm_Load(object sender, EventArgs e)
        {
         
           



            List<RoomType> roomList = new List<RoomType>();
           
            roomList.Add(new RoomType(0,"全部"));
            roomList.AddRange( rm.GetRoomType());

            combType.DataSource = roomList;
            combType.DisplayMember = "TypeName";

        



            ShowAllInfo();


            cbxState.SelectedIndex = 0;


        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            thisRoomID = 0;


            RoomDetailForm frmRoomDetail = new RoomDetailForm(thisRoomID);
            frmRoomDetail.MdiParent = this.MdiParent;
            frmRoomDetail.Show();
         
        }



        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvShowInfoRoom.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要删除的选中项!", "删除提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("确定删除该项？", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    
                    MessageBox.Show(rm.DeleteRoom(dgvShowInfoRoom.SelectedRows[0].Cells["Number"].Value.ToString()), "删除提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllInfo();
             
                }
            }
        }

      
       
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllInfo();
        }

        private void dgvShowInfoRoom_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvShowInfoRoom.SelectedRows.Count == 0)
            {


                return;
            }


            Room roomM = new Room(
                Convert.ToInt32(dgvShowInfoRoom.SelectedRows[0].Cells["RoomID"].Value),
                dgvShowInfoRoom.SelectedRows[0].Cells["Number"].Value.ToString(),
                Convert.ToInt32(dgvShowInfoRoom.SelectedRows[0].Cells["BedNumber"].Value),
                dgvShowInfoRoom.SelectedRows[0].Cells["Description"].Value.ToString(), 
                dgvShowInfoRoom.SelectedRows[0].Cells["State"].Value.ToString(),
                Convert.ToInt32(dgvShowInfoRoom.SelectedRows[0].Cells["GuestNumber"].Value),
                Convert.ToInt32(dgvShowInfoRoom.SelectedRows[0].Cells["TypeID"].Value)
                );



            RoomDetailForm frmRoomDetail = new RoomDetailForm(roomM);
            frmRoomDetail.MdiParent = this.MdiParent;
            frmRoomDetail.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvShowInfoRoom.SelectedRows.Count == 0)
            {


                return;
            }

            string roomstate = dgvShowInfoRoom.SelectedRows[0].Cells["state"].Value.ToString().Trim();

            if (roomstate != "空闲")
            {
                MessageBox.Show("此间住房不是空闲状态", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            string roomnumber =dgvShowInfoRoom.SelectedRows[0].Cells["Number"].Value.ToString();
            CustomerDetailForm customerDetailFrm = new CustomerDetailForm(roomnumber);
            customerDetailFrm.MdiParent = this.MdiParent;
            customerDetailFrm.Show();

        }

        /// <summary>
        /// 根据房间号查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            dgvShowInfoRoom.AutoGenerateColumns = false;
            dgvShowInfoRoom.DataSource = rm.GetRoomByRoomNumber(txtRoomNumber.Text.Trim(), 0, "");
            dgvShowInfoRoom.ClearSelection();
        }

      
    }
}