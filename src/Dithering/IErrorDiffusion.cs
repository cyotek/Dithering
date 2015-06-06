/* Dithering an image using the Floyd–Steinberg algorithm in C#
 * http://www.cyotek.com/blog/dithering-an-image-using-the-floyd-steinberg-algorithm-in-csharp
 *
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

namespace Cyotek.DitheringTest.Dithering
{
  public interface IErrorDiffusion
  {
    #region Methods

    void Diffuse(ArgbColor[] original, ArgbColor originalPixel, ArgbColor transformedPixel, int x, int y, int width, int height);

    #endregion
  }
}
