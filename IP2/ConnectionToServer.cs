using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace IP2
{
    class ConnectionToServer
    {
        private TcpClient tcpClient;

        public ConnectionToServer()
        {
            tcpClient = new TcpClient("192.168.3.102", 1330);
        }
    }
}
