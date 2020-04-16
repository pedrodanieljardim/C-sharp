using System;
using System.Globalization;

namespace FundamentosProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a++;
            Console.WriteLine(a);
            a = 10;
            int b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = 10;
            b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
