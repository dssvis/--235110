using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива:");

            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Ошибка ввода. Число должно быть положительным.");
                return;
            }

            int[] array = new int[n];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Ошибка ввода. Попробуйте снова.");
                    i--;
                }
            }

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            Console.WriteLine("Введите значение k:");
            int k;
            if (!int.TryParse(Console.ReadLine(), out k))
            {
                Console.WriteLine("Ошибка ввода. k должно быть целым числом.");
                return;
            }

            MultiplyArray(array, k);
            Console.WriteLine($"Массив после умножения на {k}:");
            PrintArray(array);

            double average = CalculateAverage(array);
            Console.WriteLine($"Среднее арифметическое элементов массива: {average:F2}");

            int[] reversedArray = SwapElements(array);
            Console.WriteLine("Массив после обмена элементов:");
            PrintArray(reversedArray);
            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }

        static void MultiplyArray(int[] array, int k)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= k;
            }
        }

        static double CalculateAverage(int[] array)
        {
            if (array.Length == 0) return 0;

            double sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum / array.Length;
        }

        static int[] SwapElements(int[] array)
        {
            int[] newArray = (int[])array.Clone();
            int n = newArray.Length;

            for (int i = 0; i < n / 2; i++)
            {
                int temp = newArray[i];
                newArray[i] = newArray[n - 1 - i];
                newArray[n - 1 - i] = temp;
            }

            return newArray;
        }
    }
}
