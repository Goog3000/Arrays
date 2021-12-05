using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How mych elements are in array: ");
            int arrayQuantity = int.Parse(Console.ReadLine());

            int[] myArray = new int[arrayQuantity];

            for (int j = 0; j < myArray.Length; j++)
            {
                Console.Write($"\nEnter value number {j}: ");
                myArray[j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Result: ");
            for (int i = 0; i < myArray.Length; i++)
            {                
                    Console.WriteLine(myArray[i]);
            }
        }
    }
}
