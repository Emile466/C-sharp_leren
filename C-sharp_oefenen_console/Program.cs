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
            // https://www.w3resource.com/csharp-exercises/
            //LetterNemenUitString letterNemen = new LetterNemenUitString(Console.ReadLine(), int.Parse(Console.ReadLine()));
            //letterNemen.LetterEruitNemen();

            //https://www.exercisescsharp.com/oop/
            Console.WriteLine("Geef uw naam!");
            bool blOutputKlaar = false;
            while (true)
            {
                string strTempNaam = Console.ReadLine();
                Person person = new Person(Console.ReadLine(), blOutputKlaar);

                if (strTempNaam == "")
                { 
                    blOutputKlaar = false;
                    break;
                }

                Console.WriteLine("Geef een andere naam!");
            }

            Console.ReadLine();
        }
    }
}
