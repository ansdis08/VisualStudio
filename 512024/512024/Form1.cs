using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _512024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FriendsList FL = new FriendsList();
            FL.Add("Alla", 23558697, DateTime.Parse("01.01.2002"));
            FL.Add("Anna", 25863147, DateTime.Parse("02.02.2003"));
            FL.SaveToBinFile(@"C:\Dir1\draugi.txt");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FriendsList FL = new FriendsList();
            FL.ReadFromBinFile(@"C:\Dir1\draugi.txt");
            richTextBox1.AppendText(FL.ToString());
        }
    }
}
