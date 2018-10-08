using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Point
    {
        public int data;
        public Point next;
        public Point()
        {
            data = 0;
            next = null;
        }
        public Point(int d)
        {
            data = d;
            next = null;
        }
        public override string ToString()
        {
            return data + " ";
        }

    }
}
