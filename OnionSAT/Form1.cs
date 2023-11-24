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

namespace OnionSAT
{
    public partial class Form1 : Form
    {
        static string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static string specificFolder = Path.Combine(folder, ".onionsat");
        static string path = Path.Combine(specificFolder, "settings.txt");
        String Filepath = "";
        String Apikey, Apiendpoint;
        private LineSeries temperatureSeries, humiditySeries, pressureSeries, accelerationSeries, accelerationRealSeries, accelerationRealSeries2, accelerationRealSeries3, altitudeSeries, accelerationSeries2, accelerationSeries3;
        private int currentTime = 0;
        private static readonly HttpClient client = new HttpClient();
        PlotModel plotModel, plotModel2, plotModel3, plotModel4, plotModel5, plotModel6;

        public Form1()
        {
            InitializeComponent();
            temperatureSeries = new LineSeries
            {
                Title = "Hõmérséklet"
            };

            // Hozz létre egy PlotModel-t
            plotModel = new PlotModel
            {
                Title = "Hõmérséklet",
                Axes = { new DateTimeAxis { Position = AxisPosition.Bottom, Title = "Idõ", StringFormat = "HH:mm:ss", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot }, new LinearAxis { Position = AxisPosition.Left, Title = "Hõmérséklet (Celsius)" } },
            };

            // Adjuk hozzá a LineSeries-t a PlotModel-hez
            plotModel.Series.Add(temperatureSeries);

            // Állítsuk be a PlotModel-t a PlotView-ban
            plotView1.Model = plotModel;

            pressureSeries = new LineSeries
            {
                Title = "Relatív páratartalom"
            };

            // Hozz létre egy PlotModel-t
            plotModel2 = new PlotModel
            {
                Title = "Páratartalom",
                Axes = { new DateTimeAxis { Position = AxisPosition.Bottom, Title = "Idõ", StringFormat = "HH:mm:ss", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot }, new LinearAxis { Position = AxisPosition.Left, Title = "Relatív páratartalom (%)" } },
            };

            // Adjuk hozzá a LineSeries-t a PlotModel-hez
            plotModel2.Series.Add(pressureSeries);

            // Állítsuk be a PlotModel-t a PlotView-ban
            plotView2.Model = plotModel2;

            humiditySeries = new LineSeries
            {
                Title = "Légnyomás"
            };

            // Hozz létre egy PlotModel-t
            plotModel3 = new PlotModel
            {
                Title = "Légnyomás",
                Axes = { new DateTimeAxis { Position = AxisPosition.Bottom, Title = "Idõ", StringFormat = "HH:mm:ss", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot }, new LinearAxis { Position = AxisPosition.Left, Title = "Légnyomás (hPa)" } },
            };

            // Adjuk hozzá a LineSeries-t a PlotModel-hez
            plotModel3.Series.Add(humiditySeries);

            // Állítsuk be a PlotModel-t a PlotView-ban
            plotView3.Model = plotModel3;






            accelerationRealSeries = new LineSeries
            {
                Title = "X-tengely"
            };

            accelerationRealSeries2 = new LineSeries
            {
                Title = "Y-tengely"
            };

            accelerationRealSeries3 = new LineSeries
            {
                Title = "Z-tengely"
            };

            // Hozz létre egy PlotModel-t
            plotModel4 = new PlotModel
            {
                Title = "3-tengelyes gyorsulás (mért)",
                Axes = { new DateTimeAxis { Position = AxisPosition.Bottom, Title = "Idõ", StringFormat = "HH:mm:ss", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot }, new LinearAxis { Position = AxisPosition.Left, Title = "m/s^2" } },
            };

            // Adjuk hozzá a LineSeries-t a PlotModel-hez
            plotModel4.Series.Add(accelerationRealSeries);
            plotModel4.Series.Add(accelerationRealSeries2);
            plotModel4.Series.Add(accelerationRealSeries3);

            // Állítsuk be a PlotModel-t a PlotView-ban
            plotView4.Model = plotModel4;





            accelerationSeries = new LineSeries
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
                Axes = { new DateTimeAxis { Position = AxisPosition.Bottom, Title = "Idõ", StringFormat = "HH:mm:ss", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot }, new LinearAxis { Position = AxisPosition.Left, Title = "m/s^2" } },
            };

