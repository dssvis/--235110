using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            if (!TryInputNumber("Введите число a", out a))
            {
                Console.ReadKey();
                return;
            }

            if (a < 1)
            {
                Console.WriteLine("Число a должно быть натуральным");
                Console.ReadKey();
                return;
            }

            int counter = 0;

            for (int x = 1; x <= a; x++)
            {
                for (int y = x; y <= a; y++)  
                {
                    for (int z = y; z <= a; z++)  
                    {
                        if (x * x + y * y == z * z)
                        {
                            Console.WriteLine($"Решение: x = {x}, y = {y}, z = {z}");
                            counter++;
                        }
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine($"Натуральных решений уравнения x^2 + y^2 = z^2 для a = {a} нет");
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
