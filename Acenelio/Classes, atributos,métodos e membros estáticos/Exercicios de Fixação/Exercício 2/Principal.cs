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
            Console.WriteLine("Nome:");
            f1.name = Console.ReadLine();
            Console.WriteLine("Salário Bruto: ");
            f1.salaryGross = double.Parse(Console.ReadLine());
            Console.WriteLine("Imposto: ");
            f1.tax = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionario: {f1.name}, ${f1.salaryLiquid()}");
            Console.WriteLine("Digite a porcentagem para aumentar o salário:");
            double increase = double.Parse(Console.ReadLine());
            f1.increaseSalary(increase);
            Console.WriteLine($"Dados Atualizados: {f1.name}, ${f1.salaryLiquid()}");
        }
    }
}
