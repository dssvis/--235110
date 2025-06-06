using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EuclidConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Point();
            p.X = 1;
            p.Y = 2;
            Console.WriteLine($"Точка ({p.X} , {p.Y})");
            var q = new Point() { X = -1, Y = 3 };
            Console.WriteLine($"Точка ({q.X} , {q.Y})");

            Console.ReadKey();

        }
    }
}
