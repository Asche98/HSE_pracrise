using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a1: ");
            double a1 = GetDoubleFromUser();
            Console.WriteLine("Введите a2: ");
            double a2 = GetDoubleFromUser();
            Console.WriteLine("Введите a3: ");
            double a3 = GetDoubleFromUser();
            Console.WriteLine("Введите N: ");
            int n = GetIntFromUser();
            Console.WriteLine("Введите e: ");
            double e = GetDoubleFromUser();
            int count = 0;
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0:#.###}",GetElems(i, a1, a2, a3));
                if (i >= 2)
                {
                    double current = GetElems(i, a1, a2, a3);
                    double prev= GetElems(i-1, a1, a2, a3);
                    if (Math.Abs(current - prev) < e) count++;
                }
            }
            Console.WriteLine("Количество чисел, удовлетворяющих условию: {0}",count);
        }
        static double GetElems(int n,double a1,double a2,double a3)
        {
            if (n == 1) return a1;
            if (n == 2) return a2;
            if (n == 3) return a3;
            if (n == 4) return(1 / 3d * a3 + 1 / 2d * a2 + 2 / 3d * a1);
            else
            {
                double current = 1 / 3d * GetElems(n - 1,  a1, a2, a3) + 1 / 2d * GetElems(n - 2,  a1, a2, a3) + 2 / 3d * GetElems(n - 3,  a1, a2, a3);
                return current;
            }
            
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
        static int GetIntFromUser()
        {
            bool isCorrect = false;
            int iNumber = 0;
            while (!isCorrect)
            {
                isCorrect = Int32.TryParse(Console.ReadLine(), out iNumber)&&iNumber>0;
                if (!isCorrect) Console.WriteLine("Некорректный ввод. Требуется целое положительное число. Попробуйте ещё раз: ");
            }
            return iNumber;
        }
    }
}
