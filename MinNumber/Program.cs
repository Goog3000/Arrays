using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How mach elements are in array: ");
            int arrayQuanyity = int.Parse(Console.ReadLine());

            int[] myArray = new int[arrayQuanyity];

            
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nEnter value number {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int minValue = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    myArray[i] = minValue;
                }
            }
            Console.Write("\nMinimal number of array: "+minValue);
        }
    }
}
