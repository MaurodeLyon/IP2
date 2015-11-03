using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using Library;

namespace IP2Server
{
    class Server
    {
        private static int Port = 8800;
        private static TcpListener serverListener;
        private static List<Object> measurements;

        public Server()
        {
            serverListener = new TcpListener(IPAddress.Any, Port);
            measurements = new List<Object>();
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
                        new Thread(Handler).Start(serverListener.AcceptTcpClient());
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

        private void Handler(Object clientObject)
        {
            TcpClient client = clientObject as TcpClient;

            string data = NetworkCommunication.ReadMessage(client);
            string[] protocol = data.Split('|');
            
            switch(protocol[0])
            {
                case "1":
                    SaveMeasurement(protocol[1]);
                    break;
                case "2":
                    NetworkCommunication.SendMeasurements(client, measurements);
                    break;
            }
        }

        private void SaveMeasurement(Object measurement)
        {
            measurements.Add(measurement);
        }
    }
}
