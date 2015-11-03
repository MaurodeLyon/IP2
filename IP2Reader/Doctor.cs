using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP2Reader
{
    public partial class Doctor : Form
    {
        private List<Patient> patiens;
        private Connect connect;

        public Doctor()
        {
            InitializeComponent();
            patiens = new List<Patient>();
            connect = new Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.RequestData();
            //this.chart1.Series["RPM"].Points.AddXY()
        }
    }
}
