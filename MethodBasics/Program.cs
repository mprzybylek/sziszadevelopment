using System;

namespace MethodBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.ShowName();
            user.sex = "other";
            Console.ReadKey();
        }
    }

}
