using System;
using System.Collections.Generic;
using System.Text;

namespace NameInFrame
{
    class Frame
    {
        private const char _topLeft = (char)174;
        private const char _topRight = (char)172;
        private const char _bottomLeft = (char)28;
        private const char _bottomRight = (char)175;
        private const char _horizontal = '-'; //(char)196;
        private const char _vertical = '|'; //(char)179;

        public void DrawSquare()
        {
            Console.WriteLine($"{_topLeft}{_horizontal}{_topRight}");
            Console.WriteLine($"{_vertical}{_vertical}");
            Console.WriteLine($"{_bottomLeft}{_horizontal}{_bottomRight}");
            Console.ReadKey();
        }
        public void DrawSquare(int size)
        {
            //for (int i = 0; i <= size; i++)
            //{
            //    Console.Write("\n");

            //    for (int j = 0; j < size; j++)
            //    {
            //        int z = i + j + 1;
            //        Console.Write($"{z}\n");

            //    }
            //}

            //Console.ReadKey();
            //Console.WriteLine($"{_topLeft}{_horizontal}{_topRight}");
            //Console.WriteLine($"{_vertical}{_vertical}");
            //Console.WriteLine($"{_bottomLeft}{_horizontal}{_bottomRight}");
            //Console.ReadKey();

            int slash = size - 1;
            int backslash = 0;

            for (int i = 0; i < size; i++)
            {
                Console.Write("\n");

                for (int j = 0; j < size; j++)
                {
                    if (j == slash) Console.Write("/");
                    else if (j == backslash) Console.Write("\\");
                    else Console.Write(0);

                    //if (i == j|| size - i==j+1) Console.Write(1);
                    //else Console.Write(0);

                    //int z = i + j + 1;
                    //Console.Write($"{z}\t");

                }

                backslash++;
                slash--;

            }
        }
    }
}
