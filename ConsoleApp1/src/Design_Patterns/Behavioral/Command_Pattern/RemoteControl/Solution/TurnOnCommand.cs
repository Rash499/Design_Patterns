using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Command_Pattern.RemoteControl.Solution{
    public class TurnOnCommand : ICommand
    {
        private Light _light;

        public TurnOnCommand(Light light){
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOn();

        }
    }

}