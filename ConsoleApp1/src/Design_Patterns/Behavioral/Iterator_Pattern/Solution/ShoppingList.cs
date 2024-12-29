using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Iterator_Pattern.Solution{
    
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

        public IIterator<string> CreateIterator(){

            return new ListIterator(this);
        }
        //these concrete classes are only concerned with iterating over shoppinglist objects, it makes sense to nest them so that 
        //they can only be used to iterate over shopping list objects, and not be used in other classes throughtout our codebase.
        private class ListIterator : IIterator<string>
        {

            private ShoppingList _shoppinglist;
            private int _index;

            public ListIterator(ShoppingList shoppinglist){
                _shoppinglist = shoppinglist;
            }
            public string Current()   //concrete iterator objects
            {
                return _shoppinglist._list[_index];

            }

            public bool HasNext()
            {
                return _index < _shoppinglist._list.Count;            }

            public void Next()
            {
                _index++;
            }
        }
    }
}