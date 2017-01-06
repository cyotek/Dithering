using System.Collections.Generic;
using Cyotek.Drawing;

/* Finding nearest colors using Euclidean distance
 * http://www.cyotek.com/blog/finding-nearest-colors-using-euclidean-distance
 *
 * Copyright © 2017 Cyotek Ltd.
 */

namespace Cyotek.DitheringTest.Transforms
{
  internal abstract class SimpleIndexedPalettePixelTransform : IPixelTransform
  {
    #region Constants

    private readonly ArgbColor[] _map;

    private readonly IDictionary<ArgbColor, int> _mapLookup;

    #endregion

    #region Constructors

    protected SimpleIndexedPalettePixelTransform(ArgbColor[] map)
    {
      _map = map;
      _mapLookup = new Dictionary<ArgbColor, int>();
    }

    #endregion

    #region Methods

    private int FindNearestColor(ArgbColor current)
    {
      /*
      *             sdist = 255L * 255L * 255L + 1L;      // Compute the color
      *             for (c=0; c<COLORS; ++c) {            // in colormap[] that
      *                                                   // is nearest to the
      * #define D(z) (line[z][x]-colormap[c][z])          // corrected color.
      *
      *                 dist = D(0)*D(0) + D(1)*D(1) + D(2)*D(2);
      *                 if (dist < sdist) {
      *                     nc = c;
      *                     sdist = dist;
      *                 }
      *             }
      */
      int shortestDistance;
      int index;

      index = 0;
      shortestDistance = int.MaxValue;

      for (int i = 0; i < _map.Length; i++)
      {
        ArgbColor match;
        int distance;

        match = _map[i];
        distance = this.GetDistance(current, match);

        if (distance < shortestDistance)
        {
          index = i;
          shortestDistance = distance;
        }
      }

      return index;
    }

    private int GetDistance(ArgbColor current, ArgbColor match)
    {
      int redDifference;
      int greenDifference;
      int blueDifference;

      redDifference = current.R - match.R;
      greenDifference = current.G - match.G;
      blueDifference = current.B - match.B;

      return redDifference * redDifference + greenDifference * greenDifference + blueDifference * blueDifference;
    }

    #endregion

    #region IPixelTransform Interface

    public ArgbColor Transform(ArgbColor[] data, ArgbColor pixel, int x, int y, int width, int height)
    {
      int index;

      if (!_mapLookup.TryGetValue(pixel, out index))
      {
        index = this.FindNearestColor(pixel);

        _mapLookup.Add(pixel, index);
      }

      return _map[index];
    }

    #endregion
  }
}
