using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Command_Pattern.UndoableCommandPattern{

    public class UndoCommand : Command
    {
        private History _history;

        public UndoCommand(History history){
            _history = history;
        }
        public void Execute()
        {
            if(_history.Size() > 0){
                var lastCommand = _history.Pop();
                lastCommand.Unexecute();
            }
        }
    }
}