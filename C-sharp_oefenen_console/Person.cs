using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a C# program that requests three names of people from the user and stores them in an array of objects of type Person. To do this, first create a Person class that has a Name property of type string and override the ToString() method.
//Input
//Juan
//Sara
//Carlos
//Output
//Hello! My name is Juan
//Hello! My name is Sara
//Hello! My name is Carlos
namespace C_sharp_oefenen_console
{
    class Person
    {
        private string _Name = "";
        private bool _OutputDone = false;
        public Person(string name, bool outputdone)
        {
            _Name = name;
            _OutputDone = outputdone;
        }
        public void Output()
        {
            List<string> lstNamen = new List<string>();
            string strPrintOut = "";
            while (!_OutputDone)
            {
                lstNamen.Add(_Name);
            }
            foreach (var item in lstNamen)
            {
                strPrintOut += item.ToString() + "\r\n";
            }
            Console.WriteLine(strPrintOut);
        }
    }
}
