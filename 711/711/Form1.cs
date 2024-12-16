using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _711
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Swap<T>(ref T x, ref T y)
        {
            T z= x;
            x= y;
            y= z;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Sakuma: \n";
            int a = 7, b = 13;
            richTextBox1.AppendText("a=" + a + ", b=" + b+ "\n");
            string c = "Pirmais", d = "Otrais";
            richTextBox1.AppendText("c=" + c + ", d=" + d + "\n");

            richTextBox1.AppendText("Pec Swap: \n");
            Swap(ref a, ref b);
            richTextBox1.AppendText("a=" + a + ", b=" + b + "\n");
            Swap(ref c, ref d);
            richTextBox1.AppendText("c=" + c + ", d=" + d + "\n");

            Swap(ref button2, ref button3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Esmu button2";
        }
    }
}
