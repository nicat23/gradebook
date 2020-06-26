using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new double[] { 12.7, 10.3, 6.11, 4.1 };
            List<double> grades = new List<double>(numbers);
            double result = 0;

            foreach (var item in grades)
            {
                Console.WriteLine(item);
                result += item;
            }
            Console.WriteLine(result);

            if (args.Length > 0)
            {
                //Console.WriteLine("Hello, Justin!");
                //Console.WriteLine("Hello, " + args[0] + "!");
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
