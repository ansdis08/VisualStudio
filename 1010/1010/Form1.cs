using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            Vector a = new Vector(x,y);
             x = double.Parse(textBox4.Text);
             y = double.Parse(textBox3.Text);
            Vector b = new Vector(x,y);

            Vector c = a+b;
            richTextBox1.Clear();
            richTextBox1.AppendText(" a=" + a.ToString());
            richTextBox1.AppendText("\n |a|=" + a.R().ToString());
            richTextBox1.AppendText("\n b=" + b.ToString());
            richTextBox1.AppendText("\n |b|=" + b.R().ToString());
            
            richTextBox1.AppendText("\n c=" + c);
            richTextBox1.AppendText("\n |c|=" + c.R());
            richTextBox1.AppendText("\n a+b=" + a + b);
            richTextBox1.AppendText("\n a-b=" + (a - b));
            richTextBox1.AppendText("\n a*b=" + (a * b));

            richTextBox1.AppendText("\n a<b=" + (a < b));
            richTextBox1.AppendText("\n a>b=" + (a > b));
            richTextBox1.AppendText("\n a==b=" + (a == b));
            richTextBox1.AppendText("\n a!=b=" + (a != b));
        }
    }
}
