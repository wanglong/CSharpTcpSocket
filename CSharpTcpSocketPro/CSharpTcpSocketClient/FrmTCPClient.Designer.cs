namespace CSharpTcpSocketClient
{
    partial class FrmTCPClient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDisConn = new System.Windows.Forms.Button();
            this.btnConnServer = new System.Windows.Forms.Button();
            this.listBoxStates = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxText = new System.Windows.Forms.ListBox();
            this.btnConnTest = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtServerPort);
            this.groupBox1.Controls.Add(this.txtServerIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器信息";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(103, 58);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(100, 23);
            this.txtServerPort.TabIndex = 3;
            this.txtServerPort.Text = "4455";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(103, 22);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(100, 23);
            this.txtServerIP.TabIndex = 2;
            this.txtServerIP.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "服务器端口：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器IP：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDisConn);
            this.groupBox2.Controls.Add(this.btnConnServer);
            this.groupBox2.Location = new System.Drawing.Point(269, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnDisConn
            // 
            this.btnDisConn.Location = new System.Drawing.Point(17, 58);
            this.btnDisConn.Name = "btnDisConn";
            this.btnDisConn.Size = new System.Drawing.Size(87, 28);
            this.btnDisConn.TabIndex = 1;
            this.btnDisConn.Text = "断开连接";
            this.btnDisConn.UseVisualStyleBackColor = true;
            this.btnDisConn.Click += new System.EventHandler(this.btnDisConn_Click);
            // 
            // btnConnServer
            // 
            this.btnConnServer.Location = new System.Drawing.Point(17, 17);
            this.btnConnServer.Name = "btnConnServer";
            this.btnConnServer.Size = new System.Drawing.Size(87, 28);
            this.btnConnServer.TabIndex = 0;
            this.btnConnServer.Text = "连接服务";
            this.btnConnServer.UseVisualStyleBackColor = true;
            this.btnConnServer.Click += new System.EventHandler(this.btnConnServer_Click);
            // 
            // listBoxStates
            // 
            this.listBoxStates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxStates.FormattingEnabled = true;
            this.listBoxStates.Location = new System.Drawing.Point(3, 19);
            this.listBoxStates.Name = "listBoxStates";
            this.listBoxStates.Size = new System.Drawing.Size(377, 83);
            this.listBoxStates.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxStates);
            this.groupBox3.Location = new System.Drawing.Point(12, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 105);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "客户端状态信息";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxText);
            this.groupBox4.Location = new System.Drawing.Point(12, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 105);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "客户端文字信息";
            // 
            // listBoxText
            // 
            this.listBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxText.FormattingEnabled = true;
            this.listBoxText.Location = new System.Drawing.Point(3, 19);
            this.listBoxText.Name = "listBoxText";
            this.listBoxText.Size = new System.Drawing.Size(377, 83);
            this.listBoxText.TabIndex = 2;
            // 
            // btnConnTest
            // 
            this.btnConnTest.Location = new System.Drawing.Point(213, 326);
            this.btnConnTest.Name = "btnConnTest";
            this.btnConnTest.Size = new System.Drawing.Size(100, 28);
            this.btnConnTest.TabIndex = 3;
            this.btnConnTest.Text = "压力测试";
            this.btnConnTest.UseVisualStyleBackColor = true;
            this.btnConnTest.Click += new System.EventHandler(this.btnConnTest_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(66, 326);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(100, 28);
            this.btnSendData.TabIndex = 2;
            this.btnSendData.Text = "发送随机数据";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // FrmTCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 382);
            this.Controls.Add(this.btnConnTest);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTCPClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP Client";
            this.Load += new System.EventHandler(this.FrmTCPClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConnServer;
        private System.Windows.Forms.Button btnDisConn;
        private System.Windows.Forms.ListBox listBoxStates;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxText;
        private System.Windows.Forms.Button btnConnTest;
        private System.Windows.Forms.Button btnSendData;
    }
}

