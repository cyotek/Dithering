using Cyotek.Drawing;

/* Finding nearest colors using Euclidean distance
 * https://www.cyotek.com/blog/finding-nearest-colors-using-euclidean-distance
 *
 * Copyright © 2017 Cyotek Ltd.
 */

namespace Cyotek.DitheringTest.Transforms
{
  internal sealed class SimpleIndexedPalettePixelTransform16 : SimpleIndexedPalettePixelTransform
  {
    #region Constructors

    public SimpleIndexedPalettePixelTransform16()
      : base(new[]
             {
               ArgbColor.FromArgb(0, 0, 0),
               ArgbColor.FromArgb(128, 0, 0),
               ArgbColor.FromArgb(0, 128, 0),
               ArgbColor.FromArgb(128, 128, 0),
               ArgbColor.FromArgb(0, 0, 128),
               ArgbColor.FromArgb(128, 0, 128),
               ArgbColor.FromArgb(0, 128, 128),
               ArgbColor.FromArgb(192, 192, 192),
               ArgbColor.FromArgb(128, 128, 128),
               ArgbColor.FromArgb(255, 0, 0),
               ArgbColor.FromArgb(0, 255, 0),
               ArgbColor.FromArgb(255, 255, 0),
               ArgbColor.FromArgb(0, 0, 255),
               ArgbColor.FromArgb(255, 0, 255),
               ArgbColor.FromArgb(0, 255, 255),
               ArgbColor.FromArgb(255, 255, 255)
             })
    { }

    #endregion
  }
}
