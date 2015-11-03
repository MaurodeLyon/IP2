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
            serverListener = new TcpListener(IPAddress.Any, Port);
            patients = new List<Patient>(); // to be replaced with list loaded from patient document
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

                    while (true)
                    {
                        new Thread(Handler).Start(serverListener.AcceptTcpClient());
                        Console.WriteLine("Nieuwe verbinding geaccepteerd."
                            + "\r\n");
                    }
                });

                getConnections.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void Handler(Object clientObject)
        {
            TcpClient client = clientObject as TcpClient;

            string data = NetworkCommunication.ReadMessage(client);
            string[] protocol = data.Split('|');

            switch (protocol[0])
            {
                case "1":
                    AddPatientSession(protocol[1]);
                    break;
                case "2":
                    NetworkCommunication.SendPatients(client, patients);
                    break;
            }
        }

        private void AddPatientSession(Object _patient)
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
