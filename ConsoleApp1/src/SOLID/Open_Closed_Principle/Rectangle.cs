using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.SOLID.Open_Closed_Principle{
    public class Rectangle : Shape{
        public double Legth {get; set;}

        public double Width {get; set;}

        public override double CalculateArea()
        {
            return Legth*Width;
        }
    }
}