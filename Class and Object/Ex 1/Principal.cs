using System;
using System.Collections.Generic;
using System.Text;

namespace Acenelio
{
    class Principal
    {
        static double PI = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio:");
            double radius = double.Parse(Console.ReadLine());
            double circumference = calculateCircumference(radius);
            double Volume = calculateVolumeCircumference(radius);
            Console.WriteLine($"Circuferência: {circumference:F2}");
            Console.WriteLine($"Volume da Circuferência: {Volume:F2}");
            Console.WriteLine($"PI: {PI:F2}");
        }
        static double calculateVolumeCircumference(double radius)
        {
            return (4.0/3.0) * PI * Math.Pow(radius,3);
        }

        static double calculateCircumference(double radius)
        {
            return 2 * PI * radius;
        }
    }
}
