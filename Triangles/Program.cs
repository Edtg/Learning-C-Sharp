using System;
using System.Text;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an odd number for the length of the bottom:");
            int Num;
            // Wait for a valid input
            while (int.TryParse(Console.ReadLine(), out Num) && Num <= 0 && Num % 2 == 1);

            // (NumberOfTris + 1) / 2 = Rows
            int NumRows = (Num + 1) / 2;

            DrawTriangle(NumRows);
        }

        static void DrawTriangle(int Rows)
        {
            string TriangleTop = " /\\ ";
            string TriangleBottom = "/__\\";
            string Padding = "  ";
            for (int r = 0; r < Rows; ++r)
            {
                StringBuilder TopRow = new StringBuilder();
                StringBuilder BottomRow = new StringBuilder();
                for (int j = 0; j < Rows-r; ++j)
                {
                    TopRow.Append(Padding);
                    BottomRow.Append(Padding);
                }

                for (int i = 0; i <= r; ++i)
                {
                    TopRow.Append(TriangleTop);
                    BottomRow.Append(TriangleBottom);
                }
                Console.WriteLine(TopRow.ToString());
                Console.WriteLine(BottomRow.ToString());
            }
        }
    }
}
