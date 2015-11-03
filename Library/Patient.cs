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
        public int leeftijd;
        public int gewicht;
        public List<Meetsessie> meetsessies;

        public Patient()
        {
            meetsessies = new List<Meetsessie>();
        }

        public Patient(string naam, int leeftijd, int gewicht)
        {
            this.naam = naam;
            this.leeftijd = leeftijd;
            this.gewicht = gewicht;
            meetsessies = new List<Meetsessie>();
        }
    }
    [Serializable]
    public class Meetsessie
    {
        public DateTime datum;
        public List<Measurement> session;
        public Meetsessie()
        {
            datum = DateTime.Today;
            session = new List<Measurement>();
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
            int time = 0;
            string[] timeArray = data[6].Split(':');
            time += (int.Parse(timeArray[0]) * 60);
            time += int.Parse(timeArray[1]);
            actualPower = int.Parse(data[7]);
        }
    }
}

