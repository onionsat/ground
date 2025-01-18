namespace OnionSAT
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            fájlToolStripMenuItem = new ToolStripMenuItem();
            kapcsolódásToolStripMenuItem = new ToolStripMenuItem();
            kapcsolatLétrehozásaToolStripMenuItem = new ToolStripMenuItem();
            kapcsolatBontásaToolStripMenuItem = new ToolStripMenuItem();
            beállításokToolStripMenuItem = new ToolStripMenuItem();
            loRaBeállításokToolStripMenuItem = new ToolStripMenuItem();
            adattárolásToolStripMenuItem = new ToolStripMenuItem();
            újAdatfájlLétrehozásaToolStripMenuItem = new ToolStripMenuItem();
            fájlKiválasztásaToolStripMenuItem = new ToolStripMenuItem();
            cloudStationAdatokTörléseToolStripMenuItem = new ToolStripMenuItem();
            exportálásToolStripMenuItem = new ToolStripMenuItem();
            pNGToolStripMenuItem = new ToolStripMenuItem();
            térképToolStripMenuItem = new ToolStripMenuItem();
            hőmérsékletGrafikonToolStripMenuItem = new ToolStripMenuItem();
            relatívPáratartalomGrafikonToolStripMenuItem = new ToolStripMenuItem();
            légnyomásGrafikonToolStripMenuItem = new ToolStripMenuItem();
            magasságGrafikonToolStripMenuItem = new ToolStripMenuItem();
            tengelyesGyorsulásmértGrafikonToolStripMenuItem = new ToolStripMenuItem();
            információkToolStripMenuItem = new ToolStripMenuItem();
            updateMapDataToolStripMenuItem = new ToolStripMenuItem();
            névjegyToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            label8 = new Label();
            pictureBox11 = new PictureBox();
            label7 = new Label();
            pictureBox9 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            homersekletGrafikon = new OxyPlot.WindowsForms.PlotView();
            legnyomasGrafikon = new OxyPlot.WindowsForms.PlotView();
            giroszGrafikon = new OxyPlot.WindowsForms.PlotView();
            paratartalomGrafikon = new OxyPlot.WindowsForms.PlotView();
            gyorsulasMertGrafikon = new OxyPlot.WindowsForms.PlotView();
            tableLayoutPanel2 = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fájlToolStripMenuItem, adattárolásToolStripMenuItem, exportálásToolStripMenuItem, információkToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            fájlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kapcsolódásToolStripMenuItem, beállításokToolStripMenuItem, loRaBeállításokToolStripMenuItem });
            fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            fájlToolStripMenuItem.Size = new Size(81, 22);
            fájlToolStripMenuItem.Text = "Connection";
            // 
            // kapcsolódásToolStripMenuItem
            // 
            kapcsolódásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kapcsolatLétrehozásaToolStripMenuItem, kapcsolatBontásaToolStripMenuItem });
            kapcsolódásToolStripMenuItem.Name = "kapcsolódásToolStripMenuItem";
            kapcsolódásToolStripMenuItem.Size = new Size(165, 22);
            kapcsolódásToolStripMenuItem.Text = "Serial connection";
            // 
            // kapcsolatLétrehozásaToolStripMenuItem
            // 
            kapcsolatLétrehozásaToolStripMenuItem.Name = "kapcsolatLétrehozásaToolStripMenuItem";
            kapcsolatLétrehozásaToolStripMenuItem.Size = new Size(133, 22);
            kapcsolatLétrehozásaToolStripMenuItem.Text = "Connect";
            kapcsolatLétrehozásaToolStripMenuItem.Click += KapcsolódásToolStripMenuItem_Click;
            // 
            // kapcsolatBontásaToolStripMenuItem
            // 
            kapcsolatBontásaToolStripMenuItem.Name = "kapcsolatBontásaToolStripMenuItem";
            kapcsolatBontásaToolStripMenuItem.Size = new Size(133, 22);
            kapcsolatBontásaToolStripMenuItem.Text = "Disconnect";
            kapcsolatBontásaToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            kapcsolatBontásaToolStripMenuItem.Click += KapcsolatBontásaToolStripMenuItem_Click;
            // 
            // beállításokToolStripMenuItem
            // 
            beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            beállításokToolStripMenuItem.Size = new Size(165, 22);
            beállításokToolStripMenuItem.Text = "Settings";
            beállításokToolStripMenuItem.Click += BeállításokToolStripMenuItem_Click;
            // 
            // loRaBeállításokToolStripMenuItem
            // 
            loRaBeállításokToolStripMenuItem.Name = "loRaBeállításokToolStripMenuItem";
            loRaBeállításokToolStripMenuItem.Size = new Size(165, 22);
            loRaBeállításokToolStripMenuItem.Text = "LoRa settings";
            loRaBeállításokToolStripMenuItem.Click += loRaBeállításokToolStripMenuItem_Click;
            // 
            // adattárolásToolStripMenuItem
            // 
            adattárolásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { újAdatfájlLétrehozásaToolStripMenuItem, fájlKiválasztásaToolStripMenuItem, cloudStationAdatokTörléseToolStripMenuItem });
            adattárolásToolStripMenuItem.Name = "adattárolásToolStripMenuItem";
            adattárolásToolStripMenuItem.Size = new Size(67, 22);
            adattárolásToolStripMenuItem.Text = "Database";
            // 
            // újAdatfájlLétrehozásaToolStripMenuItem
            // 
            újAdatfájlLétrehozásaToolStripMenuItem.Name = "újAdatfájlLétrehozásaToolStripMenuItem";
            újAdatfájlLétrehozásaToolStripMenuItem.Size = new Size(208, 22);
            újAdatfájlLétrehozásaToolStripMenuItem.Text = "Create new data file";
            újAdatfájlLétrehozásaToolStripMenuItem.Click += ÚjAdatfájlLétrehozásaToolStripMenuItem_Click;
            // 
            // fájlKiválasztásaToolStripMenuItem
            // 
            fájlKiválasztásaToolStripMenuItem.Name = "fájlKiválasztásaToolStripMenuItem";
            fájlKiválasztásaToolStripMenuItem.Size = new Size(208, 22);
            fájlKiválasztásaToolStripMenuItem.Text = "Open data file";
            fájlKiválasztásaToolStripMenuItem.Click += FájlKiválasztásaToolStripMenuItem_Click;
            // 
            // cloudStationAdatokTörléseToolStripMenuItem
            // 
            cloudStationAdatokTörléseToolStripMenuItem.Name = "cloudStationAdatokTörléseToolStripMenuItem";
            cloudStationAdatokTörléseToolStripMenuItem.Size = new Size(208, 22);
            cloudStationAdatokTörléseToolStripMenuItem.Text = "Delete Cloud Station data";
            cloudStationAdatokTörléseToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            cloudStationAdatokTörléseToolStripMenuItem.Click += cloudStationAdatokTörléseToolStripMenuItem_Click;
            // 
            // exportálásToolStripMenuItem
            // 
            exportálásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pNGToolStripMenuItem });
            exportálásToolStripMenuItem.Name = "exportálásToolStripMenuItem";
            exportálásToolStripMenuItem.Size = new Size(53, 22);
            exportálásToolStripMenuItem.Text = "Export";
            // 
            // pNGToolStripMenuItem
            // 
            pNGToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { térképToolStripMenuItem, hőmérsékletGrafikonToolStripMenuItem, relatívPáratartalomGrafikonToolStripMenuItem, légnyomásGrafikonToolStripMenuItem, magasságGrafikonToolStripMenuItem, tengelyesGyorsulásmértGrafikonToolStripMenuItem });
            pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
            pNGToolStripMenuItem.Size = new Size(98, 22);
            pNGToolStripMenuItem.Text = "PNG";
            // 
            // térképToolStripMenuItem
            // 
            térképToolStripMenuItem.Name = "térképToolStripMenuItem";
            térképToolStripMenuItem.Size = new Size(206, 22);
            térképToolStripMenuItem.Text = "Map";
            térképToolStripMenuItem.Click += TérképToolStripMenuItem_Click;
            // 
            // hőmérsékletGrafikonToolStripMenuItem
            // 
            hőmérsékletGrafikonToolStripMenuItem.Name = "hőmérsékletGrafikonToolStripMenuItem";
            hőmérsékletGrafikonToolStripMenuItem.Size = new Size(206, 22);
            hőmérsékletGrafikonToolStripMenuItem.Text = "Temperature graph";
            hőmérsékletGrafikonToolStripMenuItem.TextAlign = ContentAlignment.TopLeft;
            hőmérsékletGrafikonToolStripMenuItem.Click += HőmérsékletGrafikonToolStripMenuItem_Click;
            // 
            // relatívPáratartalomGrafikonToolStripMenuItem
            // 
            relatívPáratartalomGrafikonToolStripMenuItem.Name = "relatívPáratartalomGrafikonToolStripMenuItem";
            relatívPáratartalomGrafikonToolStripMenuItem.Size = new Size(206, 22);
            relatívPáratartalomGrafikonToolStripMenuItem.Text = "Humidity graph";
            relatívPáratartalomGrafikonToolStripMenuItem.Click += RelatívPáratartalomGrafikonToolStripMenuItem_Click;
            // 
            // légnyomásGrafikonToolStripMenuItem
            // 
            légnyomásGrafikonToolStripMenuItem.Name = "légnyomásGrafikonToolStripMenuItem";
            légnyomásGrafikonToolStripMenuItem.Size = new Size(206, 22);
            légnyomásGrafikonToolStripMenuItem.Text = "Pressure graph";
            légnyomásGrafikonToolStripMenuItem.Click += LégnyomásGrafikonToolStripMenuItem_Click;
            // 
            // magasságGrafikonToolStripMenuItem
            // 
            magasságGrafikonToolStripMenuItem.Name = "magasságGrafikonToolStripMenuItem";
            magasságGrafikonToolStripMenuItem.Size = new Size(206, 22);
            magasságGrafikonToolStripMenuItem.Text = "Altitude graph";
            magasságGrafikonToolStripMenuItem.Click += MagasságGrafikonToolStripMenuItem_Click;
            // 
            // tengelyesGyorsulásmértGrafikonToolStripMenuItem
            // 
            tengelyesGyorsulásmértGrafikonToolStripMenuItem.Name = "tengelyesGyorsulásmértGrafikonToolStripMenuItem";
            tengelyesGyorsulásmértGrafikonToolStripMenuItem.Size = new Size(206, 22);
            tengelyesGyorsulásmértGrafikonToolStripMenuItem.Text = "3-axis acceleration graph";
            tengelyesGyorsulásmértGrafikonToolStripMenuItem.Click += TengelyesGyorsulásmértGrafikonToolStripMenuItem_Click;
            // 
            // információkToolStripMenuItem
            // 
            információkToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { updateMapDataToolStripMenuItem, névjegyToolStripMenuItem });
            információkToolStripMenuItem.Name = "információkToolStripMenuItem";
            információkToolStripMenuItem.Size = new Size(82, 22);
            információkToolStripMenuItem.Text = "Information";
            // 
            // updateMapDataToolStripMenuItem
            // 
            updateMapDataToolStripMenuItem.Name = "updateMapDataToolStripMenuItem";
            updateMapDataToolStripMenuItem.Size = new Size(165, 22);
            updateMapDataToolStripMenuItem.Text = "Update map data";
            updateMapDataToolStripMenuItem.Click += updateMapDataToolStripMenuItem_Click;
            // 
            // névjegyToolStripMenuItem
            // 
            névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            névjegyToolStripMenuItem.Size = new Size(165, 22);
            névjegyToolStripMenuItem.Text = "About";
            névjegyToolStripMenuItem.Click += NévjegyToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlText;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox11);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pictureBox9);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1878, 46);
            panel2.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.White;
            label8.Location = new Point(559, 28);
            label8.Name = "label8";
            label8.Size = new Size(130, 15);
            label8.TabIndex = 25;
            label8.Text = "No internet connection";
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.Transparent;
            pictureBox11.Image = Properties.Resources.ethernet;
            pictureBox11.Location = new Point(537, 27);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(16, 16);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 18;
            pictureBox11.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.White;
            label7.Location = new Point(559, 5);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 24;
            label7.Text = "No database selected";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.Image = Properties.Resources.mappafa;
            pictureBox9.Location = new Point(537, 5);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(16, 16);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 23;
            pictureBox9.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.Location = new Point(365, 27);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 22;
            label6.Text = "0 received packets";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(365, 5);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 17;
            label5.Text = "0 uploaded packets";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = Properties.Resources.wifi;
            pictureBox8.Location = new Point(339, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(20, 16);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 21;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = Properties.Resources.adatbazis;
            pictureBox7.Location = new Point(341, 26);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(16, 16);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 26);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 17;
            label4.Text = "0 satellite";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(200, 27);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 17;
            label3.Text = "0 dropped package";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.chart_magnify;
            pictureBox6.Location = new Point(178, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(16, 16);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.felkialtojel;
            pictureBox5.Location = new Point(178, 26);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(16, 16);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.serial;
            pictureBox4.Location = new Point(6, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 16);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.muhold;
            pictureBox3.Location = new Point(6, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 16);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 4);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 16;
            label2.Text = "No connection";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(200, 5);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 15;
            label1.Text = "0 ms";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.Controls.Add(gMapControl1, 1, 0);
            tableLayoutPanel1.Controls.Add(homersekletGrafikon, 0, 0);
            tableLayoutPanel1.Controls.Add(legnyomasGrafikon, 0, 1);
            tableLayoutPanel1.Controls.Add(giroszGrafikon, 1, 2);
            tableLayoutPanel1.Controls.Add(paratartalomGrafikon, 0, 2);
            tableLayoutPanel1.Controls.Add(gyorsulasMertGrafikon, 2, 2);
            tableLayoutPanel1.Location = new Point(0, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1264, 609);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            tableLayoutPanel1.SetColumnSpan(gMapControl1, 2);
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(424, 3);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 2;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            tableLayoutPanel1.SetRowSpan(gMapControl1, 2);
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(837, 400);
            gMapControl1.TabIndex = 0;
            gMapControl1.Zoom = 0D;
            // 
            // homersekletGrafikon
            // 
            homersekletGrafikon.BackColor = Color.White;
            homersekletGrafikon.Dock = DockStyle.Fill;
            homersekletGrafikon.Location = new Point(3, 3);
            homersekletGrafikon.Name = "homersekletGrafikon";
            homersekletGrafikon.PanCursor = Cursors.Hand;
            homersekletGrafikon.Size = new Size(415, 197);
            homersekletGrafikon.TabIndex = 18;
            homersekletGrafikon.Text = "plotView7";
            homersekletGrafikon.ZoomHorizontalCursor = Cursors.SizeWE;
            homersekletGrafikon.ZoomRectangleCursor = Cursors.SizeNWSE;
            homersekletGrafikon.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // legnyomasGrafikon
            // 
            legnyomasGrafikon.BackColor = Color.White;
            legnyomasGrafikon.Dock = DockStyle.Fill;
            legnyomasGrafikon.ForeColor = Color.Transparent;
            legnyomasGrafikon.Location = new Point(3, 206);
            legnyomasGrafikon.Name = "legnyomasGrafikon";
            legnyomasGrafikon.PanCursor = Cursors.Hand;
            legnyomasGrafikon.Size = new Size(415, 197);
            legnyomasGrafikon.TabIndex = 9;
            legnyomasGrafikon.Text = "plotView3";
            legnyomasGrafikon.ZoomHorizontalCursor = Cursors.SizeWE;
            legnyomasGrafikon.ZoomRectangleCursor = Cursors.SizeNWSE;
            legnyomasGrafikon.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // giroszGrafikon
            // 
            giroszGrafikon.BackColor = Color.White;
            giroszGrafikon.Dock = DockStyle.Fill;
            giroszGrafikon.Location = new Point(424, 409);
            giroszGrafikon.Name = "giroszGrafikon";
            giroszGrafikon.PanCursor = Cursors.Hand;
            giroszGrafikon.Size = new Size(415, 197);
            giroszGrafikon.TabIndex = 10;
            giroszGrafikon.Text = "plotView4";
            giroszGrafikon.ZoomHorizontalCursor = Cursors.SizeWE;
            giroszGrafikon.ZoomRectangleCursor = Cursors.SizeNWSE;
            giroszGrafikon.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // paratartalomGrafikon
            // 
            paratartalomGrafikon.BackColor = Color.White;
            paratartalomGrafikon.Dock = DockStyle.Fill;
            paratartalomGrafikon.Location = new Point(3, 409);
            paratartalomGrafikon.Name = "paratartalomGrafikon";
            paratartalomGrafikon.PanCursor = Cursors.Hand;
            paratartalomGrafikon.Size = new Size(415, 197);
            paratartalomGrafikon.TabIndex = 8;
            paratartalomGrafikon.Text = "plotView2";
            paratartalomGrafikon.ZoomHorizontalCursor = Cursors.SizeWE;
            paratartalomGrafikon.ZoomRectangleCursor = Cursors.SizeNWSE;
            paratartalomGrafikon.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // gyorsulasMertGrafikon
            // 
            gyorsulasMertGrafikon.BackColor = Color.White;
            gyorsulasMertGrafikon.Dock = DockStyle.Fill;
            gyorsulasMertGrafikon.Location = new Point(845, 409);
            gyorsulasMertGrafikon.Name = "gyorsulasMertGrafikon";
            gyorsulasMertGrafikon.PanCursor = Cursors.Hand;
            gyorsulasMertGrafikon.Size = new Size(416, 197);
            gyorsulasMertGrafikon.TabIndex = 11;
            gyorsulasMertGrafikon.Text = "plotView5";
            gyorsulasMertGrafikon.ZoomHorizontalCursor = Cursors.SizeWE;
            gyorsulasMertGrafikon.ZoomRectangleCursor = Cursors.SizeNWSE;
            gyorsulasMertGrafikon.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 635);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 0F));
            tableLayoutPanel2.Size = new Size(1878, 46);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OnionSAT Ground Station";
            FormClosing += Main_FormClosing;
            Load += Form1_Load;
            Resize += Main_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fájlToolStripMenuItem;
        private ToolStripMenuItem beállításokToolStripMenuItem;
        private ToolStripMenuItem kapcsolódásToolStripMenuItem;
        private ToolStripMenuItem kapcsolatLétrehozásaToolStripMenuItem;
        private ToolStripMenuItem kapcsolatBontásaToolStripMenuItem;
        private ToolStripMenuItem adattárolásToolStripMenuItem;
        private ToolStripMenuItem fájlKiválasztásaToolStripMenuItem;
        private ToolStripMenuItem újAdatfájlLétrehozásaToolStripMenuItem;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private ToolStripMenuItem exportálásToolStripMenuItem;
        private ToolStripMenuItem pNGToolStripMenuItem;
        private ToolStripMenuItem hőmérsékletGrafikonToolStripMenuItem;
        private ToolStripMenuItem relatívPáratartalomGrafikonToolStripMenuItem;
        private ToolStripMenuItem légnyomásGrafikonToolStripMenuItem;
        private ToolStripMenuItem magasságGrafikonToolStripMenuItem;
        private ToolStripMenuItem tengelyesGyorsulásmértGrafikonToolStripMenuItem;
        private ToolStripMenuItem tengelyesGyorsulásGrafikonToolStripMenuItem;
        private ToolStripMenuItem térképToolStripMenuItem;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox9;
        private Label label8;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox12;
        private ToolStripMenuItem információkToolStripMenuItem;
        private ToolStripMenuItem névjegyToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private OxyPlot.WindowsForms.PlotView paratartalomGrafikon;
        private OxyPlot.WindowsForms.PlotView legnyomasGrafikon;
        private OxyPlot.WindowsForms.PlotView gyorsulasMertGrafikon;
        private OxyPlot.WindowsForms.PlotView gyorsulasGrafikon;
        private OxyPlot.WindowsForms.PlotView giroszGrafikon;
        private OxyPlot.WindowsForms.PlotView homersekletGrafikon;
        private TableLayoutPanel tableLayoutPanel2;
        private ToolStripMenuItem loRaBeállításokToolStripMenuItem;
        private ToolStripMenuItem cloudStationAdatokTörléseToolStripMenuItem;
        private ToolStripMenuItem updateMapDataToolStripMenuItem;
    }
}