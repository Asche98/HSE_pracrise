using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        public static Random rnd=new Random();
        static void Main(string[] args)
        {
            Point list = MakeList(5);
            ShowCount(list);
            Console.WriteLine("В списке {0} элемент(а/ов)", RecursiveShowCount(list));
        }

        static Point MakePoint(int d)
        {
            Point p = new Point(d);
            return p;
        }

        static Point MakeList(int size,Point prev=null,Point begP=null)
        {
            if (size == 0) return begP;
            int info = rnd.Next(0, 11);
            if (begP == null)//если список ещё не был создан
            {
                info = rnd.Next(0, 11);
                Point beg = MakePoint(info);
                beg.next = beg;
                return MakeList(size-1, prev = beg, begP = beg);
            }
            info = rnd.Next(0, 11);
            Point p = MakePoint(info);
            p.next = begP;
            if (prev != null) prev.next = p;
            return MakeList(size-1, prev = p, begP);
        }
        static void ShowList(Point beg)
        {
            if (beg == null)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            Point p = beg;
            do
            {
                Console.Write(p);
                p = p.next;
            } while (p != beg);
            Console.WriteLine();
        }
        static void ShowCount(Point beg)
        {
            int count = 0;
            if (beg == null)
            {
                Console.WriteLine("В списке 0 элементов");
            }
            Point p = beg;
            do
            {
                count++;
                p = p.next;
            } while (p != beg);
            Console.WriteLine("В списке {0} элемент(а/ов)",count);
        }
        static int RecursiveShowCount(Point beg,Point ConstantBeg=null)
        {
            if (beg == null) return 0;
            if (beg.next == beg) return 1;
            if (ConstantBeg == null) ConstantBeg = beg;
            else if (beg.next == ConstantBeg) return 1;
            return 1 + RecursiveShowCount(beg.next,ConstantBeg);
        }
    }
}
