using System;

namespace Stack_vs_Heap
{
    class Program
    {
        static TestClass testClassObj;
        static TestStruct testStructObj;
        static void Main(string[] args)
        {
            //EX 1
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


            //Ex 2
            //Class - heap - ref type
            testClassObj = new TestClass();
            Console.WriteLine(testClassObj);
            Console.WriteLine(testClassObj.TestField);

            //Struct - stack - val type
            Console.WriteLine(testStructObj);
            Console.WriteLine(testStructObj.TestField);



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
