using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskk2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x центра ");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y центра ");
            var b  = double.Parse (Console.ReadLine());

            Console.WriteLine("Введите координату x вершины ");
            var c = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y вершины ");
            var d = double.Parse(Console.ReadLine());

            var sideLength = Math.Sqrt(Math.Pow(c - a , 2) + Math.Pow(d - b , 2)) * Math.Sqrt(2);

            var area = Math.Pow(sideLength, 2);
            var perimeter = 4 * sideLength;

            Console.WriteLine($"Площадь квадрата: {area}");
            Console.WriteLine($"Периметр квадрата: {perimeter}");

            Console.ReadKey();

        }
    }
}
