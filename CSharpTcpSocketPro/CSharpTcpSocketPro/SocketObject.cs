using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CSharpTcpSocketPro
{
    /// <summary>
    /// Socket abstract Object
    /// </summary>
    public abstract class SocketObject
    {
        /// <summary>
        /// 初始化Socket方法
        /// </summary>
        /// <param name="ipAddress">ipAddress</param>
        /// <param name="port">port</param>
        public abstract void InitSocket(IPAddress ipAddress, int port);

        /// <summary>
        /// 初始化Socket方法
        /// </summary>
        /// <param name="ipAddress">ip Address</param>
        /// <param name="port">port</param>
        public abstract void InitSocket(string ipAddress, int port);

        /// <summary>
        /// Socket启动方法
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// Sockdet停止方法
        /// </summary>
        public abstract void Stop();
    }

    /// <summary>
    /// 推送器
    /// </summary>
    /// <param name="sockets">sockets</param>
    public delegate void PushSockets(Sockets sockets);
}
