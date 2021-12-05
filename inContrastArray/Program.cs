using System;

namespace inContrastArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How mych elements are in array: ");
            int arrayQuantity = int.Parse(Console.ReadLine());

            int[] myArray = new int[arrayQuantity];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nEnter value number {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nResult: ");
            for (int i = myArray.Length -1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
