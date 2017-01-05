using Cyotek.Drawing;

namespace Cyotek.DitheringTest.Transforms
{
  internal sealed class MonochromePixelTransform : IPixelTransform
  {
    #region Constants

    private readonly ArgbColor _black;

    private readonly byte _threshold;

    private readonly ArgbColor _white;

    #endregion

    #region Constructors

    public MonochromePixelTransform(byte threshold)
    {
      _threshold = threshold;
      _black = new ArgbColor(0, 0, 0);
      _white = new ArgbColor(255, 255, 255);
    }

    #endregion

    #region IPixelTransform Interface

    public ArgbColor Transform(ArgbColor[] data, ArgbColor pixel, int x, int y, int width, int height)
    {
      byte gray;

      gray = (byte)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);

      /*
       * I'm leaving the alpha channel untouched instead of making it fully opaque
       * otherwise the transparent areas become fully black, and I was getting annoyed
       * by this when testing images with large swathes of transparency!
       */

      return gray < _threshold ? _black : _white;
    }

    #endregion
  }
}
