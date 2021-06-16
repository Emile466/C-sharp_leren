using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_leren
{
    class Excercises_boek
    {
        static void Main(string[] args)
        {
            #region Case - switch
            /*      string strDagVanDeWeek = "maandag";
                  string strResult = "";
                  switch (strDagVanDeWeek)
                  {
                      case "maandag":
                          { 
                              strResult = "maandag";
                              break;
                          }
                      case "dinsdag":
                          {
                              strResult = "dinsdag";
                              break;
                          }
                  }
                  Console.WriteLine(strResult);*/
            #endregion

            #region Newline
            /*
            Console.WriteLine("Eerste lijn \r\n");
            */
            #endregion

            #region Herhalingen
            /*
            // foreach wordt gebruikt voor rijen in een lijst te overlopen
            // for kan gebruikt worden als de iteratiehoeveelheid niet veranderd
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("50x test in for" + i.ToString());
            }

            // while kan gebruikt worden als de iteratiehoeveelheid wel veranderd (als de gebruiker dit kan aanpassen)
            int iw = 0;
            while (iw < 50)
            {
                Console.WriteLine("50x test in while " + iw.ToString());
                iw++;
            }
            */
            #endregion

            #region Herhalingen - maaltafels
            /*
            while(true)
            {
                Console.WriteLine("Kies nummer (enter om te sluiten)");
                int intNummerMaaltafel = 0;
                bool blCheckIfEmpty = int.TryParse(Console.ReadLine(), out intNummerMaaltafel);
                if (!blCheckIfEmpty)
                { 
                    Console.WriteLine("Geen cijfer ingegeven!");
                    break;
                }
                Console.Clear();
                for (int i = 1;  i <= 10;  i++)
                {
                Console.WriteLine(i.ToString() + " x " + intNummerMaaltafel.ToString() + " = " + (intNummerMaaltafel*i).ToString());
                }
            }*/
            #endregion

            #region Herhalingen - wiskundige faculteit
            /*
            Console.WriteLine("Wiskundige functie faculteit");
            while (true)
            {
                Console.WriteLine("Kies cijfer");
                int intCijfer = 1; 
                bool blCheckifNumber = int.TryParse(Console.ReadLine(), out intCijfer);
                if (!blCheckifNumber)
                {
                    Console.WriteLine("Geen cijfers ingegeven!");
                    break;
                }
                int intResultaat = 1;
                string strResultaat = "";
                for (int i = 1; i <= intCijfer; i++)
                { 
                    intResultaat = intResultaat * i;
                    strResultaat += i.ToString();
                    if(intCijfer == i)
                        break;
                    strResultaat += " x ";
                }
                Console.WriteLine(strResultaat + " = " + intResultaat.ToString());
                Console.WriteLine();
            }*/
            #endregion

            #region Methodes - afstand berekenen
            /*          Console.WriteLine(berekenAfstand(50, 1).ToString());
                        int berekenAfstand (int intKilometerPerUur, int intPeriodeInUur)
                        {
                            int intAfstand = intKilometerPerUur * intPeriodeInUur;
                            return intAfstand;
                        }*/
            #endregion

            #region Arrays maken
            /*
            int[] intGetallenArrayLeeg = new int[5]; // Lege nieuwe int array
            int[] intGetallenArrayGevuld = {5,4,3,2,1}; // Gevulde nieuwe int array
            double[] dblArrayGevuld = { 2.5, 5.4, 3.3 }; // Gevulde nieuwe double array
            Console.WriteLine(intGetallenArrayGevuld[3].ToString()); // Element ophalen uit array*/
            #endregion

            #region Arrays oefeningen
            while (true)
            {
                int[] ArrayPrijzen = { 10, 85, 53, 45, 65, 20, 45, 85, 65 };
                int[] ArrayTemperaturen = { 2, 5, 9, 7, 21, 6, 3, 4, 6 };
                Console.WriteLine("Geef rijnummer");
                bool blParseGelukt = int.TryParse(Console.ReadLine(), out int intRijNummer);

                if (!blParseGelukt || intRijNummer >= 10)
                    continue;

                Console.WriteLine((ArrayPrijzen[intRijNummer - 1] * ArrayTemperaturen[intRijNummer - 1]).ToString());
                // foreach - makkelijk voor alle elementen plain weer te geven, werkt niet goed met komma's
                string output = "";
                foreach (var item in ArrayPrijzen)
                {
                    output += item.ToString() + ",";
                }
                Console.WriteLine(output);

                // for - moeilijker om te configureren maar werkt goed met komma's
                Array.Sort(ArrayPrijzen); // Array sorteren
                string outputfor = ArrayPrijzen[0].ToString();
                for (int i = 1; i < ArrayPrijzen.Length; i++)
                {
                    outputfor += "," + ArrayPrijzen[i].ToString();
                }
                Console.WriteLine(outputfor);

                Array.Resize(ref ArrayPrijzen, 100); // Array resizen voor meer gegevens erbij te laten passen
                // Gegevens aan array toevoegen
                for (int i = 9; i < 100; i++)
                {
                    ArrayPrijzen[i] = i;
                }
                foreach (var item in ArrayPrijzen)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            #endregion

            Console.ReadLine();
        }
    }
}
