using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbasic6
{
    class Program
    {
        public static int instanceMethod()
        {
            return 0;
        }
        static void Main(string[] args)
        {
            MethodExample m = new MethodExample();
            Console.WriteLine(m.Power(4));

            Test test = new Test();
            Console.WriteLine(test.Sum(1, 100));

            MyMath math = new MyMath();


        }

        class MyMath
        {
            public static int Abs(int input)
            {
                return (input < 0) ? -input : input;
            }
            public static double Abs(double input)
            {
                return (input < 0) ? -input : input;
            }
        }

    }

    class Test
    {
        public int Sum(int min, int max)
        {
            int output = 0; 
            for(int i = 0; i < max; i++)
            {
                output += i;
            }
            return output;
        }
        public void TestMethod()
        {
            Program.Main(new string[] { "" });
        }
    }

    class MethodExample 
    {
        public int Power(int x)
        {
            return x * x;
        }
    }
}
