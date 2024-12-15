using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число n:");
            if (!long.TryParse(Console.ReadLine(), out long n) || n <= 0)
            {
                Console.WriteLine("Ошибка ввода. Введите положительное число.");
                return;
            }

            int[] digits = GetDigitsInReverse(n);
            Console.WriteLine("Массив цифр в обратном порядке:");
            PrintArray(digits);

            Console.WriteLine("Введите число k:");
            if (!int.TryParse(Console.ReadLine(), out int k))
            {
                Console.WriteLine("Ошибка ввода для k.");
                return;
            }
            AddKModulo10(digits, k);
            Console.WriteLine("Массив после добавления k по модулю 10:");
            PrintArray(digits);

            int sumModulo10 = GetSumModulo10(digits);
            Console.WriteLine($"Сумма элементов массива по модулю 10: {sumModulo10}");

            int[] swappedArray = SwapAdjacentElements(digits);
            Console.WriteLine("Массив после обмена соседних элементов:");
            PrintArray(swappedArray);
            Console.ReadKey();
        }

        static int[] GetDigitsInReverse(long number)
        {
            string numStr = number.ToString();
            int[] digits = new int[numStr.Length];
            for (int i = 0; i < numStr.Length; i++)
            {
                digits[i] = int.Parse(numStr[numStr.Length - 1 - i].ToString());
            }
            return digits;
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join("; ", array));
        }

        static void AddKModulo10(int[] array, int k)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (array[i] + k) % 10;
            }
        }

        static int GetSumModulo10(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum = (sum + element) % 10;
            }
            return sum;
        }

        static int[] SwapAdjacentElements(int[] array)
        {
            int[] swappedArray = (int[])array.Clone();
            for (int i = 0; i < swappedArray.Length - 1; i += 2)
            {
                int temp = swappedArray[i];
                swappedArray[i] = swappedArray[i + 1];
                swappedArray[i + 1] = temp;
            }
            return swappedArray;
        }
    }
}
