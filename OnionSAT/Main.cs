using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO.Ports;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using OxyPlot.Series;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.WindowsForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using OxyPlot.Annotations;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;
using System.Timers;
using System.Threading;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Text;
using Windows.Devices.Radios;

namespace OnionSAT
{
    public partial class Main : Form
    {
        static readonly string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static readonly string specificFolder = Path.Combine(folder, ".onionsat");
        static readonly string path = Path.Combine(specificFolder, "settings.txt");
        String Filepath = "";
        static readonly String Errorpath = Path.Combine(specificFolder, "error.txt");
        String Apikey = "", Apiendpoint = "";
        private LineSeries temperatureSeries, temperatureSeries2, temperatureSeries3, humiditySeries, humiditySeries2, humiditySeries3, pressureSeries, pressureSeries2, pressureSeries3, accelerationSeries, accelerationRealSeries, accelerationRealSeries2, accelerationRealSeries3, gyroSeries, gyroSeries2, gyroSeries3, accelerationSeries2, accelerationSeries3, metanSeries, co2Series;
        private static readonly HttpClient client = new();
        PlotModel plotModel, plotModel2, plotModel3, plotModel4, plotModel5, plotModel6, metanModel, co2Model;
        static readonly string csatpath = Path.Combine(specificFolder, "settings.csat");
        public SerialPort serialPort = new("COM1");
        String lora_mod, lora_freq, lora_pwr, lora_sf, lora_crc, lora_cr, lora_bw, lora_sync, lora_pa;

