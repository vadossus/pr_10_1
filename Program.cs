using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main (string[] args)
        {
            try
            {
                //Random rnd = new Random();
                //Console.Write("Введите размерность: ");
                //int n = Convert.ToInt32(Console.ReadLine());

                //int[,] massive = new int[n, n];

                //Console.WriteLine("Исходный массив: ");
                //for (int i = 0; i < massive.GetLength(0); i++)
                //{
                //    for (int j = 0; j < massive.GetLength(1); j++)
                //    {
                //        massive[i, j] = rnd.Next(0, 20);
                //        Console.Write(massive[i, j] + " ");
                //    }
                //    Console.WriteLine();
                //}


                //// Кратные k 
                //Console.Write("Введите значение K: ");
                //int k = int.Parse(Console.ReadLine());
                //int count = 0;
                //for (int i = 0; i < massive.GetLength(0); i++)
                //{
                //    for (int j =0; j < massive.GetLength(1); j++)
                //    {
                //        if (massive[i, j] > 0 && massive[i, j] % k == 0)
                //        {
                //            count++;
                //        }
                //    }
                //}
                //Console.WriteLine($"Количество кратных K {count}");

                //int summa = 0;
                //for (int i =0; i < massive.GetLength(0); i++)
                //{
                //    for (int j = 0; j < massive.GetLength(1); j++)
                //    {
                //        summa += massive[i, j];
                //    }
                //}
                //Console.WriteLine($"Сумма K1,K2: {summa}");

                // 19
                Random rnd = new Random();
                Console.WriteLine("Введите N: ");
                int n = int.Parse(Console.ReadLine());

                int[,] array = new int[n, n];

                Console.WriteLine("Исходный массив: ");

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = rnd.Next(50);
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Введите A и B: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                int k1 = 0;
                int k2 = 1;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    int count = 0;
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] % a == 0 || array[i, j] % b == 0)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"Количество элементов, кратных A или Б: {count}");
                }

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int proizvedenie = 1;
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        if (array[i, j] < 0 && (j == k1 || j == k2))
                        {
                            proizvedenie *= array[i, j];
                        }
                    }
                    if (proizvedenie != 1)
                    {
                        Console.WriteLine($"Произведение отриц.элементов в столбцах {j + 1}: {proizvedenie}");
                    }
                }
                Console.Read();
            }
            catch
            {
                Console.Write("Ошибка.");
            }
        }
    }
}
