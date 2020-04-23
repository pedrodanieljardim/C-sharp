using System;
using System.Collections.Generic;
using System.Text;

namespace Acenelio
{
    class Principal
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();

            Console.WriteLine("Nome do Produto:");
            p1.name = Console.ReadLine();
            Console.WriteLine("Preço do Produto:");
            p1.price = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade do Produto:");
            p1.quantity = double.Parse(Console.ReadLine());

            Console.WriteLine($"Total em estoque: R${p1.valueStock():F2}");
            p1.addProduct(12);
            p1.removeProduct(2);
            Console.WriteLine($"Total em estoque após movimentações: R${p1.valueStock():F2}");
        }
    }
}
