using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            if (!TryInputNumber("Введите число n", out n))
            {
                Console.ReadKey();
                return;
            }

            if (n <= 0)
            {
                Console.WriteLine("Число n должно быть положительным");
                Console.ReadKey();
                return;
            }

            double step = Math.PI / n;
            Console.WriteLine("Таблица значений функции sin(x):");
            for (double x = 0; x <= 2 * Math.PI; x += step)
            {
                Console.WriteLine($"sin({x:F2}) = {Math.Sin(x):F4}");
            }

            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            return true;
        }
    }
}
