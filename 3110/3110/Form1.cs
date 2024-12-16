using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3110
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal a = new Animal();
            Cat c1 = new Cat("Murka", 2);
            Cat c2 = new Cat("Murziks", 8);
            Dog d1 = new Dog("Reksis", 5);
            richTextBox1.Clear();
            //richTextBox1.AppendText(a.Hi() + "\n");
            richTextBox1.AppendText(c1.Hi() + "\n");
            richTextBox1.AppendText(c2.Hi() + "\n");
            richTextBox1.AppendText(d1.Hi() + "\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int N = 10;
            string[] Names = { "Reks", "Musja", "Bebja", "Tuna", "Vadims", "Murka", "Pipe", "Tusja", "Marina", "Ksjusa" };
            Animal[] a = new Animal[N];
            Random r = new Random();
            for (int i = 0; i < N; i++)
            {
                int n = r.Next(Names.Length);
                int v = r.Next(1, 10);
                int rr = r.Next(100);
                if (rr < 20) a[i] = new Animal();
                else if (rr > 20 && rr < 50) a[i] = new Cat(Names[n], v);
                else a[i] = new Dog("Dog" + Dog.DogCount, v);

            }
            richTextBox1.Clear();
            for (int i = 0; i < N; i++)
            {
                //richTextBox1.AppendText(a[i].Hi() + "\n");
                if (a[i] is Dog)
                {
                    richTextBox1.AppendText((a[i] as Dog).Vau() + "\n");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int N = 10;
            string[] Names = { "Reks", "Musja", "Bebja", "Tuna", "Vadims", "Murka", "Pipe", "Tusja", "Marina", "Ksjusa" };
            IAnimal[] a = new IAnimal[N];
            Random r = new Random();
            for (int i = 0; i < N; i++)
            {
                int n = r.Next(Names.Length);
                int v = r.Next(1, 10);
                int rr = r.Next(100);

                if (rr > 20 && rr < 50) a[i] = new Cat(Names[n], v);
                else a[i] = new Dog("Dog" + Dog.DogCount, v);

            }
            richTextBox1.Clear();
            for (int i = 0; i < N; i++)
            {
                richTextBox1.AppendText(a[i].Hi() + "\n");
                if (a[i] is Dog)
                {
                    richTextBox1.AppendText((a[i] as Dog).Vau() + "\n");
                }
            }
            richTextBox1.AppendText("\nSorted: \n");
           
            Array.Sort(a/*, (x,y)=((x as Animal).Age.CompareTo((y as Animal).Age)*/);
            for (int i = 0; i < N; i++)
            {
                richTextBox1.AppendText(a[i].ToString() + "\n");
            }
        }
    }
}
