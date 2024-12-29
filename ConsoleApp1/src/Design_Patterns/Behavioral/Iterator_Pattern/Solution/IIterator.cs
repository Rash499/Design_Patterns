using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Iterator_Pattern.Solution{

    public interface IIterator<T>{
        void Next();
        bool HasNext();
        //string Current();

        T Current(); //use for mutiple types of lists
    }
}