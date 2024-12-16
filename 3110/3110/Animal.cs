using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3110
{
    public class Animal //:IComparable
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Animal() { Name = "?"; Age = 0; }

        public override string ToString()
        {
            return this.GetType().Name+" - " + this.Name + " - " + this.Age;

        }

        public int CompareTo(object obj)
        {
            return this.Age.CompareTo((obj as Animal).Age);
        }

    }//Animal


}
