using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Library;

namespace IP2
{
    class DataHandler
    {
        public string naam;
        public int leeftijd;
        public int gewicht;
        public decimal minutes;
        public decimal seconds;
        public decimal minToeren;
        public decimal maxToeren;
        public decimal maxPower;

        private ConnectionToBicycle bicycle;
        private readonly string comport = "COM5";

        public DataHandler()
        {
            bicycle = new ConnectionToBicycle();
            bicycle.initComm(comport);
            ConnectionToBicycle.IncomingDataEvent += addMeasurment;
            //startServerConnection();
        }

        private void startServerConnection()
        {
            throw new NotImplementedException();
        }

        internal void startMeasurment()
        {
            new Thread(startTraject).Start();
        }

        private Patient patient;
        private Meetsessie meetsessie;
        private void startTraject()
        {
            patient = new Patient(naam);
            meetsessie = new Meetsessie(leeftijd, gewicht);
            patient.meetsessies.Add(meetsessie);
            int amount_of_seconds = (int)((minutes * 60) + seconds);

            int toAdd = (int)maxPower - 25;
            int seconds_until_next_power_add = amount_of_seconds / toAdd;
            int tick = seconds_until_next_power_add;
            int currentPower = 25;

            while (amount_of_seconds != 0)
            {
                bicycle.sendData(ConnectionToBicycle.STATUS);
                if (tick == 0)
                {
                    tick = seconds_until_next_power_add;
                    bicycle.sendData("CM");
                    bicycle.sendData("PW " + currentPower);
                    currentPower++;
                }
                else tick--;
                Thread.Sleep(1000);
                amount_of_seconds--;
            }
            stopTraject();
        }

        private void addMeasurment(string[] data)
        {
            //check toerental
            if (data[1] > maxToeren)
            {
                //geef aan dat hij te hard fietst
            }
            if (data[1] < minToeren)
            {
                //geef aan dat hij te langzaam fietst
            }
            meetsessie.addMeasurment(new Measurement(data));
        }

        private void stopTraject()
        {
            bicycle.sendData(ConnectionToBicycle.RESET);
            //save logfile to server
            throw new NotImplementedException();
        }
    }
}
