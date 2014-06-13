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
    public partial class LoginForm : Form
    {
        UserManage userManage = new UserManage();
        public LoginForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (tbUserName.Text == "" || tbPassword.Text == "")
                {
                    MessageBox.Show("请填写登陆信息!", "提	示");
                }
                else
                {
                   


                    List<User> userLogin = userManage.GetInfoByName(tbUserName.Text.Trim());
                    if (userLogin.Count > 0 && userLogin[0].Password.Trim() == tbPassword.Text.Trim())
                    {

                        this.DialogResult = DialogResult.OK;//
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("登陆信息错误", "提示");
                    }

                   
                }


            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常信息");

            }
        }




        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Dispose();
            this.Close();
        }

      
       

    }
}
