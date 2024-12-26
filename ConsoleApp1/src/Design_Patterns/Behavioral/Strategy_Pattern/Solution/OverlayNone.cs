using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Strategy_Pattern.Solution{
    public class OverlayNone : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("no Overlay");
        }

    }
}