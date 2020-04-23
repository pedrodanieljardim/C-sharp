using System;
using System.Collections.Generic;
using System.Text;

namespace Acenelio
{
    class Principal
    {
        static void Main(string[] args)
        {
            Student a1 = new Student();

            Console.WriteLine("Nome do Aluno: ");
            a1.name = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            a1.noteSemester1 = double.Parse(Console.ReadLine());
            a1.noteSemester2 = double.Parse(Console.ReadLine());
            a1.noteSemester3 = double.Parse(Console.ReadLine());

            a1.calculateFinalnote();
        }
    }
}
