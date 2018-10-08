using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrect=false;
            string str = "";
            while (!isCorrect)
            {
                Console.WriteLine("Введите последовательность: ");
                str = Console.ReadLine();
                if (str.Length % 3 != 0) Console.WriteLine("Строка должна содержать количество символов, кратное трём");
                else isCorrect = true;
                for (int i = 0; i < str.Length; i++)
                {
                    if(str[i]!='0' && str[i] != '1')
                    {
                        Console.WriteLine("Строка должна содержать только символы 0 и 1");
                        isCorrect = false;
                        break;
                    }
                }
            }
            string result = "";
            for (int i = 0; i < str.Length; i += 3)
            {
                string substr = str.Substring(i, 3);
                int countZeros = 0;
                for(int j = 0; j < substr.Length; j++)
                {
                    if (substr[j] == '0') countZeros++;
                }
                if (countZeros >= 2) result += 0;
                else result += 1;
            }
            Console.WriteLine("Расшифрованное сообщение: {0}", result);
        }
    }
}
