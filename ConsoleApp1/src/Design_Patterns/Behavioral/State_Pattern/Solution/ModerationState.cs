using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.State_Pattern.Solution{
    public class ModerationState : State {

        private Document _document;

        public ModerationState(Document document){
            _document = document;
        }

        public void Publish(){
            if(_document.CurrentUserRoles == UserRoles.Admin){
                _document.State = new PublishedState(_document);
            }
        }
    }
}