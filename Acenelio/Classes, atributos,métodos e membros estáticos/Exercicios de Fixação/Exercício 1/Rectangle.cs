using System;
using System.Collections.Generic;
using System.Text;

namespace Acenelio
{
    class Rectangle
    {
        public double height;
        public double width;

        public double calculateArea()
        {
            return this.height * this.width;
        }
        public double calculatePerimeter()
        {
            return 2 * (this.height + this.width);
        }
        public double calculateDiagonal()
        {
            return Math.Sqrt(Math.Pow(this.height, 2) * Math.Pow(this.width,2));
        }

        public void showAll()
        {
            Console.WriteLine("Dados do retângulo:");
            Console.WriteLine($"Area: {calculateArea():F2}");
            Console.WriteLine($"Diagonal: {calculateDiagonal():F2}");
            Console.WriteLine($"Perímetro: {calculatePerimeter():F2}");
        }

    }
}