        public Main()
        {

            InitializeComponent();

            // Hozz létre egy PlotModel-t
            plotModel = new PlotModel
            {
                Title = "Temperature",
                Axes = {
            new DateTimeAxis {
                Position = AxisPosition.Bottom, Title = "Time", StringFormat = "HH:mm:ss", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot
            },
            new LinearAxis {
                Position = AxisPosition.Left, Title = "°C"
            }
        },
            };

            // Hozz létre és adj hozzá minden LineSeries-t a PlotModel-hez
            temperatureSeries = new LineSeries
            {
                Title = "BME2801"
            };
            plotModel.Series.Add(temperatureSeries);

            temperatureSeries2 = new LineSeries
            {
                Title = "BME2802"
            };
            plotModel.Series.Add(temperatureSeries2);

            temperatureSeries3 = new LineSeries
            {
                Title = "BME680"
            };
            plotModel.Series.Add(temperatureSeries3);

            // Állítsuk be a PlotModel-t a PlotView-ban
            homersekletGrafikon.Model = plotModel;

            pressureSeries = new LineSeries
            {
                Title = "BME2801"
            };
            pressureSeries2 = new LineSeries
            {
                Title = "BME2802"
            };
            pressureSeries3 = new LineSeries
            {
                Title = "BME680"
            };

            // Hozz létre egy PlotModel-t
            plotModel2 = new PlotModel
            {
                Title = "Humidity",
                Axes = {
            new DateTimeAxis {
              Position = AxisPosition.Bottom, Title = "Time", StringFormat = "HH:mm:ss", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot
            },
            new LinearAxis {
              Position = AxisPosition.Left, Title = "%"
            }
          },
            };

            // Adjuk hozzá a LineSeries-t a PlotModel-hez
            plotModel2.Series.Add(pressureSeries);
            plotModel2.Series.Add(pressureSeries2);
            plotModel2.Series.Add(pressureSeries3);

            // Állítsuk be a PlotModel-t a PlotView-ban
            paratartalomGrafikon.Model = plotModel2;

            humiditySeries = new LineSeries
            {
                Title = "BME2801"
            };
            humiditySeries2 = new LineSeries
            {
                Title = "BME2802"
            };
            humiditySeries3 = new LineSeries
            {
                Title = "BME680"
            };

            // Hozz létre egy PlotModel-t
            plotModel3 = new PlotModel
            {
                Title = "Pressure",
                Axes = {
            new DateTimeAxis {
              Position = AxisPosition.Bottom, Title = "Time", StringFormat = "HH:mm:ss", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot
            },
            new LinearAxis {
              Position = AxisPosition.Left, Title = "hPa"
            }
          },
            };

            // Adjuk hozzá a LineSeries-t a PlotModel-hez
            plotModel3.Series.Add(humiditySeries);
            plotModel3.Series.Add(humiditySeries2);
            plotModel3.Series.Add(humiditySeries3);

            // Állítsuk be a PlotModel-t a PlotView-ban
            legnyomasGrafikon.Model = plotModel3;

            accelerationRealSeries = new LineSeries
            {
                Title = "X-axis"
            };

            accelerationRealSeries2 = new LineSeries
            {
                Title = "Y-axis"
            };

            accelerationRealSeries3 = new LineSeries
            {
                Title = "Z-axis"
            };

            // Hozz létre egy PlotModel-t
            plotModel4 = new PlotModel
            {
                Title = "3-axis acceleration",
                Axes = {
            new DateTimeAxis {
              Position = AxisPosition.Bottom, Title = "Time", StringFormat = "HH:mm:ss", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot
            },
            new LinearAxis {
              Position = AxisPosition.Left, Title = "m/s^2"
            }
          },
            };

            // Adjuk hozzá a LineSeries-t a PlotModel-hez
            plotModel4.Series.Add(accelerationRealSeries);
            plotModel4.Series.Add(accelerationRealSeries2);
            plotModel4.Series.Add(accelerationRealSeries3);

            // Állítsuk be a PlotModel-t a PlotView-ban
            gyorsulasMertGrafikon.Model = plotModel4;

            /* accelerationSeries = new LineSeries
             {
                 Title = "X-tengely"
             };

             accelerationSeries2 = new LineSeries
             {
                 Title = "Y-tengely"
             };

             accelerationSeries3 = new LineSeries
             {
                 Title = "Z-tengely"
             };

             // Hozz létre egy PlotModel-t
             plotModel5 = new PlotModel
             {
                 Title = "3-tengelyes gyorsulás",
                 Axes = {
             new DateTimeAxis {
               Position = AxisPosition.Bottom, Title = "Time", StringFormat = "HH:mm:ss", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot
             },
             new LinearAxis {
               Position = AxisPosition.Left, Title = "m/s^2"
             }
           },
             };

             // Adjuk hozzá a LineSeries-t a PlotModel-hez
             plotModel5.Series.Add(accelerationSeries);
             plotModel5.Series.Add(accelerationSeries2);
             plotModel5.Series.Add(accelerationSeries3);

             // Állítsuk be a PlotModel-t a PlotView-ban
             gyorsulasMertGrafikon.Model = plotModel5; */

            gyroSeries = new LineSeries
            {
                Title = "X"
            };
            gyroSeries2 = new LineSeries
            {
                Title = "Y"
            };

            gyroSeries3 = new LineSeries
            {
                Title = "Z"
            };


            // Hozz létre egy PlotModel-t
            plotModel6 = new PlotModel
            {
                Title = "Gyroscope",
                Axes = {
            new DateTimeAxis {
              Position = AxisPosition.Bottom, Title = "Time", StringFormat = "HH:mm:ss", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot
            },
            new LinearAxis {
              Position = AxisPosition.Left, Title = "rad/s"
            }
          },
            };

            // Adjuk hozzá a LineSeries-t a PlotModel-hez
            plotModel6.Series.Add(gyroSeries);
            plotModel6.Series.Add(gyroSeries2);
            plotModel6.Series.Add(gyroSeries3);

            // Állítsuk be a PlotModel-t a PlotView-ban
            giroszGrafikon.Model = plotModel6;





            metanSeries = new LineSeries
            {
                Title = "Methane"
            };

            // Hozz létre egy PlotModel-t
            metanModel = new PlotModel
            {
                Title = "Methane",
                Axes = {
            new DateTimeAxis {
              Position = AxisPosition.Bottom, Title = "Time", StringFormat = "HH:mm:ss", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot
            },
            new LinearAxis {
              Position = AxisPosition.Left, Title = "ppm"
            }
          },
            };

            // Adjuk hozzá a LineSeries-t a PlotModel-hez
            metanModel.Series.Add(metanSeries);

            // Állítsuk be a PlotModel-t a PlotView-ban




            co2Series = new LineSeries
            {
                Title = "Carbon dioxide"
            };

            // Hozz létre egy PlotModel-t
            co2Model = new PlotModel
            {
                Title = "Carbon dioxide",
                Axes = {
            new DateTimeAxis {
              Position = AxisPosition.Bottom, Title = "Time", StringFormat = "HH:mm:ss", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot
            },
            new LinearAxis {
              Position = AxisPosition.Left, Title = "ppm"
            }
          },
            };

            // Adjuk hozzá a LineSeries-t a PlotModel-hez
            co2Model.Series.Add(co2Series);

            // Állítsuk be a PlotModel-t a PlotView-ban
        }

