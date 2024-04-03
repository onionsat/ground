using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnionSAT
{
    public partial class Settings : Form
    {
        static readonly string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static readonly string specificFolder = Path.Combine(folder, ".onionsat");
        static readonly string path = Path.Combine(specificFolder, "settings.txt");
        public Settings()
        {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
            if (File.Exists(path))
            {
                var settings = File.ReadLines(path);
                string serial;
                string api_key;
                string api_endpoint;

                // iterate through each element within the array and
                // print it out
                //
                foreach (var lineRead in settings)
                {
                    if (lineRead.Contains("serial="))
                    {
                        serial = lineRead.Replace("serial=", "");
                        comboBox1.Text = serial;
                    }
                    else if (lineRead.Contains("api_key="))
                    {
                        api_key = lineRead.Replace("api_key=", "");
                        textBox2.Text = api_key;
                    }
                    else if (lineRead.Contains("api_endpoint="))
                    {
                        api_endpoint = lineRead.Replace("api_endpoint=", "");
                        textBox1.Text = api_endpoint;

                    }
                }
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Directory.CreateDirectory(specificFolder);

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write("serial=" + comboBox1.Text + "\napi_endpoint=" + textBox1.Text + "\napi_key=" + textBox2.Text + "");
                sw.Close();
            }

            MessageBox.Show("Successful save.");
            this.Close();
        }
    }
}
