using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WhyNotLockWithString
{
    class StringLockClass
    {
        private readonly string _lockObj = "LockString";
        private readonly string _lockObj1 = "LockString";
        public void LockMethod1()
        {

            lock (_lockObj)
            {
                Thread.Sleep(5000);
                Console.WriteLine("It's not ok");
            }

        }
        public void LockMethod2()
        {
            lock (_lockObj1)
            {
                Thread.Sleep(5000);
                Console.WriteLine("It's not ok");
            }
        }
    }
}
