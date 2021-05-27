﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic_4
{

    class Car 
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[10];
            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(100));
            Console.WriteLine(random.Next(1, 19));
            Console.WriteLine(random.NextDouble());

            List<int> list = new List<int>();
            list.Add(43);
            list.Add(4);
            list.Add(64);
            list.Add(32);
            list.Add(12);

            List<int> list_1 = new List<int>() { 2, 3, 4, 5, 6 };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Math.Abs(-32424));
            Console.WriteLine(Math.Ceiling(54.643));
            Console.WriteLine(Math.Floor(3243.34));
             

        }
    }
}
