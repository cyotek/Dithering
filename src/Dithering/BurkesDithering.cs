/* Dithering an image using the Burkes algorithm in C#
 * http://www.cyotek.com/blog/dithering-an-image-using-the-burkes-algorithm-in-csharp
 *
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

using Cyotek.DitheringTest.Helpers;

namespace Cyotek.DitheringTest.Dithering
{
  public sealed class BurksDithering : IErrorDiffusion
  {
    #region Constants

    private static readonly byte[,] _matrix =
{
  {
    0, 0, 0, 8, 4
  },
  {
    2, 4, 8, 4, 2
  }
};

    private const int _matrixHeight = 2;

    private const int _matrixStartX = 2;

    private const int _matrixWidth = 5;

    #endregion

    #region IDither Interface

    void IErrorDiffusion.Diffuse(ArgbColor[] original, ArgbColor originalPixel, ArgbColor transformedPixel, int x, int y, int width, int height)
    {
      int redError;
      int blueError;
      int greenError;

      /*
        * Burkes Dithering
        * http://www.efg2.com/Lab/Library/ImageProcessing/DHALF.TXT
        *
        *                  *  8/32 4/32
        *      2/32 4/32 8/32 4/32 2/32
        *
        * As 32 is a power of two, we can use bit shifting to do the
        * division which is actually faster than the division operator
        */

      redError = originalPixel.R - transformedPixel.R;
      blueError = originalPixel.G - transformedPixel.G;
      greenError = originalPixel.B - transformedPixel.B;

      for (int row = 0; row < _matrixHeight; row++)
      {
        int offsetY;

        offsetY = y + row;

        for (int col = 0; col < _matrixWidth; col++)
        {
          int coefficient;
          int offsetX;

          coefficient = _matrix[row, col];
          offsetX = x + (col - _matrixStartX);

          if (coefficient != 0 && offsetX > 0 && offsetX < width && offsetY > 0 && offsetY < height)
          {
            ArgbColor offsetPixel;
            int offsetIndex;

            offsetIndex = offsetY * width + offsetX;
            offsetPixel = original[offsetIndex];
            offsetPixel.R = (offsetPixel.R + ((redError * coefficient) >> 5)).ToByte();
            offsetPixel.G = (offsetPixel.G + ((greenError * coefficient) >> 5)).ToByte();
            offsetPixel.B = (offsetPixel.B + ((blueError * coefficient) >> 5)).ToByte();
            original[offsetIndex] = offsetPixel;
          }
        }
      }
    }

    #endregion
  }
}
