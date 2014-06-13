using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using HotelManagerBLL;
using HotelManagerModels;   

namespace HotelManager.Manager
{
    public partial class UserForm : Form
    {

        UserManage userM = new UserManage();

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {


            dgvShowList.AutoGenerateColumns = false;
            dgvShowList.DataSource = userM.GetList();
            dgvShowList.ClearSelection();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {


            Manager.Detail frmUserDetail = new Manager.Detail();
            frmUserDetail.MdiParent = this.MdiParent;
            frmUserDetail.Show();
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void dgvShowList_DoubleClick(object sender, EventArgs e)
        {

            if (dgvShowList.SelectedRows.Count == 0)
            {
                return;
            }

            string username = dgvShowList.SelectedRows[0].Cells["name"].Value.ToString();



            Manager.Detail frmUserDetail = new Manager.Detail(username);
            frmUserDetail.MdiParent = this.MdiParent;
            frmUserDetail.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showAllInfo();
        }

        public void showAllInfo()
        {
            dgvShowList.AutoGenerateColumns = false;
            dgvShowList.DataSource = userM.GetList();
            dgvShowList.ClearSelection();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvShowList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要删除的选中项!", "删除提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("确定删除该项？", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int userId = Convert.ToInt32(dgvShowList.SelectedRows[0].Cells["id"].Value.ToString());
                    if(userM.Delete(userId)>0){
                          MessageBox.Show("删除成功", "删除提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         showAllInfo();
                    }
                  

                }
            }
        }
    }
}