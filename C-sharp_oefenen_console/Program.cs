using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_oefenen_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //LetterNemenUitString letterNemen = new LetterNemenUitString(Console.ReadLine(), int.Parse(Console.ReadLine()));
            //letterNemen.LetterEruitNemen();
            Console.WriteLine("Geef uw woord voor om te wisselen");
            EersteLaatsteLetterOmwisselen StringOmwisselen = new EersteLaatsteLetterOmwisselen(Console.ReadLine());
            StringOmwisselen.Omwisselen();
            Console.ReadLine();
        }
    }
}
