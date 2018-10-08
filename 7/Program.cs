using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 1, 2, 3, 4, 5 };
            int tailLength = 1;
            int beforeTailPos = getBeforeTailPos(t);
            for(int i = 0; i < fact(t.Length); i++)
            {
                beforeTailPos = getBeforeTailPos(t);
                tailLength = t.Length-beforeTailPos-1;
                if (beforeTailPos != -1)
                {
                    for (int d = 0; d < t.Length; d++)
                    {
                        Console.Write(t[d] + " ");
                    }
                    Console.WriteLine();
                    for (int j = t.Length - 1; j > beforeTailPos; j--)
                    {
                        if (t[j] > t[beforeTailPos])
                        {
                            int temp = t[beforeTailPos];
                            t[beforeTailPos] = t[j];
                            t[j] = temp;
                            break;
                        }
                    }
                    if (tailLength > 1)
                    {
                        int startPos = beforeTailPos + 1;
                        int endPos = t.Length - 1;
                        do
                        {
                            int temp = t[startPos];
                            t[startPos] = t[endPos];
                            t[endPos] = temp;
                            startPos++;
                            endPos--;
                        }
                        while ((startPos - endPos) > 1);
                    }
                }
            }    
        }
        static int fact(int n)
        {
            int fact = 1;
            for(int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static int getBeforeTailPos(int[] a)
        {
            int pos = -1;
            for(int i = a.Length - 2; i >= 0; i--)
            {
                if (a[i] < a[i + 1])
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
    }
}
