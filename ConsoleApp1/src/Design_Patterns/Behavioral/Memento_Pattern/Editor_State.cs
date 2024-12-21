using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Memento_Pattern{
    //Memento
    public class Editor_State{
        private readonly string _title;
        private readonly string _content;

        //State meta data
        private readonly DateTime _stateCreatedAt;


        public Editor_State(string title, string content){
            _title = title;
            _content = content;
            _stateCreatedAt = DateTime.Now;
        }

        public string GetTitle(){
            return _title;
        }

        public string GetContent(){
            return _content;
        }

        public DateTime GetDate(){
            return _stateCreatedAt;
        }

        public string GetName(){
            return $"{_stateCreatedAt} / {_title}";
        }
    }
}