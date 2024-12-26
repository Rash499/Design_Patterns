using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Strategy_Pattern.Solution{
    public class CompressorMOV : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compresssing video using MOV");
        }
    }
}