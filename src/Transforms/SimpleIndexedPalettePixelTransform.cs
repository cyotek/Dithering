using System;
using System.Collections.Generic;
using Cyotek.Drawing;

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

    private long D(byte z, ArgbColor current, ArgbColor match)
    {
      /*
       * #define D(z) (line[z][x]-colormap[c][z])          // corrected color.
       */
      byte lhs;
      byte rhs;

      switch (z)
      {
        case 0:
          lhs = current.R;
          rhs = match.R;
          break;
        case 1:
          lhs = current.G;
          rhs = match.G;
          break;
        case 2:
          lhs = current.B;
          rhs = match.B;
          break;
        default:
          throw new ArgumentException("Invalid channel.", nameof(z));
      }

      return lhs - rhs;
    }

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
      long sdist;
      int index;

      index = 0;
      sdist = long.MaxValue;

      for (int i = 0; i < _map.Length; i++)
      {
        long dist;
        ArgbColor match;

        match = _map[i];

        // Could do with C# 7's inline functions here ;)
        dist = this.D(0, current, match) * this.D(0, current, match) + this.D(1, current, match) * this.D(1, current, match) + this.D(2, current, match) * this.D(2, current, match);

        if (dist < sdist)
        {
          index = i;
          sdist = dist;
        }
      }

      return index;
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
