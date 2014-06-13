namespace HotelManager
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msHotelManager = new System.Windows.Forms.MenuStrip();
            this.menuSetUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msHotelManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // msHotelManager
            // 
            this.msHotelManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TypeToolStripMenuItem,
            this.RoomToolStripMenuItem,
            this.CheckInToolStripMenuItem,
            this.menuSetUser,
            this.tsmiExitSystem});
            this.msHotelManager.Location = new System.Drawing.Point(0, 0);
            this.msHotelManager.Name = "msHotelManager";
            this.msHotelManager.Size = new System.Drawing.Size(1008, 24);
            this.msHotelManager.TabIndex = 2;
            this.msHotelManager.Text = "menuStrip1";
            // 
            // menuSetUser
            // 
            this.menuSetUser.Name = "menuSetUser";
            this.menuSetUser.Size = new System.Drawing.Size(41, 20);
            this.menuSetUser.Text = "设置";
            this.menuSetUser.Click += new System.EventHandler(this.menuSetUser_Click);
            // 
            // tsmiExitSystem
            // 
            this.tsmiExitSystem.Name = "tsmiExitSystem";
            this.tsmiExitSystem.Size = new System.Drawing.Size(65, 20);
            this.tsmiExitSystem.Text = "退出系统";
            this.tsmiExitSystem.Click += new System.EventHandler(this.tsmiExitSystem_Click);
            // 
            // TypeToolStripMenuItem
            // 
            this.TypeToolStripMenuItem.Name = "TypeToolStripMenuItem";
            this.TypeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.TypeToolStripMenuItem.Text = "客房类型";
            this.TypeToolStripMenuItem.Click += new System.EventHandler(this.TypeToolStripMenuItem_Click);
            // 
            // RoomToolStripMenuItem
            // 
            this.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem";
            this.RoomToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.RoomToolStripMenuItem.Text = "房间信息";
            this.RoomToolStripMenuItem.Click += new System.EventHandler(this.RoomToolStripMenuItem_Click);
            // 
            // CheckInToolStripMenuItem
            // 
            this.CheckInToolStripMenuItem.Name = "CheckInToolStripMenuItem";
            this.CheckInToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.CheckInToolStripMenuItem.Text = "入住登记";
            this.CheckInToolStripMenuItem.Click += new System.EventHandler(this.CheckInToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 748);
            this.Controls.Add(this.msHotelManager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1024, 786);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【酒店管理系统】";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msHotelManager.ResumeLayout(false);
            this.msHotelManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msHotelManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiExitSystem;
        private System.Windows.Forms.ToolStripMenuItem menuSetUser;
        private System.Windows.Forms.ToolStripMenuItem TypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckInToolStripMenuItem;
    }
}

