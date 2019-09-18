using System;
using System.Threading;

namespace WhyNotLockWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            CorrectLockClass lockClass = new CorrectLockClass();
            //Thread t1 = new Thread(new ThreadStart(lockClass.LockMethod1));
            //Thread t2 = new Thread(new ThreadStart(lockClass.LockMethod2));
            //t1.Start();
            //Console.WriteLine("T1 Started");
            //t2.Start();
            //Console.WriteLine("T2 Started");
            //Console.ReadKey();


            Thread t1 = new Thread(new ThreadStart(lockClass.LockMethod1));
            Thread t2 = new Thread(new ThreadStart(lockClass.LockMethod2));
            t1.Start();
            Console.WriteLine("T1 Started");
            t2.Start();
            Console.WriteLine("T2 Started");
            Console.ReadKey();




        }
    }
}
