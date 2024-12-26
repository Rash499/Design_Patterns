using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Strategy_Pattern.Solution{
    public class VideoStorage{

        private ICompressor _compressor;

        private IOverlay _overlay;

        public VideoStorage(ICompressor compressor, IOverlay overlay){

            _compressor = compressor;
            _overlay = overlay;
        }

        public void SetCompressor(ICompressor compressor){
            _compressor = compressor;
        }

        public void SetOverlays(IOverlay overlay){
            _overlay = overlay;
        }

        public void Store(string fileName){

            _compressor.Compress();
            _overlay.Apply();

            System.Console.WriteLine("Storing video to "+ fileName + "." + _compressor);

        }
    }
    
}