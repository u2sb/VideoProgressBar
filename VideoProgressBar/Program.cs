// See https://aka.ms/new-console-template for more information

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using VideoProgressBar.Models.ImageConfigs;
using VideoProgressBar.Utils.Images;

Console.WriteLine("Hello, World!");


var sz = new SizeConfig
{
    Bg = new BackGroundSize
    {
        Width = 3840,
        Height = 2160,
        ProgressBarHeight = 100
    }
};

var c = new ColorConfig
{
    Bg = new BackGroundColor
    {
        ProgressBarColor = new Color(new Rgba32(162, 162, 162, 100))
    },
    Pb = new ProgressBar
    {
        ProgressBarColor = new Color(new Rgba32(162, 162, 162, 200))
    }
};


var f = new FontConfig
{
    Font = "Fonts/极影毁片圆.ttf"
};

var createImg = new CreateImage(sz, c);
var bg = createImg.CreateBgImage();
bg.SaveAsPng("bg.png");

var pb = createImg.CreatePbImage();
pb.SaveAsPng("pb.png");