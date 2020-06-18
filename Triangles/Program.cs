using System;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many triangles would you like to make up a big triangle?");
            int Num;
            // Wait for a valid input
            while (int.TryParse(Console.ReadLine(), out Num) && Num <= 0);

            // (NumberOfTris + 1) / 2 = Rows
            int NumRows = (Num + 1) / 2;
        }
    }
}
