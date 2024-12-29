using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Iterator_Pattern.BadExample{
    
    public class ShoppingList{

        private List<string> _list = new List<string>();

        public void Push(string itemName){
            _list.Add(itemName);
        }

        public string Pop(){
            var last = _list.Last();
            _list.Remove(last);
            return last;
        }

        public List<string> GetList(){
            return _list;
        }
    }
}