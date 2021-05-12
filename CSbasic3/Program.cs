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

            int i = 0; 
            int[] intArray2 = { 44, 55, 66, 77, 88, 99 };
            while (i < intArray2.Length)
            {
                Console.WriteLine(intArray2[i]);
                i++;
            }

            string input;
            do
            {
                Console.WriteLine("입력 종료");
                input = Console.ReadLine();
            } while (input != "exit");

            for(int j = '가';  j <= '힣'; j++)
            {
                Console.Write((char)j);
            }

            int[] intArray3 = { 1, 2, 3, 4, 5, 6 };
            for(int k = intArray2.Length - 1; k >= 0; k--)
            {
                Console.WriteLine(intArray3[k]);
            }
            for(int k = intArray3.Length; k > 0; k--)
            {
                Console.WriteLine(intArray3[k - 1]);
            }
        }
    }
}
