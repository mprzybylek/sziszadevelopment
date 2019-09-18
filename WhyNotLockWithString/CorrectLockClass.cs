using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WhyNotLockWithString
{
    class CorrectLockClass
    {
        private readonly object _lockObj = new object();
        private readonly object _lockObj1 = new object();
        public void LockMethod1()
        {

            lock (_lockObj)
            {
                Thread.Sleep(5000);
                Console.WriteLine("It's ok");
            }

        }
        public void LockMethod2()
        {
            lock (_lockObj1)
            {
                Thread.Sleep(5000);
                Console.WriteLine("It's ok");
            }
        }
    }
}
