using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int vertexCount,edgeCount;
            Console.WriteLine("Введите количество вершин в графе: ");
            vertexCount = GetIntFromUser();
            Vertex[] vertices = new Vertex[vertexCount];
            Console.WriteLine("Введите идентификатор каждого ребра - целое число");
            for(int i = 0; i < vertexCount; i++)
            {
                vertices[i] = new Vertex(GetIntFromUser());
            }
            Console.WriteLine("Введите количество рёбер в графе: ");
            edgeCount = GetIntFromUser();
            Edge[] edges = new Edge[edgeCount];

        }
        static int GetIntFromUser()
        {
            bool isCorrect = false;
            int iNumber = 0;
            while (!isCorrect)
            {
                isCorrect = Int32.TryParse(Console.ReadLine(), out iNumber) && iNumber > 0;
                if (!isCorrect) Console.WriteLine("Некорректный ввод. Требуется целое положительное число. Попробуйте ещё раз: ");
            }
            return iNumber;
        }
    }
}