        public static DateTime JavaTimeStampToDateTime(double javaTimeStamp)
        {
            // Java timestamp is milliseconds past epoch
            DateTime dateTime = new(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddMilliseconds(javaTimeStamp).ToLocalTime();
            return dateTime;
        }

        private void UpdateTempGraph(float Temp1, float Temp2, float Temp3, long Timestamp)
        {

            // Hozzáadás az élõ adatokhoz
            temperatureSeries.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), Temp1));
            temperatureSeries2.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), Temp2));
            temperatureSeries3.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), Temp3));

            // Diagram frissítése
            homersekletGrafikon.InvalidatePlot(true);
            return;

        }

        private void UpdateHumidityGraph(float Temp1, float Temp2, float Temp3, long Timestamp)
        {
            // Hozzáadás az élõ adatokhoz
            humiditySeries.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), Temp1));
            humiditySeries2.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), Temp2));
            humiditySeries3.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), Temp3));

            // Diagram frissítése
            paratartalomGrafikon.InvalidatePlot(true);
            return;

        }

        private void UpdatePressureGraph(float Temp1, float Temp2, float Temp3, long Timestamp)
        {
            // Hozzáadás az élõ adatokhoz
            pressureSeries.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), Temp1));
            pressureSeries2.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), Temp2));
            pressureSeries3.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), Temp3));

            // Diagram frissítése
            legnyomasGrafikon.InvalidatePlot(true);
            return;

        }

        private void UpdateGyroGraph(float Temp1, float Temp2, float Temp3, long Timestamp)
        {
            // Hozzáadás az élõ adatokhoz
            gyroSeries.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), Temp1));
            gyroSeries2.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), Temp2));
            gyroSeries3.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), Temp3));

            // Diagram frissítése
            giroszGrafikon.InvalidatePlot(true);
        }

        private void UpdateAccelRealGraph(float x, float y, float z, long Timestamp)
        {
            // Hozzáadás az élõ adatokhoz
            accelerationRealSeries.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), x));
            accelerationRealSeries2.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), y));
            accelerationRealSeries3.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), z));

            // Diagram frissítése
            gyorsulasMertGrafikon.InvalidatePlot(true);
            return;
        }

        GMapOverlay o = new("o");
        System.Timers.Timer timer = new(), globtimer = new(), netchecktimer = new();
        Stopwatch stopWatch = new(), globstopwatch = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            string path2 = Path.Combine(specificFolder, "map");
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.Position = new GMap.NET.PointLatLng(47.5265409, 19.0574471);
            gMapControl1.ShowCenter = false;
            gMapControl1.MinZoom = 4;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 15;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            gMapControl1.CanDragMap = true;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.IgnoreMarkerOnMouseWheel = true;
            gMapControl1.CacheLocation = path2;
            Size siz = new(gMapControl1.Width, gMapControl1.Height);
            gMapControl1.ClientSize = siz;

            timer.Interval = 2;
            timer.Elapsed += OnTimeEvent;

            globtimer.Interval = 50;
            globtimer.Elapsed += OnGlobTimeEvent;

            NetworkCheck(null, null);
            netchecktimer.Start();
            netchecktimer.Interval = 5000;
            netchecktimer.Elapsed += NetworkCheck;

            panel2.Width = this.Width;



            if (!File.Exists(path))
            {
                Directory.CreateDirectory(specificFolder);

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write("serial=COM1\napi_endpoint=\napi_key=");
                    sw.Close();
                }
            }

            if (!File.Exists(csatpath))
            {
                Directory.CreateDirectory(specificFolder);

                using (StreamWriter sw = File.CreateText(csatpath))
                {
                    sw.Write("lora_mod=lora\nlora_freq=864875000\nlora_pwr=14\nlora_sf=sf9\nlora_crc=on\nlora_cr=3/4\nlora_bw=250\nlora_sync=35\nlora_pa=off");
                    sw.Close();
                }
            }
        }

        int errors = 0;
        bool errorcounter = false;

        async void NetworkCheck(object? sender, System.Timers.ElapsedEventArgs? e)
        {
            try
            {
                if (IsHandleCreated)
                {
                    var response = await client.GetAsync("http://ip-api.com/line/?fields=512");
                    var responseString = await response.Content.ReadAsStringAsync();

                    BeginInvoke(new Action(() =>
                    {
                        if (label8.Text != responseString)
                        {
                            new ToastContentBuilder()
                                    .AddText("Internet connection")
                                    .AddText("Internet connection established on the \"" + responseString + "\" network.")
                                    .Show();
                        }
                        label8.Text = responseString;
                    }));
                }
            }
            catch (Exception ex)
            {
                try
                {
                    BeginInvoke(new Action(() =>
                    {
                        if (label8.Text != "No internet connection")
                        {
                            new ToastContentBuilder()
                                .AddText("Internet connection")
                                .AddText("The internet connection has been lost.")
                                .Show();
                        }
                        label8.Text = "No internet connection";
                    }));



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

        bool userClosed = false;
        private void OnTimeEvent(object? sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                if (IsHandleCreated)
                {
                    BeginInvoke(new Action(() =>
                     {
                         var ts = stopWatch.Elapsed;
                         if (ts.TotalMilliseconds > 999 && errorcounter == false)
                         {
                             errors++;
                             errorcounter = true;
                             label3.Text = errors.ToString() + " kiesett csomag";
                         }

                         label1.Text = $"{Math.Round(ts.TotalMilliseconds)} ms";

                         if (!serialPort.IsOpen)
                         {
                             if (!userClosed)
                             {
                                 Port_ErrorReceived(null, null);
                             }
                         }
                     }));
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

        private void OnGlobTimeEvent(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if (IsHandleCreated)
            {
                BeginInvoke(new Action(() =>
            {
                var ts = globstopwatch.Elapsed;

                String kitoltoora, kitoltoperc, kitoltomasodperc;

                if (ts.Hours < 10)
                {
                    kitoltoora = "0";
                }
                else
                {
                    kitoltoora = "";
                }

                if (ts.Minutes < 10)
                {
                    kitoltoperc = "0";
                }
                else
                {
                    kitoltoperc = "";
                }

                if (ts.Seconds < 10)
                {
                    kitoltomasodperc = "0";
                }
                else
                {
                    kitoltomasodperc = "";
                }

                // Format and display the TimeSpan value.
                label2.Text = $"Connected ({kitoltoora}{ts.Hours}:{kitoltoperc}{ts.Minutes}:{kitoltomasodperc}{ts.Seconds})";
            }));
            }
        }

        static string HexToAscii(string hexString)
        {
            // Ellenõrizzük, hogy a hexadecimális karakterlánc hossza páros
            if (hexString.Length % 2 == 0)
            {
                // Hexadecimális karaktereket byte-okká alakítjuk
                byte[] bytes = new byte[hexString.Length / 2];
                for (int i = 0; i < hexString.Length; i += 2)
                {
                    bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
                }

                // Byte-okat olvasható szöveggé alakítjuk
                string asciiText = Encoding.ASCII.GetString(bytes);

                return asciiText;
            }
            else
            {
                return "";
            }


        }

        int receivedpackets = 0;
        int uploadedpackets = 0;
        int lastsend = 0;
        async void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = "";
            try
            {
                SerialPort comm = (SerialPort)sender;
                if (comm.IsOpen)
                {
                    String rawdata = comm.ReadLine();
                    if (rawdata.Contains("radio_rx") && lorasetup > 99)
                    {

                        data = rawdata.Replace("radio_rx", "").Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("f", "").Replace("b", ".").Replace("e", "-");

                    }

                    //String lora_mod, lora_freq, lora_pwr, lora_sf, lora_crc, lora_cr, lora_bw, lora_sync, lora_pa;

                    /*
                                        if (rawdata.Contains("Last reset") && lorasetup == 0)
                                        {
                                            lorasetup = 2;
                                            comm.Write("radio set freq " + lora_freq + "\r\n");
                                            return;
                                        }

                                        if (lorasetup == 1)
                                        {
                                            if (rawdata.Contains("ok"))
                                            {
                                                lorasetup = 2;
                                                comm.Write("radio set freq " + lora_freq + "\r\n");
                                            } else
                                            {
                                                MessageBox.Show("DEBUG -> error level 1  radio set mod " + lora_mod + "\r\n");
                                                comm.Write("radio set mod " + lora_mod + "\r\n");
                                            }

                                        } else
                                        if (lorasetup == 2)
                                        {
                                            if (rawdata.Contains("ok"))
                                            {
                                                lorasetup = 3;
                                                comm.Write("radio set pa " + lora_pa + "\r\n");
                                                return;
                                            }
                                            else
                                            {
                                                comm.Write("radio set freq " + lora_freq + "\r\n");
                                                return;
                                            }

                                        }
                                        else if (lorasetup == 3)
                                        {
                                            if (rawdata.Contains("ok"))
                                            {
                                                lorasetup = 4;
                                                comm.Write("radio set pwr " + lora_pwr + "\r\n");
                                                return;
                                            }
                                            else
                                            {
                                                comm.Write("radio set pa " + lora_pa + "\r\n");
                                                return;
                                            }

                                        }
                                        else if (lorasetup == 4)
                                        {
                                            if (rawdata.Contains("ok"))
                                            {
                                                lorasetup = 5;
                                                comm.Write("radio set sf " + lora_sf + "\r\n");
                                                return;
                                            }
                                            else
                                            {
                                                comm.Write("radio set pwr " + lora_pwr + "\r\n");
                                                return;
                                            }

                                        }
                                        else if (lorasetup == 5)
                                        {
                                            if (rawdata.Contains("ok"))
                                            {
                                                lorasetup = 6;
                                                comm.Write("radio set crc " + lora_crc + "\r\n");
                                                return;
                                            }
                                            else
                                            {
                                                comm.Write("radio set sf " + lora_sf + "\r\n");
                                                return;
                                            }

                                        }
                                        else if (lorasetup == 6)
                                        {
                                            if (rawdata.Contains("ok"))
                                            {
                                                lorasetup = 8;
                                                comm.Write("radio set bw " + lora_bw + "\r\n");
                                                return;
                                            }
                                            else
                                            {
                                                comm.Write("radio set crc " + lora_crc + "\r\n");
                                                return;
                                            }

                                        }
                                        else if (lorasetup == 7)
                                        {
                                            if (rawdata.Contains("ok"))
                                            {
                                                lorasetup = 8;
                                                comm.Write("radio set bw " + lora_bw + "\r\n");
                                                return;
                                            }
                                            else
                                            {
                                                comm.Write("radio set cr " + lora_cr + "\r\n");
                                                return;
                                            }

                                        }

                                        else if (lorasetup == 8)
                                        {
                                            if (rawdata.Contains("ok"))
                                            {
                                                lorasetup = 9;
                                                comm.Write("radio set sync " + lora_sync + "\r\n");
                                                return;
                                            }
                                            else
                                            {
                                                comm.Write("radio set bw " + lora_bw + "\r\n");
                                                return;
                                            }

                                        }
                                        else if (lorasetup == 9)
                                        {
                                            if (rawdata.Contains("ok"))
                                            { */
                    /*comm.Write("radio rx 0\r\n");*/
                    if (lorasetup == 100)
                    {
                        lorasetup = 1000;
                        timer.Start();
                        globtimer.Start();
                        globstopwatch.Restart();
                        new ToastContentBuilder()
             .AddText("Connection")
             .AddText("The serial connection was successfully established.")
             .Show();
                        return;
                    }
                            
                        /*}
                        else
                        {
                            comm.Write("radio set sync " + lora_sync + "\r\n");
                            return;
                        }

                    }*/






                    if (data.Contains('a') && rawdata.Contains("radio_rx") && lorasetup > 99)
                    {
                        var Tstamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
                        BuildFromData(data, Tstamp);
                        string[] args = data.Split("a");
                        if (args.Length == 11)
                        {
                            stopWatch.Restart();
                            errorcounter = false;

                            int now = (int)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                            if (lastsend == 0)
                            {
                                lastsend = (int)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                            }
                            int kulonbseg = now - lastsend;
                            if (kulonbseg >= 950)
                            {

                                lastsend = (int)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                                try
                                {
                                    var values = new Dictionary<string, string> { { "key", Apikey }, { "data", Tstamp + "@#" + data } };

                                    var content = new FormUrlEncodedContent(values);

                                    var response = await client.PostAsync(Apiendpoint, content);
                                    var responseString = await response.Content.ReadAsStringAsync();

                                    if (responseString == "OK")
                                    {
                                        uploadedpackets++;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    try
                                    {
                                        var Tstamp2 = GetTimestamp(DateTime.Now);
                                        if (Errorpath != "")
                                        {
                                            File.AppendAllText(Errorpath, Tstamp2 + " -> " + ex.ToString() + Environment.NewLine);
                                        }
                                    }
                                    catch (Exception ex2)
                                    {
                                        MessageBox.Show(ex2.ToString(), "Error handling failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }

                            receivedpackets++;
                            BeginInvoke(new Action(() =>
                            {
                                label6.Text = receivedpackets.ToString() + " received packets";
                                label5.Text = uploadedpackets.ToString() + " uploaded packets";
                            }));

                            if (Filepath != "")
                            {
                                File.AppendAllText(Filepath, Tstamp + "@#" + data + Environment.NewLine);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                try
                {
                    //Port_ErrorReceived(null, null);
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

        void Port_ErrorReceived(object? sender, SerialErrorReceivedEventArgs? e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
                CloseGUIUpdate();
                if (e == null)
                {
                    MessageBox.Show("The device has probably been disconnected.", "Serial connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(e.ToString(), "Serial connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CloseGUIUpdate()
        {
            try
            {
                timer.Stop();
                stopWatch.Stop();
                globtimer.Stop();
                globstopwatch.Stop();
                BeginInvoke(new Action(() =>
                {
                    label2.Text = "No connection";
                }));
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

        private void BuildFromData(string data, long Timestamp)
        {
            string[] args = data.Split("a");
            //if (args.Length == 11)
            //{
                string timestamp = args[0];
                string lat = args[1];
                string lon = args[2];

                BeginInvoke(new Action(() =>
                {
                    string satelites = args[3];
                    label4.Text = satelites + " satellite";
                }));

                float tempreture = float.Parse(args[4])/100;
            float tempreture2 = float.Parse(args[7]) / 100;
            float tempreture3 = float.Parse(args[10]) / 100;

            UpdateTempGraph(tempreture, tempreture2, tempreture3, Timestamp);

            

            float hum1 = float.Parse(args[5]) / 100;
            float hum2 = float.Parse(args[8]) / 100;
            float hum3 = float.Parse(args[11]) / 100;
            
            UpdateHumidityGraph(hum1,hum2,hum3, Timestamp);

            float pres1 = float.Parse(args[6]) / 100;
            float pres2 = float.Parse(args[9]) / 100;
            float pres3 = float.Parse(args[12]) / 100;
            
            UpdatePressureGraph(pres1,pres2,pres3, Timestamp);

            float accel1 = float.Parse(args[14]) / 100;
            float accel2 = float.Parse(args[15]) / 100;
            float accel3 = float.Parse(args[16]) / 100;
            UpdateAccelRealGraph(accel1, accel2, accel3, Timestamp);

            float gyro1 = float.Parse(args[17]) / 100;
            float gyro2 = float.Parse(args[18]) / 100;
            float gyro3 = float.Parse(args[19]) / 100;

            UpdateGyroGraph(gyro1, gyro2, gyro3, Timestamp);




            //string methane = args[11];
            //string co2 = args[12];
            //                UpdateMap(lat, lon);

            //UpdateAccelGraph(x2, y2, z2, Timestamp);
            //}
        }

        double lat_last;
        double lon_last;

        private void UpdateMap(string lat_str, string lon_str)
        {
            if (gMapControl1.InvokeRequired)
            {
                MethodInvoker AssignMethodToControl = new(() => UpdateMap(lat_str, lon_str));
                gMapControl1.BeginInvoke(AssignMethodToControl);
            }
            else
            {

                bool first = false;

                    if (!lat_str.Contains("0.00000") && lat_str.Contains('.') && !lon_str.Contains("0.00000") && lon_str.Contains('.'))
                    {
                        try
                        {
                            double latitude = Double.Parse(lat_str, CultureInfo.InvariantCulture);
                            double longitude = Double.Parse(lon_str, CultureInfo.InvariantCulture);
                            if (lat_last == 0)
                            {
                                lat_last = latitude;
                                first = true;
                            }
                            if (lon_last == 0)
                            {
                                lon_last = longitude;
                                first = true;
                            }
                            GMapOverlay polyOverlay = new("polygons");
                            IList<PointLatLng> points = new List<PointLatLng>
                            {
                                new PointLatLng(lat_last, lon_last),
                                new PointLatLng(latitude, longitude)
                            };
                            GMapPolygon polygon = new((List<PointLatLng>)points, "mypolygon")
                            {
                                Fill = new SolidBrush(Color.FromArgb(50, Color.Red)),
                                Stroke = new Pen(Color.Red, 1)
                            };
                            polyOverlay.Polygons.Add(polygon);
                            gMapControl1.Overlays.Add(polyOverlay);

                            lat_last = latitude;
                            lon_last = longitude;

                            gMapControl1.Position = new PointLatLng(latitude, longitude);
                            GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(latitude, longitude), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.black_small);
                            if (first == false)
                            {
                                o.Markers.RemoveAt(0);
                            }
                            else
                            {
                                gMapControl1.Overlays.Add(o);
                            }

                            o.Markers.Add(marker);
                            gMapControl1.Invalidate();
                            gMapControl1.Update();
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

        private void BeállításokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings s2 = new();
            s2.ShowDialog();
        }
        int lorasetup = 100;
        private void KapcsolódásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                userClosed = false;
                string serial = "COM8";
                string api_key;
                string api_endpoint;

                var settings = File.ReadLines(path);

                foreach (var lineRead in settings)
                {
                    if (lineRead.Contains("serial="))
                    {
                        serial = lineRead.Replace("serial=", "");
                    }
                    else if (lineRead.Contains("api_key="))
                    {
                        api_key = lineRead.Replace("api_key=", "");
                        Apikey = api_key;
                    }
                    else if (lineRead.Contains("api_endpoint="))
                    {
                        api_endpoint = lineRead.Replace("api_endpoint=", "");
                        Apiendpoint = api_endpoint;

                    }
                }

                serialPort = new(serial, 115200)
                {
                    DtrEnable = true
                };

                serialPort.Open();
                serialPort.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceived);
                serialPort.ErrorReceived += new SerialErrorReceivedEventHandler(Port_ErrorReceived);




                /*var cansettings = File.ReadLines(csatpath);


                foreach (var lineRead in cansettings)
                {
                    if (lineRead.Contains("lora_mod="))
                    {
                        lora_mod = lineRead.Replace("lora_mod=", "").Replace(" ", "").Replace("\n", "").Replace("\r", "");
                    }
                    else if (lineRead.Contains("lora_freq="))
                    {
                        lora_freq = lineRead.Replace("lora_freq=", "").Replace(" ", "").Replace("\n", "").Replace("\r", "");
                    }
                    else if (lineRead.Contains("lora_pwr="))
                    {
                        lora_pwr = lineRead.Replace("lora_pwr=", "").Replace(" ", "").Replace("\n", "").Replace("\r", "");
                    }
                    else if (lineRead.Contains("lora_sf="))
                    {
                        lora_sf = lineRead.Replace("lora_sf=", "").Replace(" ", "").Replace("\n", "").Replace("\r", "");
                    }
                    else if (lineRead.Contains("lora_crc="))
                    {
                        lora_crc = lineRead.Replace("lora_crc=", "").Replace(" ", "").Replace("\n", "").Replace("\r", "");
                    }
                    else if (lineRead.Contains("lora_cr="))
                    {
                        lora_cr = lineRead.Replace("lora_cr=", "").Replace(" ", "").Replace("\n", "").Replace("\r", "");
                    }
                    else if (lineRead.Contains("lora_bw="))
                    {
                        lora_bw = lineRead.Replace("lora_bw=", "").Replace(" ", "").Replace("\n", "").Replace("\r", "");
                    }
                    else if (lineRead.Contains("lora_sync="))
                    {
                        lora_sync = lineRead.Replace("lora_sync=", "").Replace(" ", "").Replace("\n", "").Replace("\r", "");
                    }
                    else if (lineRead.Contains("lora_pa="))
                    {
                        lora_pa = lineRead.Replace("lora_pa=", "").Replace(" ", "").Replace("\n", "").Replace("\r", "");
                    }
                }

                lorasetup = 0;
                serialPort.Write("sys reset\r\n");*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Kapcsolódási hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KapcsolatBontásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CloseGUIUpdate();
                userClosed = true;
                serialPort.Write("radio rxstop\r\n");
                serialPort.Write("sys reset\r\n");
                serialPort.Close();
                lorasetup = 0;

                new ToastContentBuilder()
                  .AddText("Connection")
                  .AddText("The serial connection has been terminated.")
                  .Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Connection breakdown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FájlKiválasztásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new()
                {
                    Filter = "Text file (*.txt)|*.TXT"
                };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (String file in ofd.FileNames)
                    {

                        if (File.Exists(file))
                        {
                            label7.Text = Path.GetFileName(file);
                            DeleteGraphs();

                            Filepath = file;
                            string[] lines = File.ReadAllLines(file);
                            foreach (string line in lines)
                            {
                                if (line.Contains('|'))
                                {
                                    string[] args = line.Split("@#");
                                    if (args.Length == 2)
                                    {
                                        long l1 = (long)Convert.ToDouble(args[0]);
                                        BuildFromData(args[1], l1);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "File selection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ÚjAdatfájlLétrehozásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String timeStamp = GetTimestamp(DateTime.Now);
                Directory.CreateDirectory(specificFolder);
                string folder = Path.Join(specificFolder, "data");
                Directory.CreateDirectory(folder);
                string datafile = Path.Join(folder, timeStamp + ".txt");

                FileStream fs = File.Create(datafile);
                fs.Close();


                if (File.Exists(datafile))
                {

                    DeleteGraphs();
                    Filepath = datafile;
                    label7.Text = Path.GetFileName(datafile);

                    MessageBox.Show("Successful data file creation!");

                }
                else
                {
                    MessageBox.Show("Unsuccessful data file creation!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "File creation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy-MM-dd HH-mm-ss.ffff");
        }

        private void DeleteGraphs()
        {
            temperatureSeries.Points.Clear();
            temperatureSeries2.Points.Clear();
            temperatureSeries3.Points.Clear();
            accelerationRealSeries.Points.Clear();
            accelerationRealSeries3.Points.Clear();
            accelerationRealSeries2.Points.Clear();
            humiditySeries.Points.Clear();
            humiditySeries2.Points.Clear();
            humiditySeries3.Points.Clear();

            gyroSeries.Points.Clear();
            gyroSeries2.Points.Clear();
            gyroSeries3.Points.Clear();

            pressureSeries.Points.Clear();
            pressureSeries2.Points.Clear();
            pressureSeries3.Points.Clear();

            giroszGrafikon.InvalidatePlot(true);
            gyorsulasMertGrafikon.InvalidatePlot(true);
            legnyomasGrafikon.InvalidatePlot(true);
            paratartalomGrafikon.InvalidatePlot(true);
            homersekletGrafikon.InvalidatePlot(true);
        }

        private void HõmérsékletGrafikonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                String timeStamp = GetTimestamp(DateTime.Now);

                Directory.CreateDirectory(specificFolder);
                string folder = Path.Join(specificFolder, "exports");
                Directory.CreateDirectory(folder);
                string folder2 = Path.Join(folder, "temperature");
                Directory.CreateDirectory(folder2);
                string datafile = Path.Join(folder2, timeStamp + ".png");
                var pngExporter = new PngExporter
                {
                    Width = 1600,
                    Height = 700
                };
                pngExporter.ExportToFile(plotModel, datafile);

                new ToastContentBuilder()
                  .AddText("Successful exportation!")
                  .AddText("The image has been successfully exported.")
                  .Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "An error occurred during export.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RelatívPáratartalomGrafikonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                String timeStamp = GetTimestamp(DateTime.Now);

                Directory.CreateDirectory(specificFolder);
                string folder = Path.Join(specificFolder, "exports");
                Directory.CreateDirectory(folder);
                string folder2 = Path.Join(folder, "humidity");
                Directory.CreateDirectory(folder2);
                string datafile = Path.Join(folder2, timeStamp + ".png");
                var pngExporter = new PngExporter
                {
                    Width = 1600,
                    Height = 700
                };
                pngExporter.ExportToFile(plotModel2, datafile);

                new ToastContentBuilder()
                  .AddText("Successful exportation!")
                  .AddText("The image has been successfully exported.")
                  .Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "An error occurred during export.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LégnyomásGrafikonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                String timeStamp = GetTimestamp(DateTime.Now);

                Directory.CreateDirectory(specificFolder);
                string folder = Path.Join(specificFolder, "exports");
                Directory.CreateDirectory(folder);
                string folder2 = Path.Join(folder, "pressure");
                Directory.CreateDirectory(folder2);
                string datafile = Path.Join(folder2, timeStamp + ".png");
                var pngExporter = new PngExporter
                {
                    Width = 1600,
                    Height = 700
                };
                pngExporter.ExportToFile(plotModel3, datafile);

                new ToastContentBuilder()
                  .AddText("Successful exportation!")
                  .AddText("The image has been successfully exported.")
                  .Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "An error occurred during export.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MagasságGrafikonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                String timeStamp = GetTimestamp(DateTime.Now);

                Directory.CreateDirectory(specificFolder);
                string folder = Path.Join(specificFolder, "exports");
                Directory.CreateDirectory(folder);
                string folder2 = Path.Join(folder, "altitude");
                Directory.CreateDirectory(folder2);
                string datafile = Path.Join(folder2, timeStamp + ".png");
                var pngExporter = new PngExporter
                {
                    Width = 1600,
                    Height = 700
                };
                pngExporter.ExportToFile(plotModel6, datafile);

                new ToastContentBuilder()
                  .AddText("Successful exportation!")
                  .AddText("The image has been successfully exported.")
                  .Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "An error occurred during export.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TengelyesGyorsulásmértGrafikonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                String timeStamp = GetTimestamp(DateTime.Now);

                Directory.CreateDirectory(specificFolder);
                string folder = Path.Join(specificFolder, "exports");
                Directory.CreateDirectory(folder);
                string folder2 = Path.Join(folder, "acceleration");
                Directory.CreateDirectory(folder2);
                string datafile = Path.Join(folder2, timeStamp + ".png");
                var pngExporter = new PngExporter
                {
                    Width = 1600,
                    Height = 700
                };
                pngExporter.ExportToFile(plotModel4, datafile);

                new ToastContentBuilder()
                  .AddText("Successful exportation!")
                  .AddText("The image has been successfully exported.")
                  .Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "An error occurred during export.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TérképToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                String timeStamp = GetTimestamp(DateTime.Now);

                Directory.CreateDirectory(specificFolder);
                string folder = Path.Join(specificFolder, "exports");
                Directory.CreateDirectory(folder);
                string folder2 = Path.Join(folder, "map");
                Directory.CreateDirectory(folder2);
                string datafile = Path.Join(folder2, timeStamp + ".png");

                System.Drawing.Image tmpImage = gMapControl1.ToImage();
                if (tmpImage == null) return;
                tmpImage.Save(datafile);

                new ToastContentBuilder()
                  .AddText("Successful exportation!")
                  .AddText("The image has been successfully exported.")
                  .Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "An error occurred during export.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Write("radio rxstop\r\n");
                    serialPort.Write("sys reset\r\n");
                    serialPort.Close();
                }
            }));
        }

        private void NévjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new();
            about.ShowDialog();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            tableLayoutPanel2.Width = this.Width;
            panel2.Width = this.Width;

        }



        private void loRaBeállításokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lorasettings lorasettings = new lorasettings();
            lorasettings.ShowDialog();
        }




        async void cloudStationAdatokTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string api_key;
                string api_endpoint;

                var settings = File.ReadLines(path);

                foreach (var lineRead in settings)
                {
                    if (lineRead.Contains("api_key="))
                    {
                        api_key = lineRead.Replace("api_key=", "");
                        Apikey = api_key;
                    }
                    else if (lineRead.Contains("api_endpoint="))
                    {
                        api_endpoint = lineRead.Replace("api_endpoint=", "");
                        Apiendpoint = api_endpoint;

                    }
                }

                var values = new Dictionary<string, string> { { "key", Apikey }, { "method", "truncate" } };

                var content = new FormUrlEncodedContent(values);

                var response = await client.PostAsync(Apiendpoint, content);
                var responseString = await response.Content.ReadAsStringAsync();
                if (responseString == "OK")
                {
                    MessageBox.Show("Sucessful data deletion.");
                }
                else
                {
                    MessageBox.Show("An unexpected error ocurred. (500)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't connect to the server.");
                try
                {
                    //Port_ErrorReceived(null, null);
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

        private void methaneGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                String timeStamp = GetTimestamp(DateTime.Now);

                Directory.CreateDirectory(specificFolder);
                string folder = Path.Join(specificFolder, "exports");
                Directory.CreateDirectory(folder);
                string folder2 = Path.Join(folder, "methane");
                Directory.CreateDirectory(folder2);
                string datafile = Path.Join(folder2, timeStamp + ".png");
                var pngExporter = new PngExporter
                {
                    Width = 1600,
                    Height = 700
                };
                pngExporter.ExportToFile(metanModel, datafile);

                new ToastContentBuilder()
                  .AddText("Successful exportation!")
                  .AddText("The image has been successfully exported.")
                  .Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "An error occurred during export.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carbonDioxideGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                String timeStamp = GetTimestamp(DateTime.Now);

                Directory.CreateDirectory(specificFolder);
                string folder = Path.Join(specificFolder, "exports");
                Directory.CreateDirectory(folder);
                string folder2 = Path.Join(folder, "co2");
                Directory.CreateDirectory(folder2);
                string datafile = Path.Join(folder2, timeStamp + ".png");
                var pngExporter = new PngExporter
                {
                    Width = 1600,
                    Height = 700
                };
                pngExporter.ExportToFile(co2Model, datafile);

                new ToastContentBuilder()
                  .AddText("Successful exportation!")
                  .AddText("The image has been successfully exported.")
                  .Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "An error occurred during export.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateMapDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path2 = Path.Combine(specificFolder, "map");
            string path3 = Path.Combine(path2, "def_map");
            gMapControl1.CacheLocation = path3;
            UpdateMapData UpdateMapData = new UpdateMapData();
            UpdateMapData.ShowDialog();
            gMapControl1.CacheLocation = path2;
        }

    }
}