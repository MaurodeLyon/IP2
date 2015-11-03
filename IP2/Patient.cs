using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP2
{
    public partial class Patient_Applicatie : Form
    {
        DataHandler dataHandler;
        public Patient_Applicatie()
        {
            InitializeComponent();
            dataHandler = new DataHandler();
        }

        private void Verbind_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //stuur gegevens van patient naar server en verbind de aankomende logfile met de correcte patient
            //of maak een nieuwe patient aan waar de logfile opgeslagen wordt
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            //pak gegevens uit de form en start de test
            Minutes.Enabled = false;
            Seconds.Enabled = false;
            minToeren.Enabled = false;
            maxToeren.Enabled = false;
            MaxPower.Enabled = false;
            dataHandler.minutes = Minutes.Value;
            dataHandler.seconds = Seconds.Value;
            dataHandler.minToeren = minToeren.Value;
            dataHandler.maxToeren = maxToeren.Value;
            dataHandler.maxPower = MaxPower.Value;
            dataHandler.naam = 
            dataHandler.startMeasurment();
        }

        private void Stop_button_Click(object sender, EventArgs e)
        {
            Minutes.Enabled = true;
            Seconds.Enabled = true;
            minToeren.Enabled = true;
            maxToeren.Enabled = true;
            MaxPower.Enabled = true;
            //save to server
            throw new NotImplementedException();
        }

    }
}
