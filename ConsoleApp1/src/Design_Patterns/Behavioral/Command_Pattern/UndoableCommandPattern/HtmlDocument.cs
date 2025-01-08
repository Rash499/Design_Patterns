using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Command_Pattern.UndoableCommandPattern{
    public class HtmlDocument{

        public string Content {get;set;}

        public void MakeItalic(){
            Content = "<i>" + Content + "</i>";
        }
    }
}