using System;

namespace CSbasic3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] intArry = new int[100];
            Console.WriteLine(intArry.Length);
            Console.WriteLine(intArry[99]);
            Console.WriteLine(intArry[intArry.Length]);

        }
    }
}
