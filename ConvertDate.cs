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
    public partial class ConvertDate : Form
    {
        public ConvertDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbmitosh.Checked)
                {
                    lblC.Text = PersianDate.Parse(mtxtDate.Text).ToString("yyyy/MM/dd");

                }
                else if (rbshtomi.Checked)
                {

                    int year = int.Parse(mtxtDate.Text.Substring(0, 4));
                    int month = int.Parse(mtxtDate.Text.Substring(5, 2));
                    int day = int.Parse(mtxtDate.Text.Substring(8, 2));


                    lblC.Text = PersianDate.GetMiladi(new PersianDate(year, month, day)).ToString("yyyy/MM/dd");
                }
            }
            catch { }
        }
    }
}
