using System;
using System.Collections.Generic;
using System.Text;

namespace Acenelio
{
    class Principal
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine("Digite os dados do retângulo R1:");
            Console.WriteLine("Altura:");
            r1.height = double.Parse(Console.ReadLine());
            Console.WriteLine("Largura:");
            r1.width = double.Parse(Console.ReadLine());

            r1.showAll();
        }
    }
}
