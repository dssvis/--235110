using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskk3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число:");
            var number = int.Parse(Console.ReadLine());

            var hundreds = number / 100;
            var tens = (number / 10) % 10;
            var units = number % 10;

            var result = tens * 100 + hundreds * 10 + units;

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
