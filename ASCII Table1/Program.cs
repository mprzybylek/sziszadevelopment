using System;

namespace ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"65\t-\t{(char)65}\n");

           for (int i = 0; i <= 255; i++)
           {
                if ((i>='A' && i<='Z') || (i>='a' && i<='z'))
                
                    
                    
                Console.WriteLine ($"{i}\t-\t{(char)i}");

           }

           //Console.WriteLine($"{(char)26} {(char)27}");

            Console.ReadKey();
        }
    }
}
