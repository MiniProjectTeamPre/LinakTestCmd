namespace LinakTestCmd {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.bt_connect = new System.Windows.Forms.Button();
            this.bt_LanOn = new System.Windows.Forms.Button();
            this.bt_LanOff = new System.Windows.Forms.Button();
            this.bt_La1 = new System.Windows.Forms.Button();
            this.bt_offAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_readKeypadB = new System.Windows.Forms.TextBox();
            this.bt_stopTimerB = new System.Windows.Forms.Button();
            this.bt_startTimerB = new System.Windows.Forms.Button();
            this.tb_readKeypadA = new System.Windows.Forms.TextBox();
            this.bt_stopTimerA = new System.Windows.Forms.Button();
            this.bt_startTimerA = new System.Windows.Forms.Button();
            this.bt_three1 = new System.Windows.Forms.Button();
            this.bt_Lb4 = new System.Windows.Forms.Button();
            this.bt_Lb3 = new System.Windows.Forms.Button();
            this.bt_Lb2 = new System.Windows.Forms.Button();
            this.bt_Lb7 = new System.Windows.Forms.Button();
            this.bt_Lb6 = new System.Windows.Forms.Button();
            this.bt_Lb5 = new System.Windows.Forms.Button();
            this.bt_Lb1 = new System.Windows.Forms.Button();
            this.bt_La7 = new System.Windows.Forms.Button();
            this.bt_La6 = new System.Windows.Forms.Button();
            this.bt_La5 = new System.Windows.Forms.Button();
            this.bt_La4 = new System.Windows.Forms.Button();
            this.bt_La3 = new System.Windows.Forms.Button();
            this.bt_La2 = new System.Windows.Forms.Button();
            this.bt_onAll = new System.Windows.Forms.Button();
            this.bt_testMode = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_powerRequest = new System.Windows.Forms.TextBox();
            this.bt_powerRequest = new System.Windows.Forms.Button();
            this.tb_readTestMode = new System.Windows.Forms.TextBox();
            this.bt_readTestMode = new System.Windows.Forms.Button();
            this.tb_deviceNumber = new System.Windows.Forms.TextBox();
            this.bt_deviceNumber = new System.Windows.Forms.Button();
            this.tb_serialNumber = new System.Windows.Forms.TextBox();
            this.bt_serialNumber = new System.Windows.Forms.Button();
            this.tb_orderNumber = new System.Windows.Forms.TextBox();
            this.bt_orderNumber = new System.Windows.Forms.Button();
            this.tb_configNumber = new System.Windows.Forms.TextBox();
            this.bt_configNumber = new System.Windows.Forms.Button();
            this.tb_swVersion = new System.Windows.Forms.TextBox();
            this.bt_swVersion = new System.Windows.Forms.Button();
            this.tb_swNumber = new System.Windows.Forms.TextBox();
            this.bt_swNumber = new System.Windows.Forms.Button();
            this.tm_kaypad = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(18, 12);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(188, 23);
            this.bt_connect.TabIndex = 0;
            this.bt_connect.Text = "Connect";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // bt_LanOn
            // 
            this.bt_LanOn.Location = new System.Drawing.Point(6, 19);
            this.bt_LanOn.Name = "bt_LanOn";
            this.bt_LanOn.Size = new System.Drawing.Size(71, 23);
            this.bt_LanOn.TabIndex = 1;
            this.bt_LanOn.Text = "On";
            this.bt_LanOn.UseVisualStyleBackColor = true;
            this.bt_LanOn.Click += new System.EventHandler(this.bt_LanOn_Click);
            // 
            // bt_LanOff
            // 
            this.bt_LanOff.Location = new System.Drawing.Point(123, 19);
            this.bt_LanOff.Name = "bt_LanOff";
            this.bt_LanOff.Size = new System.Drawing.Size(71, 23);
            this.bt_LanOff.TabIndex = 2;
            this.bt_LanOff.Text = "Off";
            this.bt_LanOff.UseVisualStyleBackColor = true;
            this.bt_LanOff.Click += new System.EventHandler(this.bt_LanOff_Click);
            // 
            // bt_La1
            // 
            this.bt_La1.Location = new System.Drawing.Point(6, 77);
            this.bt_La1.Name = "bt_La1";
            this.bt_La1.Size = new System.Drawing.Size(56, 23);
            this.bt_La1.TabIndex = 3;
            this.bt_La1.Text = "LA1";
            this.bt_La1.UseVisualStyleBackColor = true;
            this.bt_La1.Click += new System.EventHandler(this.bt_La1_Click);
            // 
            // bt_offAll
            // 
            this.bt_offAll.Location = new System.Drawing.Point(138, 193);
            this.bt_offAll.Name = "bt_offAll";
            this.bt_offAll.Size = new System.Drawing.Size(56, 52);
            this.bt_offAll.TabIndex = 4;
            this.bt_offAll.Text = "OFF ALL";
            this.bt_offAll.UseVisualStyleBackColor = true;
            this.bt_offAll.Click += new System.EventHandler(this.bt_offAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_readKeypadB);
            this.groupBox1.Controls.Add(this.bt_stopTimerB);
            this.groupBox1.Controls.Add(this.bt_startTimerB);
            this.groupBox1.Controls.Add(this.tb_readKeypadA);
            this.groupBox1.Controls.Add(this.bt_stopTimerA);
            this.groupBox1.Controls.Add(this.bt_startTimerA);
            this.groupBox1.Controls.Add(this.bt_three1);
            this.groupBox1.Controls.Add(this.bt_Lb4);
            this.groupBox1.Controls.Add(this.bt_Lb3);
            this.groupBox1.Controls.Add(this.bt_Lb2);
            this.groupBox1.Controls.Add(this.bt_Lb7);
            this.groupBox1.Controls.Add(this.bt_Lb6);
            this.groupBox1.Controls.Add(this.bt_Lb5);
            this.groupBox1.Controls.Add(this.bt_Lb1);
            this.groupBox1.Controls.Add(this.bt_La7);
            this.groupBox1.Controls.Add(this.bt_La6);
            this.groupBox1.Controls.Add(this.bt_La5);
            this.groupBox1.Controls.Add(this.bt_La4);
            this.groupBox1.Controls.Add(this.bt_La3);
            this.groupBox1.Controls.Add(this.bt_La2);
            this.groupBox1.Controls.Add(this.bt_onAll);
            this.groupBox1.Controls.Add(this.bt_testMode);
            this.groupBox1.Controls.Add(this.bt_LanOn);
            this.groupBox1.Controls.Add(this.bt_offAll);
            this.groupBox1.Controls.Add(this.bt_LanOff);
            this.groupBox1.Controls.Add(this.bt_La1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 362);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // tb_readKeypadB
            // 
            this.tb_readKeypadB.Location = new System.Drawing.Point(6, 335);
            this.tb_readKeypadB.Name = "tb_readKeypadB";
            this.tb_readKeypadB.Size = new System.Drawing.Size(188, 20);
            this.tb_readKeypadB.TabIndex = 23;
            // 
            // bt_stopTimerB
            // 
            this.bt_stopTimerB.Location = new System.Drawing.Point(107, 306);
            this.bt_stopTimerB.Name = "bt_stopTimerB";
            this.bt_stopTimerB.Size = new System.Drawing.Size(87, 23);
            this.bt_stopTimerB.TabIndex = 25;
            this.bt_stopTimerB.Text = "Stop";
            this.bt_stopTimerB.UseVisualStyleBackColor = true;
            this.bt_stopTimerB.Click += new System.EventHandler(this.bt_stopTimerB_Click);
            // 
            // bt_startTimerB
            // 
            this.bt_startTimerB.Location = new System.Drawing.Point(6, 306);
            this.bt_startTimerB.Name = "bt_startTimerB";
            this.bt_startTimerB.Size = new System.Drawing.Size(87, 23);
            this.bt_startTimerB.TabIndex = 24;
            this.bt_startTimerB.Text = "Read KeypadB";
            this.bt_startTimerB.UseVisualStyleBackColor = true;
            this.bt_startTimerB.Click += new System.EventHandler(this.bt_startTimerB_Click);
            // 
            // tb_readKeypadA
            // 
            this.tb_readKeypadA.Location = new System.Drawing.Point(6, 280);
            this.tb_readKeypadA.Name = "tb_readKeypadA";
            this.tb_readKeypadA.Size = new System.Drawing.Size(188, 20);
            this.tb_readKeypadA.TabIndex = 16;
            // 
            // bt_stopTimerA
            // 
            this.bt_stopTimerA.Location = new System.Drawing.Point(107, 251);
            this.bt_stopTimerA.Name = "bt_stopTimerA";
            this.bt_stopTimerA.Size = new System.Drawing.Size(87, 23);
            this.bt_stopTimerA.TabIndex = 22;
            this.bt_stopTimerA.Text = "Stop";
            this.bt_stopTimerA.UseVisualStyleBackColor = true;
            this.bt_stopTimerA.Click += new System.EventHandler(this.bt_stopTimerA_Click);
            // 
            // bt_startTimerA
            // 
            this.bt_startTimerA.Location = new System.Drawing.Point(6, 251);
            this.bt_startTimerA.Name = "bt_startTimerA";
            this.bt_startTimerA.Size = new System.Drawing.Size(87, 23);
            this.bt_startTimerA.TabIndex = 21;
            this.bt_startTimerA.Text = "Read KeypadA";
            this.bt_startTimerA.UseVisualStyleBackColor = true;
            this.bt_startTimerA.Click += new System.EventHandler(this.bt_startTimerA_Click);
            // 
            // bt_three1
            // 
            this.bt_three1.Location = new System.Drawing.Point(73, 222);
            this.bt_three1.Name = "bt_three1";
            this.bt_three1.Size = new System.Drawing.Size(56, 23);
            this.bt_three1.TabIndex = 20;
            this.bt_three1.Text = "Three1";
            this.bt_three1.UseVisualStyleBackColor = true;
            this.bt_three1.Click += new System.EventHandler(this.bt_three1_Click);
            // 
            // bt_Lb4
            // 
            this.bt_Lb4.Location = new System.Drawing.Point(73, 193);
            this.bt_Lb4.Name = "bt_Lb4";
            this.bt_Lb4.Size = new System.Drawing.Size(56, 23);
            this.bt_Lb4.TabIndex = 19;
            this.bt_Lb4.Text = "LB4";
            this.bt_Lb4.UseVisualStyleBackColor = true;
            this.bt_Lb4.Click += new System.EventHandler(this.bt_Lb4_Click);
            // 
            // bt_Lb3
            // 
            this.bt_Lb3.Location = new System.Drawing.Point(6, 193);
            this.bt_Lb3.Name = "bt_Lb3";
            this.bt_Lb3.Size = new System.Drawing.Size(56, 23);
            this.bt_Lb3.TabIndex = 18;
            this.bt_Lb3.Text = "LB3";
            this.bt_Lb3.UseVisualStyleBackColor = true;
            this.bt_Lb3.Click += new System.EventHandler(this.bt_Lb3_Click);
            // 
            // bt_Lb2
            // 
            this.bt_Lb2.Location = new System.Drawing.Point(138, 164);
            this.bt_Lb2.Name = "bt_Lb2";
            this.bt_Lb2.Size = new System.Drawing.Size(56, 23);
            this.bt_Lb2.TabIndex = 17;
            this.bt_Lb2.Text = "LB2";
            this.bt_Lb2.UseVisualStyleBackColor = true;
            this.bt_Lb2.Click += new System.EventHandler(this.bt_Lb2_Click);
            // 
            // bt_Lb7
            // 
            this.bt_Lb7.Location = new System.Drawing.Point(73, 164);
            this.bt_Lb7.Name = "bt_Lb7";
            this.bt_Lb7.Size = new System.Drawing.Size(56, 23);
            this.bt_Lb7.TabIndex = 16;
            this.bt_Lb7.Text = "LB7";
            this.bt_Lb7.UseVisualStyleBackColor = true;
            this.bt_Lb7.Click += new System.EventHandler(this.bt_Lb7_Click);
            // 
            // bt_Lb6
            // 
            this.bt_Lb6.Location = new System.Drawing.Point(6, 164);
            this.bt_Lb6.Name = "bt_Lb6";
            this.bt_Lb6.Size = new System.Drawing.Size(56, 23);
            this.bt_Lb6.TabIndex = 15;
            this.bt_Lb6.Text = "LB6";
            this.bt_Lb6.UseVisualStyleBackColor = true;
            this.bt_Lb6.Click += new System.EventHandler(this.bt_Lb6_Click);
            // 
            // bt_Lb5
            // 
            this.bt_Lb5.Location = new System.Drawing.Point(138, 135);
            this.bt_Lb5.Name = "bt_Lb5";
            this.bt_Lb5.Size = new System.Drawing.Size(56, 23);
            this.bt_Lb5.TabIndex = 14;
            this.bt_Lb5.Text = "LB5";
            this.bt_Lb5.UseVisualStyleBackColor = true;
            this.bt_Lb5.Click += new System.EventHandler(this.bt_Lb5_Click);
            // 
            // bt_Lb1
            // 
            this.bt_Lb1.Location = new System.Drawing.Point(73, 135);
            this.bt_Lb1.Name = "bt_Lb1";
            this.bt_Lb1.Size = new System.Drawing.Size(56, 23);
            this.bt_Lb1.TabIndex = 13;
            this.bt_Lb1.Text = "LB1";
            this.bt_Lb1.UseVisualStyleBackColor = true;
            this.bt_Lb1.Click += new System.EventHandler(this.bt_Lb1_Click);
            // 
            // bt_La7
            // 
            this.bt_La7.Location = new System.Drawing.Point(6, 135);
            this.bt_La7.Name = "bt_La7";
            this.bt_La7.Size = new System.Drawing.Size(56, 23);
            this.bt_La7.TabIndex = 12;
            this.bt_La7.Text = "LA7";
            this.bt_La7.UseVisualStyleBackColor = true;
            this.bt_La7.Click += new System.EventHandler(this.bt_La7_Click);
            // 
            // bt_La6
            // 
            this.bt_La6.Location = new System.Drawing.Point(138, 106);
            this.bt_La6.Name = "bt_La6";
            this.bt_La6.Size = new System.Drawing.Size(56, 23);
            this.bt_La6.TabIndex = 11;
            this.bt_La6.Text = "LA6";
            this.bt_La6.UseVisualStyleBackColor = true;
            this.bt_La6.Click += new System.EventHandler(this.bt_La6_Click);
            // 
            // bt_La5
            // 
            this.bt_La5.Location = new System.Drawing.Point(73, 106);
            this.bt_La5.Name = "bt_La5";
            this.bt_La5.Size = new System.Drawing.Size(56, 23);
            this.bt_La5.TabIndex = 10;
            this.bt_La5.Text = "LA5";
            this.bt_La5.UseVisualStyleBackColor = true;
            this.bt_La5.Click += new System.EventHandler(this.bt_La5_Click);
            // 
            // bt_La4
            // 
            this.bt_La4.Location = new System.Drawing.Point(6, 106);
            this.bt_La4.Name = "bt_La4";
            this.bt_La4.Size = new System.Drawing.Size(56, 23);
            this.bt_La4.TabIndex = 9;
            this.bt_La4.Text = "LA4";
            this.bt_La4.UseVisualStyleBackColor = true;
            this.bt_La4.Click += new System.EventHandler(this.bt_La4_Click);
            // 
            // bt_La3
            // 
            this.bt_La3.Location = new System.Drawing.Point(138, 77);
            this.bt_La3.Name = "bt_La3";
            this.bt_La3.Size = new System.Drawing.Size(56, 23);
            this.bt_La3.TabIndex = 8;
            this.bt_La3.Text = "LA3";
            this.bt_La3.UseVisualStyleBackColor = true;
            this.bt_La3.Click += new System.EventHandler(this.bt_La3_Click);
            // 
            // bt_La2
            // 
            this.bt_La2.Location = new System.Drawing.Point(73, 77);
            this.bt_La2.Name = "bt_La2";
            this.bt_La2.Size = new System.Drawing.Size(56, 23);
            this.bt_La2.TabIndex = 7;
            this.bt_La2.Text = "LA2";
            this.bt_La2.UseVisualStyleBackColor = true;
            this.bt_La2.Click += new System.EventHandler(this.bt_La2_Click);
            // 
            // bt_onAll
            // 
            this.bt_onAll.Location = new System.Drawing.Point(6, 222);
            this.bt_onAll.Name = "bt_onAll";
            this.bt_onAll.Size = new System.Drawing.Size(56, 23);
            this.bt_onAll.TabIndex = 6;
            this.bt_onAll.Text = "ALL";
            this.bt_onAll.UseVisualStyleBackColor = true;
            this.bt_onAll.Click += new System.EventHandler(this.bt_onAll_Click);
            // 
            // bt_testMode
            // 
            this.bt_testMode.Location = new System.Drawing.Point(6, 48);
            this.bt_testMode.Name = "bt_testMode";
            this.bt_testMode.Size = new System.Drawing.Size(188, 23);
            this.bt_testMode.TabIndex = 5;
            this.bt_testMode.Text = "Test Mode";
            this.bt_testMode.UseVisualStyleBackColor = true;
            this.bt_testMode.Click += new System.EventHandler(this.bt_testMode_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_powerRequest);
            this.groupBox2.Controls.Add(this.bt_powerRequest);
            this.groupBox2.Controls.Add(this.tb_readTestMode);
            this.groupBox2.Controls.Add(this.bt_readTestMode);
            this.groupBox2.Controls.Add(this.tb_deviceNumber);
            this.groupBox2.Controls.Add(this.bt_deviceNumber);
            this.groupBox2.Controls.Add(this.tb_serialNumber);
            this.groupBox2.Controls.Add(this.bt_serialNumber);
            this.groupBox2.Controls.Add(this.tb_orderNumber);
            this.groupBox2.Controls.Add(this.bt_orderNumber);
            this.groupBox2.Controls.Add(this.tb_configNumber);
            this.groupBox2.Controls.Add(this.bt_configNumber);
            this.groupBox2.Controls.Add(this.tb_swVersion);
            this.groupBox2.Controls.Add(this.bt_swVersion);
            this.groupBox2.Controls.Add(this.tb_swNumber);
            this.groupBox2.Controls.Add(this.bt_swNumber);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 391);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Config";
            // 
            // tb_powerRequest
            // 
            this.tb_powerRequest.Location = new System.Drawing.Point(182, 309);
            this.tb_powerRequest.Name = "tb_powerRequest";
            this.tb_powerRequest.Size = new System.Drawing.Size(170, 20);
            this.tb_powerRequest.TabIndex = 15;
            // 
            // bt_powerRequest
            // 
            this.bt_powerRequest.Location = new System.Drawing.Point(182, 280);
            this.bt_powerRequest.Name = "bt_powerRequest";
            this.bt_powerRequest.Size = new System.Drawing.Size(170, 23);
            this.bt_powerRequest.TabIndex = 14;
            this.bt_powerRequest.Text = "Power request";
            this.bt_powerRequest.UseVisualStyleBackColor = true;
            this.bt_powerRequest.Click += new System.EventHandler(this.bt_powerRequest_Click);
            // 
            // tb_readTestMode
            // 
            this.tb_readTestMode.Location = new System.Drawing.Point(6, 309);
            this.tb_readTestMode.Name = "tb_readTestMode";
            this.tb_readTestMode.Size = new System.Drawing.Size(170, 20);
            this.tb_readTestMode.TabIndex = 13;
            // 
            // bt_readTestMode
            // 
            this.bt_readTestMode.Location = new System.Drawing.Point(6, 280);
            this.bt_readTestMode.Name = "bt_readTestMode";
            this.bt_readTestMode.Size = new System.Drawing.Size(170, 23);
            this.bt_readTestMode.TabIndex = 12;
            this.bt_readTestMode.Text = "Test Mode";
            this.bt_readTestMode.UseVisualStyleBackColor = true;
            this.bt_readTestMode.Click += new System.EventHandler(this.bt_readTestMode_Click);
            // 
            // tb_deviceNumber
            // 
            this.tb_deviceNumber.Location = new System.Drawing.Point(182, 222);
            this.tb_deviceNumber.Name = "tb_deviceNumber";
            this.tb_deviceNumber.Size = new System.Drawing.Size(170, 20);
            this.tb_deviceNumber.TabIndex = 11;
            // 
            // bt_deviceNumber
            // 
            this.bt_deviceNumber.Location = new System.Drawing.Point(182, 193);
            this.bt_deviceNumber.Name = "bt_deviceNumber";
            this.bt_deviceNumber.Size = new System.Drawing.Size(170, 23);
            this.bt_deviceNumber.TabIndex = 10;
            this.bt_deviceNumber.Text = "Read SDT And Device Number";
            this.bt_deviceNumber.UseVisualStyleBackColor = true;
            this.bt_deviceNumber.Click += new System.EventHandler(this.bt_deviceNumber_Click);
            // 
            // tb_serialNumber
            // 
            this.tb_serialNumber.Location = new System.Drawing.Point(6, 222);
            this.tb_serialNumber.Name = "tb_serialNumber";
            this.tb_serialNumber.Size = new System.Drawing.Size(170, 20);
            this.tb_serialNumber.TabIndex = 9;
            // 
            // bt_serialNumber
            // 
            this.bt_serialNumber.Location = new System.Drawing.Point(6, 193);
            this.bt_serialNumber.Name = "bt_serialNumber";
            this.bt_serialNumber.Size = new System.Drawing.Size(170, 23);
            this.bt_serialNumber.TabIndex = 8;
            this.bt_serialNumber.Text = "Read Production Serial Number";
            this.bt_serialNumber.UseVisualStyleBackColor = true;
            this.bt_serialNumber.Click += new System.EventHandler(this.bt_serialNumber_Click);
            // 
            // tb_orderNumber
            // 
            this.tb_orderNumber.Location = new System.Drawing.Point(182, 135);
            this.tb_orderNumber.Name = "tb_orderNumber";
            this.tb_orderNumber.Size = new System.Drawing.Size(170, 20);
            this.tb_orderNumber.TabIndex = 7;
            // 
            // bt_orderNumber
            // 
            this.bt_orderNumber.Location = new System.Drawing.Point(182, 106);
            this.bt_orderNumber.Name = "bt_orderNumber";
            this.bt_orderNumber.Size = new System.Drawing.Size(170, 23);
            this.bt_orderNumber.TabIndex = 6;
            this.bt_orderNumber.Text = "Read Production Order Number";
            this.bt_orderNumber.UseVisualStyleBackColor = true;
            this.bt_orderNumber.Click += new System.EventHandler(this.bt_orderNumber_Click);
            // 
            // tb_configNumber
            // 
            this.tb_configNumber.Location = new System.Drawing.Point(6, 135);
            this.tb_configNumber.Name = "tb_configNumber";
            this.tb_configNumber.Size = new System.Drawing.Size(170, 20);
            this.tb_configNumber.TabIndex = 5;
            // 
            // bt_configNumber
            // 
            this.bt_configNumber.Location = new System.Drawing.Point(6, 106);
            this.bt_configNumber.Name = "bt_configNumber";
            this.bt_configNumber.Size = new System.Drawing.Size(170, 23);
            this.bt_configNumber.TabIndex = 4;
            this.bt_configNumber.Text = "Read Configuration Number";
            this.bt_configNumber.UseVisualStyleBackColor = true;
            this.bt_configNumber.Click += new System.EventHandler(this.bt_configNumber_Click);
            // 
            // tb_swVersion
            // 
            this.tb_swVersion.Location = new System.Drawing.Point(182, 48);
            this.tb_swVersion.Name = "tb_swVersion";
            this.tb_swVersion.Size = new System.Drawing.Size(170, 20);
            this.tb_swVersion.TabIndex = 3;
            // 
            // bt_swVersion
            // 
            this.bt_swVersion.Location = new System.Drawing.Point(182, 19);
            this.bt_swVersion.Name = "bt_swVersion";
            this.bt_swVersion.Size = new System.Drawing.Size(170, 23);
            this.bt_swVersion.TabIndex = 2;
            this.bt_swVersion.Text = "Read Software Version";
            this.bt_swVersion.UseVisualStyleBackColor = true;
            this.bt_swVersion.Click += new System.EventHandler(this.bt_swVersion_Click);
            // 
            // tb_swNumber
            // 
            this.tb_swNumber.Location = new System.Drawing.Point(6, 48);
            this.tb_swNumber.Name = "tb_swNumber";
            this.tb_swNumber.Size = new System.Drawing.Size(170, 20);
            this.tb_swNumber.TabIndex = 1;
            // 
            // bt_swNumber
            // 
            this.bt_swNumber.Location = new System.Drawing.Point(6, 19);
            this.bt_swNumber.Name = "bt_swNumber";
            this.bt_swNumber.Size = new System.Drawing.Size(170, 23);
            this.bt_swNumber.TabIndex = 0;
            this.bt_swNumber.Text = "Read Software Number";
            this.bt_swNumber.UseVisualStyleBackColor = true;
            this.bt_swNumber.Click += new System.EventHandler(this.bt_swNumber_Click);
            // 
            // tm_kaypad
            // 
            this.tm_kaypad.Interval = 250;
            this.tm_kaypad.Tick += new System.EventHandler(this.tm_kaypad_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 405);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linak 10SMI Debug Cmd V1.01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.Button bt_LanOn;
        private System.Windows.Forms.Button bt_LanOff;
        private System.Windows.Forms.Button bt_La1;
        private System.Windows.Forms.Button bt_offAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_testMode;
        private System.Windows.Forms.Button bt_onAll;
        private System.Windows.Forms.TextBox tb_swNumber;
        private System.Windows.Forms.Button bt_swNumber;
        private System.Windows.Forms.Button bt_three1;
        private System.Windows.Forms.Button bt_Lb4;
        private System.Windows.Forms.Button bt_Lb3;
        private System.Windows.Forms.Button bt_Lb2;
        private System.Windows.Forms.Button bt_Lb7;
        private System.Windows.Forms.Button bt_Lb6;
        private System.Windows.Forms.Button bt_Lb5;
        private System.Windows.Forms.Button bt_Lb1;
        private System.Windows.Forms.Button bt_La7;
        private System.Windows.Forms.Button bt_La6;
        private System.Windows.Forms.Button bt_La5;
        private System.Windows.Forms.Button bt_La4;
        private System.Windows.Forms.Button bt_La3;
        private System.Windows.Forms.Button bt_La2;
        private System.Windows.Forms.TextBox tb_readKeypadB;
        private System.Windows.Forms.Button bt_stopTimerB;
        private System.Windows.Forms.Button bt_startTimerB;
        private System.Windows.Forms.TextBox tb_readKeypadA;
        private System.Windows.Forms.Button bt_stopTimerA;
        private System.Windows.Forms.Button bt_startTimerA;
        private System.Windows.Forms.TextBox tb_powerRequest;
        private System.Windows.Forms.Button bt_powerRequest;
        private System.Windows.Forms.TextBox tb_readTestMode;
        private System.Windows.Forms.Button bt_readTestMode;
        private System.Windows.Forms.TextBox tb_deviceNumber;
        private System.Windows.Forms.Button bt_deviceNumber;
        private System.Windows.Forms.TextBox tb_serialNumber;
        private System.Windows.Forms.Button bt_serialNumber;
        private System.Windows.Forms.TextBox tb_orderNumber;
        private System.Windows.Forms.Button bt_orderNumber;
        private System.Windows.Forms.TextBox tb_configNumber;
        private System.Windows.Forms.Button bt_configNumber;
        private System.Windows.Forms.TextBox tb_swVersion;
        private System.Windows.Forms.Button bt_swVersion;
        private System.Windows.Forms.Timer tm_kaypad;
    }
}

