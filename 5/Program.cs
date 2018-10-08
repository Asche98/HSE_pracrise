using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядок матрицы");
            bool isCorrect = false;
            int n = 0;
            while (!isCorrect)
            {
                isCorrect = Int32.TryParse(Console.ReadLine(), out n) && n>0;
                if (!isCorrect) Console.WriteLine("Некорректный ввод. Требуется целое положительное число. Попробуйте ещё раз: ");
            }
            double max = 0;
            double[,] matr = new double[n, n];
            Console.WriteLine("Введите элементы матрицы - действительные числа:");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    double number = GetDoubleFromUser();
                    matr[i, j] = number;
                }
            }
            //обход левой половины
            int p=0, k=n;
            for(int i = 0; i < Math.Ceiling(n / 2d); i++)
            {
                for(int j = p; j < k; j++)
                {
                    if (matr[j, i] > max) max = matr[j, i];
                }
                p++;
                k--;
            }
            //обход правой половины
            p = 0;k = n;
            for (int i = n-1; i>= Math.Ceiling(n / 2d); i--)
            {
                for (int j = p; j < k; j++)
                {
                    if (matr[j, i] > max) max = matr[j, i];
                }
                p++;
                k--;
            }
            Console.WriteLine("Максимум: {0}", max);
        }
        static double GetDoubleFromUser()
        {
            bool isCorrect = false;
            double dNumber = 0;
            while (!isCorrect)
            {
                isCorrect = Double.TryParse(Console.ReadLine(), out dNumber);
                if (!isCorrect) Console.WriteLine("Некорректный ввод. Требуется действительное число. Попробуйте ещё раз: ");
            }
            return dNumber;
        }
    }
}
