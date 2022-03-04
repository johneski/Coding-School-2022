using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercise1
    {
        public Exercise1()
        {
             
        }

        public string Reverse(string name)
        {
            string reversedName = "";

            for(int i = name.Length-1; i >= 0; i--)
            {
                reversedName += name[i];
            }

            return reversedName;
        }

        public string ReverseWithLib(string name)
        {
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            return new string(nameArray);
        }
    }
}
