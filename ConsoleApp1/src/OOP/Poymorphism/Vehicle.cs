using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OOP.Polymorphism{
    public class Vehicle{
        public required string Brand { get; set; }

        public required string Model { get; set; }

        public int Year { get; set; }

        public void start() {
            Console.WriteLine("Vehicle is starting");
        }

        public void stop(){
            Console.WriteLine("Vehicle is stoping");
        }
    }
}