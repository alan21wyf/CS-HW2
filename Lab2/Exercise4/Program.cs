using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Spiral s = new Spiral();
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 8, 9, 4 }, { 7, 6, 5 } };
            Console.WriteLine("The 2d Array is: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("It's spiral form is: ");
            s.SpiralView(matrix);
        }

    }
}
