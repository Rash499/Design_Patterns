using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Command_Pattern.UndoableCommandPattern{

    public class History{
        private List<UndoableCommand> commands = new List<UndoableCommand>();

        public void Push(UndoableCommand command){
            commands.Add(command);
        } 

        public UndoableCommand Pop(){
            var last = commands.Last();
            commands.Remove(last);
            return last;
        }

        public int Size(){
            return commands.Count;
        }
    }
}