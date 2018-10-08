using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = { 1, 2, 3, 4, 5 };
            int[] p2 = { 5, 4, 3, 2, 1 };
            int[] p3 = { 3, 5, 1, 4, 2 };
            Console.WriteLine("Сортировка пузырьком\n");
            Console.WriteLine("Массив, упорядоченный во возрастанию:");
            BubbleSort(p1);
            PrintMas(p1);
            Console.WriteLine();
            Console.WriteLine("Массив, упорядоченный по убыванию:");
            BubbleSort(p2);
            PrintMas(p2);
            Console.WriteLine();
            Console.WriteLine("Неупорядоченный массив:");
            BubbleSort(p3);
            PrintMas(p3);
            Console.WriteLine();
            int[] s1 = { 1, 2, 3, 4, 5 };
            int[] s2 = { 5, 4, 3, 2, 1 };
            int[] s3 = { 3, 5, 1, 4, 2 };
            Console.WriteLine("\nСортировка перемешиванием\n");
            Console.WriteLine("Массив, упорядоченный по возрастанию:");
            ShakerSort(s1);
            PrintMas(s1);
            Console.WriteLine();
            Console.WriteLine("Массив, упорядоченный по убыванию:");
            ShakerSort(s2);
            PrintMas(s2);
            Console.WriteLine();
            Console.WriteLine("Неупорядоченный массив:");
            ShakerSort(s3);
            PrintMas(s3);
            Console.WriteLine();
        }

        static int[] BubbleSort(int[] n)
        {
            int swaps = 0;
            int compares = 0;
            for(int i = n.Length; i > 0; i--)
            {
                for(int j = 0; j < i-1; j++)
                {
                    if (n[j] > n[j + 1])
                    {
                        int temp = n[j];
                        n[j] = n[j + 1];
                        n[j + 1] = temp;
                        swaps++;
                    }
                    compares++;
                }
            }
            Console.WriteLine("Количество сравнений: {0}", compares);
            Console.WriteLine("Количество пересылок: {0}", swaps);
            return n;
        }

        static int[] ShakerSort(int[] n)
        {
            int swaps = 0;
            int compares = 0;
            int p = 0;
            int q = n.Length-1;
            int count = 0;
            do
            {
                count++;
                for (int i = p; i < q; i++)
                {
                    if (n[i] > n[i + 1])
                    {
                        int temp = n[i];
                        n[i] = n[i + 1];
                        n[i + 1] = temp;
                        swaps++;
                    }
                    compares++;
                }
                q--;
                for (int j = q; j > p; j--)
                {
                    if (n[j] < n[j - 1])
                    {
                        int temp = n[j];
                        n[j] = n[j - 1];
                        n[j - 1] = temp;
                        swaps++;
                    }
                    compares++;
                }
                p++;
            } while (count<n.Length/2);
            Console.WriteLine("Количество сравнений: {0}", compares);
            Console.WriteLine("Количество пересылок: {0}", swaps);
            return n;
        }
        static void PrintMas(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write(n[i] + " ");
            }
        }
    }
}
