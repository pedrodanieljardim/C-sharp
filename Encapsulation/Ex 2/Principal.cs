using System;
using System.Collections.Generic;
using System.Text;

namespace Acenelio
{
    class Principal
    {
        static void Main(string[] args)
        {
            Account a1;
            Console.WriteLine("Entre o número da conta:");
            int numberAccount = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta:");
            String nameAccount = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)?");
            char choice = char.Parse(Console.ReadLine());
            if(choice == 's')
            {
                Console.WriteLine("Entre o valor de depósito inicial:");
                double initialDeposit = double.Parse(Console.ReadLine());
                 a1 = new Account(numberAccount, nameAccount, initialDeposit);
            }
            else
            {
                 a1 = new Account(numberAccount, nameAccount,0);
            }

            Console.WriteLine("Dados da conta:");
            a1.ToString();

            Console.Write("Entre um valor para depósito: ");
            double deposit = double.Parse(Console.ReadLine());
            a1.depositAccount(deposit);
            Console.WriteLine("Dados da conta atualizados:");
            a1.ToString();

            Console.Write("Entre um valor para saque: ");
            double withdraw = double.Parse(Console.ReadLine());
            a1.withdrawAccount(withdraw);
            Console.WriteLine("Dados da conta atualizados:");
            a1.ToString();
        }
    }
}
