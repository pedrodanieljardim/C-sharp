using System;
using System.Globalization;

namespace FundamentosProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            String name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int numRooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product price:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            String all = Console.ReadLine();
            string[] v = all.Split(' ');
            String nome = v[0];
            int age = int.Parse(v[2]);
            double height = double.Parse(v[4]);

            Console.WriteLine(name);
            Console.WriteLine(numRooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
