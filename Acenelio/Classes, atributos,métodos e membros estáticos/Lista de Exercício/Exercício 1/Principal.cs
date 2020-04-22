using System;
using System.Collections.Generic;
using System.Text;

namespace Acenelio
{
    class Principal
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Console.WriteLine("Dados da Primeira Pessoa:");
            Console.WriteLine("Nome:");
            p1.name = Console.ReadLine();
            Console.WriteLine("Idade:");
            p1.age = int.Parse(Console.ReadLine());

            Pessoa p2 = new Pessoa();
            Console.WriteLine("Dados da Segunda Pessoa:");
            Console.WriteLine("Nome:");
            p2.name = Console.ReadLine();
            Console.WriteLine("Idade:");
            p2.age = int.Parse(Console.ReadLine());

            if(p2.age > p1.age)
            {
                Console.WriteLine("Pessoa mais velha: " + p2.name);
            }
            if(p1.age > p2.age)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.name);
            }
            if(p1.age == p2.age)
            {
                Console.WriteLine("Não há Pessoa mais velha, porque ambos tem a mesma idade...");
            }

        }
    }
}
