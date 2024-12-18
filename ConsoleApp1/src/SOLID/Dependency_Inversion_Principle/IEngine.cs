using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.SOLID.Dependency_Inversion_Principle{
    public interface IEngine{
        void Start(){
            System.Console.WriteLine("Engine Started");
        }
    }
}