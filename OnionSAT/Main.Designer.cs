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
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            panel1 = new Panel();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            menuStrip1 = new MenuStrip();
            fájlToolStripMenuItem = new ToolStripMenuItem();
            kapcsolódásToolStripMenuItem = new ToolStripMenuItem();
            kapcsolatLétrehozásaToolStripMenuItem = new ToolStripMenuItem();
            kapcsolatBontásaToolStripMenuItem = new ToolStripMenuItem();
            beállításokToolStripMenuItem = new ToolStripMenuItem();
            adattárolásToolStripMenuItem = new ToolStripMenuItem();
            újAdatfájlLétrehozásaToolStripMenuItem = new ToolStripMenuItem();
            fájlKiválasztásaToolStripMenuItem = new ToolStripMenuItem();
            exportálásToolStripMenuItem = new ToolStripMenuItem();
            pNGToolStripMenuItem = new ToolStripMenuItem();
            térképToolStripMenuItem = new ToolStripMenuItem();
            hőmérsékletGrafikonToolStripMenuItem = new ToolStripMenuItem();
            relatívPáratartalomGrafikonToolStripMenuItem = new ToolStripMenuItem();
            légnyomásGrafikonToolStripMenuItem = new ToolStripMenuItem();
            magasságGrafikonToolStripMenuItem = new ToolStripMenuItem();
            tengelyesGyorsulásmértGrafikonToolStripMenuItem = new ToolStripMenuItem();
            tengelyesGyorsulásGrafikonToolStripMenuItem = new ToolStripMenuItem();
            információkToolStripMenuItem = new ToolStripMenuItem();
            névjegyToolStripMenuItem = new ToolStripMenuItem();
            plotView2 = new OxyPlot.WindowsForms.PlotView();
            plotView3 = new OxyPlot.WindowsForms.PlotView();
            plotView7 = new OxyPlot.WindowsForms.PlotView();
            plotView5 = new OxyPlot.WindowsForms.PlotView();
            plotView61 = new OxyPlot.WindowsForms.PlotView();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox12 = new PictureBox();
            pictureBox10 = new PictureBox();
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
            pictureBox2 = new PictureBox();
            plotView4 = new OxyPlot.WindowsForms.PlotView();
            plotView8 = new OxyPlot.WindowsForms.PlotView();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(-1, 0);
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
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(684, 419);
            gMapControl1.TabIndex = 0;
            gMapControl1.Zoom = 0D;
            // 
            // panel1
            // 
            panel1.Controls.Add(gMapControl1);
            panel1.Location = new Point(618, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 419);
            panel1.TabIndex = 2;
            // 
            // plotView1
            // 
            plotView1.BackColor = Color.White;
            plotView1.Location = new Point(12, 32);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(600, 305);
            plotView1.TabIndex = 6;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fájlToolStripMenuItem, adattárolásToolStripMenuItem, exportálásToolStripMenuItem, információkToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1952, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            fájlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kapcsolódásToolStripMenuItem, beállításokToolStripMenuItem });
            fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            fájlToolStripMenuItem.Size = new Size(70, 22);
            fájlToolStripMenuItem.Text = "Kapcsolat";
            // 
            // kapcsolódásToolStripMenuItem
            // 
            kapcsolódásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kapcsolatLétrehozásaToolStripMenuItem, kapcsolatBontásaToolStripMenuItem });
            kapcsolódásToolStripMenuItem.Name = "kapcsolódásToolStripMenuItem";
            kapcsolódásToolStripMenuItem.Size = new Size(180, 22);
            kapcsolódásToolStripMenuItem.Text = "Kapcsolódás";
            // 
            // kapcsolatLétrehozásaToolStripMenuItem
            // 
            kapcsolatLétrehozásaToolStripMenuItem.Name = "kapcsolatLétrehozásaToolStripMenuItem";
            kapcsolatLétrehozásaToolStripMenuItem.Size = new Size(187, 22);
            kapcsolatLétrehozásaToolStripMenuItem.Text = "Kapcsolat létrehozása";
            kapcsolatLétrehozásaToolStripMenuItem.Click += KapcsolódásToolStripMenuItem_Click;
            // 
            // kapcsolatBontásaToolStripMenuItem
            // 
            kapcsolatBontásaToolStripMenuItem.Name = "kapcsolatBontásaToolStripMenuItem";
            kapcsolatBontásaToolStripMenuItem.Size = new Size(187, 22);
            kapcsolatBontásaToolStripMenuItem.Text = "Kapcsolat bontása";
            kapcsolatBontásaToolStripMenuItem.Click += KapcsolatBontásaToolStripMenuItem_Click;
            // 
            // beállításokToolStripMenuItem
            // 
            beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            beállításokToolStripMenuItem.Size = new Size(180, 22);
            beállításokToolStripMenuItem.Text = "Beállítások";
            beállításokToolStripMenuItem.Click += BeállításokToolStripMenuItem_Click;
            // 
            // adattárolásToolStripMenuItem
            // 
            adattárolásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { újAdatfájlLétrehozásaToolStripMenuItem, fájlKiválasztásaToolStripMenuItem });
            adattárolásToolStripMenuItem.Name = "adattárolásToolStripMenuItem";
            adattárolásToolStripMenuItem.Size = new Size(79, 22);
            adattárolásToolStripMenuItem.Text = "Adattárolás";
            // 
            // újAdatfájlLétrehozásaToolStripMenuItem
            // 
            újAdatfájlLétrehozásaToolStripMenuItem.Name = "újAdatfájlLétrehozásaToolStripMenuItem";
            újAdatfájlLétrehozásaToolStripMenuItem.Size = new Size(189, 22);
            újAdatfájlLétrehozásaToolStripMenuItem.Text = "Új adatfájl létrehozása";
            újAdatfájlLétrehozásaToolStripMenuItem.Click += ÚjAdatfájlLétrehozásaToolStripMenuItem_Click;
            // 
            // fájlKiválasztásaToolStripMenuItem
            // 
            fájlKiválasztásaToolStripMenuItem.Name = "fájlKiválasztásaToolStripMenuItem";
            fájlKiválasztásaToolStripMenuItem.Size = new Size(189, 22);
            fájlKiválasztásaToolStripMenuItem.Text = "Fájl kiválasztása";
            fájlKiválasztásaToolStripMenuItem.Click += FájlKiválasztásaToolStripMenuItem_Click;
            // 
            // exportálásToolStripMenuItem
            // 
            exportálásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pNGToolStripMenuItem });
            exportálásToolStripMenuItem.Name = "exportálásToolStripMenuItem";
            exportálásToolStripMenuItem.Size = new Size(73, 22);
            exportálásToolStripMenuItem.Text = "Exportálás";
            // 
            // pNGToolStripMenuItem
            // 
            pNGToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { térképToolStripMenuItem, hőmérsékletGrafikonToolStripMenuItem, relatívPáratartalomGrafikonToolStripMenuItem, légnyomásGrafikonToolStripMenuItem, magasságGrafikonToolStripMenuItem, tengelyesGyorsulásmértGrafikonToolStripMenuItem, tengelyesGyorsulásGrafikonToolStripMenuItem });
            pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
            pNGToolStripMenuItem.Size = new Size(180, 22);
            pNGToolStripMenuItem.Text = "PNG";
            // 
            // térképToolStripMenuItem
            // 
            térképToolStripMenuItem.Name = "térképToolStripMenuItem";
            térképToolStripMenuItem.Size = new Size(271, 22);
            térképToolStripMenuItem.Text = "Térkép";
            térképToolStripMenuItem.Click += TérképToolStripMenuItem_Click;
            // 
            // hőmérsékletGrafikonToolStripMenuItem
            // 
            hőmérsékletGrafikonToolStripMenuItem.Name = "hőmérsékletGrafikonToolStripMenuItem";
            hőmérsékletGrafikonToolStripMenuItem.Size = new Size(271, 22);
            hőmérsékletGrafikonToolStripMenuItem.Text = "Hőmérséklet grafikon";
            hőmérsékletGrafikonToolStripMenuItem.Click += HőmérsékletGrafikonToolStripMenuItem_Click;
            // 
            // relatívPáratartalomGrafikonToolStripMenuItem
            // 
            relatívPáratartalomGrafikonToolStripMenuItem.Name = "relatívPáratartalomGrafikonToolStripMenuItem";
            relatívPáratartalomGrafikonToolStripMenuItem.Size = new Size(271, 22);
            relatívPáratartalomGrafikonToolStripMenuItem.Text = "Relatív páratartalom grafikon";
            relatívPáratartalomGrafikonToolStripMenuItem.Click += RelatívPáratartalomGrafikonToolStripMenuItem_Click;
            // 
            // légnyomásGrafikonToolStripMenuItem
            // 
            légnyomásGrafikonToolStripMenuItem.Name = "légnyomásGrafikonToolStripMenuItem";
            légnyomásGrafikonToolStripMenuItem.Size = new Size(271, 22);
            légnyomásGrafikonToolStripMenuItem.Text = "Légnyomás grafikon";
            légnyomásGrafikonToolStripMenuItem.Click += LégnyomásGrafikonToolStripMenuItem_Click;
            // 
            // magasságGrafikonToolStripMenuItem
            // 
            magasságGrafikonToolStripMenuItem.Name = "magasságGrafikonToolStripMenuItem";
            magasságGrafikonToolStripMenuItem.Size = new Size(271, 22);
            magasságGrafikonToolStripMenuItem.Text = "Magasság grafikon";
            magasságGrafikonToolStripMenuItem.Click += MagasságGrafikonToolStripMenuItem_Click;
            // 
            // tengelyesGyorsulásmértGrafikonToolStripMenuItem
            // 
            tengelyesGyorsulásmértGrafikonToolStripMenuItem.Name = "tengelyesGyorsulásmértGrafikonToolStripMenuItem";
            tengelyesGyorsulásmértGrafikonToolStripMenuItem.Size = new Size(271, 22);
            tengelyesGyorsulásmértGrafikonToolStripMenuItem.Text = "3-tengelyes gyorsulás (mért) grafikon";
            tengelyesGyorsulásmértGrafikonToolStripMenuItem.Click += TengelyesGyorsulásmértGrafikonToolStripMenuItem_Click;
            // 
            // tengelyesGyorsulásGrafikonToolStripMenuItem
            // 
            tengelyesGyorsulásGrafikonToolStripMenuItem.Name = "tengelyesGyorsulásGrafikonToolStripMenuItem";
            tengelyesGyorsulásGrafikonToolStripMenuItem.Size = new Size(271, 22);
            tengelyesGyorsulásGrafikonToolStripMenuItem.Text = "3-tengelyes gyorsulás grafikon";
            tengelyesGyorsulásGrafikonToolStripMenuItem.Click += TengelyesGyorsulásGrafikonToolStripMenuItem_Click;
            // 
            // információkToolStripMenuItem
            // 
            információkToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { névjegyToolStripMenuItem });
            információkToolStripMenuItem.Name = "információkToolStripMenuItem";
            információkToolStripMenuItem.Size = new Size(83, 22);
            információkToolStripMenuItem.Text = "Információk";
            // 
            // névjegyToolStripMenuItem
            // 
            névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            névjegyToolStripMenuItem.Size = new Size(180, 22);
            névjegyToolStripMenuItem.Text = "Névjegy";
            névjegyToolStripMenuItem.Click += NévjegyToolStripMenuItem_Click;
            // 
            // plotView2
            // 
            plotView2.BackColor = Color.White;
            plotView2.Location = new Point(12, 340);
            plotView2.Name = "plotView2";
            plotView2.PanCursor = Cursors.Hand;
            plotView2.Size = new Size(600, 305);
            plotView2.TabIndex = 8;
            plotView2.Text = "plotView2";
            plotView2.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView2.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView3
            // 
            plotView3.BackColor = Color.White;
            plotView3.ForeColor = Color.Transparent;
            plotView3.Location = new Point(11, 649);
            plotView3.Name = "plotView3";
            plotView3.PanCursor = Cursors.Hand;
            plotView3.Size = new Size(600, 305);
            plotView3.TabIndex = 9;
            plotView3.Text = "plotView3";
            plotView3.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView3.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView3.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView7
            // 
            plotView7.BackColor = Color.White;
            plotView7.Location = new Point(1308, 32);
            plotView7.Name = "plotView7";
            plotView7.PanCursor = Cursors.Hand;
            plotView7.Size = new Size(600, 305);
            plotView7.TabIndex = 10;
            plotView7.Text = "plotView4";
            plotView7.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView7.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView7.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView5
            // 
            plotView5.BackColor = Color.White;
            plotView5.Location = new Point(618, 457);
            plotView5.Name = "plotView5";
            plotView5.PanCursor = Cursors.Hand;
            plotView5.Size = new Size(684, 245);
            plotView5.TabIndex = 11;
            plotView5.Text = "plotView5";
            plotView5.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView5.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView5.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView61
            // 
            plotView61.BackColor = Color.White;
            plotView61.Location = new Point(1308, 343);
            plotView61.Name = "plotView61";
            plotView61.PanCursor = Cursors.Hand;
            plotView61.Size = new Size(600, 305);
            plotView61.TabIndex = 12;
            plotView61.Text = "plotView6";
            plotView61.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView61.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView61.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rackforest_logo01;
            pictureBox1.Location = new Point(16, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlText;
            panel2.Controls.Add(pictureBox12);
            panel2.Controls.Add(pictureBox10);
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
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 960);
            panel2.Name = "panel2";
            panel2.Size = new Size(1952, 138);
            panel2.TabIndex = 14;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.Transparent;
            pictureBox12.Image = Properties.Resources.chipcad;
            pictureBox12.Location = new Point(1814, 8);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(96, 34);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 26;
            pictureBox12.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.Image = Properties.Resources.pnlkft_verylight;
            pictureBox10.Location = new Point(1603, -73);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(200, 200);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 17;
            pictureBox10.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.White;
            label8.Location = new Point(791, 28);
            label8.Name = "label8";
            label8.Size = new Size(131, 15);
            label8.TabIndex = 25;
            label8.Text = "Nincs internetkapcsolat";
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.Transparent;
            pictureBox11.Image = Properties.Resources.ethernet;
            pictureBox11.Location = new Point(769, 27);
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
            label7.Location = new Point(791, 5);
            label7.Name = "label7";
            label7.Size = new Size(141, 15);
            label7.TabIndex = 24;
            label7.Text = "Nincs kiválasztott adatfájl";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.Image = Properties.Resources.mappafa;
            pictureBox9.Location = new Point(769, 5);
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
            label6.Location = new Point(597, 27);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 22;
            label6.Text = "0 beérkezett csomag";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(597, 5);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 17;
            label5.Text = "0 feltöltött csomag";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = Properties.Resources.wifi;
            pictureBox8.Location = new Point(571, 4);
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
            pictureBox7.Location = new Point(573, 26);
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
            label4.Location = new Point(260, 26);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 17;
            label4.Text = "0 műhold";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(432, 27);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 17;
            label3.Text = "0 kiesett csomag";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.chart_magnify;
            pictureBox6.Location = new Point(410, 4);
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
            pictureBox5.Location = new Point(410, 26);
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
            pictureBox4.Location = new Point(238, 4);
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
            pictureBox3.Location = new Point(238, 26);
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
            label2.Location = new Point(260, 4);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 16;
            label2.Text = "Nincs kapcsolat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(432, 5);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 15;
            label1.Text = "0 ms";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.bdg;
            pictureBox2.Location = new Point(166, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // plotView4
            // 
            plotView4.BackColor = Color.White;
            plotView4.Location = new Point(617, 708);
            plotView4.Name = "plotView4";
            plotView4.PanCursor = Cursors.Hand;
            plotView4.Size = new Size(685, 245);
            plotView4.TabIndex = 15;
            plotView4.Text = "plotView7";
            plotView4.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView4.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView4.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView8
            // 
            plotView8.BackColor = Color.White;
            plotView8.Location = new Point(1308, 654);
            plotView8.Name = "plotView8";
            plotView8.PanCursor = Cursors.Hand;
            plotView8.Size = new Size(600, 305);
            plotView8.TabIndex = 16;
            plotView8.Text = "plotView8";
            plotView8.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView8.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView8.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1904, 1009);
            Controls.Add(plotView8);
            Controls.Add(plotView4);
            Controls.Add(panel2);
            Controls.Add(plotView61);
            Controls.Add(plotView5);
            Controls.Add(plotView7);
            Controls.Add(plotView3);
            Controls.Add(plotView2);
            Controls.Add(plotView1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OnionSAT Ground Station";
            FormClosing += Main_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Panel panel1;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fájlToolStripMenuItem;
        private ToolStripMenuItem beállításokToolStripMenuItem;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private OxyPlot.WindowsForms.PlotView plotView3;
        private OxyPlot.WindowsForms.PlotView plotView4;
        private OxyPlot.WindowsForms.PlotView plotView5;
        private OxyPlot.WindowsForms.PlotView plotView61;
        private ToolStripMenuItem kapcsolódásToolStripMenuItem;
        private ToolStripMenuItem kapcsolatLétrehozásaToolStripMenuItem;
        private ToolStripMenuItem kapcsolatBontásaToolStripMenuItem;
        private ToolStripMenuItem adattárolásToolStripMenuItem;
        private ToolStripMenuItem fájlKiválasztásaToolStripMenuItem;
        private ToolStripMenuItem újAdatfájlLétrehozásaToolStripMenuItem;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private OxyPlot.WindowsForms.PlotView plotView7;
        private OxyPlot.WindowsForms.PlotView plotView8;
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
    }
}