namespace NotifyIconSampleCSharp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.convertdate = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCalender = new System.Windows.Forms.Panel();
            this.lbldayofweek = new System.Windows.Forms.Label();
            this.lblday = new System.Windows.Forms.Label();
            this.lblmount = new System.Windows.Forms.Label();
            this.imgTaghvim = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbldaynamemi = new System.Windows.Forms.Label();
            this.lbldaymi = new System.Windows.Forms.Label();
            this.lblnamemonthmi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DateMiladi = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblDateArabic = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDayArabic = new System.Windows.Forms.Label();
            this.lblDayNArabic = new System.Windows.Forms.Label();
            this.lblMonthArabic = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTimeArabic = new System.Windows.Forms.Label();
            this.lblTimePersian = new System.Windows.Forms.Label();
            this.lbltimeUsa = new System.Windows.Forms.Label();
            this.lblCustome = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlCalender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTaghvim)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipShown += new System.EventHandler(this.notifyIcon1_BalloonTipShown);
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertdate,
            this.exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // convertdate
            // 
            this.convertdate.Name = "convertdate";
            this.convertdate.Size = new System.Drawing.Size(127, 22);
            this.convertdate.Text = "تبدیل تاریخ";
            this.convertdate.Click += new System.EventHandler(this.convertdate_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(127, 22);
            this.exit.Text = "خروج";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pnlCalender
            // 
            this.pnlCalender.Controls.Add(this.lbldayofweek);
            this.pnlCalender.Controls.Add(this.lblday);
            this.pnlCalender.Controls.Add(this.lblmount);
            this.pnlCalender.Controls.Add(this.imgTaghvim);
            this.pnlCalender.Location = new System.Drawing.Point(28, 57);
            this.pnlCalender.Name = "pnlCalender";
            this.pnlCalender.Size = new System.Drawing.Size(172, 187);
            this.pnlCalender.TabIndex = 3;
            // 
            // lbldayofweek
            // 
            this.lbldayofweek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldayofweek.AutoSize = true;
            this.lbldayofweek.BackColor = System.Drawing.Color.LightGray;
            this.lbldayofweek.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbldayofweek.ForeColor = System.Drawing.Color.Black;
            this.lbldayofweek.Location = new System.Drawing.Point(101, 72);
            this.lbldayofweek.Name = "lbldayofweek";
            this.lbldayofweek.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbldayofweek.Size = new System.Drawing.Size(64, 24);
            this.lbldayofweek.TabIndex = 19;
            this.lbldayofweek.Text = "چهارشنبه";
            this.lbldayofweek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblday
            // 
            this.lblday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblday.BackColor = System.Drawing.Color.LightGray;
            this.lblday.Font = new System.Drawing.Font("B Titr", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblday.ForeColor = System.Drawing.Color.Black;
            this.lblday.Location = new System.Drawing.Point(5, 71);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(166, 112);
            this.lblday.TabIndex = 17;
            this.lblday.Text = "25";
            this.lblday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblmount
            // 
            this.lblmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmount.BackColor = System.Drawing.Color.DarkRed;
            this.lblmount.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblmount.ForeColor = System.Drawing.Color.White;
            this.lblmount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblmount.Location = new System.Drawing.Point(0, 3);
            this.lblmount.Name = "lblmount";
            this.lblmount.Size = new System.Drawing.Size(171, 68);
            this.lblmount.TabIndex = 16;
            this.lblmount.Text = "آذر";
            this.lblmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgTaghvim
            // 
            this.imgTaghvim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgTaghvim.BackColor = System.Drawing.Color.LightGray;
            this.imgTaghvim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTaghvim.Location = new System.Drawing.Point(0, 25);
            this.imgTaghvim.Name = "imgTaghvim";
            this.imgTaghvim.Size = new System.Drawing.Size(169, 159);
            this.imgTaghvim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTaghvim.TabIndex = 15;
            this.imgTaghvim.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbldaynamemi);
            this.panel1.Controls.Add(this.lbldaymi);
            this.panel1.Controls.Add(this.lblnamemonthmi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(259, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 187);
            this.panel1.TabIndex = 4;
            // 
            // lbldaynamemi
            // 
            this.lbldaynamemi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldaynamemi.AutoSize = true;
            this.lbldaynamemi.BackColor = System.Drawing.Color.LightGray;
            this.lbldaynamemi.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbldaynamemi.ForeColor = System.Drawing.Color.Black;
            this.lbldaynamemi.Location = new System.Drawing.Point(73, 71);
            this.lbldaynamemi.Name = "lbldaynamemi";
            this.lbldaynamemi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbldaynamemi.Size = new System.Drawing.Size(79, 24);
            this.lbldaynamemi.TabIndex = 19;
            this.lbldaynamemi.Text = "Wensday";
            this.lbldaynamemi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldaymi
            // 
            this.lbldaymi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldaymi.BackColor = System.Drawing.Color.LightGray;
            this.lbldaymi.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbldaymi.ForeColor = System.Drawing.Color.Black;
            this.lbldaymi.Location = new System.Drawing.Point(5, 71);
            this.lbldaymi.Name = "lbldaymi";
            this.lbldaymi.Size = new System.Drawing.Size(166, 112);
            this.lbldaymi.TabIndex = 17;
            this.lbldaymi.Text = "25";
            this.lbldaymi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnamemonthmi
            // 
            this.lblnamemonthmi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnamemonthmi.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblnamemonthmi.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamemonthmi.ForeColor = System.Drawing.Color.White;
            this.lblnamemonthmi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblnamemonthmi.Location = new System.Drawing.Point(0, 3);
            this.lblnamemonthmi.Name = "lblnamemonthmi";
            this.lblnamemonthmi.Size = new System.Drawing.Size(170, 68);
            this.lblnamemonthmi.TabIndex = 16;
            this.lblnamemonthmi.Text = "december";
            this.lblnamemonthmi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(662, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "-";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateMiladi
            // 
            this.DateMiladi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DateMiladi.AutoSize = true;
            this.DateMiladi.BackColor = System.Drawing.Color.Transparent;
            this.DateMiladi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateMiladi.ForeColor = System.Drawing.Color.White;
            this.DateMiladi.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DateMiladi.Location = new System.Drawing.Point(302, 249);
            this.DateMiladi.Name = "DateMiladi";
            this.DateMiladi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateMiladi.Size = new System.Drawing.Size(71, 15);
            this.DateMiladi.TabIndex = 19;
            this.DateMiladi.Text = "1988/12/19";
            this.DateMiladi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldate
            // 
            this.lbldate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbldate.Location = new System.Drawing.Point(69, 249);
            this.lbldate.Name = "lbldate";
            this.lbldate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbldate.Size = new System.Drawing.Size(71, 15);
            this.lbldate.TabIndex = 20;
            this.lbldate.Text = "1988/12/19";
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateArabic
            // 
            this.lblDateArabic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateArabic.AutoSize = true;
            this.lblDateArabic.BackColor = System.Drawing.Color.Transparent;
            this.lblDateArabic.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateArabic.ForeColor = System.Drawing.Color.White;
            this.lblDateArabic.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblDateArabic.Location = new System.Drawing.Point(522, 245);
            this.lblDateArabic.Name = "lblDateArabic";
            this.lblDateArabic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDateArabic.Size = new System.Drawing.Size(71, 15);
            this.lblDateArabic.TabIndex = 22;
            this.lblDateArabic.Text = "1988/12/19";
            this.lblDateArabic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDayArabic);
            this.panel2.Controls.Add(this.lblDayNArabic);
            this.panel2.Controls.Add(this.lblMonthArabic);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(481, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 187);
            this.panel2.TabIndex = 21;
            // 
            // lblDayArabic
            // 
            this.lblDayArabic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDayArabic.AutoSize = true;
            this.lblDayArabic.BackColor = System.Drawing.Color.LightGray;
            this.lblDayArabic.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDayArabic.ForeColor = System.Drawing.Color.Black;
            this.lblDayArabic.Location = new System.Drawing.Point(101, 72);
            this.lblDayArabic.Name = "lblDayArabic";
            this.lblDayArabic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDayArabic.Size = new System.Drawing.Size(64, 24);
            this.lblDayArabic.TabIndex = 19;
            this.lblDayArabic.Text = "چهارشنبه";
            this.lblDayArabic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDayNArabic
            // 
            this.lblDayNArabic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDayNArabic.BackColor = System.Drawing.Color.LightGray;
            this.lblDayNArabic.Font = new System.Drawing.Font("B Titr", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDayNArabic.ForeColor = System.Drawing.Color.Black;
            this.lblDayNArabic.Location = new System.Drawing.Point(5, 71);
            this.lblDayNArabic.Name = "lblDayNArabic";
            this.lblDayNArabic.Size = new System.Drawing.Size(166, 112);
            this.lblDayNArabic.TabIndex = 17;
            this.lblDayNArabic.Text = "25";
            this.lblDayNArabic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMonthArabic
            // 
            this.lblMonthArabic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthArabic.BackColor = System.Drawing.Color.Green;
            this.lblMonthArabic.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblMonthArabic.ForeColor = System.Drawing.Color.White;
            this.lblMonthArabic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMonthArabic.Location = new System.Drawing.Point(1, 3);
            this.lblMonthArabic.Name = "lblMonthArabic";
            this.lblMonthArabic.Size = new System.Drawing.Size(170, 68);
            this.lblMonthArabic.TabIndex = 16;
            this.lblMonthArabic.Text = "آذر";
            this.lblMonthArabic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 159);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(448, 315);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTimeArabic
            // 
            this.lblTimeArabic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeArabic.AutoSize = true;
            this.lblTimeArabic.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeArabic.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeArabic.ForeColor = System.Drawing.Color.White;
            this.lblTimeArabic.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTimeArabic.Location = new System.Drawing.Point(528, 273);
            this.lblTimeArabic.Name = "lblTimeArabic";
            this.lblTimeArabic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTimeArabic.Size = new System.Drawing.Size(39, 15);
            this.lblTimeArabic.TabIndex = 26;
            this.lblTimeArabic.Text = "--:--:--";
            this.lblTimeArabic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimePersian
            // 
            this.lblTimePersian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimePersian.AutoSize = true;
            this.lblTimePersian.BackColor = System.Drawing.Color.Transparent;
            this.lblTimePersian.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePersian.ForeColor = System.Drawing.Color.White;
            this.lblTimePersian.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTimePersian.Location = new System.Drawing.Point(73, 277);
            this.lblTimePersian.Name = "lblTimePersian";
            this.lblTimePersian.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTimePersian.Size = new System.Drawing.Size(39, 15);
            this.lblTimePersian.TabIndex = 25;
            this.lblTimePersian.Text = "--:--:--";
            this.lblTimePersian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltimeUsa
            // 
            this.lbltimeUsa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltimeUsa.AutoSize = true;
            this.lbltimeUsa.BackColor = System.Drawing.Color.Transparent;
            this.lbltimeUsa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimeUsa.ForeColor = System.Drawing.Color.White;
            this.lbltimeUsa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbltimeUsa.Location = new System.Drawing.Point(310, 277);
            this.lbltimeUsa.Name = "lbltimeUsa";
            this.lbltimeUsa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltimeUsa.Size = new System.Drawing.Size(39, 15);
            this.lbltimeUsa.TabIndex = 24;
            this.lbltimeUsa.Text = "--:--:--";
            this.lbltimeUsa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustome
            // 
            this.lblCustome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustome.AutoSize = true;
            this.lblCustome.BackColor = System.Drawing.Color.Transparent;
            this.lblCustome.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustome.ForeColor = System.Drawing.Color.White;
            this.lblCustome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCustome.Location = new System.Drawing.Point(338, 317);
            this.lblCustome.Name = "lblCustome";
            this.lblCustome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustome.Size = new System.Drawing.Size(39, 15);
            this.lblCustome.TabIndex = 27;
            this.lblCustome.Text = "--:--:--";
            this.lblCustome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCustome.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(700, 348);
            this.Controls.Add(this.lblCustome);
            this.Controls.Add(this.lblTimeArabic);
            this.Controls.Add(this.lblTimePersian);
            this.Controls.Add(this.lbltimeUsa);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblDateArabic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.DateMiladi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCalender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlCalender.ResumeLayout(false);
            this.pnlCalender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTaghvim)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem convertdate;
        private System.Windows.Forms.ToolStripMenuItem exit;
        public System.Windows.Forms.Panel pnlCalender;
        private System.Windows.Forms.Label lbldayofweek;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lblmount;
        private System.Windows.Forms.PictureBox imgTaghvim;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbldaynamemi;
        private System.Windows.Forms.Label lbldaymi;
        private System.Windows.Forms.Label lblnamemonthmi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DateMiladi;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblDateArabic;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDayArabic;
        private System.Windows.Forms.Label lblDayNArabic;
        private System.Windows.Forms.Label lblMonthArabic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTimeArabic;
        private System.Windows.Forms.Label lblTimePersian;
        private System.Windows.Forms.Label lbltimeUsa;
        private System.Windows.Forms.Label lblCustome;
    }
}

