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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
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
            this.btnDeleteSequence = new System.Windows.Forms.Button();
            this.btnRunSequence = new System.Windows.Forms.Button();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.btnRecordSequence = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.txtTimername = new System.Windows.Forms.TextBox();
            this.btnSetTimer = new System.Windows.Forms.Button();
            this.dateTimeTimer = new System.Windows.Forms.DateTimePicker();
            this.txtSequenceNameTimer = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lblMeterReading = new System.Windows.Forms.Label();
            this.btnGetReading = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnSendRaw = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSendRaw = new System.Windows.Forms.TextBox();
            this.btnAllHeatOff = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAllHeatOn = new System.Windows.Forms.Button();
            this.btnHeatControl = new System.Windows.Forms.Button();
            this.chkRadiatorState = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage6.SuspendLayout();
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
            this.txtcommands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcommands.Size = new System.Drawing.Size(567, 228);
            this.txtcommands.TabIndex = 22;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(8, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 65);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnOpen);
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(556, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 23);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(515, 7);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(39, 23);
            this.btnStop.TabIndex = 30;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(470, 7);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(46, 23);
            this.btnOpen.TabIndex = 29;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnFullLock
            // 
            this.btnFullLock.Location = new System.Drawing.Point(236, 6);
            this.btnFullLock.Name = "btnFullLock";
            this.btnFullLock.Size = new System.Drawing.Size(60, 23);
            this.btnFullLock.TabIndex = 28;
            this.btnFullLock.Text = "FullLock";
            this.btnFullLock.UseVisualStyleBackColor = true;
            this.btnFullLock.Click += new System.EventHandler(this.btnFullLock_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(302, 6);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(61, 23);
            this.btnUnlock.TabIndex = 27;
            this.btnUnlock.Text = "UnLock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(190, 6);
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
            this.label4.Location = new System.Drawing.Point(369, 11);
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
            this.cmbPct.Location = new System.Drawing.Point(417, 9);
            this.cmbPct.Name = "cmbPct";
            this.cmbPct.Size = new System.Drawing.Size(47, 21);
            this.cmbPct.TabIndex = 24;
            this.cmbPct.Text = "0";
            this.cmbPct.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(107, 6);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(39, 23);
            this.btnOff.TabIndex = 23;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(152, 6);
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
            this.cmbDevice.Size = new System.Drawing.Size(56, 21);
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
            this.btnSaveMood.Location = new System.Drawing.Point(108, 5);
            this.btnSaveMood.Name = "btnSaveMood";
            this.btnSaveMood.Size = new System.Drawing.Size(76, 23);
            this.btnSaveMood.TabIndex = 24;
            this.btnSaveMood.Text = "SaveMood";
            this.btnSaveMood.UseVisualStyleBackColor = true;
            this.btnSaveMood.Click += new System.EventHandler(this.btnSaveMood_Click);
            // 
            // btnSetMood
            // 
            this.btnSetMood.Location = new System.Drawing.Point(190, 6);
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
            this.cmbMood.Size = new System.Drawing.Size(53, 21);
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
            this.btnCHoff.Location = new System.Drawing.Point(548, 6);
            this.btnCHoff.Name = "btnCHoff";
            this.btnCHoff.Size = new System.Drawing.Size(117, 23);
            this.btnCHoff.TabIndex = 16;
            this.btnCHoff.Text = "Central Heating Off";
            this.btnCHoff.UseVisualStyleBackColor = true;
            this.btnCHoff.Click += new System.EventHandler(this.btnCHoff_Click);
            // 
            // btnCHon
            // 
            this.btnCHon.Location = new System.Drawing.Point(430, 6);
            this.btnCHon.Name = "btnCHon";
            this.btnCHon.Size = new System.Drawing.Size(112, 23);
            this.btnCHon.TabIndex = 15;
            this.btnCHon.Text = "CentralHeating On";
            this.btnCHon.UseVisualStyleBackColor = true;
            this.btnCHon.Click += new System.EventHandler(this.btnCHon_Click);
            // 
            // btnHWoff
            // 
            this.btnHWoff.Location = new System.Drawing.Point(340, 6);
            this.btnHWoff.Name = "btnHWoff";
            this.btnHWoff.Size = new System.Drawing.Size(86, 23);
            this.btnHWoff.TabIndex = 14;
            this.btnHWoff.Text = "Hot Water Off";
            this.btnHWoff.UseVisualStyleBackColor = true;
            this.btnHWoff.Click += new System.EventHandler(this.btnHWoff_Click);
            // 
            // btnHWon
            // 
            this.btnHWon.Location = new System.Drawing.Point(257, 6);
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
            this.label9.Location = new System.Drawing.Point(178, 11);
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
            this.tabPage4.Controls.Add(this.btnDeleteSequence);
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
            // btnDeleteSequence
            // 
            this.btnDeleteSequence.Location = new System.Drawing.Point(250, 12);
            this.btnDeleteSequence.Name = "btnDeleteSequence";
            this.btnDeleteSequence.Size = new System.Drawing.Size(47, 23);
            this.btnDeleteSequence.TabIndex = 29;
            this.btnDeleteSequence.Text = "Delete";
            this.btnDeleteSequence.UseVisualStyleBackColor = true;
            this.btnDeleteSequence.Click += new System.EventHandler(this.btnDeleteSequence_Click);
            // 
            // btnRunSequence
            // 
            this.btnRunSequence.Location = new System.Drawing.Point(197, 11);
            this.btnRunSequence.Name = "btnRunSequence";
            this.btnRunSequence.Size = new System.Drawing.Size(47, 23);
            this.btnRunSequence.TabIndex = 28;
            this.btnRunSequence.Text = "Run";
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
            this.btnRecordSequence.Size = new System.Drawing.Size(54, 23);
            this.btnRecordSequence.TabIndex = 26;
            this.btnRecordSequence.Text = "Record";
            this.btnRecordSequence.UseVisualStyleBackColor = true;
            this.btnRecordSequence.Click += new System.EventHandler(this.btnRecordSequence_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.txtTimername);
            this.tabPage7.Controls.Add(this.btnSetTimer);
            this.tabPage7.Controls.Add(this.dateTimeTimer);
            this.tabPage7.Controls.Add(this.txtSequenceNameTimer);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(680, 39);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Timer";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // txtTimername
            // 
            this.txtTimername.Location = new System.Drawing.Point(11, 10);
            this.txtTimername.Name = "txtTimername";
            this.txtTimername.Size = new System.Drawing.Size(100, 20);
            this.txtTimername.TabIndex = 3;
            this.txtTimername.Text = "TimerName";
            // 
            // btnSetTimer
            // 
            this.btnSetTimer.Location = new System.Drawing.Point(599, 9);
            this.btnSetTimer.Name = "btnSetTimer";
            this.btnSetTimer.Size = new System.Drawing.Size(75, 23);
            this.btnSetTimer.TabIndex = 2;
            this.btnSetTimer.Text = "Set Timer";
            this.btnSetTimer.UseVisualStyleBackColor = true;
            this.btnSetTimer.Click += new System.EventHandler(this.btnSetTimer_Click);
            // 
            // dateTimeTimer
            // 
            this.dateTimeTimer.CustomFormat = "dd MMM yyyy HH:mm:ss";
            this.dateTimeTimer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTimer.Location = new System.Drawing.Point(231, 10);
            this.dateTimeTimer.Name = "dateTimeTimer";
            this.dateTimeTimer.ShowUpDown = true;
            this.dateTimeTimer.Size = new System.Drawing.Size(135, 20);
            this.dateTimeTimer.TabIndex = 1;
            // 
            // txtSequenceNameTimer
            // 
            this.txtSequenceNameTimer.Location = new System.Drawing.Point(116, 10);
            this.txtSequenceNameTimer.Name = "txtSequenceNameTimer";
            this.txtSequenceNameTimer.Size = new System.Drawing.Size(100, 20);
            this.txtSequenceNameTimer.TabIndex = 0;
            this.txtSequenceNameTimer.Text = "SequenceName";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lblMeterReading);
            this.tabPage6.Controls.Add(this.btnGetReading);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(680, 39);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Energy Meter";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lblMeterReading
            // 
            this.lblMeterReading.AutoSize = true;
            this.lblMeterReading.Location = new System.Drawing.Point(12, 12);
            this.lblMeterReading.Name = "lblMeterReading";
            this.lblMeterReading.Size = new System.Drawing.Size(192, 13);
            this.lblMeterReading.TabIndex = 1;
            this.lblMeterReading.Text = "Press \'Get Reading\' To read from meter";
            // 
            // btnGetReading
            // 
            this.btnGetReading.Location = new System.Drawing.Point(590, 7);
            this.btnGetReading.Name = "btnGetReading";
            this.btnGetReading.Size = new System.Drawing.Size(75, 23);
            this.btnGetReading.TabIndex = 0;
            this.btnGetReading.Text = "Get Reading";
            this.btnGetReading.UseVisualStyleBackColor = true;
            this.btnGetReading.Click += new System.EventHandler(this.btnGetReading_Click);
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
            this.btnAllHeatOff.Location = new System.Drawing.Point(240, 12);
            this.btnAllHeatOff.Name = "btnAllHeatOff";
            this.btnAllHeatOff.Size = new System.Drawing.Size(105, 23);
            this.btnAllHeatOff.TabIndex = 27;
            this.btnAllHeatOff.Text = "All Heat Off";
            this.btnAllHeatOff.UseVisualStyleBackColor = true;
            this.btnAllHeatOff.Click += new System.EventHandler(this.btnAllHeatOff_Click);
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
            this.btnAllHeatOn.Location = new System.Drawing.Point(351, 12);
            this.btnAllHeatOn.Name = "btnAllHeatOn";
            this.btnAllHeatOn.Size = new System.Drawing.Size(105, 23);
            this.btnAllHeatOn.TabIndex = 30;
            this.btnAllHeatOn.Text = "All Heat On";
            this.btnAllHeatOn.UseVisualStyleBackColor = true;
            this.btnAllHeatOn.Click += new System.EventHandler(this.btnAllHeatOn_Click);
            // 
            // btnHeatControl
            // 
            this.btnHeatControl.Location = new System.Drawing.Point(505, 61);
            this.btnHeatControl.Name = "btnHeatControl";
            this.btnHeatControl.Size = new System.Drawing.Size(191, 23);
            this.btnHeatControl.TabIndex = 31;
            this.btnHeatControl.Text = "Control Heating with weather";
            this.btnHeatControl.UseVisualStyleBackColor = true;
            this.btnHeatControl.Click += new System.EventHandler(this.btnHeatControl_Click);
            // 
            // chkRadiatorState
            // 
            this.chkRadiatorState.AutoSize = true;
            this.chkRadiatorState.Location = new System.Drawing.Point(559, 16);
            this.chkRadiatorState.Name = "chkRadiatorState";
            this.chkRadiatorState.Size = new System.Drawing.Size(137, 17);
            this.chkRadiatorState.TabIndex = 32;
            this.chkRadiatorState.Text = "Maintain Radiator State";
            this.chkRadiatorState.UseVisualStyleBackColor = true;
            this.chkRadiatorState.CheckedChanged += new System.EventHandler(this.chkRadiatorState_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 399);
            this.Controls.Add(this.chkRadiatorState);
            this.Controls.Add(this.btnHeatControl);
            this.Controls.Add(this.btnAllHeatOn);
            this.Controls.Add(this.button2);
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
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
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
        private System.Windows.Forms.Button btnDeleteSequence;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label lblMeterReading;
        private System.Windows.Forms.Button btnGetReading;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnHeatControl;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button btnSetTimer;
        private System.Windows.Forms.DateTimePicker dateTimeTimer;
        private System.Windows.Forms.TextBox txtSequenceNameTimer;
        private System.Windows.Forms.TextBox txtTimername;
        private System.Windows.Forms.CheckBox chkRadiatorState;
    }
}

