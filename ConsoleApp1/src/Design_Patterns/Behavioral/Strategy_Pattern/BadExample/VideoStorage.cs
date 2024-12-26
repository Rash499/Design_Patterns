using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Design_Patterns.Behavioral.Strategy_Pattern.BadExample{

    public class VideoStorage{

        private Compressors _compressor;

        private Overlays _overlay;

        public VideoStorage(Compressors compressor, Overlays overlay = Overlays.None){

            _compressor = compressor;
            _overlay = overlay;
        }

        public void SetCompressor(Compressors compressor){
            _compressor = compressor;
        }

        public void SetOverlays(Overlays overlay){
            _overlay = overlay;
        }

        public void Store(string fileName){

            //compressing
            if(_compressor == Compressors.MOV){
                System.Console.WriteLine("Compressing using MOV");
            }
            else if(_compressor == Compressors.MP4){
                System.Console.WriteLine("Compressing using MP4");

            }
            else if(_compressor == Compressors.WEBM){
                System.Console.WriteLine("Compressing using WEBM");

            }

            //overlaying
            if(_overlay == Overlays.BlackAndWhite){
                System.Console.WriteLine("Applying black and white overlay");

            }
            else if(_overlay == Overlays.Blur){
                System.Console.WriteLine("Applying blur overlay");

            }
            else if(_overlay == Overlays.None){
                System.Console.WriteLine("Not applying an overlay");

            }

            System.Console.WriteLine("Storing video to "+ fileName + "." + _compressor);

        }
    }
}