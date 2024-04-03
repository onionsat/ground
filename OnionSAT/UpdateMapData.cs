using AltoHttp;
using GMap.NET.MapProviders;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Media.Protection.PlayReady;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnionSAT
{
    public partial class UpdateMapData : Form
    {
        public UpdateMapData()
        {
            InitializeComponent();
        }

        HttpDownloader httpDownloader;
        static readonly string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static readonly string specificFolder = Path.Combine(folder, ".onionsat");
        static readonly String Errorpath = Path.Combine(specificFolder, "error.txt");
        static readonly string path2 = Path.Combine(specificFolder, "map");
        static readonly string path3 = Path.Combine(path2, "TileDBv5");
        static readonly string path4 = Path.Combine(path3, "en");
        static readonly string path5 = Path.Combine(path4, "Data.gmdb");
        private static readonly HttpClient client = new();

        int downloading = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (downloading == 0)
                {
                  Main Main = new Main();
                  Main.Close();
    
                  httpDownloader = new HttpDownloader("https://sat.onionsat.com/Data.gmdb", path5);
                  httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
                   httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
                   httpDownloader.Start();
                   button1.Text = "Downloading...";
                   button1.UseWaitCursor = true;
                    button1.Enabled = false;
                    downloading = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "An error ocurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    var Tstamp = GetTimestamp(DateTime.Now);
                    if (Errorpath != "")
                    {
                        File.AppendAllText(Errorpath, Tstamp + " -> " + ex.ToString() + Environment.NewLine);
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.ToString(), "Error handling failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HttpDownloader_ProgressChanged(object? sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar1.Value = (int)(e.Progress);
        }

        private async void HttpDownloader_DownloadCompleted(object? sender, EventArgs e)
        {
            var response = await client.GetAsync("https://sat.onionsat.com/mapIntegrityCheck");
            var responseString = await response.Content.ReadAsStringAsync();
            long x = Int64.Parse(responseString);
            long size = new System.IO.FileInfo(path5).Length;
            BeginInvoke(new Action(() =>
            {
                button1.Text = "Restart download";
                button1.UseWaitCursor = false;
                button1.Enabled = true;
            }));
            downloading = 0;

            if (x == size)
            {
                MessageBox.Show("Successful download!", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("File integrity check failed!\n(Size on server: " + responseString + " bytes)\n(Local size: " + size + " bytes)", "Download", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await client.GetAsync("https://sat.onionsat.com/mapIntegrityCheck");
                var responseString = await response.Content.ReadAsStringAsync();
                long x = Int64.Parse(responseString);
                long size = new System.IO.FileInfo(path5).Length;

                if (x == size)
                {
                    MessageBox.Show("File integrity check succeeded!\n(Size on server: " + responseString + " bytes)\n(Local size: " + size + " bytes)", "File integrity check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("File integrity check failed!\n(Size on server: " + responseString + " bytes)\n(Local size: " + size + " bytes)", "File integrity check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("File integrity check failed!\nThe server is not reachable.", "File integrity check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    var Tstamp = GetTimestamp(DateTime.Now);
                    if (Errorpath != "")
                    {
                        File.AppendAllText(Errorpath, Tstamp + " -> " + ex.ToString() + Environment.NewLine);
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.ToString(), "Error handling failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy-MM-dd HH-mm-ss.ffff");
        }

        private void UpdateMapData_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(httpDownloader != null)
                {
                    httpDownloader.Pause();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    var Tstamp = GetTimestamp(DateTime.Now);
                    if (Errorpath != "")
                    {
                        File.AppendAllText(Errorpath, Tstamp + " -> " + ex.ToString() + Environment.NewLine);
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.ToString(), "Error handling failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
