using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnionSAT
{
    public partial class lorasettings : Form
    {
        static readonly string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static readonly string specificFolder = Path.Combine(folder, ".onionsat");
        static readonly string path = Path.Combine(specificFolder, "settings.txt");
        String Filepath = "";
        static readonly string Errorpath = Path.Combine(specificFolder, "error.txt");
        String Apikey = "", Apiendpoint = "";
        public SerialPort serialPort = new("COM1");

        public lorasettings()
        {
            InitializeComponent();
        }

        public void updateLora(string newText, int loraloadcounter)
        {
            if (loraloadcounter == 1)
            {
                label1.Text = newText;
            }
            else if (loraloadcounter == 2)
            {
                textBox1.Text = newText;
            }
            else if (loraloadcounter == 3)
            {
                textBox2.Text = newText;
            }
            else if (loraloadcounter == 4)
            {
                textBox3.Text = newText;
            }
            else if (loraloadcounter == 5)
            {
                textBox4.Text = newText;
            }
            else if (loraloadcounter == 6)
            {
                textBox5.Text = newText;
            }
            else if (loraloadcounter == 7)
            {
                textBox6.Text = newText;
            }
            else if (loraloadcounter == 8)
            {
                textBox7.Text = newText;
            }
            else if (loraloadcounter == 9)
            {
                textBox8.Text = newText;
            }
        }

        private void lorasettings_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    //userClosed = false;
                    string serial = "COM8";

                    var settings = File.ReadLines(path);

                    foreach (var lineRead in settings)
                    {
                        if (lineRead.Contains("serial="))
                        {
                            serial = lineRead.Replace("serial=", "");
                        }
                    }

                    serialPort = new(serial, 115384)
                    {
                        DtrEnable = true
                    };

                    serialPort.Open();
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceived_Lora);
                    //serialPort.ErrorReceived += new SerialErrorReceivedEventHandler(Port_ErrorReceived_Lora);

                    serialPort.WriteLine("radio set mod " + textBox1.Text + "\r\n");
                    Thread.Sleep(100);
                    serialPort.WriteLine("radio set freq " + textBox2.Text + "\r\n");
                    Thread.Sleep(100);
                    serialPort.WriteLine("radio set pwr " + textBox3.Text + "\r\n");
                    Thread.Sleep(100);

                    serialPort.Close();
                }
                else
                {
                    MessageBox.Show("Kérlek állítsd le a kapcsolatot a LoRa beállítások szerkesztése előtt.", "Hiba történt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Kapcsolódási hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Port_DataReceived_Lora(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort comm = (SerialPort)sender;
                if (comm.IsOpen)
                {
                    String rawdata = comm.ReadLine().Replace("\r", "").Replace("\n", "");

                    MessageBox.Show(rawdata);
                }
            }
            catch (Exception ex)
            {
                try
                {
                    //Port_ErrorReceived(null, null);
                    //var Tstamp = GetTimestamp(DateTime.Now);
                    //if (Errorpath != "")
                    //{
                    //    File.AppendAllText(Errorpath, Tstamp + " -> " + ex.ToString() + Environment.NewLine);
                    //}
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.ToString(), "Hiba kezelése sikertelen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
