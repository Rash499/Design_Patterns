using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.SOLID.Interface_Segregation_Principle{
    public class Circle : IShape2D
    {

        public double Radius {get; set;}
        public double Area()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
    }
}