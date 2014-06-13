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
    public partial class CustomerDetailForm : Form
    {
        private int userId;
        CustomerManage customerManage = new CustomerManage();

        string roomnumber = "";

        public CustomerDetailForm()
        {
            this.userId = 0;
            InitializeComponent();
        }

        public CustomerDetailForm(string roomnumber)
        {
            this.userId = 0;
            this.roomnumber = roomnumber;
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRoomNum.Text.Trim()))
            {
                MessageBox.Show("����Ų���Ϊ��!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(tbUserName.Text.Trim()))
            {
                MessageBox.Show("�û���������Ϊ��!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(tbCardNo.Text.Trim()))
            {
                MessageBox.Show("���֤�Ų���Ϊ��!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(tbPhone.Text.Trim()))
            {
                MessageBox.Show("�绰����Ϊ��!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(tbUserNum.Text.Trim()))
            {
                MessageBox.Show("��ס��������Ϊ��!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

              try
                {
                     Convert.ToInt32(tbUserNum.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("��ס��������������!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


            DateTime dateStart = dtStartTime.Value.Date;
            DateTime dateEnd = dtEndTime.Value.Date;




            if (dateEnd<dateStart)
            {
                MessageBox.Show("�뿪ʱ��������ʼʱ��!", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string isAddBed= "��";
            if(chkAddBed.Checked){
                isAddBed = "��";
            }


          

            Customer user = new Customer(0, tbRoomNum.Text.Trim(), tbUserName.Text.Trim(), cmbSex.Text, tbCardNo.Text.Trim(),
                tbPhone.Text.Trim(), 0, dateStart, dateEnd, Convert.ToInt32(tbUserNum.Text.Trim()), isAddBed, "��");


           string retStr = customerManage.Add(user);

           if (retStr == "-1")
           {
               MessageBox.Show(" ���䲻���ڣ�","������ʾ",MessageBoxButtons.OK,MessageBoxIcon.Information);
           }
           else if (retStr == "-2")
           {
               MessageBox.Show(" ��ǰ���䲻�ǿ���״̬", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }  else if (retStr == "-3")
           {
               MessageBox.Show(" ��ǰ����δ����", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else if (retStr == "0")
           {
                MessageBox.Show("�Ǽ�ʧ��", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           {
               this.Hide();
               MessageBox.Show( "�Ǽǳɹ�,����" + retStr + "Ԫ", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
           }


           

          
        }

        private void CustomerDetailForm_Load(object sender, EventArgs e)
        {
            dtStartTime.Format = DateTimePickerFormat.Custom; //����Ϊ��ʾ��ʽΪ�Զ���
             dtStartTime.CustomFormat = "yyyy-MM-dd"; //������ʾ��ʽ

             dtStartTime.Text = DateTime.Now.Date.ToString(); //��Ϊ��ǰ����


             dtEndTime.Format = DateTimePickerFormat.Custom; //����Ϊ��ʾ��ʽΪ�Զ���
             dtEndTime.CustomFormat = "yyyy-MM-dd"; //������ʾ��ʽ

             dtEndTime.Text = DateTime.Now.Date.ToString(); //��Ϊ��ǰ����

             cmbSex.SelectedIndex = 0;

             if (this.roomnumber != "")
             {
                 tbRoomNum.Text = this.roomnumber;
                 tbRoomNum.ReadOnly = true;

             }
         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
            this.Dispose();
        }
    }
}