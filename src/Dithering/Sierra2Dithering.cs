/* Dithering an image using the Burkes algorithm in C#
 * http://www.cyotek.com/blog/dithering-an-image-using-the-burkes-algorithm-in-csharp
 *
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

/*
 * Two Row Sierra Dithering
 * http://www.efg2.com/Lab/Library/ImageProcessing/DHALF.TXT
 *
 *                  *  4/16 3/16
 *      1/16 2/16 3/16 2/16 1/16
 */

namespace Cyotek.Drawing.Imaging.ColorReduction
{
  public sealed class Sierra2Dithering : ErrorDiffusionDithering
  {
    #region Constructors

    public Sierra2Dithering()
      : base(new byte[,]
             {
               {
                 0, 0, 0, 4, 3
               },
               {
                 1, 2, 3, 2, 1
               }
             }, 4, true)
    { }

    #endregion
  }
}
