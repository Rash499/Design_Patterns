using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Command_Pattern.RemoteControl.Solution{
    public class TurnOffCommand : ICommand
    {
        private Light _light;

        public TurnOffCommand(Light light){
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOff();

        }
    }

}