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
    class PersonGreetings
    {
        private List<string> _InputList = new List<string>();
        public PersonGreetings(List<string> inputlist)
        {
            _InputList = inputlist;
        }
        public void Output()
        {
            string strOuput = "";
            foreach (string item in _InputList)
            {
                strOuput += "Hello! My name is " + item + "\r\n";
            }
            Console.WriteLine(strOuput);
        }
    }
}
