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
    public partial class CustomerForm : Form
    {



        CustomerManage customeM = new CustomerManage();
        RoomManage roomManage = new RoomManage();


        public CustomerForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 添加入住登记
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {


            CustomerDetailForm customerDetailFrm = new CustomerDetailForm();
            customerDetailFrm.MdiParent = this.MdiParent;
            customerDetailFrm.Show();

        }

        /// <summary>
        /// 显示所有入住登记记录
        /// </summary>
        private void ShowAllInfo()
        {

            dgvShowUserList.AutoGenerateColumns = false;
            dgvShowUserList.DataSource = customeM.GetAll();
            dgvShowUserList.ClearSelection();
            for (int i = 0; i < dgvShowUserList.Columns.Count; i++)
            {
                if (dgvShowUserList.Columns[i].HeaderCell.ColumnIndex==1)
                {
                    dgvShowUserList.Columns[i].Width = 120;
                    dgvShowUserList.Columns[i].Resizable = DataGridViewTriState.False;
                    break;
                }
            }

        }


        private void CustomerForm_Load(object sender, EventArgs e)
        {
           
            ShowAllInfo();

        }

        /// <summary>
        /// 显示所有入住登记
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllInfo();
        }

        /// <summary>
        /// 删除入住登记记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvShowUserList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择需要删除的数据！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("确定删除该记录？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                int userId = Convert.ToInt32(dgvShowUserList.SelectedRows[0].Cells["CustomerId"].Value.ToString());
                MessageBox.Show(customeM.DeleteById(userId), "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvShowUserList.AutoGenerateColumns = false;
                ShowAllInfo();

            }
        }


        /// <summary>
        /// 退出当前操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnExit_Click(object sender, EventArgs e)
        {

            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 结账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCharge_Click(object sender, EventArgs e)
        {
            if (dgvShowUserList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要结算的账户！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }


            string payoffStr = dgvShowUserList.SelectedRows[0].Cells["ispayoff"].Value.ToString().Trim();
            if (payoffStr == "是")
            {
                MessageBox.Show("此条入住记录已结清款项", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (MessageBox.Show("请确认用户已结清房款？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int userId = Convert.ToInt32(dgvShowUserList.SelectedRows[0].Cells["CustomerId"].Value.ToString());

                int tmpcount = customeM.UpdateChargeState(userId, "是");

                if (tmpcount > 0)
                {

                    string roomNum = dgvShowUserList.SelectedRows[0].Cells["dgRoomId"].Value.ToString();
                    if (roomManage.UpdateRoomState(roomNum, "空闲") > 0)
                    {
                        MessageBox.Show("结款成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvShowUserList.AutoGenerateColumns = false;
                        ShowAllInfo();


                    }
                    else
                    {
                        MessageBox.Show("结款成功,设置房间空闲状态失败", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }


                }
                else
                {

                    MessageBox.Show("结款失败", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        /// <summary>
        /// 选择结账/未结账的全部项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string cardNum = tbCardNo.Text.Trim() ;
            string TelNum = tbTel.Text.Trim();


            if (cardNum == string.Empty && TelNum != string.Empty)
            {
                return;
            }

            dgvShowUserList.AutoGenerateColumns = false;
            dgvShowUserList.DataSource = customeM.GetListByUserInfo(cardNum,TelNum);
            dgvShowUserList.ClearSelection();
        }

        /// <summary>
        /// 根据房间号查询记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilterByRoomNumber_Click(object sender, EventArgs e)
        {
            string roomNum = txtRoomNumber.Text.Trim();

          
            dgvShowUserList.AutoGenerateColumns = false;
            dgvShowUserList.DataSource = customeM.GetListByRoomNumber(roomNum);
            dgvShowUserList.ClearSelection();

        }

        



    }
}