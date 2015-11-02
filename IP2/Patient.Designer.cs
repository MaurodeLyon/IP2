﻿namespace IP2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Verbind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minToeren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxToeren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(109, 205);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(75, 23);
            this.Start_button.TabIndex = 0;
            this.Start_button.Text = "Start traject";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Stop_button
            // 
            this.Stop_button.Location = new System.Drawing.Point(204, 205);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(75, 23);
            this.Stop_button.TabIndex = 1;
            this.Stop_button.Text = "Stop traject";
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // minToeren
            // 
            this.minToeren.Location = new System.Drawing.Point(122, 153);
            this.minToeren.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.minToeren.Name = "minToeren";
            this.minToeren.Size = new System.Drawing.Size(50, 20);
            this.minToeren.TabIndex = 5;
            // 
            // Seconds
            // 
            this.Seconds.Location = new System.Drawing.Point(229, 127);
            this.Seconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(50, 20);
            this.Seconds.TabIndex = 6;
            // 
            // maxToeren
            // 
            this.maxToeren.Location = new System.Drawing.Point(229, 153);
            this.maxToeren.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.maxToeren.Name = "maxToeren";
            this.maxToeren.Size = new System.Drawing.Size(50, 20);
            this.maxToeren.TabIndex = 7;
            // 
            // MaxPower
            // 
            this.MaxPower.Location = new System.Drawing.Point(122, 179);
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
            this.MaxPower.Size = new System.Drawing.Size(50, 20);
            this.MaxPower.TabIndex = 8;
            this.MaxPower.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // Minutes
            // 
            this.Minutes.Location = new System.Drawing.Point(122, 127);
            this.Minutes.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(50, 20);
            this.Minutes.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Toerental:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tijd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Seconden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Minuten";
            // 
            // ToerentalLabel
            // 
            this.ToerentalLabel.AutoSize = true;
            this.ToerentalLabel.Location = new System.Drawing.Point(196, 155);
            this.ToerentalLabel.Name = "ToerentalLabel";
            this.ToerentalLabel.Size = new System.Drawing.Size(10, 13);
            this.ToerentalLabel.TabIndex = 14;
            this.ToerentalLabel.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Toeren per minuut";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Maximale vermogen:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Watt";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(67, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Naam:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Leeftijd:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Gewicht:";
            // 
            // Verbind
            // 
            this.Verbind.Location = new System.Drawing.Point(76, 88);
            this.Verbind.Name = "Verbind";
            this.Verbind.Size = new System.Drawing.Size(75, 23);
            this.Verbind.TabIndex = 24;
            this.Verbind.Text = "Verbind patient";
            this.Verbind.UseVisualStyleBackColor = true;
            this.Verbind.Click += new System.EventHandler(this.Verbind_Click);
            // 
            // Patient_Applicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(418, 240);
            this.Controls.Add(this.Verbind);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.Button Stop_button;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Verbind;
        public System.Windows.Forms.Label ToerentalLabel;
    }
}

