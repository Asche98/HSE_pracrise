using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coefs = new int[11];//коэффициенты
            bool isHaveRoots = false;
            for(int i = 0; i < coefs.Length; i++)
            {
                if (i == 10)
                {
                    Console.WriteLine("Введите свободный коэффициент:");
                }
                else
                {
                    Console.WriteLine("Введите коэффициент {0}: ", i + 1);
                }
                coefs[i] = GetIntFromUser();
            }
            int free = coefs[10];//свободный коэффициент
            if (free == 0)
            {
                Console.WriteLine("Имеется корень равный 0");
                isHaveRoots = true;
            }
            else
            {
                for(int i = 1; i <= Math.Abs(free); i++)
                {
                    if (free % i == 0)
                    {
                        if (GetValueByHorner(coefs, i) == 0)
                        {
                            isHaveRoots = true;
                            Console.WriteLine("Имеется корень {0}", i);
                        }
                        if (GetValueByHorner(coefs, -i) == 0)
                        {
                            isHaveRoots = true;
                            Console.WriteLine("Имеется корень {0}", -i);
                        }
                    }
                }
            }
            if (!isHaveRoots)
            {
                Console.WriteLine("Корней нет");
            }
        }
        static int GetIntFromUser()
        {
            bool isCorrect = false;
            int iNumber = 0;
            while (!isCorrect)
            {
                isCorrect = Int32.TryParse(Console.ReadLine(), out iNumber);
                if (!isCorrect) Console.WriteLine("Некорректный ввод. Требуется целое число. Попробуйте ещё раз: ");
            }
            return iNumber;
        }
        static int GetValueByHorner(int[]coefs,int x)
        {
            int value=coefs[0];
            for(int i = 1; i < coefs.Length; i++)
            {
                value = value * x + coefs[i];
            }
            return value;
        }
    }
}
