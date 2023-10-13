using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt1_zad.classes
{
    internal class Rectangle
    {
        private double sideA, sideB;
        
        public Rectangle(double a, double b)
        {
            if (a <=0 || b<=0)
            {
                Console.WriteLine("Boki prostokata musza byc dodatnie");
            }

            sideA = a;
            sideB = b;
        }

        public double CalculateRactangle()
        {
            return sideA * sideB;
        }
    }
}
