/* Dithering an image using the Burkes algorithm in C#
 * http://www.cyotek.com/blog/dithering-an-image-using-the-burkes-algorithm-in-csharp
 *
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

/*
 * Jarvis, Judice & Ninke Dithering
 * http://www.efg2.com/Lab/Library/ImageProcessing/DHALF.TXT
 *
 *                  *  8/48 5/48
 *      3/48 5/48 7/48 5/48 3/48
 *      1/48 3/48 5/48 3/48 1/48
 */

namespace Cyotek.Drawing.Imaging.ColorReduction
{
  public sealed class JarvisJudiceNinkeDithering : ErrorDiffusionDithering
  {
    #region Constructors

    public JarvisJudiceNinkeDithering()
      : base(new byte[,]
             {
               {
                 0, 0, 0, 7, 5
               },
               {
                 3, 5, 7, 5, 3
               },
               {
                 1, 3, 5, 3, 1
               }
             }, 48, false)
    { }

    #endregion
  }
}
