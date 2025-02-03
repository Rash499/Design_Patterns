using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Template_Method_Pattern.BadExample{
    public class Tea{

        public void MakeBeverage(){
            BoilWater();
            PourWaterIntoCup();
            Brew();
            AddCondiments();
        }
        private void BoilWater(){
            System.Console.WriteLine("Boling Water");
        }

        private void PourWaterIntoCup(){
            System.Console.WriteLine("Pouring Water into Cup");
        }

        private void Brew(){
            System.Console.WriteLine("Brewing tea for 3 Minitues");

        }

        private void AddCondiments(){
            if(CustomerWantsCondiments()){
                System.Console.WriteLine("Adding lemon to the tea");
            }
        }

        private bool CustomerWantsCondiments(){
            System.Console.WriteLine("Would you like lemon with your tea (y/n)?");
            string input = Console.ReadLine();
            return input.ToLower() == "y";
        }
    }
}