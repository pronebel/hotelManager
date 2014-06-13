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
                MessageBox.Show("房间号不能为空!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(tbUserName.Text.Trim()))
            {
                MessageBox.Show("用户姓名不能为空!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(tbCardNo.Text.Trim()))
            {
                MessageBox.Show("身份证号不能为空!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(tbPhone.Text.Trim()))
            {
                MessageBox.Show("电话不能为空!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(tbUserNum.Text.Trim()))
            {
                MessageBox.Show("入住人数不能为空!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

              try
                {
                     Convert.ToInt32(tbUserNum.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("入住人数请输入数字!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


            DateTime dateStart = dtStartTime.Value.Date;
            DateTime dateEnd = dtEndTime.Value.Date;




            if (dateEnd<dateStart)
            {
                MessageBox.Show("离开时间晚于起始时间!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string isAddBed= "否";
            if(chkAddBed.Checked){
                isAddBed = "是";
            }


          

            Customer user = new Customer(0, tbRoomNum.Text.Trim(), tbUserName.Text.Trim(), cmbSex.Text, tbCardNo.Text.Trim(),
                tbPhone.Text.Trim(), 0, dateStart, dateEnd, Convert.ToInt32(tbUserNum.Text.Trim()), isAddBed, "否");


           string retStr = customerManage.Add(user);

           if (retStr == "-1")
           {
               MessageBox.Show(" 房间不存在！","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
           }
           else if (retStr == "-2")
           {
               MessageBox.Show(" 当前房间不是空闲状态", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }  else if (retStr == "-3")
           {
               MessageBox.Show(" 当前房间未结清", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else if (retStr == "0")
           {
                MessageBox.Show("登记失败", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           {
               this.Hide();
               MessageBox.Show( "登记成功,费用" + retStr + "元", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
           }


           

          
        }

        private void CustomerDetailForm_Load(object sender, EventArgs e)
        {
            dtStartTime.Format = DateTimePickerFormat.Custom; //设置为显示格式为自定义
             dtStartTime.CustomFormat = "yyyy-MM-dd"; //设置显示格式

             dtStartTime.Text = DateTime.Now.Date.ToString(); //设为当前日期


             dtEndTime.Format = DateTimePickerFormat.Custom; //设置为显示格式为自定义
             dtEndTime.CustomFormat = "yyyy-MM-dd"; //设置显示格式

             dtEndTime.Text = DateTime.Now.Date.ToString(); //设为当前日期

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