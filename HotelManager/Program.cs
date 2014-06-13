using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


       

            Form Login = new LoginForm();
            Login.ShowDialog();//显示登陆窗体  
            if (Login.DialogResult == DialogResult.OK)
                Application.Run(new MainForm());//判断登陆成功时主进程显示主窗口  
            else return;  


        }
    }
}