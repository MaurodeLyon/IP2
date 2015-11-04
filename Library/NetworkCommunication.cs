using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Library
{
    public class NetworkCommunication
    {
        //simple writeline and readline
        public static void WriteMessage(TcpClient client, string message)
        {
            StreamWriter stream = new StreamWriter(client.GetStream(), Encoding.Unicode);
            stream.WriteLine(message);
            stream.Flush();
        }

        public static string ReadMessage(TcpClient client)
        {
            StreamReader stream = new StreamReader(client.GetStream(), Encoding.Unicode);
            return stream.ReadLine();
        }

        //sending patient
        public static void SendPatient(TcpClient client, Patient patient)
        {
            string json = JsonConvert.SerializeObject(patient);
            WriteMessage(client, "1|" + json);
        }

        //send patients
        public static void SendPatients(TcpClient client, List<Patient> patients)
        {
            string json = JsonConvert.SerializeObject(patients);
            WriteMessage(client, json);
        }
    }
}
