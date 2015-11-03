using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class JsonCommunication
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

        public static void savePatientsJson(string path, List<Patient> patient)
        {
            string json = JsonConvert.SerializeObject(patient);
            File.WriteAllText(path, json);
        }

        public static List<Patient> loadPatientsJson(string path)
        {
            string jsonFile = File.ReadAllText(path);
            List<Patient> sessionFromJson = JsonConvert.DeserializeObject<List<Patient>>(jsonFile);
            return sessionFromJson;
        }
    }
}
