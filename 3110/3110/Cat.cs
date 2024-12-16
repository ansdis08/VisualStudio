using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _3110
{
    public class Cat:Animal,IAnimal
    {
        public Cat(string aName,int aAge)
        {
            Name = aName;
            Age = aAge;
        }

        public string Hi()
        {
            return "Mur! Mani sauc " + Name + ". Paspelesim?";
        }

       
    }
}
