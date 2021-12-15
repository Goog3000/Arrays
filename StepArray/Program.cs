using System;

namespace StepArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int [3][]; //двумерный зубчатый

            myArray[0] = new int[4];
            myArray[1] = new int[3];
            myArray[2] = new int[5];

            Random ransom = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = ransom.Next(50);
                }
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
