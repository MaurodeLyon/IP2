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
            dataHandler.minutes = Minutes.Value;
            dataHandler.seconds = Seconds.Value;
            dataHandler.minToeren = minToeren.Value;
            dataHandler.maxToeren = maxToeren.Value;
            dataHandler.maxPower = MaxPower.Value;
            dataHandler.startMeasurment();
        }

        private void Stop_button_Click(object sender, EventArgs e)
        {

        }
    }
}
