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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pulseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LoadButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PatientBox = new System.Windows.Forms.ToolStripComboBox();
            this.MeetsessieBox = new System.Windows.Forms.ToolStripComboBox();
            this.rpmChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.powerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.speedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.laadGrafiekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginTijdBox = new System.Windows.Forms.ToolStripTextBox();
            this.eindTijdBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.gewichtBox = new System.Windows.Forms.ToolStripTextBox();
            this.leeftijdBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
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
            chartArea5.Name = "ChartArea1";
            this.pulseChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.pulseChart.Legends.Add(legend5);
            this.pulseChart.Location = new System.Drawing.Point(0, 30);
            this.pulseChart.Name = "pulseChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.pulseChart.Series.Add(series5);
            this.pulseChart.Size = new System.Drawing.Size(512, 337);
            this.pulseChart.TabIndex = 0;
            this.pulseChart.Text = "pulseChart";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadButton,
            this.PatientBox,
            this.MeetsessieBox,
            this.laadGrafiekToolStripMenuItem,
            this.beginTijdBox,
            this.eindTijdBox,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LoadButton
            // 
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(97, 23);
            this.LoadButton.Text = "Laad patienten";
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // PatientBox
            // 
            this.PatientBox.Name = "PatientBox";
            this.PatientBox.Size = new System.Drawing.Size(121, 23);
            this.PatientBox.SelectedIndexChanged += new System.EventHandler(this.PatientBox_SelectedIndexChanged);
            // 
            // MeetsessieBox
            // 
            this.MeetsessieBox.Name = "MeetsessieBox";
            this.MeetsessieBox.Size = new System.Drawing.Size(121, 23);
            this.MeetsessieBox.SelectedIndexChanged += new System.EventHandler(this.MeetsessieBox_SelectedIndexChanged);
            // 
            // rpmChart
            // 
            chartArea6.Name = "ChartArea1";
            this.rpmChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.rpmChart.Legends.Add(legend6);
            this.rpmChart.Location = new System.Drawing.Point(496, 30);
            this.rpmChart.Name = "rpmChart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.rpmChart.Series.Add(series6);
            this.rpmChart.Size = new System.Drawing.Size(512, 337);
            this.rpmChart.TabIndex = 3;
            this.rpmChart.Text = "rpmChart";
            // 
            // powerChart
            // 
            chartArea7.Name = "ChartArea1";
            this.powerChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.powerChart.Legends.Add(legend7);
            this.powerChart.Location = new System.Drawing.Point(0, 363);
            this.powerChart.Name = "powerChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.powerChart.Series.Add(series7);
            this.powerChart.Size = new System.Drawing.Size(512, 337);
            this.powerChart.TabIndex = 4;
            this.powerChart.Text = "powerChart";
            // 
            // speedChart
            // 
            chartArea8.Name = "ChartArea1";
            this.speedChart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.speedChart.Legends.Add(legend8);
            this.speedChart.Location = new System.Drawing.Point(496, 363);
            this.speedChart.Name = "speedChart";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.speedChart.Series.Add(series8);
            this.speedChart.Size = new System.Drawing.Size(512, 337);
            this.speedChart.TabIndex = 5;
            this.speedChart.Text = "speedChart";
            // 
            // laadGrafiekToolStripMenuItem
            // 
            this.laadGrafiekToolStripMenuItem.Name = "laadGrafiekToolStripMenuItem";
            this.laadGrafiekToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.laadGrafiekToolStripMenuItem.Text = "Laad grafiek";
            this.laadGrafiekToolStripMenuItem.Click += new System.EventHandler(this.laadGrafiekToolStripMenuItem_Click);
            // 
            // beginTijdBox
            // 
            this.beginTijdBox.Name = "beginTijdBox";
            this.beginTijdBox.Size = new System.Drawing.Size(100, 23);
            // 
            // eindTijdBox
            // 
            this.eindTijdBox.Name = "eindTijdBox";
            this.eindTijdBox.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 23);
            this.toolStripMenuItem1.Text = "Laad gegevens tussen";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gewichtBox,
            this.leeftijdBox,
            this.toolStripTextBox3});
            this.menuStrip2.Location = new System.Drawing.Point(0, 702);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1008, 27);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // gewichtBox
            // 
            this.gewichtBox.Name = "gewichtBox";
            this.gewichtBox.Size = new System.Drawing.Size(100, 23);
            // 
            // leeftijdBox
            // 
            this.leeftijdBox.Name = "leeftijdBox";
            this.leeftijdBox.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.speedChart);
            this.Controls.Add(this.powerChart);
            this.Controls.Add(this.rpmChart);
            this.Controls.Add(this.pulseChart);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
    }
}

