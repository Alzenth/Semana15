using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f, c;
            Random rnd = new Random();
            Console.Write("Ingrese el número de filas: ");
            f = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número de columnas: ");
            c = int.Parse(Console.ReadLine());

            int[,] matriz = new int[f, c];

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matriz[i,j] = rnd.Next(30, 50);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
