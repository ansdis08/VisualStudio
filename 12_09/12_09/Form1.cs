using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] NatKva(int N)
        {
            if(N<0) { N= 0; }
            int[] A = new int[N];
            for (int i = 0; i<N; i++)
                A[i] = (i+1)*(i+1);
            return A;
        }

        string ToStr(int[] A) 
        {   //kopiga
            string s = " ";
            for (int i = 0; i < A.Length; i++)
                s+= A[i]+"\n";
                return s;
        }
        //3.30 Izveidojiet funkciju int[] NatKva(int N),
        //kuras atgriežamā vērtība ir pirmo N naturālu skaitļu
        //kvadrātu masīvs: (1, 4, 9, 16, 25, 36...).
        private void button1_Click(object sender, EventArgs e)
        {
            int N= int.Parse(textBox1.Text);
            int[] A = NatKva(N);
            richTextBox1.Text= "A: \n" + ToStr(A);
        }

        int[] Prime(int N) 
        {
            if (N < 0) { N = 0; }
            int[] A = new int[N];
            int NN = 0;
            if (N > 0) { A[0] = 2; NN++; }
            int k = 1;
            while (NN < N)
            {
                k += 2;
                bool IsPrime = true;
                for (int i = 0; i < NN; i++)
                {
                    if (k % A[i] == 0) { IsPrime = false; break; }
                }
                    if (IsPrime) { A[NN] = k; NN++; }
               
            }
            return A;
        }

        //3.29 Izveidojiet funkciju int[] Prime(int N),
        //kuras atgriežamā vērtība ir pirmo
        //N pirmskaitļu masīvs (2, 3, 5, 7, 11, 13...).
        private void button2_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox1.Text);
            int[] A = Prime(N);
            richTextBox1.Text = "A: \n" + ToStr(A);
        }

        double Laiks(double h, double g = 9.8)
        {
            return Math.Sqrt(2*h/g);
        }
        //3.44 a
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Zeme: " + Laiks(12).ToString("F2")+"\n");
            richTextBox1.AppendText("Men: " + Laiks(12, 1.8).ToString("F2") + "\n");
        }

        double t(double h)
        {
            return Math.Sqrt(2 * h / 9.8);
        }

        double t(double h, double g)
        {
            return Math.Sqrt(2 * h / g);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Zeme: " + Laiks(12).ToString("F2") + "\n");
            richTextBox1.AppendText("Men: " + Laiks(12, 1.8).ToString("F2") + "\n");
        }


        //3.41
        double Av(params int[] A) 
        { 
            int N=A.Length;
            int S = 0;
            for (int i = 0; i < N; i++) S += A[i];
            return S*1.0/N;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Av(2, 5)=" + Av(2, 5) + "\n");
            richTextBox1.AppendText("Av(1,2,3,4, 5)=" + Av(1, 2, 3, 4, 5) + "\n");
        }
    }
}
