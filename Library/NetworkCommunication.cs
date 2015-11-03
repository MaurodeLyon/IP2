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
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Patient));

            using (var memoryStream = new MemoryStream())
            {
                xmlSerializer.Serialize(memoryStream, patient);
            }

            NetworkStream networkStream = client.GetStream();
            if (networkStream.CanWrite)
            {
                xmlSerializer.Serialize(networkStream, patient);
            }
        }

        public static Patient receivePatient(TcpClient client)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Patient));
            NetworkStream networkStream = client.GetStream();

            using (var memoryStream = new MemoryStream())
            {
                xmlSerializer.Deserialize(memoryStream);
            }

            if (networkStream.CanRead)
            {
                object obj = xmlSerializer.Deserialize(networkStream);
                Patient p = obj as Patient;
                return p;
            }
            return null;
        }

        //send patients
        public static void SendPatients(TcpClient client, List<Patient> patients)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Patient>));

            using (var memoryStream = new MemoryStream())
            {
                xmlSerializer.Serialize(memoryStream, patients);
            }

            NetworkStream networkStream = client.GetStream();
            if (networkStream.CanWrite)
            {
                xmlSerializer.Serialize(networkStream, patients);
            }
        }

        public static List<Patient> ReceivePatients(TcpClient client, List<Patient> patients)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Patient>));
            NetworkStream networkStream = client.GetStream();

            using (var memoryStream = new MemoryStream())
            {
                xmlSerializer.Deserialize(memoryStream);
            }

            if (networkStream.CanRead)
            {
                object obj = xmlSerializer.Deserialize(networkStream);
                List<Patient> p = obj as List<Patient>;
                return p;
            }
            return null;
        }

    }
}
