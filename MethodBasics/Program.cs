using System;

namespace MethodBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.ShowName();
            //user.ShowProffession();  -  inaccessible level 
            //user.sex = "other";  - inaccessible level 


            user.ShowAddress();
            

            Console.ReadKey();

        }
    }

}
