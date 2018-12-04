using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double ans = sin(a);
                label1.Text = ans.ToString();
            }
            catch
            {
                MessageBox.Show("Enter as Number");
            }
        }

        double sin(double a)
        {
            double rad = a / 180.0 * Math.PI;
            return Math.Sin(rad);
        }
        double inversesin(double a)
        {
            return Math.Asin(a) * 180.0 / Math.PI
        }
        double cos(double a)
        {
            double rad = a / 180.0 * Math.PI;
            return Math.Cos(rad);
        }
        double inversecos(double a)
        {
            return Math.Acos(a) * 180.0 / Math.PI
        }
        double tan(double a)
        {
            double rad = a / 180.0 * Math.PI;
            return Math.Tan(rad);
        }
        double inversetan(double a)
        {
            return Math.Atan(a) * 180.0 / Math.PI
        }
    }
}
