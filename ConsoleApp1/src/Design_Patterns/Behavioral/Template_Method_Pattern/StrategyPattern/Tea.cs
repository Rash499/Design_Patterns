using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Template_Method_Pattern.StrategyPattern{
    public class Tea : Beverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
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