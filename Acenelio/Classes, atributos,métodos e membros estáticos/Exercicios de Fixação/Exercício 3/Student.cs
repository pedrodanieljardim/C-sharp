using System;
using System.Collections.Generic;
using System.Text;

namespace Acenelio
{
    class Student
    {
        public String name;
        public double noteSemester1;
        public double noteSemester2;
        public double noteSemester3;

        public void calculateFinalnote()
        {
            double noteFinal = noteSemester1 + noteSemester2 + noteSemester3;
            if(noteFinal >= 60)
            {
                Console.WriteLine($"NOTA FINAL = {noteFinal:F2}");
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine($"NOTA FINAL = {noteFinal:F2}");
                Console.WriteLine("Reprovado!");
                Console.WriteLine($"Faltaram {60 - noteFinal:F2} pontos");
            }
        }
    }
}
