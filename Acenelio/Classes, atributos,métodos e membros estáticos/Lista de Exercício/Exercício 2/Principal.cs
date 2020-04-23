using System;
using System.Collections.Generic;
using System.Text;

namespace Acenelio
{
    class Principal
    {
        static void Main(string[] args)
        {
            Funcionary f1 = new Funcionary();
            Console.WriteLine("Dados da Primeiro Funcionário:");
            Console.WriteLine("Nome:");
            f1.name = Console.ReadLine();
            Console.WriteLine("Salário:");
            f1.salary = double.Parse(Console.ReadLine());

            Funcionary f2 = new Funcionary();
            Console.WriteLine("Dados da Segunda Funcionário:");
            Console.WriteLine("Nome:");
            f2.name = Console.ReadLine();
            Console.WriteLine("Salário:");
            f2.salary = double.Parse(Console.ReadLine());

            double mean = (f1.salary + f2.salary) / 2;

            Console.WriteLine($"Salário Médio:{mean:F2}");
           

        }
    }
}