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
            this.btnOn.Location = new System.Drawing.Point(57, 85);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(32, 23);
            this.btnOn.TabIndex = 2;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(12, 85);
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
            this.cmbPct.Location = new System.Drawing.Point(159, 85);
            this.cmbPct.Name = "cmbPct";
            this.cmbPct.Size = new System.Drawing.Size(77, 21);
            this.cmbPct.TabIndex = 6;
            this.cmbPct.Text = "0";
            this.cmbPct.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // HeatOn
            // 
            this.HeatOn.Location = new System.Drawing.Point(253, 10);
            this.HeatOn.Name = "HeatOn";
            this.HeatOn.Size = new System.Drawing.Size(52, 23);
            this.HeatOn.TabIndex = 7;
            this.HeatOn.Text = "HeatOn";
            this.HeatOn.UseVisualStyleBackColor = true;
            this.HeatOn.Click += new System.EventHandler(this.HeatOn_Click);
            // 
            // HeatOff
            // 
            this.HeatOff.Location = new System.Drawing.Point(311, 10);
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
            this.lblMessage.Location = new System.Drawing.Point(16, 121);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(77, 13);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Last Command";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dim(%):";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(16, 148);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(55, 13);
            this.lblResponse.TabIndex = 11;
            this.lblResponse.Text = "Response";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 201);
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
    }
}

