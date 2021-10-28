using System.Collections.Generic;

namespace VideoProgressBar.Models.ImageConfigs
{
    public class VideoConfig
    {
        /// <summary>
        ///     节点时间
        /// </summary>
        public Dictionary<float, string> NodeTime { get; set; } = new()
        {
            { 0, "第 1 段" },
            { 0.5f, "第 2 段" }
        };
    }
}