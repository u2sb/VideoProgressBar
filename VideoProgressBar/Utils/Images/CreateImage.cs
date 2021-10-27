using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using VideoProgressBar.Models.ImageConfigs;

namespace VideoProgressBar.Utils.Images;

public class CreateImage
{
    private readonly ColorConfig _color;
    private readonly SizeConfig _size;

    public CreateImage(SizeConfig size, ColorConfig color)
    {
        _size = size;
        _color = color;
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
}