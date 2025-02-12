using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trapecio
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Insertar base mayor (B)");
            int B = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Insertar base menor (b)");
            int b = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Insertar altra (h)");
            int h = int.Parse(Console.ReadLine());
            int S = B + b;
            int M = S * h;
            int R = M / 2;
            System.Console.WriteLine("El resultado es:" + R);
            Console.ReadKey();
        }
    }
}
