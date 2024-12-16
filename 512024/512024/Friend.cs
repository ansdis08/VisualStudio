using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _512024
{
    [Serializable]
    public class Friend
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public Friend(string aName, int aPhone, DateTime aBirthDay)  // konstruktors
        {
            Name = aName; Phone = aPhone; BirthDay = aBirthDay;
        }
        public override string ToString()
        {
            return Name + "   " + Phone.ToString() + "   " + BirthDay.ToShortDateString();
        }
    } // Friend


}
