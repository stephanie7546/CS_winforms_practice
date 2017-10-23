using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            double h = 0;
            double w = 0;
            if (height.Text != "")
            {
                h = double.Parse(height.Text);
            }

            if (weight.Text != "")
            {
                w = double.Parse(weight.Text);
            }


            double ans1 = w / Math.Pow((h / 100), 2);
            bmi.Text = ans1.ToString();
            double ans2 = (w * 1.3) / Math.Pow((h / 100), 2.5);
            nbmi.Text = ans2.ToString();


            if (ans1 >= 18.5 && ans1 < 24)
            {
                bmi_standard.Text = "正常";
                bmi_standard.ForeColor = Color.Black;
            }
            else if (ans1 < 18.5)
            {
                bmi_standard.Text = "太輕";
                bmi_standard.ForeColor = Color.Red;
            }
            else
            {
                bmi_standard.Text = "太重";
                bmi_standard.ForeColor = Color.Red;
            }

            if (ans2 >= 18.5 && ans2 < 24)
            {
                nbmi_standard.Text = "正常";
                nbmi_standard.ForeColor = Color.Black;
            }
            else if (ans2 < 18.5)
            {
                nbmi_standard.Text = "太輕";
                nbmi_standard.ForeColor = Color.Red;
            }
            else
            {
                nbmi_standard.Text = "太重";
                nbmi_standard.ForeColor = Color.Red;
            }
        }
    }
}
