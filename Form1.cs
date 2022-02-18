using System;
using System.IO;
using System.IO.Ports;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using Microsoft.Win32;


namespace moParctronic
{
    public partial class Form1 : Form
    {

        private RegistryKey registry;
        private SerialPort serial = new SerialPort();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            registry = Registry.CurrentUser.CreateSubKey("SOFTWARE\\mo\\parctronic");

            comRefresh_Scan();

            fileName.Text = registry.GetValue("fileName", "").ToString();

            parkRoll = System.Convert.ToDouble(registry.GetValue("roll", 0));
            parkPitch = System.Convert.ToDouble(registry.GetValue("pitch", 0));
            parkYaw = System.Convert.ToDouble(registry.GetValue("yaw", 0));

            parkData.Text =
                "r=" + parkRoll.ToString() + ", " +
                "p=" + parkPitch.ToString() + ", " +
                "y=" + parkYaw.ToString();

        }

        /// <summary>
        /// Сканирование доступных ком-портов. Установка ранее выбранного из регистри
        /// </summary>
        private void comRefresh_Scan()
        {
            comboBoxComPort.Items.Clear();
            comboBoxComPort.Items.AddRange(SerialPort.GetPortNames());

            string com = registry.GetValue("COM", "").ToString();

            if (comboBoxComPort.Items.Contains(com))
            {
                comboBoxComPort.SelectedItem = com;
            }
        }


        private void serialConnect()
        {
            try
            {
                if (serial.IsOpen)
                {
                    serial.Close();
                    serial.Dispose();
                }

                if (!serial.IsOpen)
                {
                    serial.PortName = comboBoxComPort.SelectedItem.ToString();
                    serial.BaudRate = 115200;
                    serial.Parity = Parity.None;
                    serial.StopBits = StopBits.One;
                    serial.DataBits = 8;
                    serial.ReadTimeout = 1500;
                    serial.WriteTimeout = 500;
                    serial.DtrEnable = false;
                    serial.RtsEnable = false;
                    serial.DataReceived += new SerialDataReceivedEventHandler(serial_DataReceived);

                    serial.Open();
                    
                    timer1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не могу подключиться к COM-порту: " + registry.GetValue("COM", "").ToString(), "Ошибка подключения", MessageBoxButtons.OK);
            }
        }


        private string serialLine = "";


        /// <summary>
        /// Получатель данных из ком-порта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            do {

                char ch = (char)serial.ReadByte();
                serialLine += ch;

                if (ch == 13)
                {
                    //"t=29.40,r=51.75,p=10.32,y=-11\r"
                    string[] vars = serialLine.Split(',');

                    if (vars.Length == 4)
                    {
                        try
                        {
                            if (vars[0].Split('=').Length == 2)
                            {
                                temp.BeginInvoke((MethodInvoker)(() =>
                                    temp.Text = Math.Round(System.Convert.ToDouble((vars[0].Split('='))[1])).ToString()
                                ));
                            }

                            if (vars[1].Split('=').Length == 2)
                            {
                                roll.BeginInvoke((MethodInvoker)(() =>
                                    roll.Text = Math.Round(System.Convert.ToDouble((vars[1].Split('='))[1])).ToString()
                                ));
                            }

                            if (vars[2].Split('=').Length == 2)
                            {
                                pitch.BeginInvoke((MethodInvoker)(() =>
                                    pitch.Text = Math.Round(System.Convert.ToDouble((vars[2].Split('='))[1])).ToString()
                                ));
                            }

                            if (vars[3].Split('=').Length == 2)
                            {
                                yaw.BeginInvoke((MethodInvoker)(() =>
                                    yaw.Text = Math.Round(System.Convert.ToDouble((vars[3].Split('='))[1])).ToString()
                                ));
                            }
                        }
                        catch (Exception ex)
                        {
                            // если из ком-порта пришёл мусор ... то и плевать пока
                        }

                        if (parkRoll != -999)
                        {
                            if (
                                near(roll.Text, parkRoll) &&
                                near(pitch.Text, parkPitch) &&
                                near(yaw.Text, parkYaw)
                                )
                            {
                                parkPanel.BackColor = System.Drawing.Color.Green;
                                notifyIcon1.Text = "moПарктроник - парипаркован";
                                notifyIcon1.Icon = this.Icon;
                            }
                            else 
                            {
                                parkPanel.BackColor = System.Drawing.Color.Red;
                                notifyIcon1.Text = "moПарктроник";
                                notifyIcon1.Icon = moParctronic.Properties.Resources.red;
                            }
                        }
                    }

                    serialLine = "";
                }

            } while (serial.BytesToRead > 0);
        }


        private bool near(string a, double b)
        {

            try
            {
                double aa = System.Convert.ToDouble(a);

                return ((aa + parkGap >= b) && (aa - parkGap <= b));
            }
            catch (Exception ex)
            {
                return false;
            }
        }

//        private double roll, pitch, yaw, temp;

        private double parkRoll = -999, parkPitch, parkYaw;

        private void comboBoxComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            registry.SetValue("COM", comboBoxComPort.SelectedItem);

            serialConnect();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            comRefresh_Scan();
        }

        private void parkButton_Click(object sender, EventArgs e)
        {
            parkData.Text =
                "r=" + roll.Text + ", " +
                "p=" + pitch.Text + ", " +
                "y=" + yaw.Text;

            parkRoll = System.Convert.ToDouble(roll.Text);
            parkPitch = System.Convert.ToDouble(pitch.Text);
            parkYaw = System.Convert.ToDouble(yaw.Text);

            registry.SetValue("roll", roll.Text);
            registry.SetValue("pitch", pitch.Text);
            registry.SetValue("yaw", yaw.Text);
        }

        double parkGap = 1;

        private void parkGapSlider_Scroll(object sender, EventArgs e)
        {
            parkGap = parkGapSlider.Value;
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = fileName.Text;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName.Text = openFileDialog1.FileName;
            }

            registry.SetValue("fileName", fileName.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fileName.Text == "")
            {
                return;
            }

            DateTime dt = DateTime.Now;

            File.WriteAllText(
                fileName.Text,
                "{\"date\":\""+ dt.ToString() +"\",\"park\":"+
                ((parkPanel.BackColor == System.Drawing.Color.Green) ? "true" : "false") +
                "}");
        }

        private void fileName_TextChanged(object sender, EventArgs e)
        {
            registry.SetValue("fileName", fileName.Text);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
            }

            this.ShowInTaskbar = false;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            // Activate the form.
            this.Activate();
            this.ShowInTaskbar = true;

            notifyIcon1.Visible = false;
        }

    }
}
