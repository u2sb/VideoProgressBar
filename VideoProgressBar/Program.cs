using System;
using SixLabors.ImageSharp;
using VideoProgressBar.Models.ImageConfigs;
using VideoProgressBar.Utils.Images;

namespace VideoProgressBar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            var I = new ImageConfig();


            var createImg = new CreateImage(I);
            var bg = createImg.CreateBgImage();
            bg.SaveAsPng("Output/bg.png");

            var pb = createImg.CreatePbImage();
            pb.SaveAsPng("Output/pb.png");


            var tx = createImg.CreateTextImage();
            tx.SaveAsPng("Output/tx.png");
        }
    }
}