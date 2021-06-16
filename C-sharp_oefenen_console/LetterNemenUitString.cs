using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6.Write a C# Sharp program to remove the character in a given position of a given string. The given position will be in the range 0.. string length -1 inclusive. 
//Sample Input:
//"Python", 1
//"Python", o
//"Python", 4
//Expected Output:
//Pthon
//ython
//Pythn

namespace C_sharp_oefenen_console
{
    class LetterNemenUitString
    {
        private string _UserInputString = "";
        private int _Positie = 0;
        public LetterNemenUitString(string userinputstring, int positie)
        {
            _UserInputString = userinputstring;
            _Positie = positie;
        }

        public void LetterEruitNemen()
        {
            Console.WriteLine(_UserInputString.Remove((_Positie -1), 1)); // .Remove(welke letter, hoeveel letters)
        }
    }
}
