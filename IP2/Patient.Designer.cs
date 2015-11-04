namespace IP2
{
    partial class Patient_Applicatie
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
            this.Start_button = new System.Windows.Forms.Button();
            this.Stop_button = new System.Windows.Forms.Button();
            this.minToeren = new System.Windows.Forms.NumericUpDown();
            this.Seconds = new System.Windows.Forms.NumericUpDown();
            this.maxToeren = new System.Windows.Forms.NumericUpDown();
            this.MaxPower = new System.Windows.Forms.NumericUpDown();
            this.Minutes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ToerentalLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NaamBox = new System.Windows.Forms.TextBox();
            this.leeftijdBox = new System.Windows.Forms.TextBox();
            this.gewichtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.WaarschuwingLabel = new System.Windows.Forms.Label();
            this.actualPowerBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minToeren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxToeren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(163, 252);
            this.Start_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(100, 28);
            this.Start_button.TabIndex = 0;
            this.Start_button.Text = "Start traject";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Stop_button
            // 
            this.Stop_button.Enabled = false;
            this.Stop_button.Location = new System.Drawing.Point(289, 252);
            this.Stop_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(100, 28);
            this.Stop_button.TabIndex = 1;
            this.Stop_button.Text = "Stop traject";
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // minToeren
            // 
            this.minToeren.Location = new System.Drawing.Point(180, 188);
            this.minToeren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minToeren.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.minToeren.Name = "minToeren";
            this.minToeren.Size = new System.Drawing.Size(67, 22);
            this.minToeren.TabIndex = 5;
            this.minToeren.ValueChanged += new System.EventHandler(this.minToeren_ValueChanged);
            // 
            // Seconds
            // 
            this.Seconds.Location = new System.Drawing.Point(323, 156);
            this.Seconds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Seconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(67, 22);
            this.Seconds.TabIndex = 6;
            this.Seconds.ValueChanged += new System.EventHandler(this.Seconds_ValueChanged);
            // 
            // maxToeren
            // 
            this.maxToeren.Location = new System.Drawing.Point(323, 188);
            this.maxToeren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxToeren.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.maxToeren.Name = "maxToeren";
            this.maxToeren.Size = new System.Drawing.Size(67, 22);
            this.maxToeren.TabIndex = 7;
            this.maxToeren.ValueChanged += new System.EventHandler(this.maxToeren_ValueChanged);
            // 
            // MaxPower
            // 
            this.MaxPower.Location = new System.Drawing.Point(180, 220);
            this.MaxPower.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxPower.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.MaxPower.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.MaxPower.Name = "MaxPower";
            this.MaxPower.Size = new System.Drawing.Size(67, 22);
            this.MaxPower.TabIndex = 8;
            this.MaxPower.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.MaxPower.ValueChanged += new System.EventHandler(this.MaxPower_ValueChanged);
            // 
            // Minutes
            // 
            this.Minutes.Location = new System.Drawing.Point(180, 156);
            this.Minutes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Minutes.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(67, 22);
            this.Minutes.TabIndex = 9;
            this.Minutes.ValueChanged += new System.EventHandler(this.Minutes_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Toerental:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tijd:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Seconden";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Minuten";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ToerentalLabel
            // 
            this.ToerentalLabel.AutoSize = true;
            this.ToerentalLabel.Location = new System.Drawing.Point(279, 191);
            this.ToerentalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ToerentalLabel.Name = "ToerentalLabel";
            this.ToerentalLabel.Size = new System.Drawing.Size(13, 17);
            this.ToerentalLabel.TabIndex = 14;
            this.ToerentalLabel.Text = "-";
            this.ToerentalLabel.Click += new System.EventHandler(this.ToerentalLabel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Toeren per minuut";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Maximale vermogen:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Watt";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // NaamBox
            // 
            this.NaamBox.Location = new System.Drawing.Point(123, 15);
            this.NaamBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NaamBox.Name = "NaamBox";
            this.NaamBox.Size = new System.Drawing.Size(364, 22);
            this.NaamBox.TabIndex = 18;
            // 
            // leeftijdBox
            // 
            this.leeftijdBox.Location = new System.Drawing.Point(123, 47);
            this.leeftijdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leeftijdBox.Name = "leeftijdBox";
            this.leeftijdBox.Size = new System.Drawing.Size(364, 22);
            this.leeftijdBox.TabIndex = 19;
            // 
            // gewichtBox
            // 
            this.gewichtBox.Location = new System.Drawing.Point(123, 79);
            this.gewichtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gewichtBox.Name = "gewichtBox";
            this.gewichtBox.Size = new System.Drawing.Size(364, 22);
            this.gewichtBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Naam:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Leeftijd:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 82);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Gewicht:";
            // 
            // WaarschuwingLabel
            // 
            this.WaarschuwingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WaarschuwingLabel.AutoSize = true;
            this.WaarschuwingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaarschuwingLabel.Location = new System.Drawing.Point(32, 128);
            this.WaarschuwingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WaarschuwingLabel.Name = "WaarschuwingLabel";
            this.WaarschuwingLabel.Size = new System.Drawing.Size(459, 25);
            this.WaarschuwingLabel.TabIndex = 24;
            this.WaarschuwingLabel.Text = ">Hier zullen waarschuwingen komen te staan<";
            // 
            // actualPowerBox
            // 
            this.actualPowerBox.Enabled = false;
            this.actualPowerBox.Location = new System.Drawing.Point(321, 219);
            this.actualPowerBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actualPowerBox.Name = "actualPowerBox";
            this.actualPowerBox.Size = new System.Drawing.Size(67, 22);
            this.actualPowerBox.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Huidig vermogen";
            // 
            // Patient_Applicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(557, 295);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.actualPowerBox);
            this.Controls.Add(this.WaarschuwingLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gewichtBox);
            this.Controls.Add(this.leeftijdBox);
            this.Controls.Add(this.NaamBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ToerentalLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.MaxPower);
            this.Controls.Add(this.maxToeren);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.minToeren);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Start_button);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Patient_Applicatie";
            this.Text = "Patient applicatie";
            ((System.ComponentModel.ISupportInitialize)(this.minToeren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxToeren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.NumericUpDown minToeren;
        public System.Windows.Forms.NumericUpDown Seconds;
        public System.Windows.Forms.NumericUpDown maxToeren;
        public System.Windows.Forms.NumericUpDown MaxPower;
        public System.Windows.Forms.NumericUpDown Minutes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label ToerentalLabel;
        public System.Windows.Forms.TextBox NaamBox;
        public System.Windows.Forms.TextBox gewichtBox;
        public System.Windows.Forms.TextBox leeftijdBox;
        public System.Windows.Forms.Label WaarschuwingLabel;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox actualPowerBox;
        public System.Windows.Forms.Button Stop_button;
    }
}

