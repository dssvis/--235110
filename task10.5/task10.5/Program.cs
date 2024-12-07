using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число больше 1000:");

            int number;
            if (!int.TryParse(Console.ReadLine(), out number) || number <= 1000)
            {
                Console.WriteLine("Ошибка ввода. Число должно быть больше 1000.");
                return;
            }

            int result = 0;
            int multiplier = 1;  

            
            while (number > 0)
            {
                int num1 = number % 10; 
                number /= 10; 

                if (num1 % 2 != 0)
                {
                    result += num1 * multiplier;
                    multiplier *= 10; 
                }
            }

            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();
        }


    }
}
