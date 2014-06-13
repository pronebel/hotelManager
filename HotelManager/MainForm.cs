using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 隐藏子窗体
        /// </summary>
        private void hideSubForms()
        {
            this.roomFrm.Hide();
            this.roomTypeFrm.Hide();
            this.curstomerFrm.Hide();
            this.userMangeForm.Hide();


            TypeToolStripMenuItem.BackColor = Color.LightGray;
            menuSetUser.BackColor = Color.LightGray;
            CheckInToolStripMenuItem.BackColor = Color.LightGray;
            RoomToolStripMenuItem.BackColor = Color.LightGray;
        }

        RoomTypeForm roomTypeFrm = new RoomTypeForm();

        /// <summary>
        /// click：显示RoomType窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRoomTypeSetup_Click(object sender, EventArgs e)
        {

            this.ShowRoomTypeForm();
        }

        /// <summary>
        /// 显示RoomTypeForm
        /// </summary>
        public void ShowRoomTypeForm()
        {
        
            this.hideSubForms();
            TypeToolStripMenuItem.BackColor = Color.Orange;
            if (roomTypeFrm.IsDisposed)
            {
                roomTypeFrm = new RoomTypeForm();
            }
            roomTypeFrm.MdiParent = this;
            roomTypeFrm.StartPosition = FormStartPosition.CenterScreen;
            roomTypeFrm.Size = this.GetMdiAreaSize();

            roomTypeFrm.Show();
        }

        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        RoomForm roomFrm = new RoomForm();
    



        BlankForm MainFormSizeFrm = new BlankForm();
        /// <summary>
        /// 主窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            MainFormSizeFrm = new BlankForm();
            MainFormSizeFrm.MdiParent = this;
            this.ShowRoomTypeForm();

        }

        /// <summary>
        /// 获取主窗体可显示区域的大小
        /// </summary>
        /// <returns></returns>
        private Size GetMdiAreaSize()
        {
            MdiClient client = MainFormSizeFrm.Parent as MdiClient;
            return client.ClientSize;
        }

        CustomerForm curstomerFrm = new CustomerForm();
  

        Manager.UserForm userMangeForm = new Manager.UserForm();
        private void menuSetUser_Click(object sender, EventArgs e)
        {
         
            this.hideSubForms();
            menuSetUser.BackColor = Color.Orange;
            if (userMangeForm.IsDisposed)
            {
                userMangeForm = new Manager.UserForm();
            }
            userMangeForm.MdiParent = this;

            userMangeForm.StartPosition = FormStartPosition.CenterScreen;
            userMangeForm.Size = this.GetMdiAreaSize();

            userMangeForm.Show();
        }

        private void TypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowRoomTypeForm();
        }

        private void RoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            this.hideSubForms();
            RoomToolStripMenuItem.BackColor = Color.Orange;
            if (roomFrm.IsDisposed)
            {
                roomFrm = new RoomForm();
            }
            roomFrm.MdiParent = this;

            roomFrm.StartPosition = FormStartPosition.CenterScreen;
            roomFrm.Size = this.GetMdiAreaSize();

            roomFrm.Show();
        }

        private void CheckInToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            this.hideSubForms();
            CheckInToolStripMenuItem.BackColor = Color.Orange;
            if (curstomerFrm.IsDisposed)
            {
                curstomerFrm = new CustomerForm();
            }
            curstomerFrm.MdiParent = this;

            curstomerFrm.StartPosition = FormStartPosition.CenterScreen;
            curstomerFrm.Size = this.GetMdiAreaSize();

            curstomerFrm.Show();
        }

     

      

       
    }
}