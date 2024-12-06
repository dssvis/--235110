using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double epsilon;
            if (!TryInputNumber("Введите точность ε ", out epsilon))
            {
                Console.ReadKey();
                return;
            }

            if (epsilon <= 0)
            {
                Console.WriteLine("Точность должна быть положительной");
                Console.ReadKey();
                return;
            }

            int numerator1 = 1, numerator2 = 2;
            int denominator1 = 1, denominator2 = 1;

            double currentValue, previousValue = (double)numerator2 / denominator2;

            while (true)
            {
                int currentNumerator = numerator1 + numerator2;
                int currentDenominator = denominator1 + denominator2;

                currentValue = (double)currentNumerator / currentDenominator;

                if (Math.Abs(currentValue - previousValue) <= epsilon)
                {
                    Console.WriteLine($"Первый член последовательности, удовлетворяющий условию: {currentNumerator}/{currentDenominator}");
                    break;
                }

                numerator1 = numerator2;
                denominator1 = denominator2;
                numerator2 = currentNumerator;
                denominator2 = currentDenominator;

                previousValue = currentValue;
            }

            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out double number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!double.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            return true;
        }
    }
}
