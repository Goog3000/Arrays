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
            foreach(var item in myArray)
            {
                Console.Write(item + ",");
            }
        }
    }
}
