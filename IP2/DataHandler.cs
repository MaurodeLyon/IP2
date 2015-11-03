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
        public string leeftijd;
        public string gewicht;
        public decimal minutes;
        public decimal seconds;
        public decimal minToeren;
        public decimal maxToeren;
        public decimal maxPower;

        public DataHandler()
        {
            //startBicyleConnection();
            //startServerConnection();
        }

        private void startServerConnection()
        {
            throw new NotImplementedException();
        }

        private void startBicyleConnection()
        {
            throw new NotImplementedException();
        }


        internal void startMeasurment()
        {
            new Thread(startTraject).Start();
        }

        private void startTraject()
        {
            Patient patient = new Patient(;
            int amount_of_seconds = (int)((minutes * 60) + seconds);
            int toAdd = (int)maxPower - 25;
            int seconds_until_next_power_add = amount_of_seconds / toAdd;
            int tick = seconds_until_next_power_add;
            while (amount_of_seconds != 0)
            {
                //save measurments to file
                if (tick == 0)
                {
                    tick = seconds_until_next_power_add;
                    //add 1 power to the bicycle
                }
                else tick--;
                Thread.Sleep(1000);
                amount_of_seconds--;
            }
            //traject ended
            stopTraject();
        }

        private void stopTraject()
        {
            throw new NotImplementedException();
            //save logfile to server
            //reset bicycle
        }
    }
}
