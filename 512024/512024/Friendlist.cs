using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _512024
{
    public class FriendsList
    {
        private List<Friend> L { get; set; }
        public FriendsList() { L = new List<Friend>(); }
        public void Add(string aName, int aPhone, DateTime aBirthDay)
        {
            L.Add(new Friend(aName, aPhone, aBirthDay));
        }
        public override string ToString()
        {
            string s = "";
            foreach (Friend f in L) s += f.ToString() + "\n";
            return s;
        }
        public void SaveToBinFile(string FileName)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream fs = new FileStream(FileName,
            FileMode.Create, FileAccess.Write))
                foreach (Friend f in L) bf.Serialize(fs, f);
        } // SaveToBinFile
        public void ReadFromBinFile(string FileName)
        {
            L.Clear();
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream fs = File.OpenRead(FileName))
            {
                bool err = false;
                while (!err)
                    try
                    {
                        Friend f = (Friend)bf.Deserialize(fs);
                        L.Add(f);
                    }
                    catch { err = true; }
            }
        } // ReadFromBinFile
    }
    //class FriendsList

}
