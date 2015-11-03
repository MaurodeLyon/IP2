﻿using System;
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
        public Patient_Applicatie patientScherm;
        public string naam;
        public int leeftijd;
        public int gewicht;
        public int minutes;
        public int seconds;
        public int minToeren;
        public int maxToeren;
        public int maxPower;


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
            bicycle.sendData("RS");
            bicycle.sendData("CM");
            bicycle.sendData("PT " + minutes + ":" + seconds);
            new Thread(startTraject).Start();
        }

        private Patient patient;
        private Meetsessie meetsessie;
        private void startTraject()
        {
            patient = new Patient(naam);
            meetsessie = new Meetsessie(leeftijd, gewicht);
            patient.meetsessies.Add(meetsessie);
            int amount_of_seconds = (minutes * 60) + seconds;
            int sec_per_stap = amount_of_seconds / 10;
            int amount_per_stap = (maxPower - 25) / 10;

            int currentPower = 25;
            int tick = sec_per_stap;
            bicycle.sendData("CM");
            bicycle.sendData("PW " + currentPower);
            bicycle.sendData("CM");
            bicycle.sendData("PT " + Math.Floor(Convert.ToDecimal(amount_of_seconds / 60)) + ":" + Convert.ToDecimal(amount_of_seconds % 60));

            while (amount_of_seconds != 0)
            {
                bicycle.sendData(ConnectionToBicycle.STATUS);
                if (tick == 0)
                {
                    tick = sec_per_stap;
                    currentPower += amount_per_stap;
                    bicycle.sendData("CM");
                    bicycle.sendData("PW " + currentPower);
                    bicycle.sendData("CM");
                    bicycle.sendData("PT " + Math.Floor(Convert.ToDecimal(amount_of_seconds / 60)) + ":" + Convert.ToDecimal(amount_of_seconds % 60));

                }
                else tick--;
                Thread.Sleep(1000);
                amount_of_seconds--;
                Action min = () => patientScherm.Minutes.Value = Math.Floor(Convert.ToDecimal(amount_of_seconds / 60));
                patientScherm.WaarschuwingLabel.Invoke(min);
                Action sec = () => patientScherm.Seconds.Value = Convert.ToDecimal(amount_of_seconds % 60);
                patientScherm.WaarschuwingLabel.Invoke(sec);
            }

            stopTraject();
        }

        private void addMeasurment(string[] data)
        {
            //check toerental
            int rpm = Int32.Parse(data[1]);
            if (rpm > maxToeren)
            {
                //geef aan dat hij te hard fietst
                Action max = () => patientScherm.WaarschuwingLabel.Text = "U rijdt te hard.";
                patientScherm.WaarschuwingLabel.Invoke(max);
            }
            if (rpm < minToeren)
            {
                //geef aan dat hij te langzaam fietst
                Action min = () => patientScherm.WaarschuwingLabel.Text = "U rijdt te langzaam.";
                patientScherm.WaarschuwingLabel.Invoke(min);
            }

            Action pow = () => patientScherm.actualPowerBox.Text = data[7];
            patientScherm.actualPowerBox.Invoke(pow);

            meetsessie.addMeasurment(new Measurement(data));
        }

        public void stopTraject()
        {
            bicycle.sendData(ConnectionToBicycle.RESET);
            //save logfile to server
            throw new NotImplementedException();
        }
    }
}
