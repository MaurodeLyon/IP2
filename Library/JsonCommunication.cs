using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class JsonCommunication
    {
        public static void saveToJson(string path, Meetsessie session)
        {
            string json = JsonConvert.SerializeObject(session);
            File.WriteAllText(path, json);
        }

        public static Meetsessie loadFromJson(string path)
        {
            string jsonFile = File.ReadAllText(path);

            Meetsessie sessionFromJson = JsonConvert.DeserializeObject<Meetsessie>(jsonFile);
            return sessionFromJson;
        }
    }
}
