using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Ошибка ввода числа a.");
                return;
            }

            Console.WriteLine("Введите последовательность целых чисел, заканчивающуюся нулем:");
            int sum = 0;

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Ошибка ввода числа.");
                    return;
                }

                if (number == 0) break;

                if (number > a)
                {
                    sum += number;
                }
            }

            Console.WriteLine($"Сумма всех чисел, больших {a}, равна {sum}");

            Console.ReadLine();

        }
    }
}
