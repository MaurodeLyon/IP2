using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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
    }
}
