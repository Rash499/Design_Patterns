using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Command_Pattern.RemoteControl.Solution{

    //receving from the remote
    public class Light{
        public void TurnOn(){
            System.Console.WriteLine("Light is on");
        }

        public void TurnOff(){
            System.Console.WriteLine("Light is off");
        }

        public void Dim(){
            System.Console.WriteLine("Light is dim");
        }
    }
}