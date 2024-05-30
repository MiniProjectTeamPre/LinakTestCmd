using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinakTestCmd {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public Global global = new Global();
        public static Client client = new Client();

        #region =============================================== Event ===============================================
        private void Form1_Load(object sender, EventArgs e) {

        }
        private void bt_connect_Click(object sender, EventArgs e) {
            try {
                client.Connect();
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
            } catch { }
        }
        private void bt_LanOn_Click(object sender, EventArgs e) {
            byte[] byteSup = Encoding.ASCII.GetBytes("161");
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_LanOff_Click(object sender, EventArgs e) {
            byte[] byteSup = Encoding.ASCII.GetBytes("162");
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_testMode_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x15);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_La1_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_La2_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x02);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_La3_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x04);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_La4_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x08);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_La5_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x10);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_La6_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x20);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_La7_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x40);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_Lb1_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_Lb5_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x10);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_Lb6_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x20);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_Lb7_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x40);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_Lb2_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x02);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_Lb3_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x04);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_Lb4_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x08);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_three1_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x70);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_onAll_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x7F);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_offAll_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);
            data += ByteToBinaryString(0x80 + 0x16);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("101");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);
        }
        private void bt_swNumber_Click(object sender, EventArgs e) {
            string data = string.Empty;
            data += ByteToBinaryString(0x0B);

            data += ByteToBinaryString(0x00);

            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("103");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);

            byte[] receive = new byte[1];
            try {
                receive = client.udpClient.Receive(ref client.iPEndPoint);
            } catch {
                tb_swNumber.Text = "ReadError";
                return;
            }

            string resultData = Encoding.ASCII.GetString(receive);
            ////////////////////////////////////////////////////////////////////////////////
            data = string.Empty;
            data += ByteToBinaryString(0x0B);

            data += ByteToBinaryString(0x01);

            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byteSup = Encoding.ASCII.GetBytes("103");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);

            try {
                receive = client.udpClient.Receive(ref client.iPEndPoint);
            } catch {
                tb_swNumber.Text = "ReadError";
                return;
            }

            string resultData2 = Encoding.ASCII.GetString(receive);
            string finalResult = "SW0" + Convert.ToInt32(resultData2 + resultData, 2).ToString();
            tb_swNumber.Text = finalResult;
        }
        private void bt_swVersion_Click(object sender, EventArgs e) {
            string data = string.Empty;
            data += ByteToBinaryString(0x0B);

            data += ByteToBinaryString(0x02);

            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("103");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);

            byte[] receive = new byte[1];
            try {
                receive = client.udpClient.Receive(ref client.iPEndPoint);
            } catch {
                tb_swVersion.Text = "ReadError";
                return;
            }

            string resultData = Encoding.ASCII.GetString(receive);
            ////////////////////////////////////////////////////////////////////////////////
            data = string.Empty;
            data += ByteToBinaryString(0x0B);

            data += ByteToBinaryString(0x03);

            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byteSup = Encoding.ASCII.GetBytes("103");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);

            try {
                receive = client.udpClient.Receive(ref client.iPEndPoint);
            } catch {
                tb_swVersion.Text = "ReadError";
                return;
            }

            string resultData2 = Encoding.ASCII.GetString(receive);
            string finalResultSup = Convert.ToInt32(resultData2 + resultData, 2).ToString();
            ////////////////////////////////////////////////////////////////////////////////
            data = string.Empty;
            data += ByteToBinaryString(0x0B);

            data += ByteToBinaryString(0x04);

            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byteSup = Encoding.ASCII.GetBytes("103");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);

            receive = new byte[1];
            try {
                receive = client.udpClient.Receive(ref client.iPEndPoint);
            } catch {
                tb_swVersion.Text = "ReadError";
                return;
            }

            resultData = Encoding.ASCII.GetString(receive);
            ////////////////////////////////////////////////////////////////////////////////
            data = string.Empty;
            data += ByteToBinaryString(0x0B);

            data += ByteToBinaryString(0x05);

            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byteSup = Encoding.ASCII.GetBytes("103");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);

            try {
                receive = client.udpClient.Receive(ref client.iPEndPoint);
            } catch {
                tb_swVersion.Text = "ReadError";
                return;
            }

            resultData2 = Encoding.ASCII.GetString(receive);
            string finalResultSup2 = Convert.ToInt32(resultData2 + resultData, 2).ToString();
            string finalResult = "V" + finalResultSup + "." + finalResultSup2;
            tb_swVersion.Text = finalResult;
        }
        private void bt_configNumber_Click(object sender, EventArgs e) {
            string data = string.Empty;
            data += ByteToBinaryString(0x0B);

            data += ByteToBinaryString(0x08);

            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("103");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);

            byte[] receive = new byte[1];
            try {
                receive = client.udpClient.Receive(ref client.iPEndPoint);
            } catch {
                tb_configNumber.Text = "ReadError";
                return;
            }

            string resultSup = Encoding.ASCII.GetString(receive);
            string resultSup2 = resultSup.Substring(0, resultSup.Length - 4);
            string result = "C" + Convert.ToInt32(resultSup2, 2).ToString();
            tb_configNumber.Text = result;
        }
        private void bt_orderNumber_Click(object sender, EventArgs e) {
            string data = string.Empty;
            data += ByteToBinaryString(0x0B);

            data += ByteToBinaryString(0x09);

            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("103");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);

            byte[] receive = new byte[1];
            try {
                receive = client.udpClient.Receive(ref client.iPEndPoint);
            } catch {
                tb_orderNumber.Text = "ReadError";
                return;
            }

            string resultData = Encoding.ASCII.GetString(receive);
            ////////////////////////////////////////////////////////////////////////////////
            data = string.Empty;
            data += ByteToBinaryString(0x0B);

            data += ByteToBinaryString(0x0A);

            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byteSup = Encoding.ASCII.GetBytes("103");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);

            try {
                receive = client.udpClient.Receive(ref client.iPEndPoint);
            } catch {
                tb_orderNumber.Text = "ReadError";
                return;
            }

            string resultData2 = Encoding.ASCII.GetString(receive);
            string finalResult = Convert.ToInt64(resultData2 + resultData, 2).ToString();
            tb_orderNumber.Text = finalResult;
        }
        private void bt_serialNumber_Click(object sender, EventArgs e) {
            string data = string.Empty;
            data += ByteToBinaryString(0x0B);

            data += ByteToBinaryString(0x0B);

            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("103");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);

            byte[] receive = new byte[1];
            try {
                receive = client.udpClient.Receive(ref client.iPEndPoint);
            } catch {
                tb_serialNumber.Text = "ReadError";
                return;
            }

            string resultSup = Encoding.ASCII.GetString(receive);
            string result = Convert.ToInt32(resultSup, 2).ToString();
            tb_serialNumber.Text = result;
        }
        private void bt_deviceNumber_Click(object sender, EventArgs e) {
            string data = string.Empty;
            data += ByteToBinaryString(0x0B);

            data += ByteToBinaryString(0x10);

            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("103");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);

            byte[] receive = new byte[1];
            try {
                receive = client.udpClient.Receive(ref client.iPEndPoint);
            } catch {
                tb_deviceNumber.Text = "ReadError";
                return;
            }

            string receiveSup = Encoding.ASCII.GetString(receive);
            receiveSup = receiveSup.Substring(8, receiveSup.Length - 8); ;
            string result = Convert.ToInt32(receiveSup, 2).ToString("X2");
            tb_deviceNumber.Text = result;
        }
        private void bt_readTestMode_Click(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);

            data += ByteToBinaryString(0x14);

            data += ByteToBinaryString(0x01);
            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("103");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);

            byte[] receive = new byte[1];
            try {
                receive = client.udpClient.Receive(ref client.iPEndPoint);
            } catch {
                tb_readTestMode.Text = "ReadError";
                return;
            }

            string receiveSup = Encoding.ASCII.GetString(receive);
            receiveSup = receiveSup.Substring(8, receiveSup.Length - 8); ;
            string result = Convert.ToInt32(receiveSup, 2).ToString();
            tb_readTestMode.Text = result;
        }
        private void bt_powerRequest_Click(object sender, EventArgs e) {
            byte[] byteSup = Encoding.ASCII.GetBytes("140");
            client.udpClient.Send(byteSup, byteSup.Length);

            byte[] receive = new byte[1];
            try {
                receive = client.udpClient.Receive(ref client.iPEndPoint);
            } catch {
                tb_readTestMode.Text = "ReadError";
                return;
            }

            string receiveSup = Encoding.ASCII.GetString(receive);
            tb_powerRequest.Text = receiveSup;
        }

        private void bt_startTimerA_Click(object sender, EventArgs e) {
            try {
                tm_kaypad.Stop();
                tb_readKeypadB.Text = string.Empty;
            } catch { }

            global.key = 0x12;
            tm_kaypad.Start();
        }
        private void bt_stopTimerA_Click(object sender, EventArgs e) {
            tm_kaypad.Stop();
            tb_readKeypadA.Text = string.Empty;
        }
        private void bt_startTimerB_Click(object sender, EventArgs e) {
            try {
                tm_kaypad.Stop();
                tb_readKeypadA.Text = string.Empty;
            } catch { }

            global.key = 0x13;
            tm_kaypad.Start();
        }
        private void bt_stopTimerB_Click(object sender, EventArgs e) {
            tm_kaypad.Stop();
            tb_readKeypadB.Text = string.Empty;
        }
        private void tm_kaypad_Tick(object sender, EventArgs e) {
            string data = string.Empty;

            data += ByteToBinaryString(0x0B);

            data += ByteToBinaryString(global.key);
            data += ByteToBinaryString(0x01);

            data += ByteToBinaryString(0x00);
            data += ByteToBinaryString(0xFF);

            byte[] byteSup = Encoding.ASCII.GetBytes("103");
            client.udpClient.Send(byteSup, byteSup.Length);
            byteSup = Encoding.ASCII.GetBytes("0000" + data);
            client.udpClient.Send(byteSup, byteSup.Length);

            byte[] receive = new byte[1];
            try {
                receive = client.udpClient.Receive(ref client.iPEndPoint);
            } catch {
                tb_deviceNumber.Text = "ReadError";
                return;
            }

            string receiveSup = Encoding.ASCII.GetString(receive);

            if (global.key == 0x12) {
                string keySup = "0";
                switch (receiveSup) {
                    case "0000000000000001": keySup = "KA1"; break;
                    case "0000000000000010": keySup = "KA2"; break;
                    case "0000000000000100": keySup = "KA3"; break;
                    case "0000000000001000": keySup = "KA4"; break;
                    case "0000000000010000": keySup = "KA5"; break;
                    case "0000000000100000": keySup = "KA6"; break;
                    case "0000000001000000": keySup = "KA7"; break;
                    case "0000000010000000": keySup = "KA8"; break;
                    case "0000000100000000": keySup = "KA9"; break;
                    case "0000001000000000": keySup = "KA10"; break;
                    case "0000010000000000": keySup = "KA11"; break;
                    case "0000100000000000": keySup = "KA12"; break;
                    case "0001000000000000": keySup = "KA13"; break;
                    case "0010000000000000": keySup = "KA14"; break;
                    default: break;
                }
                tb_readKeypadA.Text = keySup;

            } else {
                string keySup = "0";
                switch (receiveSup) {
                    case "0000000000000001": keySup = "KB1"; break;
                    case "0000000000000010": keySup = "KB2"; break;
                    case "0000000000000100": keySup = "KB3"; break;
                    case "0000000000001000": keySup = "KB4"; break;
                    case "0000000000010000": keySup = "KB5"; break;
                    case "0000000000100000": keySup = "KB6"; break;
                    case "0000000001000000": keySup = "KB7"; break;
                    case "0000000010000000": keySup = "KB8"; break;
                    case "0000000100000000": keySup = "KB9"; break;
                    case "0000001000000000": keySup = "KB10"; break;
                    default: break;
                }
                tb_readKeypadB.Text = keySup;
            }
        }
        #endregion

        #region =============================================== function ===============================================
        private string ByteToBinaryString(byte data) {
            string result = string.Empty;

            for (int i = 7; i >= 0; i--) {
                result += (data & (1 << i)) == 0 ? "0" : "1";
            }

            return result;
        }
        #endregion
    }

    public class NetworkManagement {
        public void setIP(string ip_address, string subnet_mask) {
            ManagementClass objMC =
              new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC) {
                if ((bool)objMO["IPEnabled"]) {
                    ManagementBaseObject setIP;
                    ManagementBaseObject newIP =
                      objMO.GetMethodParameters("EnableStatic");

                    newIP["IPAddress"] = new string[] { ip_address };
                    newIP["SubnetMask"] = new string[] { subnet_mask };

                    setIP = objMO.InvokeMethod("EnableStatic", newIP, null);
                }
            }
        }
        public void setGateway(string gateway) {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC) {
                if ((bool)objMO["IPEnabled"]) {
                    ManagementBaseObject setGateway;
                    ManagementBaseObject newGateway =
                      objMO.GetMethodParameters("SetGateways");

                    newGateway["DefaultIPGateway"] = new string[] { gateway };
                    newGateway["GatewayCostMetric"] = new int[] { 1 };

                    setGateway = objMO.InvokeMethod("SetGateways", newGateway, null);
                }
            }
        }
        public void setDNS(string NIC, string DNS) {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC) {
                if ((bool)objMO["IPEnabled"]) {
                    // if you are using the System.Net.NetworkInformation.NetworkInterface
                    // you'll need to change this line to
                    // if (objMO["Caption"].ToString().Contains(NIC))
                    // and pass in the Description property instead of the name 
                    if (objMO["Caption"].Equals(NIC)) {
                        ManagementBaseObject newDNS =
                          objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        newDNS["DNSServerSearchOrder"] = DNS.Split(',');
                        ManagementBaseObject setDNS =
                          objMO.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                    }
                }
            }
        }
        public void setWINS(string NIC, string priWINS, string secWINS) {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC) {
                if ((bool)objMO["IPEnabled"]) {
                    if (objMO["Caption"].Equals(NIC)) {
                        ManagementBaseObject setWINS;
                        ManagementBaseObject wins =
                        objMO.GetMethodParameters("SetWINSServer");
                        wins.SetPropertyValue("WINSPrimaryServer", priWINS);
                        wins.SetPropertyValue("WINSSecondaryServer", secWINS);

                        setWINS = objMO.InvokeMethod("SetWINSServer", wins, null);
                    }
                }
            }
        }
    }
    public class Global {
        public byte key { get; set; }

        public Global() {

        }
    }
    public class Client {
        public UdpClient udpClient { get; set; }
        public IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);

        public Client() {
            udpClient = new UdpClient(8080);
            udpClient.Client.SendTimeout = 2500;
            udpClient.Client.ReceiveTimeout = 2500;
        }
        public void Connect() {
            udpClient.Connect("10.10.10.32", 8080);
        }
    }
}
