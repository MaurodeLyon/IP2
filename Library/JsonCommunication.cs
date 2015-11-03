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
        public static void savePatientJson(string path, Patient patient)
        {
            string json = JsonConvert.SerializeObject(patient);
            File.WriteAllText(path, json);
        }

        public static Patient loadPatientJson(string path)
        {
            string jsonFile = File.ReadAllText(path);
            Patient sessionFromJson = JsonConvert.DeserializeObject<Patient>(jsonFile);
            return sessionFromJson;
        }
    }
}
