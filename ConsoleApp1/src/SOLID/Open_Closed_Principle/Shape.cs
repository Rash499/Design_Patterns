using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.SOLID.Open_Closed_Principle{
    public abstract class Shape{
        /*
        public ShapeType Type {get; set;}

        public double Radius {get; set;}

        public double Length {get; set;}

        public double Width {get; set;} 

        public double CalculateArea() {
            switch(Type){
                case ShapeType.Circle:
                    return Math.PI * Math.Pow(Radius, 2);
                case ShapeType.Rectangle:
                    return Length * Width;
                default:
                    throw new InvalidOperationException("Unsupported shape type");
            }
        } */
        public abstract double CalculateArea();
    }
}