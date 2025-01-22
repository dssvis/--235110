using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            bool flag = false;
            while (true)
            {
                if (FindProstoe(n) == false)
                {
                    int[] prost = Resheto(n);
                    flag = false;

                    for (int i = 0; i < prost.Length; i++)
                    {
                        int p = prost[i];
                        double M = (n - p) / 2.0;
                        if (M == (int)M)
                        {
                            int m = (int)Math.Sqrt(M);
                            if (m * m == M)
                            {
                                flag = true;
                                break;
                            }
                        }
                    }

                    if (flag == false)
                    {
                        Console.WriteLine($"Наименьшее число, которое нельзя представить в виде p + 2m^2: {n}");
                        break;
                    }
                }
                n += 2;
            }
            Console.ReadKey();
        }

        static int[] Resheto(int limit)
        {
            bool[] resheto = new bool[limit + 1];
            for (int i = 2; i <= limit; i++)
                resheto[i] = true;

            for (int num = 2; num * num <= limit; num++)
            {
                if (resheto[num] == true)
                {
                    for (int multiple = num * num; multiple <= limit; multiple += num)
                    {
                        resheto[multiple] = false;
                    }
                }
            }

            int count = 0;
            for (int i = 2; i <= limit; i++)
            {
                if (resheto[i] == true)
                    count++;
            }

            int[] prost = new int[count];
            int index = 0;
            for (int i = 2; i <= limit; i++)
            {
                if (resheto[i] == true)
                {
                    prost[index++] = i;
                }
            }

            return prost;
        }

        static bool FindProstoe(int number)
        {
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
