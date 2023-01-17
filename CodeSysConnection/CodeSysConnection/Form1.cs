using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using System.Threading;

namespace CodeSysConnection
{
    public partial class Form1 : Form
    {
        ModbusClient client = new ModbusClient();
        private Thread tRead;
        private Thread tWrite;
        private Thread tAlwaysRunning;
        int second;

        public void AlwaysRunning()
        {
            while (true)
            {
                if (client.Connected == false)
                {
                    //
                }
            }

        }
        public void Read()
        {
            int[] readInputRegisters;

            if (client.Connected == true)
            {
                readInputRegisters = client.ReadInputRegisters(0, 10);

                string[] QW = new string[10];

                for (int i = 0; i < 10; i++)
                {
                    QW[i] = readInputRegisters[i].ToString();
                }
                inputW1.Text = QW[0];
                inputW2.Text = QW[1];
                inputW3.Text = QW[2];
                inputW4.Text = QW[3];
                inputW5.Text = QW[4];
                inputW6.Text = QW[5];
                inputW7.Text = QW[6];
                inputW8.Text = QW[7];
                inputW9.Text = QW[8];
                inputW10.Text = QW[9];
            }

        }
        public void Write()
        {
            try
            {
                if (client.Connected == true)
                {
                    int[] writevalues = new int[]
                    {
                    Convert.ToInt32(holdingW1.Text),
                    Convert.ToInt32(holdingW2.Text),
                    Convert.ToInt32(holdingW3.Text),
                    Convert.ToInt32(holdingW4.Text),
                    Convert.ToInt32(holdingW5.Text),
                    Convert.ToInt32(holdingW6.Text),
                    Convert.ToInt32(holdingW7.Text),
                    Convert.ToInt32(holdingW8.Text),
                    Convert.ToInt32(holdingW9.Text),
                    Convert.ToInt32(holdingW10.Text),
                    };

                    client.WriteMultipleRegisters(0, writevalues);

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
        public void Listen()
        {
            client.IPAddress = txtIp.Text;
            client.Port = Convert.ToInt32(txtPort.Text);

            tRead = new Thread(new ThreadStart(Read));
            tWrite = new Thread(new ThreadStart(Write));

            tRead.Start();
            tWrite.Start();

            if (client.Connected == false)
            {
                try
                {
                    client.Connect();
                }
                catch (Exception err)
                {
                    txtStatus.Text = err.Message;
                }
                finally
                {
                    if (client.Connected == true)
                    {
                        txtStatus.Text = "Connection Successfull - IP: " + client.IPAddress + " - PORT: " + client.Port;
                    }
                }
            }
        }
        public void Stoplistening()
        {
            if (tRead.IsAlive == true)
            {
                tRead.Abort();
            }


            if (tWrite.IsAlive == true)
            {
                tRead.Abort();
            }

            client.Disconnect();

        }

        public Form1()
        {
            InitializeComponent();
            tAlwaysRunning = new Thread(new ThreadStart(AlwaysRunning));
            tAlwaysRunning.Start();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            timerConnection.Start();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Listen();

            timer1.Interval = 250;
            timer1.Start();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Stoplistening();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (client.Connected == true)
            {
                Read();
                Write();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            second++;
            if (second % 2 == 0)
            {
                txtStatus.ForeColor = Color.Lime;
            }
            else
                txtStatus.ForeColor = Color.Yellow;
            if (second % 10 == 0)
            {
                timer2.Stop();
                second = 0;
            }
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timerConnection_Tick(object sender, EventArgs e)
        {
            if (client.Connected == true)
            {
                lblStatus.Text = "✔";
                lblStatus.ForeColor = Color.Lime;
            }
            else
            {
                lblStatus.Text = "❌";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            timerConnection.Stop();
        }

    }
}
