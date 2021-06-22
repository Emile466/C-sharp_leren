using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_oefenen_console
{
    class PersonInClassroom
    {
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
        protected int age = 0; // protected betekent dat de variabele alleen in dezelfde class kan opgeroepen worden
        public void SetAge(int n)
        {
            age = n;
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is " + age.ToString() + " years old");
        }
    }

    class Student : PersonInClassroom // Child class, inherited from student
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
    }

    class Professor : PersonInClassroom
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
}
