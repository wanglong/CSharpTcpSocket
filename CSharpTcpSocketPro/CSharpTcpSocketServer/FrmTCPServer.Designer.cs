namespace CSharpTcpSocketServer
{
    partial class FrmTCPServer
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTCPServer));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.UserManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeViewClientList = new System.Windows.Forms.TreeView();
            this.contextMenuStripClientSingle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuSendSingle = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelClientNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBoxServerInfo = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStripClientAll = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuSendAll = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.menuMain.SuspendLayout();
            this.contextMenuStripClientSingle.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripClientAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("宋体", 10F);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserManagerToolStripMenuItem,
            this.ServerToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(724, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // UserManagerToolStripMenuItem
            // 
            this.UserManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserLoginToolStripMenuItem,
            this.UserPasswordToolStripMenuItem,
            this.UserExitToolStripMenuItem});
            this.UserManagerToolStripMenuItem.Font = new System.Drawing.Font("宋体", 10F);
            this.UserManagerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UserManagerToolStripMenuItem.Image")));
            this.UserManagerToolStripMenuItem.Name = "UserManagerToolStripMenuItem";
            this.UserManagerToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.UserManagerToolStripMenuItem.Text = "用户管理";
            // 
            // UserLoginToolStripMenuItem
            // 
            this.UserLoginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UserLoginToolStripMenuItem.Image")));
            this.UserLoginToolStripMenuItem.Name = "UserLoginToolStripMenuItem";
            this.UserLoginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UserLoginToolStripMenuItem.Text = "用户登录";
            // 
            // UserPasswordToolStripMenuItem
            // 
            this.UserPasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UserPasswordToolStripMenuItem.Image")));
            this.UserPasswordToolStripMenuItem.Name = "UserPasswordToolStripMenuItem";
            this.UserPasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UserPasswordToolStripMenuItem.Text = "修改密码";
            // 
            // UserExitToolStripMenuItem
            // 
            this.UserExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UserExitToolStripMenuItem.Image")));
            this.UserExitToolStripMenuItem.Name = "UserExitToolStripMenuItem";
            this.UserExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UserExitToolStripMenuItem.Text = "用户退出";
            // 
            // ServerToolStripMenuItem
            // 
            this.ServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartServerToolStripMenuItem,
            this.StopServerToolStripMenuItem});
            this.ServerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ServerToolStripMenuItem.Image")));
            this.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem";
            this.ServerToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.ServerToolStripMenuItem.Text = "服务器";
            // 
            // StartServerToolStripMenuItem
            // 
            this.StartServerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("StartServerToolStripMenuItem.Image")));
            this.StartServerToolStripMenuItem.Name = "StartServerToolStripMenuItem";
            this.StartServerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StartServerToolStripMenuItem.Text = "启动监听";
            this.StartServerToolStripMenuItem.Click += new System.EventHandler(this.StartServerToolStripMenuItem_Click);
            // 
            // StopServerToolStripMenuItem
            // 
            this.StopServerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("StopServerToolStripMenuItem.Image")));
            this.StopServerToolStripMenuItem.Name = "StopServerToolStripMenuItem";
            this.StopServerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StopServerToolStripMenuItem.Text = "停止监听";
            this.StopServerToolStripMenuItem.Click += new System.EventHandler(this.StopServerToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // treeViewClientList
            // 
            this.treeViewClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewClientList.HideSelection = false;
            this.treeViewClientList.ImageIndex = 0;
            this.treeViewClientList.ImageList = this.imageList1;
            this.treeViewClientList.Location = new System.Drawing.Point(0, 0);
            this.treeViewClientList.Name = "treeViewClientList";
            this.treeViewClientList.SelectedImageIndex = 0;
            this.treeViewClientList.Size = new System.Drawing.Size(130, 359);
            this.treeViewClientList.TabIndex = 1;
            this.treeViewClientList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewClientList_AfterSelect);
            this.treeViewClientList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeViewClientList_MouseClick);
            // 
            // contextMenuStripClientSingle
            // 
            this.contextMenuStripClientSingle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuSendSingle});
            this.contextMenuStripClientSingle.Name = "contextMenuStripClient";
            this.contextMenuStripClientSingle.Size = new System.Drawing.Size(125, 26);
            // 
            // toolStripMenuSendSingle
            // 
            this.toolStripMenuSendSingle.Name = "toolStripMenuSendSingle";
            this.toolStripMenuSendSingle.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuSendSingle.Text = "单个发送";
            this.toolStripMenuSendSingle.Click += new System.EventHandler(this.toolStripMenuSendSingle_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelClientNum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 385);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(724, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "客户端连接：";
            // 
            // toolStripStatusLabelClientNum
            // 
            this.toolStripStatusLabelClientNum.Name = "toolStripStatusLabelClientNum";
            this.toolStripStatusLabelClientNum.Size = new System.Drawing.Size(15, 17);
            this.toolStripStatusLabelClientNum.Text = "0";
            // 
            // listBoxServerInfo
            // 
            this.listBoxServerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxServerInfo.FormattingEnabled = true;
            this.listBoxServerInfo.Location = new System.Drawing.Point(0, 0);
            this.listBoxServerInfo.Name = "listBoxServerInfo";
            this.listBoxServerInfo.Size = new System.Drawing.Size(587, 251);
            this.listBoxServerInfo.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(587, 104);
            this.listBox1.TabIndex = 4;
            // 
            // contextMenuStripClientAll
            // 
            this.contextMenuStripClientAll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuSendAll});
            this.contextMenuStripClientAll.Name = "contextMenuStripClientAll";
            this.contextMenuStripClientAll.Size = new System.Drawing.Size(125, 26);
            // 
            // toolStripMenuSendAll
            // 
            this.toolStripMenuSendAll.Name = "toolStripMenuSendAll";
            this.toolStripMenuSendAll.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuSendAll.Text = "全部发送";
            this.toolStripMenuSendAll.Click += new System.EventHandler(this.toolStripMenuSendAll_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewClientList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(724, 361);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBoxServerInfo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBox1);
            this.splitContainer2.Size = new System.Drawing.Size(589, 361);
            this.splitContainer2.SplitterDistance = 253;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 5;
            // 
            // FrmTCPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 407);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MainMenuStrip = this.menuMain;
            this.Name = "FrmTCPServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTCPServer_FormClosing);
            this.Load += new System.EventHandler(this.FrmTCPServer_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.contextMenuStripClientSingle.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripClientAll.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem UserManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserExitToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem ServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopServerToolStripMenuItem;
        private System.Windows.Forms.TreeView treeViewClientList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelClientNum;
        private System.Windows.Forms.ListBox listBoxServerInfo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripClientSingle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSendSingle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripClientAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSendAll;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

