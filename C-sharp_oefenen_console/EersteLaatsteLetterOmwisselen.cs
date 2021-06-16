using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7.Write a C# Sharp program to exchange the first and last characters in a given string and return the new string. Go to the editor

//Sample Input:
//"abcd"
//"a"
//"xy"
//Expected Output:

//dbca
//a
//yx

namespace C_sharp_oefenen_console
{
    class EersteLaatsteLetterOmwisselen
    {
        private string _UserInput = "";
        public EersteLaatsteLetterOmwisselen(string userinput )
        {
            _UserInput = userinput;
        }
        public void Omwisselen()
        {
            int intLengteString = _UserInput.Length - 1;
            Console.WriteLine(_UserInput.Substring(intLengteString, 0) + _UserInput.Remove(0, 1).Remove(4, 1) + _UserInput.Substring(intLengteString, 0));
        }
    }
}
