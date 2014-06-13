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
    public partial class Detail : Form
    {

        UserManage userManage = new UserManage();
        string username = string.Empty;

        public Detail()
        {
            InitializeComponent();
        }
        public Detail(string username)
        {
            InitializeComponent();
            this.username = username;

            List<User> userList = userManage.GetInfoByName(this.username);
            if (userList.Count > 0)
            {
                User tmpUser= userList[0];
                if (tmpUser != null)
                {
                    txtUserName.Text = tmpUser.Name;
                    txtUserName.ReadOnly = true;

                    txtMobile.Text = tmpUser.Mobile;
                    txtEmail.Text = tmpUser.Email;
                    txtPassword.Text = tmpUser.Password;

                }
               

            }
            else
            {
                this.username = string.Empty;
            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名称!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("请输入Email!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMobile.Text.Trim() == "")
            {
                MessageBox.Show("请输入手机号!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入Email!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


        

           string strAlert;

           if (username!=string.Empty)
           {
               strAlert = "确定更新该项?";
           }
           else
           {
               strAlert = "确定新增该项?";
           }

           if (MessageBox.Show(strAlert, "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
           {
               if (username!=string.Empty)
               {
                  // message = rm.UpdateRoom(room);
                   // MessageBox.Show(message, "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                   User userM = new User(0, txtUserName.Text.Trim(), txtMobile.Text.Trim(), txtEmail.Text.Trim(), txtPassword.Text.Trim());

                   int retNum = userManage.Add(userM);
                   if (retNum > 0)
                   {
                       MessageBox.Show("添加成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);


                       this.Close();
                       this.Dispose();
                   }
                   else if (retNum == -1)
                   {
                       MessageBox.Show("已经存在相同昵称的用户", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   }else
                   {
                       MessageBox.Show("操作失败", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
              
               }
           
           }


      
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

    }
}