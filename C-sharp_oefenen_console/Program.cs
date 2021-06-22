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
            #region Letter nemen uit string
            //LetterNemenUitString letterNemen = new LetterNemenUitString(Console.ReadLine(), int.Parse(Console.ReadLine()));
            //letterNemen.LetterEruitNemen();
            #endregion

            // https://www.exercisescsharp.com/oop/
            #region Print namen
            //List<string> lstInput = new List<string>();
            //Console.WriteLine("Geef een naam (enter om te stoppen)");
            //while (true)
            //{
            //    string strTempName = Console.ReadLine();

            //    if (strTempName == "")
            //        break;

            //    strTempName = strTempName.Substring(0, 1).ToUpper() + strTempName.Remove(0,1);

            //    lstInput.Add(strTempName);
            //    Console.WriteLine("Geef een ander naam (enter om te stoppen)");
            //}
            //Console.Clear();
            //PersonGreeting person = new PersonGreeting(lstInput);
            //person.Output();
            #endregion

            #region Person, student en professor
            //PersonInClassroom person = new PersonInClassroom();
            //person.Greet();

            //Student student = new Student();
            //student.SetAge(20);
            //student.Greet();
            //student.ShowAge();
            //student.Study();

            //Professor professor = new Professor();
            //professor.SetAge(50);
            //professor.Greet();
            //professor.ShowAge();
            //professor.Explain();
            #endregion

            #region Photobook
            //Photobook photobook = new Photobook();
            //photobook.PrintPages();
            //photobook.GetNumberPages(24);
            //photobook.PrintPages();
            //BigPhotobook bigPhotobook = new BigPhotobook();
            //bigPhotobook.PrintPages();
            #endregion

            Console.ReadLine();
        }
    }
}
