using Library;
using Newtonsoft.Json;
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
        private Doctor doctor;


        public Connect(Doctor doctor)
        {
            this.doctor = doctor;
            do { tcpClient = new TcpClient(serverIP, serverPort); }
            while (!tcpClient.Connected);
            RequestData();
            new Thread(receiveUpdate).Start();
        }

        public void RequestData()
        {
            NetworkCommunication.WriteMessage(tcpClient, "2");
        }

        private void receiveUpdate()
        {
            while (true)
            {
               // doctor.patients = new List<Patient>();
                string data = NetworkCommunication.ReadMessage(tcpClient);
                doctor.patients = JsonConvert.DeserializeObject<List<Patient>>(data);
            }
        }

    }
}
