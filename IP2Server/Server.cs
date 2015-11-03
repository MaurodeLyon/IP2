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
        private List<Patient> patients;

        public Server()
        {
            patients = new List<Patient>(); // to be replaced with list loaded from patient document
            serverListener = new TcpListener(IPAddress.Any, Port);
            serverListener.Start();
            Console.WriteLine("Server gestart, wachten op verbindingen...\r\n");
            while (true)
            {
                Console.WriteLine("Wachten op verbindingen...\r\n");
                TcpClient tcp = serverListener.AcceptTcpClient();
                new Thread(Handler).Start(tcp);
                Console.WriteLine("Nieuwe verbinding geaccepteerd.\r\n");
            }
        }

        private void Handler(object obj)
        {
            TcpClient client = obj as TcpClient;
            while (true)
            {
                string data = NetworkCommunication.ReadMessage(client);
                Console.WriteLine($"received: {data}");
                switch (data)
                {
                    case "1":
                        Patient P = NetworkCommunication.receivePatient(client);
                        //AddPatientSession(P);
                        break;
                    case "2":
                        NetworkCommunication.SendPatients(client, patients);
                        break;
                }
            }
        }

        private void AddPatientSession(object _patient)
        {
            Patient receivedPatient = _patient as Patient;
            foreach (Patient patient in patients)
            {
                if (patient.naam == receivedPatient.naam)
                    patient.meetsessies.Add(receivedPatient.meetsessies[0]);
                else patients.Add(receivedPatient);

            }
        }
    }
}
