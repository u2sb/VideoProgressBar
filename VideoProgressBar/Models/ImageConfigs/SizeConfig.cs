namespace VideoProgressBar.Models.ImageConfigs
{
    public class SizeConfig
    {
        public BackGroundSize Bg { get; set; } = new();
        public VideoNodeSize Vn { get; set; } = new();
    }

    public class BackGroundSize
    {
        /// <summary>
        ///     图片整体宽度
        /// </summary>
        public int Width { get; set; } = 1920;

        /// <summary>
        ///     图片整体高度
        /// </summary>
        public int Height { get; set; } = 1080;

        /// <summary>
        ///     底栏高度
        /// </summary>
        public int ProgressBarHeight { get; set; } = 50;
    }

    public class VideoNodeSize
    {
        public int NodeWidth { get; set; } = 10;
        public int FontSize { get; set; } = 36;
    }
}