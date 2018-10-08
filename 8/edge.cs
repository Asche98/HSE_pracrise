using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Edge
    {
        Vertex startVertex { get; set; }
        Vertex endVertex { get; set; }
        public Edge(Vertex startVertex,Vertex endVertex)
        {
            this.startVertex = startVertex;
            this.endVertex = endVertex;
        }
    }
}
