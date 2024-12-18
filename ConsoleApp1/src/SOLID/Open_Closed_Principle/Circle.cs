using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.SOLID.Open_Closed_Principle{
    public class Circle : Shape
    {
        public double Radius {get; set;}
        public override double CalculateArea()
        {
            return Math.PI* Math.Pow(Radius,2);
        }
    }

}