using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double B;
            double h;
            double a;
            Console.Write("Insira a Base do Triângulo: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Insira a Altura do Triângulo: ");
            h = double.Parse(Console.ReadLine());

            a = B * h / 2;

            Console.WriteLine("A area do Triângulo é {0}.", a);
        }
    }
}
