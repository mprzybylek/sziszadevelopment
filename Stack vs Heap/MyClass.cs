using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_vs_Heap
{
    class MyClass
    {
        public int value;
        private int myField;
        public List<int> Numbers = new List<int>();
        public int this[int index]
        {
            get { return Numbers[index]; }
        }

        public int MyProperty { get => myField; private set => myField = value; }

        public MyClass(int valueP)
        {
            value = valueP;
            MyProperty = 5;
            Numbers.Add(1);
            Numbers.Add(2);
            Numbers.Add(3);
            Numbers.Add(4);
            //Console.WriteLine("This is MyClass constructor");
        }

        public MyClass(string valueString)
        {
            Console.WriteLine($"Object MyClass created. Initial value = {valueString}");
        }

        public MyClass(float valueFloat)
        {

        }
    }
}
