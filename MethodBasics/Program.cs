using System;

namespace MethodBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //User user = new User();

            //user.ShowName();
            //user.ShowProffession();  -  inaccessible level 
            //user.sex = "other";  - inaccessible level 


            //user.ShowAddress();

            //wywolanie statycznej metody DisplayCounter()
            Person.DisplayCounter();
            //stworzenie nowego obiektu typu Person i przypisanie do zmiennej typu Person
            Person mirella = new Person();
            //
            Person.IncrementCounter();

            mirella.SetAge(18);

            Person.DisplayCounter();
                        

            Person cecylia;
            cecylia = new Person();

            Person.IncrementCounter();

            cecylia.SetAge(19);

            Person.DisplayCounter();

            mirella.DisplayAge();
            cecylia.DisplayAge();

            Console.WriteLine($"Current counter: {Person.ReturnCounter()}");

            Console.ReadKey();




        }
    }

}
