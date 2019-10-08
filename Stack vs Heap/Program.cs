using System;

namespace Stack_vs_Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueToChange = 15;

            MyClass myClass1 = new MyClass(8);
            MyClass myClass2 = new MyClass(10);
            myClass1 = myClass2;
            myClass2.value = 15;

            ChangeValue(myClass1);
            ChangeValue(valueToChange);
            
            Console.WriteLine($"{myClass1.value}");
            Console.WriteLine($"{valueToChange}");
            //Console.ReadKey();
        }

        public static void ChangeValue(int val)
        {
            val = 666;
        }

        public static void ChangeValue(MyClass val)
        {
            val.value = 666;
        }
    }
}
