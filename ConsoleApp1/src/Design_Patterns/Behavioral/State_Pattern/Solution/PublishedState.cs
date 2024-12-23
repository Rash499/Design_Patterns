using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.State_Pattern.Solution{

    public class PublishedState : State {
        private Document _document;

        public PublishedState(Document document){
            _document = document;
        }

        public void Publish(){
            //do nothing
        }
    }
}