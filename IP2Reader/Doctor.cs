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
using System.Windows.Forms.DataVisualization.Charting;

namespace IP2Reader
{
    public partial class Doctor : Form
    {
        public List<Patient> patients;
        private Connect connect;

        public Doctor()
        {
            InitializeComponent();
            patients = new List<Patient>();
            connect = new Connect(this);
        }

        private void laadGrafiekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadGraph();
        }

        private List<DataPoint> pulsePoints;
        private List<DataPoint> rpmPoints;
        private List<DataPoint> powerPoints;
        private List<DataPoint> speedPoints;
        private void loadGraph()
        {
            pulsePoints = new List<DataPoint>();
            rpmPoints = new List<DataPoint>();
            powerPoints = new List<DataPoint>();
            speedPoints = new List<DataPoint>();
            //load boxes at the bottem
            gewichtBox.Text = selected_session.gewicht.ToString() + " Kg";
            leeftijdBox.Text = selected_session.leeftijd.ToString() + " Jaar";

            int beginPeriode, eindPeriode;
            //check if a period is entered
            if (beginTijdBox.Text == "")
            {
                beginTijdBox.Text = selected_session.session[0].time.ToString();
                beginPeriode = selected_session.session[0].time;
            }
            else
                beginPeriode = int.Parse(beginTijdBox.Text);


            if (eindTijdBox.Text == "")
            {
                eindTijdBox.Text = 0.ToString();
                eindPeriode = 0;
            }
            else
                eindPeriode = int.Parse(eindTijdBox.Text);

            //fill charts
            //fill pulse
            foreach (Measurement m in selected_session.session)
                if (m.time > eindPeriode && m.time < beginPeriode)
                    pulsePoints.Add(new DataPoint(m.time, m.pulse));

            pulseChart.Series[0].Points.Clear();
            foreach (DataPoint p in pulsePoints)
                pulseChart.Series[0].Points.Add(p);
            pulseChart.Update();

            //fill rpm
            foreach (Measurement m in selected_session.session)
                if (m.time > eindPeriode && m.time < beginPeriode)
                    rpmPoints.Add(new DataPoint(m.time, m.rpm));

            rpmChart.Series[0].Points.Clear();
            foreach (DataPoint p in rpmPoints)
                rpmChart.Series[0].Points.Add(p);
            rpmChart.Update();
            //fill power
            foreach (Measurement m in selected_session.session)
                if (m.time > eindPeriode && m.time < beginPeriode)
                    powerPoints.Add(new DataPoint(m.time, m.pulse));

            powerChart.Series[0].Points.Clear();
            foreach (DataPoint p in powerPoints)
                powerChart.Series[0].Points.Add(p);
            powerChart.Update();

            //fill speed
            foreach (Measurement m in selected_session.session)
                if (m.time > eindPeriode && m.time < beginPeriode)
                    speedPoints.Add(new DataPoint(m.time, m.pulse));

            speedChart.Series[0].Points.Clear();
            foreach (DataPoint p in speedPoints)
                speedChart.Series[0].Points.Add(p);
            speedChart.Update();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            foreach (Patient patient in patients)
            {
                PatientBox.Items.Add(patient.naam);
            }
        }
        private void PatientBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Patient patient in patients)
            {
                if (patient.naam == PatientBox.Text)
                    foreach (Meetsessie sessie in patient.meetsessies)
                    {
                        MeetsessieBox.Items.Add(sessie.datum.ToString());
                    }
            }
        }

        private Meetsessie selected_session;
        private void MeetsessieBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Patient patient in patients)
            {
                if (patient.naam == PatientBox.Text)
                    foreach (Meetsessie sessie in patient.meetsessies)
                    {
                        if (sessie.datum.ToString() == MeetsessieBox.Text)
                        {
                            selected_session = sessie;
                        }
                    }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadGraph();
        }
    }
}
