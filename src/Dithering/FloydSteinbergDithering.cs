/* Dithering an image using the Floyd–Steinberg algorithm in C#
 * http://www.cyotek.com/blog/dithering-an-image-using-the-floyd-steinberg-algorithm-in-csharp
 *
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

using Cyotek.DitheringTest.Helpers;

namespace Cyotek.DitheringTest.Dithering
{
  public sealed class FloydSteinbergDithering : IErrorDiffusion
  {
    #region IDither Interface

    void IErrorDiffusion.Diffuse(ArgbColor[] original, ArgbColor originalPixel, ArgbColor transformedPixel, int x, int y, int width, int height)
    {
      ArgbColor offsetPixel;
      int redError;
      int blueError;
      int greenError;
      int offsetIndex;
      int index;

      /*
        * Floyd-Steinberg Dithering
        * http://en.wikipedia.org/wiki/Floyd%E2%80%93Steinberg_dithering
        *
        * Coefficients for dispersing the error (* is the current pixel):
        *
        *             *  7/16
        *      3/16 5/16 1/16
        *
        * As 16 is a power of two, we can use bit shifting to do the
        * division which is actually faster than the division operator
        */

      index = y * width + x;
      redError = originalPixel.R - transformedPixel.R;
      blueError = originalPixel.G - transformedPixel.G;
      greenError = originalPixel.B - transformedPixel.B;

      if (x + 1 < width)
      {
        // right
        offsetIndex = index + 1;
        offsetPixel = original[offsetIndex];
        offsetPixel.R = (offsetPixel.R + ((redError * 7) >> 4)).ToByte();
        offsetPixel.G = (offsetPixel.G + ((greenError * 7) >> 4)).ToByte();
        offsetPixel.B = (offsetPixel.B + ((blueError * 7) >> 4)).ToByte();
        original[offsetIndex] = offsetPixel;
      }

      if (y + 1 < height)
      {
        if (x - 1 > 0)
        {
          // left and down
          offsetIndex = index + width - 1;
          offsetPixel = original[offsetIndex];
          offsetPixel.R = (offsetPixel.R + ((redError * 3) >> 4)).ToByte();
          offsetPixel.G = (offsetPixel.G + ((greenError * 3) >> 4)).ToByte();
          offsetPixel.B = (offsetPixel.B + ((blueError * 3) >> 4)).ToByte();
          original[offsetIndex] = offsetPixel;
        }

        // down
        offsetIndex = index + width;
        offsetPixel = original[offsetIndex];
        offsetPixel.R = (offsetPixel.R + ((redError * 5) >> 4)).ToByte();
        offsetPixel.G = (offsetPixel.G + ((greenError * 5) >> 4)).ToByte();
        offsetPixel.B = (offsetPixel.B + ((blueError * 5) >> 4)).ToByte();
        original[offsetIndex] = offsetPixel;

        if (x + 1 < width)
        {
          // right and down
          offsetIndex = index + width + 1;
          offsetPixel = original[offsetIndex];
          offsetPixel.R = (offsetPixel.R + ((redError * 1) >> 4)).ToByte();
          offsetPixel.G = (offsetPixel.G + ((greenError * 1) >> 4)).ToByte();
          offsetPixel.B = (offsetPixel.B + ((blueError * 1) >> 4)).ToByte();
          original[offsetIndex] = offsetPixel;
        }
      }
    }

    #endregion
  }
}
