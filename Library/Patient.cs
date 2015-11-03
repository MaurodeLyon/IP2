using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public class Patient
    {
        public string naam;
        public List<Meetsessie> meetsessies;
        //gewicht en leeftijd verplaatst naar meetsessie, omdat dat over periodes kan veranderen

        public Patient()
        {
            meetsessies = new List<Meetsessie>();
        }

        public Patient(string naam)
        {
            this.naam = naam;
            meetsessies = new List<Meetsessie>();
        }
        [JsonConstructor]
        public Patient(string naam, List<Meetsessie> meetsessies)
        {
            this.naam = naam;
            this.meetsessies = meetsessies;
        }
    }
    [Serializable]
    public class Meetsessie
    {
        public DateTime datum;
        public int leeftijd;
        public int gewicht;

        public List<Measurement> session;

        public Meetsessie()
        {

        }

        public Meetsessie(int leeftijd, int gewicht)
        {
            datum = DateTime.Now;
            this.leeftijd = leeftijd;
            this.gewicht = gewicht;
            session = new List<Measurement>();
        }

        [JsonConstructor]
        public Meetsessie(int leeftijd, int gewicht, List<Measurement> session)
        {
            datum = DateTime.Now;
            this.leeftijd = leeftijd;
            this.gewicht = gewicht;
            this.session = session;
        }

        public void addMeasurment(Measurement measurment)
        {
            session.Add(measurment);
        }
    }

    [Serializable]
    public class Measurement
    {
        public int pulse { get; }
        public int rpm { get; }
        public int speed { get; }
        public int distance { get; }
        public int requestedPower { get; }
        public int energy { get; }
        public int actualPower { get; }
        public int time { get; }


        public Measurement(int pulse, int rpm, int speed, int distance, int requestedPower, int energy, int actualPower, int time)
        {
            this.pulse = pulse;
            this.rpm = rpm;
            this.speed = speed;
            this.distance = distance;
            this.requestedPower = requestedPower;
            this.energy = energy;
            this.actualPower = actualPower;
            this.time = time;
        }

        public Measurement(string[] data)
        {
            pulse = int.Parse(data[0]);
            rpm = int.Parse(data[1]);
            speed = int.Parse(data[2]);
            distance = int.Parse(data[3]);
            requestedPower = int.Parse(data[4]);
            energy = int.Parse(data[5]);
            string[] timeArray = data[6].Split(':');
            time += (int.Parse(timeArray[0]) * 60);
            time += int.Parse(timeArray[1]);
            actualPower = int.Parse(data[7]);
        }

        [JsonConstructor]
        public Measurement(string pulse, string rpm, string speed, string distance, string requestedPower, string energy, string time, string actualPower)
        {
            this.pulse = int.Parse(pulse);
            this.rpm = int.Parse(rpm);
            this.speed = int.Parse(speed);
            this.distance = int.Parse(distance);
            this.requestedPower = int.Parse(requestedPower);
            this.energy = int.Parse(energy);
            this.time = int.Parse(time);
            this.actualPower = int.Parse(actualPower);
        }
    }
}

