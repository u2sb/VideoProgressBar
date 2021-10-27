namespace VideoProgressBar.Models.ImageConfigs;

public class SizeConfig
{
    public BackGroundSize Bg { get; set; }
}

public class BackGroundSize
{
    /// <summary>
    ///     图片整体宽度
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    ///     图片整体高度
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    ///     底栏高度
    /// </summary>
    public int ProgressBarHeight { get; set; }
}