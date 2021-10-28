using System.Text.Json.Serialization;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using VideoProgressBar.Models.Converters;

namespace VideoProgressBar.Models.ImageConfigs
{
    public class ColorConfig
    {
        public BackGroundColor Bg { get; set; } = new();
        public ProgressBar Pb { get; set; } = new();
        public TextColor Tc { get; set; } = new();
    }

    public class BackGroundColor
    {
        [JsonConverter(typeof(RgbaConverter))]
        public Color ProgressBarColor { get; set; } = new(new Rgba32(162, 162, 162, 100));
    }

    public class ProgressBar
    {
        [JsonConverter(typeof(RgbaConverter))]
        public Color ProgressBarColor { get; set; } = new(new Rgba32(162, 162, 162, 200));
    }

    public class TextColor
    {
        [JsonConverter(typeof(RgbaConverter))] public Color SegmentationPointColor { get; set; } = Color.White;
        [JsonConverter(typeof(RgbaConverter))] public Color ForegroundTextColor { get; set; } = Color.White;
    }
}