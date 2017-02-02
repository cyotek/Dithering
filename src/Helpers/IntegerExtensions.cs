/* Dithering an image using the Floyd–Steinberg algorithm in C#
 * https://www.cyotek.com/blog/dithering-an-image-using-the-floyd-steinberg-algorithm-in-csharp
 *
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

namespace Cyotek
{
  internal static class IntegerExtensions
  {
    #region Static Methods

    internal static byte ToByte(this int value)
    {
      if (value < 0)
      {
        value = 0;
      }
      else if (value > 255)
      {
        value = 255;
      }

      return (byte)value;
    }

    #endregion
  }
}
