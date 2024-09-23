using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Весна");

            Console.WriteLine();

            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Город зимнее снял.");
            Console.WriteLine("Снега распустили слюнки.");
            Console.WriteLine("Опять пришла весна,");
            Console.WriteLine("глупа и болтлива, как юнкер.");

            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
