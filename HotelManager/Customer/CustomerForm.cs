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
        /// �����ס�Ǽ�
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
        /// ��ʾ������ס�ǼǼ�¼
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
        /// ��ʾ������ס�Ǽ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllInfo();
        }

        /// <summary>
        /// ɾ����ס�ǼǼ�¼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvShowUserList.SelectedRows.Count == 0)
            {
                MessageBox.Show("��ѡ����Ҫɾ�������ݣ�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("ȷ��ɾ���ü�¼��", "������ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                int userId = Convert.ToInt32(dgvShowUserList.SelectedRows[0].Cells["CustomerId"].Value.ToString());
                MessageBox.Show(customeM.DeleteById(userId), "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvShowUserList.AutoGenerateColumns = false;
                ShowAllInfo();

            }
        }


        /// <summary>
        /// �˳���ǰ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnExit_Click(object sender, EventArgs e)
        {

            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCharge_Click(object sender, EventArgs e)
        {
            if (dgvShowUserList.SelectedRows.Count == 0)
            {
                MessageBox.Show("��ѡ��Ҫ������˻���", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }


            string payoffStr = dgvShowUserList.SelectedRows[0].Cells["ispayoff"].Value.ToString().Trim();
            if (payoffStr == "��")
            {
                MessageBox.Show("������ס��¼�ѽ������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (MessageBox.Show("��ȷ���û��ѽ��巿�", "������ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int userId = Convert.ToInt32(dgvShowUserList.SelectedRows[0].Cells["CustomerId"].Value.ToString());

                int tmpcount = customeM.UpdateChargeState(userId, "��");

                if (tmpcount > 0)
                {

                    string roomNum = dgvShowUserList.SelectedRows[0].Cells["dgRoomId"].Value.ToString();
                    if (roomManage.UpdateRoomState(roomNum, "����") > 0)
                    {
                        MessageBox.Show("���ɹ�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvShowUserList.AutoGenerateColumns = false;
                        ShowAllInfo();


                    }
                    else
                    {
                        MessageBox.Show("���ɹ�,���÷������״̬ʧ��", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }


                }
                else
                {

                    MessageBox.Show("���ʧ��", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        /// <summary>
        /// ѡ�����/δ���˵�ȫ����
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
        /// ���ݷ���Ų�ѯ��¼
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