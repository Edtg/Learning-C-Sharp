using System;

namespace Fibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int Fib(int Pos)
        {
            if (Pos < 0) return -1;

            int a = 0;
            int b = 1;

            for (int i = 0; i < Pos; ++i)
            {
                int temp = a;
                a = a + b;
                b = temp;
            }

            return a;
        }
    }
}
