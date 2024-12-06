using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            if (!TryInputNumber("Введите количество чисел n", out n))
            {
                Console.ReadKey();
                return;
            }

            if (n < 2)
            {
                Console.WriteLine("Количество чисел должно быть >= 2");
                Console.ReadKey();
                return;
            }

            double[] numbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите число a[{i + 1}]:");
                if (!double.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Ошибка ввода");
                    Console.ReadKey();
                    return;
                }
            }

            double maxDifference = 0;
            for (int i = 1; i < n; i++)
            {
                double difference = Math.Abs(numbers[i] - numbers[i - 1]);
                if (difference > maxDifference)
                {
                    maxDifference = difference;
                }
            }

            Console.WriteLine($"Максимальная разность соседних чисел: {maxDifference:F4}");

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
