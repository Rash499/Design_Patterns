using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.State_Pattern.Solution{
    public class DraftState : State {
        private Document _document;

        public DraftState(Document document){
            _document = document;
        }

        public void Publish(){
            _document.State = new ModerationState(_document);
        }
    }
}