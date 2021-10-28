using System.Linq;
using SixLabors.Fonts;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using VideoProgressBar.Models.ImageConfigs;

namespace VideoProgressBar.Utils.Images
{
    public class CreateImage
    {
        private readonly ColorConfig _color;
        private readonly FontConfig _font;
        private readonly SizeConfig _size;
        private readonly VideoConfig _video;

        public CreateImage(ImageConfig i)
        {
            _size = i.S;
            _color = i.C;
            _video = i.V;
            _font = i.F;
        }

        public CreateImage(SizeConfig size, ColorConfig color, VideoConfig video, FontConfig font)
        {
            _size = size;
            _color = color;
            _video = video;
            _font = font;
        }

        /// <summary>
        ///     创建背景图片
        /// </summary>
        /// <returns></returns>
        public Image CreateBgImage()
        {
            var image = new Image<Rgba32>(_size.Bg.Width, _size.Bg.Height);
            image.Mutate(i
                => i
                    .BackgroundColor(Color.Transparent)
                    .Fill(_color.Bg.ProgressBarColor,
                        new RectangleF(
                            0,
                            _size.Bg.Height - _size.Bg.ProgressBarHeight,
                            _size.Bg.Width,
                            _size.Bg.ProgressBarHeight
                        ))
            );
            return image;
        }

        /// <summary>
        ///     创建进度条图片
        /// </summary>
        /// <returns></returns>
        public Image CreatePbImage()
        {
            var image = new Image<Rgba32>(_size.Bg.Width, _size.Bg.Height);
            image.Mutate(i
                => i
                    .BackgroundColor(Color.Transparent)
                    .Fill(_color.Pb.ProgressBarColor,
                        new RectangleF(
                            0,
                            _size.Bg.Height - _size.Bg.ProgressBarHeight,
                            _size.Bg.Width,
                            _size.Bg.ProgressBarHeight
                        ))
            );
            return image;
        }

        /// <summary>
        ///     创建文字图片
        /// </summary>
        /// <returns></returns>
        public Image CreateTextImage()
        {
            //处理
            if (!_video.NodeTime.ContainsKey(1)) _video.NodeTime.Add(1, "");

            //字体
            var collection = new FontCollection();
            var family = collection.Install(_font.Font);
            var font = family.CreateFont(_size.Vn.FontSize, FontStyle.Regular);
            var textOp = new TextOptions
            {
                HorizontalAlignment = HorizontalAlignment.Center
            };

            //创建图片
            var image = new Image<Rgba32>(_size.Bg.Width, _size.Bg.Height);
            image.Mutate(i => i.BackgroundColor(Color.Transparent));
            image.Mutate(i =>
            {
                var nts = _video.NodeTime.ToArray();
                for (var j = 0; j < nts.Length - 1; j++)
                    i.Fill(_color.Tc.SegmentationPointColor,
                        new RectangleF(
                            _size.Bg.Width * nts[j + 1].Key,
                            _size.Bg.Height - _size.Bg.ProgressBarHeight,
                            _size.Vn.NodeWidth,
                            _size.Bg.ProgressBarHeight
                        )).DrawText(new DrawingOptions { TextOptions = textOp }, nts[j].Value, font,
                        _color.Tc.ForegroundTextColor,
                        new PointF((_size.Bg.Width * nts[j + 1].Key + _size.Bg.Width * nts[j].Key) * 0.5f,
                            _size.Bg.Height - _size.Bg.ProgressBarHeight));
            });
            return image;
        }
    }
}