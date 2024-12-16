using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2609
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double y(double x) 
        { 
         return (x - x *x + 1)/(Math.Sqrt(2*x*x+1)+2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "  x       y \n";
            for(double x = -10; x<=10; x+=0.5)
                richTextBox1.AppendText(" "+x.ToString("F2")+ " \t" +y(x).ToString("F2") +"\n");
        }

        int RecN(int n)
        {
            if (n <= 1) return 1;
            return RecN(n-1)*RecN(n-1)+ RecN(n - 2) * RecN(n - 2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("RecN(1)=" + RecN(1) + "\n");
            richTextBox1.AppendText("RecN(5)=" + RecN(5) + "\n");
            richTextBox1.AppendText("RecN(6)=" + RecN(6) + "\n");
        }

        int TriCip(params int[] a)
        {
            int x = 0;
            for (int i = 0; i < a.Length; i++) 
                if (Math.Abs(a[i]) >=100 && Math.Abs(a[i])<=999) x++;
            return x;

         }
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("TriCip(1, 111, 225, 1000)=" + TriCip(1, 111, 225, 1000) + "\n");
            richTextBox1.AppendText("TriCip(-1, -111, -225, -1000)=" + TriCip(-1, -111, -225, -1000) + "\n");
        }

        string[] DoArr(int N)
        {
            string[] A = new string[N];
            Random r = new Random();
            for (int i = 0; i < N; i++)
                A[i] = "" + (char)(r.Next('A','Z' + 1)) + (r.Next('A', 'Z' + 1)) + (r.Next('A', 'Z' + 1));
            return A;
        }

        string ArrToStr(string[] s)
        {
            string x = "";
            for(int i = 0;i < s.Length;i++) x += s[i]+"\n";
            return x;
        }

        void Cript(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                string t = "";
                for (int k = 0; k < 3; k++)
                    if (s[i][k] == 'Z') t += 'A';
                    else t+= (char)(s[i][k] + 1);
                s[i] = t;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox1.Text);
            string[] A = DoArr(N);
            richTextBox1.Text = ArrToStr(A);
            Cript(A);
            richTextBox1.AppendText("\n Cript: \n");
            richTextBox1.AppendText(ArrToStr(A));
        }

        bool Y(double x, out double y)
        {
            double xr = x * Math.PI / 180;
            if (Math.Abs(Math.Cos(xr))<0.0001)
            {
                y = double.MaxValue;
                return false;
            }
            else {
                y = (1+Math.Sin(xr))/Math.Cos(xr);
                return true;

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            double y;
            richTextBox1.Text = "  x       y \n";
            for (double x = 0; x <= 360; x += 15)
                if(Y(x,out  y))
                richTextBox1.AppendText(" " + x.ToString("F0") + " \t" + y.ToString("F0") + "\n");
            else richTextBox1.AppendText(" " + x.ToString("F0") + " \t - \n");
        }
    }
}
