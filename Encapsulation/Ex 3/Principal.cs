using System;
using System.Collections.Generic;
using System.Text;

namespace Acenelio
{
    class Principal
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Nome do Produto:");
            String name = Console.ReadLine();
            Console.WriteLine("Preço do Produto:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade do Produto:");
            double quantity = double.Parse(Console.ReadLine());

            Product p1 = new Product(name,price,quantity);

            Console.WriteLine($"Total em estoque: R${p1.valueStock():F2}");
            p1.addProduct(12);
            p1.removeProduct(2);
            Console.WriteLine($"Total em estoque após movimentações: R${p1.valueStock():F2}");
        }
    }
}
