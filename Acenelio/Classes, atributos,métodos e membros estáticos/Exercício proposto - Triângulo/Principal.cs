using System;
using System.Collections.Generic;
using System.Text;

namespace Acenelio
{
    class Principal
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo X:");
            Console.WriteLine("Lado A:");
            t1.A = double.Parse(Console.ReadLine());
            Console.WriteLine("Lado B:");
            t1.B = double.Parse(Console.ReadLine());
            Console.WriteLine("Lado C:");
            t1.C = double.Parse(Console.ReadLine());
            double p1 = (t1.A + t1.B + t1.C) / 2.0;
            double area1 = Math.Sqrt(p1 * (p1 - t1.A) * (p1 - t1.B) * (p1 - t1.C));

            Triangulo t2 = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            Console.WriteLine("Lado A:");
            t2.A = double.Parse(Console.ReadLine());
            Console.WriteLine("Lado B:");
            t2.B = double.Parse(Console.ReadLine());
            Console.WriteLine("Lado C:");
            t2.C = double.Parse(Console.ReadLine());
            double p2 = (t2.A + t2.B + t2.C) / 2.0;
            double area2 = Math.Sqrt(p2 * (p2 - t2.A) * (p2 - t2.B) * (p2 - t2.C));
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("lados do Triangulo X: " + t1.A+","+t1.B+","+t1.C);
            Console.WriteLine($"Perímetro do Triangulo X:{p1:F2} ");
            Console.WriteLine($"Área do Triângulo X: {area1:F2}");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("lados do Triangulo Y: " + t2.A + "," + t2.B + "," + t2.C);
            Console.WriteLine($"Perímetro do Triangulo X: {p2:F2}");
            Console.WriteLine($"Área do Triângulo X: {area2:F2}");
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
