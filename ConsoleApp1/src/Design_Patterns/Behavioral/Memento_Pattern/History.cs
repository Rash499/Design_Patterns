using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Memento_Pattern{
    public class History{
        private List<Editor_State> _states = new List<Editor_State>();
        private Editor _editor;

        public History(Editor editor){
            _editor = editor;
        }

        public void BackUp(){
            _states.Add(_editor.CreateState());
        }

        public void Undo(){
            if(_states.Count == 0){
                return;
            }

            Editor_State prevState = _states.Last();
            _states.Remove(prevState);

            _editor.Restore(prevState);
        }

        public void ShowHistory(){
            System.Console.WriteLine("\nHistory: Here's the list of mementos:");

            foreach(var state in _states){
                System.Console.WriteLine(state.GetName());
            }
        }
    }
}