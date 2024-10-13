using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное число x:");
            var x = double.Parse(Console.ReadLine());

            var y = MyFunction(x);
            Console.WriteLine($"f(x) = {y}");

            Console.ReadKey();
        }

        static double MyFunction(double x)
        {
            return (Math.Abs(x + 1) - Math.Abs(x - 1)) / Math.Abs(x);
        }
    }
}
    

