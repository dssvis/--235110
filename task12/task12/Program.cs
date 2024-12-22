using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите целое число m от 5 до 20:");
                int m;
                if (!TryInputNumber(out m) || m < 5 || m > 20)
                {
                    Console.WriteLine("Ошибка ввода или число не в диапазоне.");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("Введите целое число n от 5 до 20:");
                int n;
                if (!TryInputNumber(out n) || n < 5 || n > 20)
                {
                    Console.WriteLine("Ошибка ввода или число не в диапазоне.");
                    Console.ReadKey();
                    return;
                }

                int[,] matrix = new int[m, n];
                var rnd = new Random();
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        matrix[i, j] = rnd.Next(0, 100);

                Console.WriteLine("Сгенерированная матрица:");
                PrintMatrix(matrix);

                Console.WriteLine("\nВведите границы интервала (a и b), в столбик:");
                int a, b;
                if (!TryInputNumber(out a) || !TryInputNumber(out b))
                {
                    Console.WriteLine("Ошибка ввода.");
                    Console.ReadKey();
                    return;
                }

                if (CheckInterval(matrix, a, b))
                    Console.WriteLine("Все элементы матрицы находятся в заданном интервале.");
                else
                    Console.WriteLine("Есть элементы, выходящие за пределы интервала.");

                // Часть b)
                Console.WriteLine("\nМаксимальные элементы в каждом столбце:");
                FindMaxInColumns(matrix);

                Console.ReadKey();
            }

            static bool TryInputNumber(out int number)
            {
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Ошибка ввода числа.");
                    return false;
                }
                return true;
            }

            static void PrintMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        Console.Write($"{matrix[i, j],4}");
                    Console.WriteLine();
                }
            }

            static bool CheckInterval(int[,] matrix, int a, int b)
            {
                bool allInRange = true;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] < a || matrix[i, j] > b)
                        {
                            Console.WriteLine($"Элемент вне интервала: индекс [{i},{j}], значение {matrix[i, j]}");
                            allInRange = false;
                        }
                    }
                }

                return allInRange;
            }

            static void FindMaxInColumns(int[,] matrix)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int max = int.MinValue;
                    int maxRowIndex = -1;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        if (matrix[i, j] > max)
                        {
                            max = matrix[i, j];
                            maxRowIndex = i;
                        }
                    }

                    Console.WriteLine($"Столбец {j}: максимальный элемент {max}, находится в строке {maxRowIndex}");
                }
            }
        }
    }
