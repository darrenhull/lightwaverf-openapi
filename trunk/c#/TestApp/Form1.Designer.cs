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
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPct = new System.Windows.Forms.ComboBox();
            this.HeatOn = new System.Windows.Forms.Button();
            this.HeatOff = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMood = new System.Windows.Forms.ComboBox();
            this.btnSaveMood = new System.Windows.Forms.Button();
            this.btnSetMood = new System.Windows.Forms.Button();
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
            this.cmbRoom.Location = new System.Drawing.Point(54, 12);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(182, 21);
            this.cmbRoom.TabIndex = 0;
            this.cmbRoom.Text = "1";
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
            this.cmbDevice.Location = new System.Drawing.Point(54, 40);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(182, 21);
            this.cmbDevice.TabIndex = 1;
            this.cmbDevice.Text = "1";
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(328, 40);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(32, 23);
            this.btnOn.TabIndex = 2;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(283, 40);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(39, 23);
            this.btnOff.TabIndex = 3;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Device";
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
            this.cmbPct.Location = new System.Drawing.Point(530, 43);
            this.cmbPct.Name = "cmbPct";
            this.cmbPct.Size = new System.Drawing.Size(77, 21);
            this.cmbPct.TabIndex = 6;
            this.cmbPct.Text = "0";
            this.cmbPct.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // HeatOn
            // 
            this.HeatOn.Location = new System.Drawing.Point(345, 12);
            this.HeatOn.Name = "HeatOn";
            this.HeatOn.Size = new System.Drawing.Size(52, 23);
            this.HeatOn.TabIndex = 7;
            this.HeatOn.Text = "HeatOn";
            this.HeatOn.UseVisualStyleBackColor = true;
            this.HeatOn.Click += new System.EventHandler(this.HeatOn_Click);
            // 
            // HeatOff
            // 
            this.HeatOff.Location = new System.Drawing.Point(403, 12);
            this.HeatOff.Name = "HeatOff";
            this.HeatOff.Size = new System.Drawing.Size(60, 23);
            this.HeatOff.TabIndex = 8;
            this.HeatOff.Text = "HeatOff";
            this.HeatOff.UseVisualStyleBackColor = true;
            this.HeatOff.Click += new System.EventHandler(this.HeatOff_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(325, 120);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(77, 13);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Last Command";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dim(%):";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(325, 144);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(55, 13);
            this.lblResponse.TabIndex = 11;
            this.lblResponse.Text = "Response";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "All Off";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last command sent by any device:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "response from wifilink";
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(366, 40);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(40, 23);
            this.btnLock.TabIndex = 15;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(412, 41);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(61, 23);
            this.btnUnlock.TabIndex = 16;
            this.btnUnlock.Text = "UnLock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 18;
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
            this.cmbMood.Location = new System.Drawing.Point(54, 67);
            this.cmbMood.Name = "cmbMood";
            this.cmbMood.Size = new System.Drawing.Size(182, 21);
            this.cmbMood.TabIndex = 17;
            this.cmbMood.Text = "1";
            // 
            // btnSaveMood
            // 
            this.btnSaveMood.Location = new System.Drawing.Point(283, 69);
            this.btnSaveMood.Name = "btnSaveMood";
            this.btnSaveMood.Size = new System.Drawing.Size(76, 23);
            this.btnSaveMood.TabIndex = 20;
            this.btnSaveMood.Text = "SaveMood";
            this.btnSaveMood.UseVisualStyleBackColor = true;
            this.btnSaveMood.Click += new System.EventHandler(this.btnSaveMood_Click);
            // 
            // btnSetMood
            // 
            this.btnSetMood.Location = new System.Drawing.Point(365, 70);
            this.btnSetMood.Name = "btnSetMood";
            this.btnSetMood.Size = new System.Drawing.Size(62, 23);
            this.btnSetMood.TabIndex = 19;
            this.btnSetMood.Text = "SetMood";
            this.btnSetMood.UseVisualStyleBackColor = true;
            this.btnSetMood.Click += new System.EventHandler(this.btnSetMood_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 189);
            this.Controls.Add(this.btnSaveMood);
            this.Controls.Add(this.btnSetMood);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbMood);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.HeatOff);
            this.Controls.Add(this.HeatOn);
            this.Controls.Add(this.cmbPct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.cmbRoom);
            this.Name = "Form1";
            this.Text = "LightwaveRF OpenAPI Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPct;
        private System.Windows.Forms.Button HeatOn;
        private System.Windows.Forms.Button HeatOff;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMood;
        private System.Windows.Forms.Button btnSaveMood;
        private System.Windows.Forms.Button btnSetMood;
    }
}

