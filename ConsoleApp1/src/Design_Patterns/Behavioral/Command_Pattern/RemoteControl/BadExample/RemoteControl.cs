using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Command_Pattern.RemoteControl.BadExample{

    //invoker
    public class RemoteControl{

        private Light _light;

        public RemoteControl(Light light){
            _light = light;
        }

        public void PressButton(bool turnOn){
            if(turnOn){
                _light.TurnOn();
            }
            else{
                _light.TurnOff();
            }
        }
    }
}