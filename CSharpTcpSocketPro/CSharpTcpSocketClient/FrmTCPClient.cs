using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpTcpSocketPro;
using System.Threading;

namespace CSharpTcpSocketClient
{
    /// <summary>
    /// Form TCP Client
    /// </summary>
    public partial class FrmTCPClient : Form
    {
        CommTcpClient tcpClient;

        string ip = string.Empty;
        string port = string.Empty;
        private int sendInt = 0;

        /// <summary>
        /// FrmTCPClient
        /// </summary>
        public FrmTCPClient()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnConnServer_Click(object sender, EventArgs e)
        {
            try
            {
                this.ip = txtServerIP.Text.Trim();
                this.port = txtServerPort.Text.Trim();

                tcpClient.InitSocket(ip, int.Parse(port));
                tcpClient.Start();
                listBoxStates.Items.Add("连接成功!");
                btnConnServer.Enabled = false;

            }
            catch (Exception ex)
            {

                listBoxStates.Items.Add(string.Format("连接失败!原因：{0}", ex.Message));
                btnConnServer.Enabled = true;
            }
        }

        private void FrmTCPClient_Load(object sender, EventArgs e)
        {
            //客户端如何处理异常等信息参照服务端
            CommTcpClient.pushSockets = new PushSockets(Rec);

            tcpClient = new CommTcpClient();
            this.ip = txtServerIP.Text.Trim();
            this.port = txtServerPort.Text.Trim();

        }

        /// <summary>
        /// 处理推送过来的消息
        /// </summary>
        /// <param name="rec"></param>
        private void Rec(CSharpTcpSocketPro.Sockets sks)
        {
            this.Invoke(new ThreadStart(delegate
            {
                if (listBoxText.Items.Count > 1000)
                {
                    listBoxText.Items.Clear();
                }
                if (sks.ex != null)
                {
                    if (sks.ClientDispose == true)
                    {
                        //由于未知原因引发异常.导致客户端下线.   比如网络故障.或服务器断开连接.
                        listBoxStates.Items.Add(string.Format("客户端下线.!"));
                    }
                    listBoxStates.Items.Add(string.Format("异常消息：{0}", sks.ex));
                }
                else if (sks.Offset == 0)
                {
                    //客户端主动下线
                    listBoxStates.Items.Add(string.Format("客户端下线.!"));
                }
                else
                {
                    byte[] buffer = new byte[sks.Offset];
                    Array.Copy(sks.RecBuffer, buffer, sks.Offset);
                    string str = Encoding.UTF8.GetString(buffer);
                    listBoxText.Items.Add(string.Format("服务端{0}发来消息：{1}", sks.Ip, str));
                }
            }));
        }

        private void btnDisConn_Click(object sender, EventArgs e)
        {
            tcpClient.Stop();
            btnConnServer.Enabled = true;
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            tcpClient.SendData("客户端消息!" + sendInt);
            sendInt++;

        }

        private void btnConnTest_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(o =>
            {
                for (int i = 0; i < 100; i++)
                {
                    CSharpTcpSocketPro.CommTcpClient clientx = new CSharpTcpSocketPro.CommTcpClient();//初始化类库  
                    clientx.InitSocket(ip, int.Parse(port));
                    clientx.Start();
                }
                MessageBox.Show("完成.!");
            });
        }
    }
}
