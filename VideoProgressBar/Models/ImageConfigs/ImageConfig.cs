using System.IO;
using System.Text.Json;

namespace VideoProgressBar.Models.ImageConfigs
{
    public class ImageConfig
    {
        private readonly string _configPath;

        public ImageConfig(string configPath = "Config")
        {
            _configPath = configPath;
            if (!Directory.Exists(configPath)) Directory.CreateDirectory(configPath);

            S = DConfig<SizeConfig>(Path.Combine(configPath, "size.json"));
            C = DConfig<ColorConfig>(Path.Combine(configPath, "color.json"));
            F = DConfig<FontConfig>(Path.Combine(configPath, "font.json"));
            V = DConfig<VideoConfig>(Path.Combine(configPath, "video.json"));
        }

        public SizeConfig S { get; set; }
        public ColorConfig C { get; set; }
        public FontConfig F { get; set; }
        public VideoConfig V { get; set; }

        public void SaveConfig()
        {
            SConfig(S, Path.Combine(_configPath, "size.json"));
            SConfig(C, Path.Combine(_configPath, "color.json"));
            SConfig(F, Path.Combine(_configPath, "font.json"));
            SConfig(V, Path.Combine(_configPath, "video.json"));
        }

        private T DConfig<T>(string path) where T : new()
        {
            var sr = new StreamReader(path);
            var json = sr.ReadToEnd();
            sr.Close();
            return JsonSerializer.Deserialize<T>(json) ?? new T();
        }

        private void SConfig<T>(T t, string path)
        {
            var fs = new FileStream(path, FileMode.OpenOrCreate);
            var j = JsonSerializer.Serialize(t);
            var sw = new StreamWriter(fs);
            sw.Write(j);
            sw.Close();
        }
    }
}