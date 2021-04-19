namespace OYUN
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnkarıstır = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.lbls = new System.Windows.Forms.Label();
            this.lblsure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.lblhamle = new System.Windows.Forms.Label();
            this.lblhamlesayisi = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkarıstır
            // 
            this.btnkarıstır.BackColor = System.Drawing.Color.SkyBlue;
            this.btnkarıstır.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkarıstır.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnkarıstır.Location = new System.Drawing.Point(19, 532);
            this.btnkarıstır.Name = "btnkarıstır";
            this.btnkarıstır.Size = new System.Drawing.Size(202, 84);
            this.btnkarıstır.TabIndex = 14;
            this.btnkarıstır.Text = " KARIŞTIR";
            this.btnkarıstır.UseVisualStyleBackColor = false;
            this.btnkarıstır.Click += new System.EventHandler(this.btnkarıstır_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.Color.SkyBlue;
            this.btncıkıs.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncıkıs.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btncıkıs.Location = new System.Drawing.Point(848, 513);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(202, 84);
            this.btncıkıs.TabIndex = 15;
            this.btncıkıs.Text = "ÇIKIŞ";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Font = new System.Drawing.Font("Algerian", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls.ForeColor = System.Drawing.Color.LightCoral;
            this.lbls.Location = new System.Drawing.Point(441, 532);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(118, 36);
            this.lbls.TabIndex = 16;
            this.lbls.Text = "Süre :";
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Font = new System.Drawing.Font("Algerian", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsure.ForeColor = System.Drawing.Color.LightCoral;
            this.lblsure.Location = new System.Drawing.Point(584, 532);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(35, 36);
            this.lblsure.TabIndex = 17;
            this.lblsure.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "muz.png");
            this.ımageList1.Images.SetKeyName(1, "çilek.png");
            this.ımageList1.Images.SetKeyName(2, "portakal.png");
            this.ımageList1.Images.SetKeyName(3, "armut.png");
            this.ımageList1.Images.SetKeyName(4, "elma.png");
            this.ımageList1.Images.SetKeyName(5, "üzüm.png");
            this.ımageList1.Images.SetKeyName(6, "siyah.PNG");
            this.ımageList1.Images.SetKeyName(7, "soru.png");
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(30, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 210);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(204, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 210);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(365, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 210);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(538, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 210);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(713, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 210);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(893, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 210);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(30, 273);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 210);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.ImageList = this.ımageList1;
            this.button8.Location = new System.Drawing.Point(204, 273);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 210);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.ImageList = this.ımageList1;
            this.button9.Location = new System.Drawing.Point(365, 273);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(135, 210);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.ImageList = this.ımageList1;
            this.button10.Location = new System.Drawing.Point(538, 273);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(135, 210);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.ImageList = this.ımageList1;
            this.button11.Location = new System.Drawing.Point(713, 273);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(135, 210);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.ImageList = this.ımageList1;
            this.button12.Location = new System.Drawing.Point(893, 273);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(135, 210);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // lblhamle
            // 
            this.lblhamle.AutoSize = true;
            this.lblhamle.Font = new System.Drawing.Font("Algerian", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhamle.ForeColor = System.Drawing.Color.LightCoral;
            this.lblhamle.Location = new System.Drawing.Point(309, 604);
            this.lblhamle.Name = "lblhamle";
            this.lblhamle.Size = new System.Drawing.Size(250, 36);
            this.lblhamle.TabIndex = 18;
            this.lblhamle.Text = "Hamle Sayısı:";
            // 
            // lblhamlesayisi
            // 
            this.lblhamlesayisi.AutoSize = true;
            this.lblhamlesayisi.Font = new System.Drawing.Font("Algerian", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhamlesayisi.ForeColor = System.Drawing.Color.LightCoral;
            this.lblhamlesayisi.Location = new System.Drawing.Point(584, 604);
            this.lblhamlesayisi.Name = "lblhamlesayisi";
            this.lblhamlesayisi.Size = new System.Drawing.Size(35, 36);
            this.lblhamlesayisi.TabIndex = 19;
            this.lblhamlesayisi.Text = "0";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(693, 532);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1072, 697);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblhamlesayisi);
            this.Controls.Add(this.lblhamle);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.lbls);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnkarıstır);
            this.Controls.Add(this.button7);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnkarıstır;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label lblhamle;
        private System.Windows.Forms.Label lblhamlesayisi;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}