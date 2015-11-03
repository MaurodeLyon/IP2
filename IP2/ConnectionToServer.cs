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
        private static string serverIP = "127.0.0.1";
        private static int serverPort = 8800;

        public ConnectionToServer()
        {
            tcpClient = new TcpClient();
            Connect();
        }

        private void Connect()
        {
            tcpClient.Connect(serverIP, serverPort);
        }
    }
}
