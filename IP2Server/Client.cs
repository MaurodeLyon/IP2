using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Library;
using System.Threading;

namespace IP2Server
{
    class Client
    {
        private TcpClient client;

        public Client(TcpClient client)
        {
            this.client = client;
            incommingData();
        }

        private void incommingData()
        {
            Thread getData = new Thread(() =>
            {
                while(client.Connected)
                {
                    ProtocolHandler(NetworkCommunication.ReadMessage(client));
                }
            });

            getData.Start();
        }

        private void ProtocolHandler(string data)
        {
            //schrijven
        }
    }
}
