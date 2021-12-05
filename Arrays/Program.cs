using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];

            Console.Write("Enter first value: ");
            myArray[0] = int.Parse(Console.ReadLine());

            Console.Write("Enter second value: ");
            myArray[1] = int.Parse(Console.ReadLine());

            Console.Write("Enter third value: ");
            myArray[2] = int.Parse(Console.ReadLine());

            Console.Write("Enter fourth value: ");
            myArray[3] = int.Parse(Console.ReadLine());

            Console.Write("Enter fifth value: ");
            myArray[4] = int.Parse(Console.ReadLine());

            for(int i = 0; i< myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
