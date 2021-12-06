using System;

namespace evenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How mych elements are in array: ");
            int arrayQuantity = int.Parse(Console.ReadLine());

            int[] myArray = new int[arrayQuantity];

            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nEnter value number {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());


                if (myArray[i] % 2 == 0)
                {
                    sum += myArray[i];
                }

            }
            Console.WriteLine("\nSum of even numbers: " + sum);

        }
    }
}
