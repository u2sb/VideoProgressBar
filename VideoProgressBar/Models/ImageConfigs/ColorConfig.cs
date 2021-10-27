using SixLabors.ImageSharp;

namespace VideoProgressBar.Models.ImageConfigs;

public class ColorConfig
{
    public BackGroundColor Bg { get; set; }
    public ProgressBar Pb { get; set; }
}

public class BackGroundColor
{
    public Color ProgressBarColor { get; set; }
}

public class ProgressBar
{
    public Color ProgressBarColor { get; set; }
}