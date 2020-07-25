using System;
using System.Text;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Grid = new int[10, 10];

            int PlayerX = 0;
            int PlayerY = 0;

            bool IsPlaying = true;

            Grid[PlayerY, PlayerX] = 1;

            UpdateGrid(Grid);

            while (IsPlaying)
            {
                ConsoleKey Key = Console.ReadKey().Key;
                Console.WriteLine(Key);
                
                if (Key == ConsoleKey.W && PlayerY - 1 >= 0)
                {
                    PlayerY -= 1;
                }
                else if (Key == ConsoleKey.S && PlayerY + 1 < Grid.GetLength(0))
                {
                    PlayerY += 1;
                }
                else if (Key == ConsoleKey.A && PlayerX - 1 >= 0)
                {
                    PlayerX -= 1;
                }
                else if (Key == ConsoleKey.D && PlayerX + 1 < Grid.GetLength(0))
                {
                    PlayerX += 1;
                }

                //Array.Clear(Grid, 0, Grid.GetLength(0));

                Grid = new int[10, 10];

                Grid[PlayerY, PlayerX] = 1;

                UpdateGrid(Grid);
            }
        }

        static void UpdateGrid(int[,] Grid)
        {
            

            StringBuilder GridString = new StringBuilder();

            for (int y = 0; y < Grid.GetLength(0); y++)
            {
                for (int x = 0; x < Grid.GetLength(1); x++)
                {
                    //Console.Write(Grid[y, x]);
                    GridString.Append(Grid[y, x].ToString());
                    GridString.Append(" ");
                }
                //Console.WriteLine();
                GridString.Append("\n");
            }

            Console.Clear();

            Console.Write(GridString.ToString());
        }
    }
}
