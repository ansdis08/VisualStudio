using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0509_funkcija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        double SC(double r)
        {
            return Math.PI * r * r;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double R1 = double.Parse(textBox1.Text);
            double R2 = double.Parse(textBox2.Text);
            double s = SC(R1) - SC(R2) + 2 * SC(R2 / 2);
            label3.Text = "S= " + s.ToString("F2");
        }

        bool EQ (double x, double y, double precision)
            {
            if (Math.Abs(x - y) < precision) return true;
            else return false;
            }
        //3.5
        double L(double x1, double y1, double x2, double y2) 
        {
            return Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(textBox3.Text);
            double y1 = double.Parse(textBox4.Text);
            double x2 = double.Parse(textBox5.Text);
            double y2 = double.Parse(textBox6.Text);
            double x3 = double.Parse(textBox7.Text);
            double y3 = double.Parse(textBox8.Text);

            double a=L(x1,y1, x2, y2);
            double b = L(x3,y3, x2, y2);
            double c = L(x1,y1, x3,y3);

            //if (a + b == c || a + c == b || c + b == a)
                if (EQ(a + b, c,0.0001) || EQ(a + c, b, 0.0001) || EQ(c + b, a, 0.0001)) label10.Text = "Yes";
            else label10.Text = "No";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool TTT(double a, double b, double c, out double p, out double s)
        {
            if (a < b + c && b < c + a && c < b + a)
            { p = a + b + c; 
                double pp = p / 2.0; 
                s = Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c)); 
                return true;
             }
            else { p = 0; s = 0; return false; }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox9.Text);
            double b = double.Parse(textBox10.Text);
            double c = double.Parse(textBox11.Text);
            double p = 0; double s = 0;
            if (TTT(a, b, c, out p, out s)) { label15.Text = "Yes, p= "+p+" s="+s; }
            else label15.Text = "No";
        }
    }
}
