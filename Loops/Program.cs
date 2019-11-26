using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        private static List<int> collection;

        static void Main(string[] args)
        {


            //for(int i = 0;i<=10;i=i+1)
            //{
            //    //Console.WriteLine($"i= "+i);
            //    //Console.WriteLine("i= {0}", i);
            //    Console.WriteLine($"i= {i}");
            //}
            //int length = 100;

            //for (int i = 0; i < length;)
            //{
            //    Console.WriteLine($"i= {i}");
            //    i++;
            //}

            //for (int i = 0; true;i++)
            //{
            //    Console.WriteLine($"i= {i}");
            //    i++;
            //}

            //for (int i = 0; false; i++)
            //{
            //    Console.WriteLine($"i= {i}");
            //    i++;
            //}

            //for (int i = 0; i < 10; i+= 2)
            //{
            //    Console.WriteLine($"i= {i}");
            //    i++;
            //}
            //for (int i = 0; i <= 100;++i)
            //{
            //    if(i%6==0)
            //    {
            //        Console.WriteLine($"i= {i}");
            //    }
            //}

            int i = 0;
            //while (true)
            //{
            //    Console.WriteLine($"i= {i}");
            //    i++;
            //}





            //while (i < 10)
            //{
            //    Console.WriteLine($"i= {i}");
            //    i++;
            //}

            //i = 0;

            //do
            //{
            //    Console.WriteLine($"i= {i}");
            //    i++;
            //}
            //while (i < 10);

            //while (i == 10)
            //{
            //    Console.WriteLine($"i= {i}");
            //    i++;
            //}

            //i = 0;

            //do
            //{
            //    Console.WriteLine($"i= {i}");
            //    i++;
            //}
            //while (i == 10);

            collection = new List<int>();
            collection.Add(1);
            collection.Add(1);
            collection.Add(1);
            collection.Add(1);
            collection.Add(1);
            collection.Add(2);
            collection.Add(1);
            collection.Add(1);
            collection.Add(1);
            collection.Add(1);
            collection.Add(1);
            collection.Add(1);
            

            foreach (var item in collection)
            {
                Console.WriteLine(item);
                Console.WriteLine(item);
            }


        }
    }
}
