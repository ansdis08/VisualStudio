using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1710
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Aqua;
            Velocity v1 = new Velocity();
            if(comboBox1.Text=="m") v1.M = double.Parse(textBox1.Text);
            else if(comboBox1.Text=="km") v1.Km = double.Parse(textBox1.Text);

            if (comboBox2.Text == "sec") v1.Sec = double.Parse(textBox2.Text);
            else if (comboBox2.Text == "min") v1.Min = double.Parse(textBox2.Text);
            else if (comboBox2.Text == "h") v1.H = double.Parse(textBox2.Text);

            richTextBox1.Clear();
            richTextBox1.AppendText("\n H=" + v1.H);
            richTextBox1.AppendText("\n Min=" + v1.Min);
            richTextBox1.AppendText("\n Sec=" + v1.Sec);

            richTextBox1.AppendText("\n M=" + v1.M);
            richTextBox1.AppendText("\n Km=" + v1.Km);

            richTextBox1.AppendText("\n m/sec=" + v1.MSec());
            richTextBox1.AppendText("\n km/h=" + v1.KmH());
        }
    }
}
