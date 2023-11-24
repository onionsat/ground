namespace OnionSAT
{
    partial class Form1
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
            hőmérsékletGrafikonToolStripMenuItem = new ToolStripMenuItem();
            relatívPáratartalomGrafikonToolStripMenuItem = new ToolStripMenuItem();
            légnyomásGrafikonToolStripMenuItem = new ToolStripMenuItem();
            magasságGrafikonToolStripMenuItem = new ToolStripMenuItem();
            tengelyesGyorsulásmértGrafikonToolStripMenuItem = new ToolStripMenuItem();
            tengelyesGyorsulásGrafikonToolStripMenuItem = new ToolStripMenuItem();
            plotView2 = new OxyPlot.WindowsForms.PlotView();
            plotView3 = new OxyPlot.WindowsForms.PlotView();
            plotView7 = new OxyPlot.WindowsForms.PlotView();
            plotView5 = new OxyPlot.WindowsForms.PlotView();
            plotView61 = new OxyPlot.WindowsForms.PlotView();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            plotView4 = new OxyPlot.WindowsForms.PlotView();
            plotView8 = new OxyPlot.WindowsForms.PlotView();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            gMapControl1.Margin = new Padding(4, 5, 4, 5);
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
            gMapControl1.Size = new Size(977, 698);
            gMapControl1.TabIndex = 0;
            gMapControl1.Zoom = 0D;
            // 
            // panel1
            // 
            panel1.Controls.Add(gMapControl1);
            panel1.Location = new Point(883, 53);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 698);
            panel1.TabIndex = 2;
            // 
            // plotView1
            // 
            plotView1.BackColor = Color.White;
            plotView1.Location = new Point(17, 53);
            plotView1.Margin = new Padding(4, 5, 4, 5);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(857, 508);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { fájlToolStripMenuItem, adattárolásToolStripMenuItem, exportálásToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2743, 33);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            fájlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kapcsolódásToolStripMenuItem, beállításokToolStripMenuItem });
            fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            fájlToolStripMenuItem.Size = new Size(104, 29);
            fájlToolStripMenuItem.Text = "Kapcsolat";
            // 
            // kapcsolódásToolStripMenuItem
            // 
            kapcsolódásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kapcsolatLétrehozásaToolStripMenuItem, kapcsolatBontásaToolStripMenuItem });
            kapcsolódásToolStripMenuItem.Name = "kapcsolódásToolStripMenuItem";
            kapcsolódásToolStripMenuItem.Size = new Size(214, 34);
            kapcsolódásToolStripMenuItem.Text = "Kapcsolódás";
            // 
            // kapcsolatLétrehozásaToolStripMenuItem
            // 
            kapcsolatLétrehozásaToolStripMenuItem.Name = "kapcsolatLétrehozásaToolStripMenuItem";
            kapcsolatLétrehozásaToolStripMenuItem.Size = new Size(284, 34);
            kapcsolatLétrehozásaToolStripMenuItem.Text = "Kapcsolat létrehozása";
            kapcsolatLétrehozásaToolStripMenuItem.Click += kapcsolódásToolStripMenuItem_Click;
            // 
            // kapcsolatBontásaToolStripMenuItem
            // 
            kapcsolatBontásaToolStripMenuItem.Name = "kapcsolatBontásaToolStripMenuItem";
            kapcsolatBontásaToolStripMenuItem.Size = new Size(284, 34);
            kapcsolatBontásaToolStripMenuItem.Text = "Kapcsolat bontása";
            kapcsolatBontásaToolStripMenuItem.Click += kapcsolatBontásaToolStripMenuItem_Click;
            // 
            // beállításokToolStripMenuItem
            // 
            beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            beállításokToolStripMenuItem.Size = new Size(214, 34);
            beállításokToolStripMenuItem.Text = "Beállítások";
            beállításokToolStripMenuItem.Click += beállításokToolStripMenuItem_Click;
            // 
            // adattárolásToolStripMenuItem
            // 
            adattárolásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { újAdatfájlLétrehozásaToolStripMenuItem, fájlKiválasztásaToolStripMenuItem });
            adattárolásToolStripMenuItem.Name = "adattárolásToolStripMenuItem";
            adattárolásToolStripMenuItem.Size = new Size(119, 29);
            adattárolásToolStripMenuItem.Text = "Adattárolás";
            // 
            // újAdatfájlLétrehozásaToolStripMenuItem
            // 
            újAdatfájlLétrehozásaToolStripMenuItem.Name = "újAdatfájlLétrehozásaToolStripMenuItem";
            újAdatfájlLétrehozásaToolStripMenuItem.Size = new Size(287, 34);
            újAdatfájlLétrehozásaToolStripMenuItem.Text = "Új adatfájl létrehozása";
            újAdatfájlLétrehozásaToolStripMenuItem.Click += újAdatfájlLétrehozásaToolStripMenuItem_Click;
            // 
            // fájlKiválasztásaToolStripMenuItem
            // 
            fájlKiválasztásaToolStripMenuItem.Name = "fájlKiválasztásaToolStripMenuItem";
            fájlKiválasztásaToolStripMenuItem.Size = new Size(287, 34);
            fájlKiválasztásaToolStripMenuItem.Text = "Fájl kiválasztása";
            fájlKiválasztásaToolStripMenuItem.Click += fájlKiválasztásaToolStripMenuItem_Click;
            // 
            // exportálásToolStripMenuItem
            // 
            exportálásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pNGToolStripMenuItem });
            exportálásToolStripMenuItem.Name = "exportálásToolStripMenuItem";
            exportálásToolStripMenuItem.Size = new Size(109, 29);
            exportálásToolStripMenuItem.Text = "Exportálás";
            exportálásToolStripMenuItem.Click += exportálásToolStripMenuItem_Click;
            // 
            // pNGToolStripMenuItem
            // 
            pNGToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hőmérsékletGrafikonToolStripMenuItem, relatívPáratartalomGrafikonToolStripMenuItem, légnyomásGrafikonToolStripMenuItem, magasságGrafikonToolStripMenuItem, tengelyesGyorsulásmértGrafikonToolStripMenuItem, tengelyesGyorsulásGrafikonToolStripMenuItem });
            pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
            pNGToolStripMenuItem.Size = new Size(270, 34);
            pNGToolStripMenuItem.Text = "PNG";
            // 
            // hőmérsékletGrafikonToolStripMenuItem
            // 
            hőmérsékletGrafikonToolStripMenuItem.Name = "hőmérsékletGrafikonToolStripMenuItem";
            hőmérsékletGrafikonToolStripMenuItem.Size = new Size(410, 34);
            hőmérsékletGrafikonToolStripMenuItem.Text = "Hőmérséklet grafikon";
            hőmérsékletGrafikonToolStripMenuItem.Click += hőmérsékletGrafikonToolStripMenuItem_Click;
            // 
            // relatívPáratartalomGrafikonToolStripMenuItem
            // 
            relatívPáratartalomGrafikonToolStripMenuItem.Name = "relatívPáratartalomGrafikonToolStripMenuItem";
            relatívPáratartalomGrafikonToolStripMenuItem.Size = new Size(410, 34);
            relatívPáratartalomGrafikonToolStripMenuItem.Text = "Relatív páratartalom grafikon";
            relatívPáratartalomGrafikonToolStripMenuItem.Click += relatívPáratartalomGrafikonToolStripMenuItem_Click;
            // 
            // légnyomásGrafikonToolStripMenuItem
            // 
            légnyomásGrafikonToolStripMenuItem.Name = "légnyomásGrafikonToolStripMenuItem";
            légnyomásGrafikonToolStripMenuItem.Size = new Size(410, 34);
            légnyomásGrafikonToolStripMenuItem.Text = "Légnyomás grafikon";
            légnyomásGrafikonToolStripMenuItem.Click += légnyomásGrafikonToolStripMenuItem_Click;
            // 
            // magasságGrafikonToolStripMenuItem
            // 
            magasságGrafikonToolStripMenuItem.Name = "magasságGrafikonToolStripMenuItem";
            magasságGrafikonToolStripMenuItem.Size = new Size(410, 34);
            magasságGrafikonToolStripMenuItem.Text = "Magasság grafikon";
            magasságGrafikonToolStripMenuItem.Click += magasságGrafikonToolStripMenuItem_Click;
            // 
            // tengelyesGyorsulásmértGrafikonToolStripMenuItem
            // 
            tengelyesGyorsulásmértGrafikonToolStripMenuItem.Name = "tengelyesGyorsulásmértGrafikonToolStripMenuItem";
            tengelyesGyorsulásmértGrafikonToolStripMenuItem.Size = new Size(410, 34);
            tengelyesGyorsulásmértGrafikonToolStripMenuItem.Text = "3-tengelyes gyorsulás (mért) grafikon";
            tengelyesGyorsulásmértGrafikonToolStripMenuItem.Click += tengelyesGyorsulásmértGrafikonToolStripMenuItem_Click;
            // 
            // tengelyesGyorsulásGrafikonToolStripMenuItem
            // 
            tengelyesGyorsulásGrafikonToolStripMenuItem.Name = "tengelyesGyorsulásGrafikonToolStripMenuItem";
            tengelyesGyorsulásGrafikonToolStripMenuItem.Size = new Size(410, 34);
            tengelyesGyorsulásGrafikonToolStripMenuItem.Text = "3-tengelyes gyorsulás grafikon";
            tengelyesGyorsulásGrafikonToolStripMenuItem.Click += tengelyesGyorsulásGrafikonToolStripMenuItem_Click;
            // 
            // plotView2
            // 
            plotView2.BackColor = Color.White;
            plotView2.Location = new Point(17, 567);
            plotView2.Margin = new Padding(4, 5, 4, 5);
            plotView2.Name = "plotView2";
            plotView2.PanCursor = Cursors.Hand;
            plotView2.Size = new Size(857, 508);
            plotView2.TabIndex = 8;
            plotView2.Text = "plotView2";
            plotView2.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView2.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView3
            // 
            plotView3.BackColor = Color.White;
            plotView3.Location = new Point(16, 1082);
            plotView3.Margin = new Padding(4, 5, 4, 5);
            plotView3.Name = "plotView3";
            plotView3.PanCursor = Cursors.Hand;
            plotView3.Size = new Size(857, 508);
            plotView3.TabIndex = 9;
            plotView3.Text = "plotView3";
            plotView3.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView3.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView3.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView7
            // 
            plotView7.BackColor = Color.White;
            plotView7.Location = new Point(1869, 53);
            plotView7.Margin = new Padding(4, 5, 4, 5);
            plotView7.Name = "plotView7";
            plotView7.PanCursor = Cursors.Hand;
            plotView7.Size = new Size(857, 508);
            plotView7.TabIndex = 10;
            plotView7.Text = "plotView4";
            plotView7.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView7.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView7.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView5
            // 
            plotView5.BackColor = Color.White;
            plotView5.Location = new Point(883, 762);
            plotView5.Margin = new Padding(4, 5, 4, 5);
            plotView5.Name = "plotView5";
            plotView5.PanCursor = Cursors.Hand;
            plotView5.Size = new Size(977, 408);
            plotView5.TabIndex = 11;
            plotView5.Text = "plotView5";
            plotView5.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView5.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView5.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView61
            // 
            plotView61.BackColor = Color.White;
            plotView61.Location = new Point(1869, 572);
            plotView61.Margin = new Padding(4, 5, 4, 5);
            plotView61.Name = "plotView61";
            plotView61.PanCursor = Cursors.Hand;
            plotView61.Size = new Size(857, 508);
            plotView61.TabIndex = 12;
            plotView61.Text = "plotView6";
            plotView61.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView61.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView61.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rackforest_logo01;
            pictureBox1.Location = new Point(23, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlText;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 1600);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(2743, 82);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.bdg;
            pictureBox2.Location = new Point(237, -5);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // plotView4
            // 
            plotView4.BackColor = Color.White;
            plotView4.Location = new Point(881, 1180);
            plotView4.Margin = new Padding(4, 5, 4, 5);
            plotView4.Name = "plotView4";
            plotView4.PanCursor = Cursors.Hand;
            plotView4.Size = new Size(979, 408);
            plotView4.TabIndex = 15;
            plotView4.Text = "plotView7";
            plotView4.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView4.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView4.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView8
            // 
            plotView8.BackColor = Color.White;
            plotView8.Location = new Point(1869, 1090);
            plotView8.Margin = new Padding(4, 5, 4, 5);
            plotView8.Name = "plotView8";
            plotView8.PanCursor = Cursors.Hand;
            plotView8.Size = new Size(857, 508);
            plotView8.TabIndex = 16;
            plotView8.Text = "plotView8";
            plotView8.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView8.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView8.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1250);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Panel panel1;
        private ComboBox comboBox1;
        private Button button2;
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
        private OxyPlot.WindowsForms.PlotView plotView6;
        private ToolStripMenuItem exportálásToolStripMenuItem;
        private ToolStripMenuItem pNGToolStripMenuItem;
        private ToolStripMenuItem hőmérsékletGrafikonToolStripMenuItem;
        private ToolStripMenuItem relatívPáratartalomGrafikonToolStripMenuItem;
        private ToolStripMenuItem légnyomásGrafikonToolStripMenuItem;
        private ToolStripMenuItem magasságGrafikonToolStripMenuItem;
        private ToolStripMenuItem tengelyesGyorsulásmértGrafikonToolStripMenuItem;
        private ToolStripMenuItem tengelyesGyorsulásGrafikonToolStripMenuItem;
    }
}