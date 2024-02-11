using Newtonsoft.Json.Linq;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnionSAT
{
    public partial class lorasettings : Form
    {
        static readonly string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static readonly string specificFolder = Path.Combine(folder, ".onionsat");
        static readonly string path = Path.Combine(specificFolder, "settings.txt");
        static readonly string csatpath = Path.Combine(specificFolder, "settings.csat");
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
            else if (loraloadcounter == 10)
            {
                textBox9.Text = newText;
            }
        }

        private void lorasettings_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        int lorasavecounter = 0, retrycounter = 0;

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

                    serialPort.WriteLine("radio set pa " + textBox9.Text + "\r\n");
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
                    Thread.Sleep(50);
                    String rawdata = comm.ReadLine().Replace("\r", "").Replace("\n", "");
                    if (rawdata == "ok")
                    {
                        lorasavecounter++;
                        retrycounter = 0;
                    }
                    else
                    {
                        retrycounter++;
                        if (retrycounter > 5)
                        {
                            MessageBox.Show("Az " + lorasavecounter + ". érték beállítása sikertelen volt. (" + rawdata + ")");
                            lorasavecounter++;
                            retrycounter = 0;
                        }
                    }

                    if (lorasavecounter == 1)
                    {
                        comm.WriteLine("radio set pa " + textBox9.Text + "\r\n");
                    }
                    else if (lorasavecounter == 2)
                    {
                        comm.WriteLine("radio set mod " + textBox1.Text + "\r\n");
                    }
                    else if (lorasavecounter == 3)
                    {
                        comm.WriteLine("radio set freq " + textBox2.Text + "\r\n");
                    }
                    else if (lorasavecounter == 4)
                    {
                        comm.WriteLine("radio set pwr " + textBox3.Text + "\r\n");
                    }
                    else if (lorasavecounter == 5)
                    {
                        comm.WriteLine("radio set sf " + textBox4.Text + "\r\n");
                    }
                    else if (lorasavecounter == 6)
                    {
                        comm.WriteLine("radio set crc " + textBox5.Text + "\r\n");
                    }
                    else if (lorasavecounter == 7)
                    {
                        comm.WriteLine("radio set cr " + textBox6.Text + "\r\n");
                    }
                    else if (lorasavecounter == 8)
                    {
                        comm.WriteLine("radio set bw " + textBox7.Text + "\r\n");
                    }
                    else if (lorasavecounter == 9)
                    {
                        comm.WriteLine("radio set sync " + textBox8.Text + "\r\n");
                    }
                    else if (lorasavecounter == 10)
                    {
                        comm.Close();
                        MessageBox.Show("Sikeres mentés!");
                        lorasavecounter = 1;
                        retrycounter = 0;
                    }
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.CreateText(csatpath))
            {
                sw.Write("lora_mod=" + textBox1.Text + "\nlora_freq=" + textBox2.Text + "\nlora_pwr=" + textBox3.Text + "\nlora_sf=" + textBox4.Text + "\nlora_crc=" + textBox5.Text + "\nlora_cr=" + textBox6.Text + "\nlora_bw=" + textBox7.Text + "\nlora_sync=" + textBox8.Text + "\nlora_pa=" + textBox9.Text + "");
                sw.Close();
            }

            MessageBox.Show("Sikeres mentés!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var settings = File.ReadLines(csatpath);

            foreach (var lineRead in settings)
            {
                if (lineRead.Contains("lora_mod="))
                {
                    textBox1.Text = lineRead.Replace("lora_mod=", "");
                }
                else if (lineRead.Contains("lora_freq="))
                {
                    textBox2.Text = lineRead.Replace("lora_freq=", "");
                }
                else if (lineRead.Contains("lora_pwr="))
                {
                    textBox3.Text = lineRead.Replace("lora_pwr=", "");
                }
                else if (lineRead.Contains("lora_sf="))
                {
                    textBox4.Text = lineRead.Replace("lora_sf=", "");
                }
                else if (lineRead.Contains("lora_crc="))
                {
                    textBox5.Text = lineRead.Replace("lora_crc=", "");
                }
                else if (lineRead.Contains("lora_cr="))
                {
                    textBox6.Text = lineRead.Replace("lora_cr=", "");
                }
                else if (lineRead.Contains("lora_bw="))
                {
                    textBox7.Text = lineRead.Replace("lora_bw=", "");
                }
                else if (lineRead.Contains("lora_sync="))
                {
                    textBox8.Text = lineRead.Replace("lora_sync=", "");
                }
                else if (lineRead.Contains("lora_pa="))
                {
                    textBox9.Text = lineRead.Replace("lora_pa=", "");
                }
            }
        }
    }
}
