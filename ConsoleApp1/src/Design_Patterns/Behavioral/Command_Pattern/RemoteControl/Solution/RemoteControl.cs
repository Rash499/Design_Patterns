using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Command_Pattern.RemoteControl.Solution{
    public class RemoteControl{
        private ICommand _command;
        public RemoteControl(ICommand command){
            _command = command;
        }

        public void SetCommand(ICommand command){
            _command = command;
        }

        public void PressButton(){
            _command.Execute();
        }
    }
}