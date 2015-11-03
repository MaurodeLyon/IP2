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
            dataHandler.naam = NaamBox.Text;
            dataHandler.leeftijd = Int32.Parse(LeeftijdBox.Text);
            dataHandler.gewicht = Int32.Parse(gewichtBox.Text);
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ToerentalLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Minutes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MaxPower_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maxToeren_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Seconds_ValueChanged(object sender, EventArgs e)
        {

        }

        private void minToeren_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
