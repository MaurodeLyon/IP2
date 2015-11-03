using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;

namespace IP2Server
{
    class Server
    {
        private static int Port = 8800;
        private static TcpListener serverListener;

        public Server()
        {
            serverListener = new TcpListener(IPAddress.Any, Port);
            GetConnections();
        }

        private void GetConnections()
        {
            try
            {
                Thread getConnections = new Thread(() =>
                {
                    serverListener.Start();
                    Console.WriteLine("Server gestart, wachten op verbindingen...\r\n");

                    while(true)
                    {
                        new Client(serverListener.AcceptTcpClient());
                        Console.WriteLine("Nieuwe verbinding geaccepteerd."
                            + "\r\n");
                    }
                });

                getConnections.Start();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
