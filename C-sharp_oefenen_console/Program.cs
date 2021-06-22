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

            // https://www.exercisescsharp.com/oop/
            List<string> lstInput = new List<string>();
            Console.WriteLine("Geef een naam (enter om te stoppen)");
            while (true)
            {
                string strTempName = Console.ReadLine();

                if (strTempName == "")
                    break;

                strTempName = strTempName.Substring(0, 1).ToUpper() + strTempName.Remove(0,1);

                lstInput.Add(strTempName);
                Console.WriteLine("Geef een ander naam (enter om te stoppen)");
            }
            Console.Clear();
            Person person = new Person(lstInput);
            person.Output();

            Console.ReadLine();
        }
    }
}
