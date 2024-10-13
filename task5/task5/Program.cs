using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = F(1, 2, 3, 4);
            Console.WriteLine($"x = {x:F3}");

            Console.ReadKey();
        }

        static double F(double a, double b, double c, double d)
        {
            return Math.Sin(a + Math.Sin(b + Math.Sin(c + Math.Sin(d))));
        }
    }
}

