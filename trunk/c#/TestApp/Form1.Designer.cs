namespace TestApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcommands = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFullLock = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPct = new System.Windows.Forms.ComboBox();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveMood = new System.Windows.Forms.Button();
            this.btnSetMood = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMood = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCHoff = new System.Windows.Forms.Button();
            this.btnCHon = new System.Windows.Forms.Button();
            this.btnHWoff = new System.Windows.Forms.Button();
            this.btnHWon = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HeatOff = new System.Windows.Forms.Button();
            this.HeatOn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnRunSequence = new System.Windows.Forms.Button();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.btnRecordSequence = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnSendRaw = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSendRaw = new System.Windows.Forms.TextBox();
            this.btnAllHeatOff = new System.Windows.Forms.Button();
            this.btnMaintainRadiatorOff = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAllHeatOn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbRoom.Location = new System.Drawing.Point(51, 41);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(182, 21);
            this.cmbRoom.TabIndex = 0;
            this.cmbRoom.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Room";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(129, 146);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(55, 13);
            this.lblResponse.TabIndex = 11;
            this.lblResponse.Text = "Response";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "All Room Devices Off";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Detected Commands";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Response From Wifilink";
            // 
            // txtcommands
            // 
            this.txtcommands.Location = new System.Drawing.Point(129, 166);
            this.txtcommands.Multiline = true;
            this.txtcommands.Name = "txtcommands";
            this.txtcommands.Size = new System.Drawing.Size(567, 228);
            this.txtcommands.TabIndex = 22;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(8, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 65);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnFullLock);
            this.tabPage1.Controls.Add(this.btnUnlock);
            this.tabPage1.Controls.Add(this.btnLock);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmbPct);
            this.tabPage1.Controls.Add(this.btnOff);
            this.tabPage1.Controls.Add(this.btnOn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbDevice);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(680, 39);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Devices";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFullLock
            // 
            this.btnFullLock.Location = new System.Drawing.Point(369, 3);
            this.btnFullLock.Name = "btnFullLock";
            this.btnFullLock.Size = new System.Drawing.Size(60, 23);
            this.btnFullLock.TabIndex = 28;
            this.btnFullLock.Text = "FullLock";
            this.btnFullLock.UseVisualStyleBackColor = true;
            this.btnFullLock.Click += new System.EventHandler(this.btnFullLock_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(430, 3);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(61, 23);
            this.btnUnlock.TabIndex = 27;
            this.btnUnlock.Text = "UnLock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(326, 3);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(40, 23);
            this.btnLock.TabIndex = 26;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Dim(%):";
            // 
            // cmbPct
            // 
            this.cmbPct.FormattingEnabled = true;
            this.cmbPct.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cmbPct.Location = new System.Drawing.Point(548, 5);
            this.cmbPct.Name = "cmbPct";
            this.cmbPct.Size = new System.Drawing.Size(77, 21);
            this.cmbPct.TabIndex = 24;
            this.cmbPct.Text = "0";
            this.cmbPct.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(243, 3);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(39, 23);
            this.btnOff.TabIndex = 23;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(288, 3);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(32, 23);
            this.btnOn.TabIndex = 22;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Device";
            // 
            // cmbDevice
            // 
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbDevice.Location = new System.Drawing.Point(45, 6);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(182, 21);
            this.cmbDevice.TabIndex = 6;
            this.cmbDevice.Text = "1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveMood);
            this.tabPage2.Controls.Add(this.btnSetMood);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cmbMood);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(680, 39);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Moods";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveMood
            // 
            this.btnSaveMood.Location = new System.Drawing.Point(234, 5);
            this.btnSaveMood.Name = "btnSaveMood";
            this.btnSaveMood.Size = new System.Drawing.Size(76, 23);
            this.btnSaveMood.TabIndex = 24;
            this.btnSaveMood.Text = "SaveMood";
            this.btnSaveMood.UseVisualStyleBackColor = true;
            this.btnSaveMood.Click += new System.EventHandler(this.btnSaveMood_Click);
            // 
            // btnSetMood
            // 
            this.btnSetMood.Location = new System.Drawing.Point(316, 6);
            this.btnSetMood.Name = "btnSetMood";
            this.btnSetMood.Size = new System.Drawing.Size(62, 23);
            this.btnSetMood.TabIndex = 23;
            this.btnSetMood.Text = "SetMood";
            this.btnSetMood.UseVisualStyleBackColor = true;
            this.btnSetMood.Click += new System.EventHandler(this.btnSetMood_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mood";
            // 
            // cmbMood
            // 
            this.cmbMood.FormattingEnabled = true;
            this.cmbMood.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbMood.Location = new System.Drawing.Point(48, 6);
            this.cmbMood.Name = "cmbMood";
            this.cmbMood.Size = new System.Drawing.Size(182, 21);
            this.cmbMood.TabIndex = 21;
            this.cmbMood.Text = "1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCHoff);
            this.tabPage3.Controls.Add(this.btnCHon);
            this.tabPage3.Controls.Add(this.btnHWoff);
            this.tabPage3.Controls.Add(this.btnHWon);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.HeatOff);
            this.tabPage3.Controls.Add(this.HeatOn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(680, 39);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Heating";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCHoff
            // 
            this.btnCHoff.Location = new System.Drawing.Point(555, 6);
            this.btnCHoff.Name = "btnCHoff";
            this.btnCHoff.Size = new System.Drawing.Size(117, 23);
            this.btnCHoff.TabIndex = 16;
            this.btnCHoff.Text = "Central Heating Off";
            this.btnCHoff.UseVisualStyleBackColor = true;
            this.btnCHoff.Click += new System.EventHandler(this.btnCHoff_Click);
            // 
            // btnCHon
            // 
            this.btnCHon.Location = new System.Drawing.Point(437, 6);
            this.btnCHon.Name = "btnCHon";
            this.btnCHon.Size = new System.Drawing.Size(112, 23);
            this.btnCHon.TabIndex = 15;
            this.btnCHon.Text = "CentralHeating On";
            this.btnCHon.UseVisualStyleBackColor = true;
            this.btnCHon.Click += new System.EventHandler(this.btnCHon_Click);
            // 
            // btnHWoff
            // 
            this.btnHWoff.Location = new System.Drawing.Point(349, 6);
            this.btnHWoff.Name = "btnHWoff";
            this.btnHWoff.Size = new System.Drawing.Size(86, 23);
            this.btnHWoff.TabIndex = 14;
            this.btnHWoff.Text = "Hot Water Off";
            this.btnHWoff.UseVisualStyleBackColor = true;
            this.btnHWoff.Click += new System.EventHandler(this.btnHWoff_Click);
            // 
            // btnHWon
            // 
            this.btnHWon.Location = new System.Drawing.Point(262, 6);
            this.btnHWon.Name = "btnHWon";
            this.btnHWon.Size = new System.Drawing.Size(81, 23);
            this.btnHWon.TabIndex = 13;
            this.btnHWon.Text = "Hot Water On";
            this.btnHWon.UseVisualStyleBackColor = true;
            this.btnHWon.Click += new System.EventHandler(this.btnHWon_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Boiler Contorls: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Room";
            // 
            // HeatOff
            // 
            this.HeatOff.Location = new System.Drawing.Point(112, 6);
            this.HeatOff.Name = "HeatOff";
            this.HeatOff.Size = new System.Drawing.Size(60, 23);
            this.HeatOff.TabIndex = 10;
            this.HeatOff.Text = "HeatOff";
            this.HeatOff.UseVisualStyleBackColor = true;
            this.HeatOff.Click += new System.EventHandler(this.HeatOff_Click);
            // 
            // HeatOn
            // 
            this.HeatOn.Location = new System.Drawing.Point(54, 6);
            this.HeatOn.Name = "HeatOn";
            this.HeatOn.Size = new System.Drawing.Size(52, 23);
            this.HeatOn.TabIndex = 9;
            this.HeatOn.Text = "HeatOn";
            this.HeatOn.UseVisualStyleBackColor = true;
            this.HeatOn.Click += new System.EventHandler(this.HeatOn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnRunSequence);
            this.tabPage4.Controls.Add(this.txtSequence);
            this.tabPage4.Controls.Add(this.btnRecordSequence);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(680, 39);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sequences";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnRunSequence
            // 
            this.btnRunSequence.Location = new System.Drawing.Point(270, 12);
            this.btnRunSequence.Name = "btnRunSequence";
            this.btnRunSequence.Size = new System.Drawing.Size(120, 23);
            this.btnRunSequence.TabIndex = 28;
            this.btnRunSequence.Text = "Run Sequence";
            this.btnRunSequence.UseVisualStyleBackColor = true;
            this.btnRunSequence.Click += new System.EventHandler(this.btnRunSequence_Click);
            // 
            // txtSequence
            // 
            this.txtSequence.Location = new System.Drawing.Point(10, 13);
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(121, 20);
            this.txtSequence.TabIndex = 27;
            this.txtSequence.Text = "SequenceName";
            // 
            // btnRecordSequence
            // 
            this.btnRecordSequence.Location = new System.Drawing.Point(137, 12);
            this.btnRecordSequence.Name = "btnRecordSequence";
            this.btnRecordSequence.Size = new System.Drawing.Size(120, 23);
            this.btnRecordSequence.TabIndex = 26;
            this.btnRecordSequence.Text = "Record Sequence";
            this.btnRecordSequence.UseVisualStyleBackColor = true;
            this.btnRecordSequence.Click += new System.EventHandler(this.btnRecordSequence_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnSendRaw);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.txtSendRaw);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(680, 39);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Raw";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnSendRaw
            // 
            this.btnSendRaw.Location = new System.Drawing.Point(572, 8);
            this.btnSendRaw.Name = "btnSendRaw";
            this.btnSendRaw.Size = new System.Drawing.Size(75, 23);
            this.btnSendRaw.TabIndex = 2;
            this.btnSendRaw.Text = "Send";
            this.btnSendRaw.UseVisualStyleBackColor = true;
            this.btnSendRaw.Click += new System.EventHandler(this.btnSendRaw_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Send Raw Message: ";
            // 
            // txtSendRaw
            // 
            this.txtSendRaw.Location = new System.Drawing.Point(117, 10);
            this.txtSendRaw.Name = "txtSendRaw";
            this.txtSendRaw.Size = new System.Drawing.Size(449, 20);
            this.txtSendRaw.TabIndex = 0;
            this.txtSendRaw.Text = "333!R1D1F0";
            // 
            // btnAllHeatOff
            // 
            this.btnAllHeatOff.Location = new System.Drawing.Point(338, 12);
            this.btnAllHeatOff.Name = "btnAllHeatOff";
            this.btnAllHeatOff.Size = new System.Drawing.Size(105, 23);
            this.btnAllHeatOff.TabIndex = 27;
            this.btnAllHeatOff.Text = "All Heat Off";
            this.btnAllHeatOff.UseVisualStyleBackColor = true;
            this.btnAllHeatOff.Click += new System.EventHandler(this.btnAllHeatOff_Click);
            // 
            // btnMaintainRadiatorOff
            // 
            this.btnMaintainRadiatorOff.Location = new System.Drawing.Point(560, 12);
            this.btnMaintainRadiatorOff.Name = "btnMaintainRadiatorOff";
            this.btnMaintainRadiatorOff.Size = new System.Drawing.Size(140, 23);
            this.btnMaintainRadiatorOff.TabIndex = 28;
            this.btnMaintainRadiatorOff.Text = "Maintain Radiator Off";
            this.btnMaintainRadiatorOff.UseVisualStyleBackColor = true;
            this.btnMaintainRadiatorOff.Click += new System.EventHandler(this.btnMaintainRadiatorOff_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "All Devices Off";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAllHeatOn
            // 
            this.btnAllHeatOn.Location = new System.Drawing.Point(449, 12);
            this.btnAllHeatOn.Name = "btnAllHeatOn";
            this.btnAllHeatOn.Size = new System.Drawing.Size(105, 23);
            this.btnAllHeatOn.TabIndex = 30;
            this.btnAllHeatOn.Text = "All Heat On";
            this.btnAllHeatOn.UseVisualStyleBackColor = true;
            this.btnAllHeatOn.Click += new System.EventHandler(this.btnAllHeatOn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 399);
            this.Controls.Add(this.btnAllHeatOn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMaintainRadiatorOff);
            this.Controls.Add(this.btnAllHeatOff);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtcommands);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRoom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LightwaveRF OpenAPI Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcommands;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnFullLock;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPct;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSaveMood;
        private System.Windows.Forms.Button btnSetMood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMood;
        private System.Windows.Forms.Button HeatOff;
        private System.Windows.Forms.Button HeatOn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnRunSequence;
        private System.Windows.Forms.TextBox txtSequence;
        private System.Windows.Forms.Button btnRecordSequence;
        private System.Windows.Forms.Button btnAllHeatOff;
        private System.Windows.Forms.Button btnMaintainRadiatorOff;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAllHeatOn;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnSendRaw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSendRaw;
        private System.Windows.Forms.Button btnCHoff;
        private System.Windows.Forms.Button btnCHon;
        private System.Windows.Forms.Button btnHWoff;
        private System.Windows.Forms.Button btnHWon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

