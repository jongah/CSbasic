using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csbasic6
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodExample m = new MethodExample();
            Console.WriteLine(m.Power(4));
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
