using System;

namespace doubleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[2, 4]
            {
                {2, 5, 12, 21},
                {3, 4, 6, 10 }
            };

            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(myArray[i , j] + ",");
                }
                Console.WriteLine();
            }
        }
    }
}