            // Adjuk hozzá a LineSeries-t a PlotModel-hez
            plotModel5.Series.Add(accelerationSeries);
            plotModel5.Series.Add(accelerationSeries2);
            plotModel5.Series.Add(accelerationSeries3);

            // Állítsuk be a PlotModel-t a PlotView-ban
            plotView5.Model = plotModel5;




            altitudeSeries = new LineSeries
            {
                Title = "Magasság"
            };

            // Hozz létre egy PlotModel-t
            plotModel6 = new PlotModel
            {
                Title = "Magasság",
                Axes = { new DateTimeAxis { Position = AxisPosition.Bottom, Title = "Idõ", StringFormat = "HH:mm:ss", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot }, new LinearAxis { Position = AxisPosition.Left, Title = "m" } },
            };

            // Adjuk hozzá a LineSeries-t a PlotModel-hez
            plotModel6.Series.Add(altitudeSeries);

            // Állítsuk be a PlotModel-t a PlotView-ban
            plotView7.Model = plotModel6;
        }

        public static DateTime JavaTimeStampToDateTime(double javaTimeStamp)
        {
            // Java timestamp is milliseconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddMilliseconds(javaTimeStamp).ToLocalTime();
            return dateTime;
        }

        private void updateTempGraph(string Temp, long Timestamp)
        {
            currentTime++;

            float homerseklet = float.Parse(Temp, CultureInfo.InvariantCulture.NumberFormat);
            // Hozzáadás az élõ adatokhoz
            temperatureSeries.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), homerseklet));

            // Diagram frissítése
            plotView1.InvalidatePlot(true);
        }

        private int currentTime2 = 0;
        private void updateHumidityGraph(string Temp, long Timestamp)
        {
            currentTime2++;

            float paratartalom = float.Parse(Temp, CultureInfo.InvariantCulture.NumberFormat);
            // Hozzáadás az élõ adatokhoz
            humiditySeries.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), paratartalom));

            // Diagram frissítése
            plotView2.InvalidatePlot(true);
        }

        private int currentTime3 = 0;
        private void updatePressureGraph(string Temp, long Timestamp)
        {
            currentTime3++;

            float paratartalom = float.Parse(Temp, CultureInfo.InvariantCulture.NumberFormat);
            // Hozzáadás az élõ adatokhoz
            pressureSeries.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), paratartalom));

            // Diagram frissítése
            plotView3.InvalidatePlot(true);
        }

        private int currentTime4 = 0;
        private void updateAltitudeGraph(string Temp, long Timestamp)
        {
            currentTime4++;

            float magassag = float.Parse(Temp, CultureInfo.InvariantCulture.NumberFormat);
            // Hozzáadás az élõ adatokhoz
            altitudeSeries.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), magassag));

            // Diagram frissítése
            plotView7.InvalidatePlot(true);
        }

        private int currentTime5 = 0;
        private void updateAccelRealGraph(string gx, string gy, string gz, long Timestamp)
        {
            currentTime5++;

            float x = float.Parse(gx, CultureInfo.InvariantCulture.NumberFormat);
            float y = float.Parse(gy, CultureInfo.InvariantCulture.NumberFormat);
            float z = float.Parse(gz, CultureInfo.InvariantCulture.NumberFormat);
            // Hozzáadás az élõ adatokhoz
            accelerationRealSeries.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), x));
            accelerationRealSeries2.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), y));
            accelerationRealSeries3.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), z));

            // Diagram frissítése
            plotView4.InvalidatePlot(true);
        }

        private int currentTime6 = 0;
        private void updateAccelGraph(string gx, string gy, string gz, long Timestamp)
        {
            currentTime6++;

            float x = float.Parse(gx, CultureInfo.InvariantCulture.NumberFormat);
            float y = float.Parse(gy, CultureInfo.InvariantCulture.NumberFormat);
            float z = float.Parse(gz, CultureInfo.InvariantCulture.NumberFormat);
            // Hozzáadás az élõ adatokhoz
            accelerationSeries.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), x));
            accelerationSeries2.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), y));
            accelerationSeries3.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(JavaTimeStampToDateTime(Timestamp)), z));

            // Diagram frissítése
            plotView5.InvalidatePlot(true);
        }

        GMapOverlay o = new GMapOverlay("o");
        GMapOverlay polyOverlay = new GMapOverlay("polygons");
        SerialPort serialPort;



        private void Form1_Load(object sender, EventArgs e)
        {
            //GMap.NET.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.Position = new GMap.NET.PointLatLng(47.5265409, 19.0574471);
            gMapControl1.ShowCenter = false;
            gMapControl1.MinZoom = 4;                                                                            // whole world zoom
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 15;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;                // lets the map use the mousewheel to zoom
            gMapControl1.CanDragMap = true;                                                                      // lets the user drag the map       
            gMapControl1.DragButton = MouseButtons.Left;                                                          // lets the user drag the map with the left mouse button
            gMapControl1.IgnoreMarkerOnMouseWheel = true;
            Size siz = new System.Drawing.Size(gMapControl1.Width, gMapControl1.Height);
            gMapControl1.ClientSize = siz;
        }

        async void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort comm = (SerialPort)sender;
            string data = comm.ReadLine().Replace("\r\n", "");
            if (data.Contains("|"))
            {
                var Tstamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
                buildFromData(data, Tstamp);
                string[] args = data.Split("|");
                if (args.Length == 14)
                {

                    var values = new Dictionary<string, string>
                    {
                        { "key", Apikey },
                        { "data", data }
                    };

                    var content = new FormUrlEncodedContent(values);

                    try
                    {
                        var response = await client.PostAsync(Apiendpoint, content);
                        var responseString = await response.Content.ReadAsStringAsync();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    if (Filepath != "")
                    {
                        var Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
                        File.AppendAllText(Filepath, Timestamp + "@#" + data + Environment.NewLine);
                    }
                }
            }
        }


        private void buildFromData(string data, long Timestamp)
        {
            //17:53:42.767 -> 47.5269, 19.0580|5|2023-11-23 16:53:42|8.79|24.23|33.03|1006.32|25875.60|0.47|0.12|11.02|-0.01|0.01|9.77


            string[] args = data.Split("|");
            if (args.Length == 14)
            {

                string tempreture = args[4];
                updateTempGraph(tempreture, Timestamp);

                string coordinates = args[0];
                updateMap(coordinates);

                string humidity = args[6];
                updateHumidityGraph(humidity, Timestamp);

                string pressure = args[5];
                updatePressureGraph(pressure, Timestamp);

                string altitude = args[7];
                updateAltitudeGraph(altitude, Timestamp);

                string x1 = args[8];
                string y1 = args[9];
                string z1 = args[10];
                updateAccelRealGraph(x1, y1, z1, Timestamp);

                string x2 = args[11];
                string y2 = args[12];
                string z2 = args[13];
                updateAccelGraph(x2, y2, z2, Timestamp);
            }
        }

        double lat_last;
        double lon_last;

        private void updateMap(string coordinates)
        {
            if (gMapControl1.InvokeRequired)
            {
                // If Invoke is required, call the method recursively using Invoke
                MethodInvoker AssignMethodToControl = new MethodInvoker(() => updateMap(coordinates));
                gMapControl1.Invoke(AssignMethodToControl);
            }
            else
            {

                bool first = false;

                string[] args = coordinates.Split(", ");
                if (args.Length == 2)
                {
                    string lat_str = args[0];
                    string lon_str = args[1];

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
                    GMapOverlay polyOverlay = new GMapOverlay("polygons");
                    IList<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(lat_last, lon_last));
                    points.Add(new PointLatLng(latitude, longitude));
                    GMapPolygon polygon = new GMapPolygon((List<PointLatLng>)points, "mypolygon");
                    polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                    polygon.Stroke = new Pen(Color.Red, 1);
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
            }

        }

        private void beállításokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings s2 = new Settings();
            s2.ShowDialog();
        }

        private void kapcsolódásToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

            serialPort = new SerialPort(serial, 9600);
            serialPort.DtrEnable = true;
            try
            {
                serialPort.Open();
                MessageBox.Show("Serial kapcsolat létrejött!");
                serialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serial kapcsolodasi hiba: " + ex.ToString());
            }
        }

        private void kapcsolatBontásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();
                MessageBox.Show("Serial kapcsolat bontva lett!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serial kapcsolat bontási hiba: " + ex.ToString());
            }
        }



        private void fájlKiválasztásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Szöveges állomány (*.txt)|*.TXT";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in ofd.FileNames)
                {
                    if (File.Exists(file))
                    {
                        deleteGraphs();

                        Filepath = file;
                        string[] lines = File.ReadAllLines(file);
                        int i = 0;
                        foreach (string line in lines)
                        {
                            if (line.Contains("|"))
                            {
                                string[] args = line.Split("@#");
                                if (args.Length == 2)
                                {
                                    long l1 = (long)Convert.ToDouble(args[0]);
                                    buildFromData(args[1], l1);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void újAdatfájlLétrehozásaToolStripMenuItem_Click(object sender, EventArgs e)
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

                deleteGraphs();
                Filepath = datafile;
                MessageBox.Show("Sikeres adatfájl létrehozás!");

            }
            else
            {
                MessageBox.Show("Sikertelen adatfájl létrehozás!");
            }

        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy-MM-dd HH-mm-ss.ffff");
        }

        private void deleteGraphs()
        {
            temperatureSeries.Points.Clear();
            accelerationRealSeries.Points.Clear();
            accelerationRealSeries3.Points.Clear();
            accelerationRealSeries2.Points.Clear();
            accelerationSeries.Points.Clear();
            accelerationSeries3.Points.Clear();
            accelerationSeries2.Points.Clear();
            humiditySeries.Points.Clear();
            altitudeSeries.Points.Clear();
            pressureSeries.Points.Clear();

            plotView7.InvalidatePlot(true);
            plotView5.InvalidatePlot(true);
            plotView4.InvalidatePlot(true);
            plotView3.InvalidatePlot(true);
            plotView2.InvalidatePlot(true);
            plotView1.InvalidatePlot(true);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exportálásToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hõmérsékletGrafikonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);

            Directory.CreateDirectory(specificFolder);
            string folder = Path.Join(specificFolder, "exports");
            Directory.CreateDirectory(folder);
            string folder2 = Path.Join(folder, "homerseklet");
            Directory.CreateDirectory(folder2);
            string datafile = Path.Join(folder2, timeStamp + ".png");
            var pngExporter = new PngExporter { Width = 5000, Height = 3000 };
            pngExporter.ExportToFile(plotModel, datafile);
        }

        private void relatívPáratartalomGrafikonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);

            Directory.CreateDirectory(specificFolder);
            string folder = Path.Join(specificFolder, "exports");
            Directory.CreateDirectory(folder);
            string folder2 = Path.Join(folder, "paratartalom");
            Directory.CreateDirectory(folder2);
            string datafile = Path.Join(folder2, timeStamp + ".png");
            var pngExporter = new PngExporter { Width = 5000, Height = 3000 };
            pngExporter.ExportToFile(plotModel2, datafile);
        }

        private void légnyomásGrafikonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);

            Directory.CreateDirectory(specificFolder);
            string folder = Path.Join(specificFolder, "exports");
            Directory.CreateDirectory(folder);
            string folder2 = Path.Join(folder, "legnyomas");
            Directory.CreateDirectory(folder2);
            string datafile = Path.Join(folder2, timeStamp + ".png");
            var pngExporter = new PngExporter { Width = 5000, Height = 3000 };
            pngExporter.ExportToFile(plotModel3, datafile);
        }

        private void magasságGrafikonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);

            Directory.CreateDirectory(specificFolder);
            string folder = Path.Join(specificFolder, "exports");
            Directory.CreateDirectory(folder);
            string folder2 = Path.Join(folder, "magassag");
            Directory.CreateDirectory(folder2);
            string datafile = Path.Join(folder2, timeStamp + ".png");
            var pngExporter = new PngExporter { Width = 5000, Height = 3000 };
            pngExporter.ExportToFile(plotModel6, datafile);
        }

        private void tengelyesGyorsulásmértGrafikonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);

            Directory.CreateDirectory(specificFolder);
            string folder = Path.Join(specificFolder, "exports");
            Directory.CreateDirectory(folder);
            string folder2 = Path.Join(folder, "gyorsulas_mert");
            Directory.CreateDirectory(folder2);
            string datafile = Path.Join(folder2, timeStamp + ".png");
            var pngExporter = new PngExporter { Width = 5000, Height = 3000 };
            pngExporter.ExportToFile(plotModel4, datafile);
        }

        private void tengelyesGyorsulásGrafikonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);

            Directory.CreateDirectory(specificFolder);
            string folder = Path.Join(specificFolder, "exports");
            Directory.CreateDirectory(folder);
            string folder2 = Path.Join(folder, "gyorsulas");
            Directory.CreateDirectory(folder2);
            string datafile = Path.Join(folder2, timeStamp + ".png");
            var pngExporter = new PngExporter { Width = 5000, Height = 3000 };
            pngExporter.ExportToFile(plotModel5, datafile);
        }
    }
}