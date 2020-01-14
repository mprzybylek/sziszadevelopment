using System;

namespace NameInFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            Frame Box = new Frame();
            Box.DrawSquare(10);
            Box.DrawSquare(5);

            Console.ReadKey();
        }

    }
}
