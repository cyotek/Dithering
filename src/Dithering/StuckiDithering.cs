/* Dithering an image using the Burkes algorithm in C#
 * http://www.cyotek.com/blog/dithering-an-image-using-the-burkes-algorithm-in-csharp
 *
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

/*
 * Stucki Dithering
 * http://www.efg2.com/Lab/Library/ImageProcessing/DHALF.TXT
 *
 *                  *  8/42 4/42
 *      2/42 4/42 8/42 4/42 2/42
 *      1/42 2/42 4/42 2/42 1/42
 */

namespace Cyotek.Drawing.Imaging.ColorReduction
{
  public sealed class StuckiDithering : ErrorDiffusionDithering
  {
    #region Constructors

    public StuckiDithering()
      : base(new byte[,]
             {
               {
                 0, 0, 0, 8, 4
               },
               {
                 2, 4, 8, 4, 2
               },
               {
                 1, 2, 4, 2, 1
               }
             }, 42, false)
    { }

    #endregion
  }
}
