namespace TestApp
{
    partial class HeatControl
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDayMinTempOff = new System.Windows.Forms.ComboBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbloutdoortemp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblmintemp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblmaxtemp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblHeatState = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbMaxTempOffHeat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCloudCover = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.lblLastUpdateWeather = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Outdoor Temp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deg C, turn off heating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Deg C, turn off heating that day";
            // 
            // cmbDayMinTempOff
            // 
            this.cmbDayMinTempOff.FormattingEnabled = true;
            this.cmbDayMinTempOff.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.cmbDayMinTempOff.Location = new System.Drawing.Point(251, 87);
            this.cmbDayMinTempOff.Name = "cmbDayMinTempOff";
            this.cmbDayMinTempOff.Size = new System.Drawing.Size(64, 21);
            this.cmbDayMinTempOff.TabIndex = 3;
            this.cmbDayMinTempOff.Text = "19";
            this.cmbDayMinTempOff.SelectedIndexChanged += new System.EventHandler(this.cmbDayMinTempOff_SelectedIndexChanged);
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(251, 28);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(100, 20);
            this.txtPostcode.TabIndex = 6;
            this.txtPostcode.TextChanged += new System.EventHandler(this.txtPostcode_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Postcode";
            // 
            // lbloutdoortemp
            // 
            this.lbloutdoortemp.AutoSize = true;
            this.lbloutdoortemp.Location = new System.Drawing.Point(116, 61);
            this.lbloutdoortemp.Name = "lbloutdoortemp";
            this.lbloutdoortemp.Size = new System.Drawing.Size(55, 13);
            this.lbloutdoortemp.TabIndex = 8;
            this.lbloutdoortemp.Text = "xxx Deg C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "When above";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "When above";
            // 
            // lblmintemp
            // 
            this.lblmintemp.AutoSize = true;
            this.lblmintemp.Location = new System.Drawing.Point(116, 90);
            this.lblmintemp.Name = "lblmintemp";
            this.lblmintemp.Size = new System.Drawing.Size(55, 13);
            this.lblmintemp.TabIndex = 12;
            this.lblmintemp.Text = "xxx Deg C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Min Outdoor Temp:";
            // 
            // lblmaxtemp
            // 
            this.lblmaxtemp.AutoSize = true;
            this.lblmaxtemp.Location = new System.Drawing.Point(116, 113);
            this.lblmaxtemp.Name = "lblmaxtemp";
            this.lblmaxtemp.Size = new System.Drawing.Size(55, 13);
            this.lblmaxtemp.TabIndex = 17;
            this.lblmaxtemp.Text = "xxx Deg C";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Max Outdoor Temp:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 239);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Current Heating State:";
            // 
            // lblHeatState
            // 
            this.lblHeatState.AutoSize = true;
            this.lblHeatState.Location = new System.Drawing.Point(131, 239);
            this.lblHeatState.Name = "lblHeatState";
            this.lblHeatState.Size = new System.Drawing.Size(22, 13);
            this.lblHeatState.TabIndex = 25;
            this.lblHeatState.Text = "xxx";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbMaxTempOffHeat
            // 
            this.cmbMaxTempOffHeat.FormattingEnabled = true;
            this.cmbMaxTempOffHeat.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.cmbMaxTempOffHeat.Location = new System.Drawing.Point(251, 54);
            this.cmbMaxTempOffHeat.Name = "cmbMaxTempOffHeat";
            this.cmbMaxTempOffHeat.Size = new System.Drawing.Size(64, 21);
            this.cmbMaxTempOffHeat.TabIndex = 0;
            this.cmbMaxTempOffHeat.Text = "17";
            this.cmbMaxTempOffHeat.SelectedIndexChanged += new System.EventHandler(this.cmbMaxTempOffHeat_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "ShowAPI Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 163);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Holiday until";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cloud Cover: ";
            // 
            // lblCloudCover
            // 
            this.lblCloudCover.AutoSize = true;
            this.lblCloudCover.Location = new System.Drawing.Point(116, 135);
            this.lblCloudCover.Name = "lblCloudCover";
            this.lblCloudCover.Size = new System.Drawing.Size(71, 13);
            this.lblCloudCover.TabIndex = 30;
            this.lblCloudCover.Text = "Cloud Cover: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "worldweatheronline.com API Key: ";
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(250, 6);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(100, 20);
            this.txtAPIKey.TabIndex = 32;
            this.txtAPIKey.TextChanged += new System.EventHandler(this.txtAPIKey_TextChanged);
            // 
            // lblLastUpdateWeather
            // 
            this.lblLastUpdateWeather.AutoSize = true;
            this.lblLastUpdateWeather.Location = new System.Drawing.Point(134, 256);
            this.lblLastUpdateWeather.Name = "lblLastUpdateWeather";
            this.lblLastUpdateWeather.Size = new System.Drawing.Size(0, 13);
            this.lblLastUpdateWeather.TabIndex = 33;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(347, 256);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // HeatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 291);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblLastUpdateWeather);
            this.Controls.Add(this.txtAPIKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCloudCover);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHeatState);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblmaxtemp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblmintemp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbloutdoortemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDayMinTempOff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMaxTempOffHeat);
            this.Name = "HeatControl";
            this.Text = "HeatControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HeatControl_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDayMinTempOff;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbloutdoortemp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblmintemp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblmaxtemp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblHeatState;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbMaxTempOffHeat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCloudCover;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.Label lblLastUpdateWeather;
        private System.Windows.Forms.Button btnRefresh;
    }
}

