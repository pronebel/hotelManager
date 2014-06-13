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
    public partial class RoomTypeForm : Form
    {
        public RoomTypeForm()
        {
            InitializeComponent();
        }
        RoomTypeManage hoteManageTypeM = new RoomTypeManage();
        int TypeID = 0;
        private void btnSelect_Click(object sender, EventArgs e)
        {
            showRoomTypeList(txtTypeName.Text.Trim());
        }

        private void RoomTypeForm_Load(object sender, EventArgs e)
        {
            showRoomTypeList("");
          
        }

        public void showRoomTypeList(string filterWord)
        {
            dgvShowInfoType.AutoGenerateColumns = false;
            dgvShowInfoType.DataSource = hoteManageTypeM.GetRoomTypeListByTypeName(filterWord);
            dgvShowInfoType.ClearSelection();

        }

   
    

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        
        private void dgvShowInfoType_MouseClick(object sender, MouseEventArgs e)
        {
            //

            if (dgvShowInfoType.SelectedRows.Count == 0)
            {
             
              
                MessageBox.Show("没有任何数据，请继续搜索！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        
            RoomType roomTypeM = new RoomType(
                Convert.ToInt32(dgvShowInfoType.SelectedRows[0].Cells["Type"].Value),
                dgvShowInfoType.SelectedRows[0].Cells["typename"].Value.ToString(),
                Convert.ToDouble(dgvShowInfoType.SelectedRows[0].Cells["typeprice"].Value.ToString()),
                dgvShowInfoType.SelectedRows[0].Cells["isaddbed"].Value.ToString().Trim(),
                Convert.ToDouble(dgvShowInfoType.SelectedRows[0].Cells["addbedprice"].Value.ToString()),
                dgvShowInfoType.SelectedRows[0].Cells["remark"].Value.ToString()
                
            );

            frmRoomTypeDetail rootTypeDetailFrm = new frmRoomTypeDetail(roomTypeM);
            rootTypeDetailFrm.MdiParent = this.MdiParent;
            rootTypeDetailFrm.Show();
     
        }

        /// <summary>
        /// 添加类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            TypeID = 0;
          

            frmRoomTypeDetail rootTypeDetailFrm = new frmRoomTypeDetail(TypeID);
            rootTypeDetailFrm.MdiParent = this.MdiParent;
            rootTypeDetailFrm.Show();



        }



 
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {

            if (dgvShowInfoType.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择需要删除的数据！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("确定删除该记录？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                RoomType rt = new RoomType();
                MessageBox.Show(hoteManageTypeM.DeleteRoomType(dgvShowInfoType.SelectedRows[0].Cells["typename"].Value.ToString()), "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvShowInfoType.AutoGenerateColumns = false;
                dgvShowInfoType.DataSource = hoteManageTypeM.GetRoomTypeListByTypeName(txtTypeName.Text.Trim());
             
              
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            showRoomTypeList("");
        }

       

      
    }
}