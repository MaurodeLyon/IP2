namespace IP2Reader
{
    partial class Doctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pulseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LoadButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PatientBox = new System.Windows.Forms.ToolStripComboBox();
            this.MeetsessieBox = new System.Windows.Forms.ToolStripComboBox();
            this.laadGrafiekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginTijdBox = new System.Windows.Forms.ToolStripTextBox();
            this.eindTijdBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.haalNieuweGevensOpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rpmChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.powerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.speedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.gewichtBox = new System.Windows.Forms.ToolStripTextBox();
            this.leeftijdBox = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pulseChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpmChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedChart)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pulseChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pulseChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pulseChart.Legends.Add(legend1);
            this.pulseChart.Location = new System.Drawing.Point(0, 37);
            this.pulseChart.Margin = new System.Windows.Forms.Padding(4);
            this.pulseChart.Name = "pulseChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "pulse(Bpm)";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.pulseChart.Series.Add(series1);
            this.pulseChart.Size = new System.Drawing.Size(683, 415);
            this.pulseChart.TabIndex = 0;
            this.pulseChart.Text = "pulseChart";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadButton,
            this.PatientBox,
            this.MeetsessieBox,
            this.laadGrafiekToolStripMenuItem,
            this.beginTijdBox,
            this.eindTijdBox,
            this.toolStripMenuItem1,
            this.haalNieuweGevensOpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1344, 32);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LoadButton
            // 
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(120, 28);
            this.LoadButton.Text = "Laad patienten";
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // PatientBox
            // 
            this.PatientBox.Name = "PatientBox";
            this.PatientBox.Size = new System.Drawing.Size(160, 28);
            this.PatientBox.SelectedIndexChanged += new System.EventHandler(this.PatientBox_SelectedIndexChanged);
            // 
            // MeetsessieBox
            // 
            this.MeetsessieBox.Name = "MeetsessieBox";
            this.MeetsessieBox.Size = new System.Drawing.Size(160, 28);
            this.MeetsessieBox.SelectedIndexChanged += new System.EventHandler(this.MeetsessieBox_SelectedIndexChanged);
            // 
            // laadGrafiekToolStripMenuItem
            // 
            this.laadGrafiekToolStripMenuItem.Name = "laadGrafiekToolStripMenuItem";
            this.laadGrafiekToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.laadGrafiekToolStripMenuItem.Text = "Laad grafiek";
            this.laadGrafiekToolStripMenuItem.Click += new System.EventHandler(this.laadGrafiekToolStripMenuItem_Click);
            // 
            // beginTijdBox
            // 
            this.beginTijdBox.Name = "beginTijdBox";
            this.beginTijdBox.Size = new System.Drawing.Size(132, 28);
            // 
            // eindTijdBox
            // 
            this.eindTijdBox.Name = "eindTijdBox";
            this.eindTijdBox.Size = new System.Drawing.Size(132, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 28);
            this.toolStripMenuItem1.Text = "Laad gegevens tussen";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // haalNieuweGevensOpToolStripMenuItem
            // 
            this.haalNieuweGevensOpToolStripMenuItem.Name = "haalNieuweGevensOpToolStripMenuItem";
            this.haalNieuweGevensOpToolStripMenuItem.Size = new System.Drawing.Size(172, 28);
            this.haalNieuweGevensOpToolStripMenuItem.Text = "haal nieuwe gevens op";
            this.haalNieuweGevensOpToolStripMenuItem.Click += new System.EventHandler(this.haalNieuweGevensOpToolStripMenuItem_Click);
            // 
            // rpmChart
            // 
            chartArea2.Name = "ChartArea1";
            this.rpmChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.rpmChart.Legends.Add(legend2);
            this.rpmChart.Location = new System.Drawing.Point(661, 37);
            this.rpmChart.Margin = new System.Windows.Forms.Padding(4);
            this.rpmChart.Name = "rpmChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Toerental(Rpm)";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.rpmChart.Series.Add(series2);
            this.rpmChart.Size = new System.Drawing.Size(683, 415);
            this.rpmChart.TabIndex = 3;
            this.rpmChart.Text = "rpmChart";
            // 
            // powerChart
            // 
            chartArea3.Name = "ChartArea1";
            this.powerChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.powerChart.Legends.Add(legend3);
            this.powerChart.Location = new System.Drawing.Point(0, 447);
            this.powerChart.Margin = new System.Windows.Forms.Padding(4);
            this.powerChart.Name = "powerChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "zwaarte(Watt)";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.powerChart.Series.Add(series3);
            this.powerChart.Size = new System.Drawing.Size(683, 415);
            this.powerChart.TabIndex = 4;
            this.powerChart.Text = "powerChart";
            // 
            // speedChart
            // 
            chartArea4.Name = "ChartArea1";
            this.speedChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.speedChart.Legends.Add(legend4);
            this.speedChart.Location = new System.Drawing.Point(661, 447);
            this.speedChart.Margin = new System.Windows.Forms.Padding(4);
            this.speedChart.Name = "speedChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "Snelheid(Km/h)";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.speedChart.Series.Add(series4);
            this.speedChart.Size = new System.Drawing.Size(683, 415);
            this.speedChart.TabIndex = 5;
            this.speedChart.Text = "speedChart";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gewichtBox,
            this.leeftijdBox});
            this.menuStrip2.Location = new System.Drawing.Point(0, 866);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1344, 31);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // gewichtBox
            // 
            this.gewichtBox.Enabled = false;
            this.gewichtBox.Name = "gewichtBox";
            this.gewichtBox.Size = new System.Drawing.Size(132, 27);
            // 
            // leeftijdBox
            // 
            this.leeftijdBox.Enabled = false;
            this.leeftijdBox.Name = "leeftijdBox";
            this.leeftijdBox.ReadOnly = true;
            this.leeftijdBox.Size = new System.Drawing.Size(132, 27);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.speedChart);
            this.Controls.Add(this.powerChart);
            this.Controls.Add(this.rpmChart);
            this.Controls.Add(this.pulseChart);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Doctor";
            this.Text = "IP2 Lezer";
            ((System.ComponentModel.ISupportInitialize)(this.pulseChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpmChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedChart)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pulseChart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripComboBox PatientBox;
        private System.Windows.Forms.ToolStripMenuItem LoadButton;
        public System.Windows.Forms.ToolStripComboBox MeetsessieBox;
        private System.Windows.Forms.ToolStripMenuItem laadGrafiekToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart rpmChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart powerChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart speedChart;
        private System.Windows.Forms.ToolStripTextBox beginTijdBox;
        private System.Windows.Forms.ToolStripTextBox eindTijdBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripTextBox gewichtBox;
        private System.Windows.Forms.ToolStripTextBox leeftijdBox;
        private System.Windows.Forms.ToolStripMenuItem haalNieuweGevensOpToolStripMenuItem;
    }
}

