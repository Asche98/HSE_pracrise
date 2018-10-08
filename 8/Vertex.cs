using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Vertex
    {
        int number { get; set; }
        int parent { get; set; }//прямой предок вершины
        bool isPaint { get; set; }//закрашена ли точка на текущий момент обхода алгоритмом dfs
        bool isCutVertex { get; set; }//является ли вершина точкой сочленения в данном графе

        public Vertex(int number)
        {
            this.number = number;
        }
    }
}
