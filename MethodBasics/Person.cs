using System;
using System.Collections.Generic;
using System.Text;

namespace MethodBasics
{
    class Person
    {
        private int _age;

        private static int _personCounter;

        public static void IncrementCounter()
        {
            _personCounter++;
        }

        public static int ReturnCounter()
        {
            return _personCounter;
        }

        public static void DisplayCounter()
        {
            Console.WriteLine($"Current value: {_personCounter}" + ".");
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public void DisplayAge()
        {
            Console.WriteLine("Age: " + _age + ".");
        }
    }
}
