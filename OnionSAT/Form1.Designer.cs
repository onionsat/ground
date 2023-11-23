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
            menuStrip1.Items.AddRange(new ToolStripItem[] { fájlToolStripMenuItem, adattárolásToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1920, 24);
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
            kapcsolódásToolStripMenuItem.Size = new Size(140, 22);
            kapcsolódásToolStripMenuItem.Text = "Kapcsolódás";
            // 
            // kapcsolatLétrehozásaToolStripMenuItem
            // 
            kapcsolatLétrehozásaToolStripMenuItem.Name = "kapcsolatLétrehozásaToolStripMenuItem";
            kapcsolatLétrehozásaToolStripMenuItem.Size = new Size(187, 22);
            kapcsolatLétrehozásaToolStripMenuItem.Text = "Kapcsolat létrehozása";
            kapcsolatLétrehozásaToolStripMenuItem.Click += kapcsolódásToolStripMenuItem_Click;
            // 
            // kapcsolatBontásaToolStripMenuItem
            // 
            kapcsolatBontásaToolStripMenuItem.Name = "kapcsolatBontásaToolStripMenuItem";
            kapcsolatBontásaToolStripMenuItem.Size = new Size(187, 22);
            kapcsolatBontásaToolStripMenuItem.Text = "Kapcsolat bontása";
            kapcsolatBontásaToolStripMenuItem.Click += kapcsolatBontásaToolStripMenuItem_Click;
            // 
            // beállításokToolStripMenuItem
            // 
            beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            beállításokToolStripMenuItem.Size = new Size(140, 22);
            beállításokToolStripMenuItem.Text = "Beállítások";
            beállításokToolStripMenuItem.Click += beállításokToolStripMenuItem_Click;
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
            újAdatfájlLétrehozásaToolStripMenuItem.Click += újAdatfájlLétrehozásaToolStripMenuItem_Click;
            // 
            // fájlKiválasztásaToolStripMenuItem
            // 
            fájlKiválasztásaToolStripMenuItem.Name = "fájlKiválasztásaToolStripMenuItem";
            fájlKiválasztásaToolStripMenuItem.Size = new Size(189, 22);
            fájlKiválasztásaToolStripMenuItem.Text = "Fájl kiválasztása";
            fájlKiválasztásaToolStripMenuItem.Click += fájlKiválasztásaToolStripMenuItem_Click;
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
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 960);
            panel2.Name = "panel2";
            panel2.Size = new Size(1920, 49);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1904, 1008);
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
    }
}