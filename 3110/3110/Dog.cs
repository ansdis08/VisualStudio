using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace _3110
{
    public class Dog:Animal,IAnimal
    {
        public static int DogCount;
        static Dog() {DogCount = 0;}
        public Dog(string aName, int aAge)
        {
            DogCount++;
            Name = aName;
            Age = aAge;
        }

        public  string Hi()
        {
            return "Rrrr! Mani sauc " + Name + ". Rrrr!";
        }

        public string Vau()
        {
            return "Vauuuuuuuuuu!";
        }

       
    }
}
