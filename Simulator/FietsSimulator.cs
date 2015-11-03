using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Simulator
{
    class FietsSimulator
    {
        private SerialPort comport;
        private Stopwatch stopwatch;
        private long maxtime;

        private int power, rpm, speed, distance, energy;
        public int Power
        {
            get { return power; }
            set
            {
                if (value >= 25 && value <= 400)
                    power = value;
                if (value < 25)
                    power = 25;
                if (value > 400)
                    power = 400;
            }
        }
        public int Heartbeat
        {
            get { return new Random().Next(60, 160); }
        }

        private Mode curmode;
        private enum Mode
        {
            NONE,
            CONSOLE,
            DISTANCE,
            TIME
        }

        public FietsSimulator(String addr)
        {
            this.comport = new SerialPort(addr, 9600);
            comport.DataReceived += new SerialDataReceivedEventHandler(ReceiveData);
            comport.Open();
            stopwatch = new Stopwatch();
            stopwatch.Stop();
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;

        }

        private void ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            string message = comport.ReadLine().Trim();
            Console.WriteLine(message);
            if (message == "RS")
            {
                curmode = Mode.NONE;
                rpm = speed = distance = energy = 0;
                Power = 25;
                stopwatch.Stop();
                SendData("ACK");
            }
            else if (message == "CM" || message == "CU")
            {
                curmode = Mode.CONSOLE;
                SendData("ACK");
            }
            else if (message.Contains("PD"))
            {
                if (curmode == Mode.CONSOLE && message.Split().Length == 2)
                {
                    distance = Int32.Parse(message.Split(' ')[1]);
                    curmode = Mode.DISTANCE;
                    stopwatch.Reset();
                    stopwatch.Start();
                    rpm = 100;
                    speed = 10;
                }
                else
                {
                    SendData("ERROR");
                }
            }
            else if (message.Contains("PT"))
            {
                if (curmode == Mode.CONSOLE && message.Split().Length == 2)
                {
                    string[] time = message.Split(' ')[1].Split(':');
                    maxtime = Int32.Parse(time[0]) * 60000 + Int32.Parse(time[1]) * 1000;
                    curmode = Mode.TIME;
                    stopwatch.Reset();
                    stopwatch.Start();
                    rpm = 100;
                    speed = 10;
                }
                else
                {
                    SendData("ERROR");
                }
            }
            else if (message.Contains("PW"))
            {
                if (curmode != Mode.NONE && message.Split().Length == 2)
                {
                    this.Power = Int32.Parse(message.Split(' ')[1]);
                }
                else
                {
                    SendData("ERROR");
                }
            }
            else if (message == "ST" && curmode != Mode.NONE)
            {
                SendStatus();
            }
            else
            {
                SendData("ERROR");
            }
        }

        private void SendData(string message)
        {
            Console.WriteLine("RETURN:" + message);
            this.comport.WriteLine(message);
        }
        private void SendStatus()
        {
            SendData(Heartbeat.ToString() + "\t" + rpm + "\t" + speed * 10 + "\t" + distance + "\t" + Power.ToString() + "\t600\t" + getTimeElapsed() + "\t200\r");
        }

        private string getTimeElapsed()
        {
            if (curmode == Mode.DISTANCE)
            {
                long seconds = (stopwatch.ElapsedMilliseconds / 1000) % 60;
                long minutes = ((stopwatch.ElapsedMilliseconds - seconds) / 1000) / 60;
                return minutes + ":" + seconds;
            }
            else if (curmode == Mode.TIME)
            {
                long seconds = ((maxtime - stopwatch.ElapsedMilliseconds) / 1000) % 60;
                long minutes = (((maxtime - stopwatch.ElapsedMilliseconds) - seconds) / 1000) / 60;
                return minutes + ":" + seconds;
            }
            else
            {
                return "00:00";
            }
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (curmode == Mode.DISTANCE)
            {
                distance -= 1;
            }
            else if (curmode == Mode.TIME)
            {
                distance += 1;
            }
        }
    }
}
