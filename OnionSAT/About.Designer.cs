namespace OnionSAT
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.onionsat_logo;
            pictureBox1.Location = new Point(118, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 236);
            label1.Name = "label1";
            label1.Size = new Size(343, 40);
            label1.TabIndex = 1;
            label1.Text = "OnionSAT Ground Station";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(155, 276);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 2;
            label2.Text = "2023 © Pécsi Tamás";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 433);
            label3.Name = "label3";
            label3.Size = new Size(191, 15);
            label3.TabIndex = 3;
            label3.Text = "Készült a 2024-es Cansat versenyre.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(135, 336);
            label4.Name = "label4";
            label4.Size = new Size(165, 42);
            label4.TabIndex = 4;
            label4.Text = "sat@onionsat.com\r\ntamas@pecsitamas.hu\r\n";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(435, 470);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "About";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Névjegy";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}