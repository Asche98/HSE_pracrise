using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hse_practise
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Данная программа проверяет принадлежность точки области. Пожалуйста, введите координаты точки - действительные числа");
            while (true)
            {
                Console.Write("Введите точку x: ");
                x = GetDoubleFromUser();
                Console.Write("Введите точку y: ");
                y = GetDoubleFromUser();
                if (y <= 2 * x + 3 && ((y <= -x &&  y>=0) || (y >= (1 / 3d) * x - (1 / 3d) && y <= 0)))
                {
                    Console.WriteLine("Точка принадлежит области");
                }
                else Console.WriteLine("Точка не принадлежит области");
            }
        }
        static double GetDoubleFromUser()
        {
            bool isCorrect=false;
            double dNumber=0;
            while (!isCorrect)
            {
                isCorrect = Double.TryParse(Console.ReadLine(), out dNumber);
                if (!isCorrect) Console.WriteLine("Некорректный ввод. Требуется действительное число. Попробуйте ещё раз: ");
            }
            return dNumber;
        }
    }
}
