using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotifyIconSampleCSharp
{
    public partial class Form1 : Form
    {
        Timer ss = new Timer();
        Timer timett = new Timer();
        public Form1()
        {
            InitializeComponent();

            update();
           
            ss.Tick += Ss_Tick;
            DateTime dt = DateTime.Now;
            DateTime dt2 = DateTime.Today.AddDays(1).AddHours(0).AddMinutes(0).AddSeconds(0);
            TimeSpan span = dt2 - dt;
            ss.Interval = (int)span.TotalMilliseconds;

            ss.Enabled = true;
        }

        private void Ss_Tick(object sender, EventArgs e)
        {
            update();
            DateTime dt = DateTime.Now;
            DateTime dt2 = DateTime.Today.AddDays(1).AddHours(0).AddMinutes(0).AddSeconds(0);
            TimeSpan span = dt2 - dt;
            ss.Interval = (int)span.TotalMilliseconds;
        }

        public void update()
        {
            

            lblmount.Text = PersianDate.Now.ToString("NM");
            lbldayofweek.Text = PersianDate.Now.ToString("ND");
            lblday.Text = PersianDate.Now.ToString("dd");

            lbldate.Text = PersianDate.Now.ToString("yyyy-MM-dd");

            lblnamemonthmi.Text = DateTime.Now.ToString("MMMM");
            lbldaynamemi.Text = DateTime.Now.ToString("dddd");
            lbldaymi.Text = DateTime.Now.ToString("dd");

            DateMiladi.Text = DateTime.Now.ToString("yyyy-MM-dd");



            var s = global::CalenderSRajayi.Properties.Resources._01.ToString();


            notifyIcon1.Icon = selectImae(PersianDate.Now.Day);
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            this.Hide();
            notifyIcon1.Text = PersianDate.Now.ToString(" شمسی " + "yyyy/MM/dd" + System.Environment.NewLine)
                + "  میلادی " + DateTime.Now.ToString("yyyy/MM/dd");

            ConvertDateCalendar(DateTime.Now);
            timezonecust();
        }

      






        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
            timett.Enabled = true;
            timett.Interval = 1000;
            timett.Tick += Timett_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void timezonecust()
        {
            var timeZones = TimeZoneInfo.GetSystemTimeZones();
          
            foreach (var timeZone in timeZones)
            {
                comboBox1.Items.Add(timeZone.Id) ;
            }
           

            //store dbDateTime in the database

            DateTime serverDateTime = DateTime.Now;
            DateTime dbDateTime = serverDateTime.ToUniversalTime();

            //get date time offset for UTC date stored in the database
            DateTimeOffset dbDateTimeOffset = new
                            DateTimeOffset(dbDateTime, TimeSpan.Zero);

            //get user's time zone from profile stored in the database
            TimeZoneInfo userTimeZone =
                         TimeZoneInfo.FindSystemTimeZoneById("Iran Standard Time");

            //convert  db offset to user offset
            DateTimeOffset userDateTimeOffset =
                       TimeZoneInfo.ConvertTime
                      (dbDateTimeOffset, userTimeZone);

            //format user offset for display purpose

           
            lblTimePersian.Text = userDateTimeOffset.TimeOfDay.ToString("hh\\:mm\\:ss");
            TimeZoneInfo userTimeZone1 =
                        TimeZoneInfo.FindSystemTimeZoneById("US Mountain Standard Time");
            DateTimeOffset userDateTimeOffset1 =
                     TimeZoneInfo.ConvertTime
                    (dbDateTimeOffset, userTimeZone1);
            lbltimeUsa.Text = userDateTimeOffset1.TimeOfDay.ToString("hh\\:mm\\:ss");


            TimeZoneInfo userTimeZone2 =
                        TimeZoneInfo.FindSystemTimeZoneById("Arabian Standard Time");
            DateTimeOffset userDateTimeOffset2 =
                     TimeZoneInfo.ConvertTime
                    (dbDateTimeOffset, userTimeZone2);
            lblTimeArabic.Text = userDateTimeOffset2.TimeOfDay.ToString("hh\\:mm\\:ss");

            if (comboBox1.Text != "")
            {
                TimeZoneInfo userTimeZone3 =
                           TimeZoneInfo.FindSystemTimeZoneById(comboBox1.Text);
                DateTimeOffset userDateTimeOffset3 =
                         TimeZoneInfo.ConvertTime
                        (dbDateTimeOffset, userTimeZone3);

                lblCustome.Text = userDateTimeOffset3.TimeOfDay.ToString("hh\\:mm\\:ss");
            }




        }


        public  void ConvertDateCalendar(DateTime DateConv)
        {
            System.Globalization.DateTimeFormatInfo DTFormat;
           
            string DateLangCulture = "ar-sa";
            

            /// Set the date time format to the given culture
            DTFormat = new System.Globalization.CultureInfo(DateLangCulture).DateTimeFormat;

            /// Set the calendar property of the date time format to the given calendar
    
            DTFormat.Calendar = new System.Globalization.HijriCalendar();
            /// We format the date structure to whatever we want
            lblDayNArabic.Text= DateConv.Date.ToString("dd", new System.Globalization.CultureInfo("ar-sa"));
            lblDayArabic.Text= DateConv.Date.ToString("dddd", new System.Globalization.CultureInfo("ar-sa"));
            lblMonthArabic.Text = DateConv.Date.ToString("MMMM", new System.Globalization.CultureInfo("ar-sa"));
            lblDateArabic.Text = DateConv.Date.ToString("yyyy/MM/dd", new System.Globalization.CultureInfo("ar-sa"));

           
        }

        public Icon selectImae(int day)
        {
            switch (day)
            {
                case 1:
                    return global::CalenderSRajayi.Properties.Resources._01;
                case 2:
                    return global::CalenderSRajayi.Properties.Resources._02;
                case 3:
                    return global::CalenderSRajayi.Properties.Resources._03;
                case 4:
                    return global::CalenderSRajayi.Properties.Resources._04;
                case 5:
                    return global::CalenderSRajayi.Properties.Resources._05;
                case 6:
                    return global::CalenderSRajayi.Properties.Resources._06;
                case 7:
                    return global::CalenderSRajayi.Properties.Resources._07;
                case 8:
                    return global::CalenderSRajayi.Properties.Resources._08;
                case 9:
                    return global::CalenderSRajayi.Properties.Resources._09;
                case 10:
                    return global::CalenderSRajayi.Properties.Resources._10;
                case 11:
                    return global::CalenderSRajayi.Properties.Resources._11;
                case 12:
                    return global::CalenderSRajayi.Properties.Resources._12;
                case 13:
                    return global::CalenderSRajayi.Properties.Resources._13;
                case 14:
                    return global::CalenderSRajayi.Properties.Resources._14;
                case 15:
                    return global::CalenderSRajayi.Properties.Resources._15;
                case 16:
                    return global::CalenderSRajayi.Properties.Resources._16;
                case 17:
                    return global::CalenderSRajayi.Properties.Resources._17;

                case 18:
                    return global::CalenderSRajayi.Properties.Resources._18;
                case 19:
                    return global::CalenderSRajayi.Properties.Resources._19;
                case 20:
                    return global::CalenderSRajayi.Properties.Resources._20;
                case 21:
                    return global::CalenderSRajayi.Properties.Resources._21;
                case 22:
                    return global::CalenderSRajayi.Properties.Resources._22;
                case 23:
                    return global::CalenderSRajayi.Properties.Resources._23;
                case 24:
                    return global::CalenderSRajayi.Properties.Resources._24;
                case 25:
                    return global::CalenderSRajayi.Properties.Resources._25;

                case 26:
                    return global::CalenderSRajayi.Properties.Resources._26;
                case 27:
                    return global::CalenderSRajayi.Properties.Resources._27;
                case 28:
                    return global::CalenderSRajayi.Properties.Resources._28;
                case 29:
                    return global::CalenderSRajayi.Properties.Resources._29;
                case 30:
                    return global::CalenderSRajayi.Properties.Resources._30;
                case 31:
                    return global::CalenderSRajayi.Properties.Resources._31;
             

                default:
                
                    return global::CalenderSRajayi.Properties.Resources.Blank_16x16_16;

            }
        }

        public Icon selectImaenew(int day)
        {
            switch (day)
            {
                case 1:
                    return global::CalenderSRajayi.Properties.Resources.s1;
                case 2:
                    return global::CalenderSRajayi.Properties.Resources.s2;
                case 3:
                    return global::CalenderSRajayi.Properties.Resources.s3;
                case 4:
                    return global::CalenderSRajayi.Properties.Resources.s4;
                case 5:
                    return global::CalenderSRajayi.Properties.Resources.s5;
                case 6:
                    return global::CalenderSRajayi.Properties.Resources.s6;
                case 7:
                    return global::CalenderSRajayi.Properties.Resources.s7;
                case 8:
                    return global::CalenderSRajayi.Properties.Resources.s8;
                case 9:
                    return global::CalenderSRajayi.Properties.Resources.s9;
                case 10:
                    return global::CalenderSRajayi.Properties.Resources.s10;
                case 11:
                    return global::CalenderSRajayi.Properties.Resources.s1;
                case 12:
                    return global::CalenderSRajayi.Properties.Resources.s12;
                case 13:
                    return global::CalenderSRajayi.Properties.Resources.s13;
                case 14:
                    return global::CalenderSRajayi.Properties.Resources.s14;
                case 15:
                    return global::CalenderSRajayi.Properties.Resources.s15;
                case 16:
                    return global::CalenderSRajayi.Properties.Resources._16;
                case 17:
                    return global::CalenderSRajayi.Properties.Resources._17;

                case 18:
                    return global::CalenderSRajayi.Properties.Resources.s18;
                case 19:
                    return global::CalenderSRajayi.Properties.Resources.s19;
                case 20:
                    return global::CalenderSRajayi.Properties.Resources.s20;
                case 21:
                    return global::CalenderSRajayi.Properties.Resources.s21;
                case 22:
                    return global::CalenderSRajayi.Properties.Resources.s22;
                case 23:
                    return global::CalenderSRajayi.Properties.Resources.s23;
                case 24:
                    return global::CalenderSRajayi.Properties.Resources.s24;
                case 25:
                    return global::CalenderSRajayi.Properties.Resources.s25;

                case 26:
                    return global::CalenderSRajayi.Properties.Resources.s26;
                case 27:
                    return global::CalenderSRajayi.Properties.Resources.s27;
                case 28:
                    return global::CalenderSRajayi.Properties.Resources.s28;
                case 29:
                    return global::CalenderSRajayi.Properties.Resources.s29;
                case 30:
                    return global::CalenderSRajayi.Properties.Resources.s30;
                case 31:
                    return global::CalenderSRajayi.Properties.Resources.s31;


                default:

                    return global::CalenderSRajayi.Properties.Resources.icons8_calendar_64;

            }
        }

        private void notifyIcon1_BalloonTipShown(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            
        }

        private void convertdate_Click(object sender, EventArgs e)
        {
            ConvertDate cc = new ConvertDate();
            cc.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            this.Hide();
            timett.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timezonecust();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
        }

        private void Timett_Tick(object sender, EventArgs e)
        {
            timezonecust();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
