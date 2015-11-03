using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IP2Reader
{
    class Connect
    {
        private TcpClient tcpClient;
        private static string serverIP = "127.0.0.1";
        private static int serverPort = 8800;
        private List<Patient> patiens;

        public Connect()
        {
            new Thread(StartServerConnection).Start();
        }

        private void StartServerConnection()
        {
            do { tcpClient = new TcpClient(serverIP, serverPort); }
            while (!tcpClient.Connected);
        }

        public void RequestData()
        {
            NetworkCommunication.WriteMessage(tcpClient, "2");

            //tiens = NetworkCommunication.ReceivePatients();
        }

        /*private List<Patient> RetreiveData()
        {
            while (tcpClient.Connected)
            {
                tcpClient.GetStream();
            }
        }*/
    }
}
