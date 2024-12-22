using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Memento_Pattern{
    //originator
    public class Editor{
        public required string Title {get; set;}
        public required string Content {get; set;}

        public Editor_State CreateState(){
            return new Editor_State(Title, Content);
        }

        public void Restore(Editor_State state){
            Title = state.GetTitle();
            Content = state.GetContent();
        }

    }
}