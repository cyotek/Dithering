using System.ComponentModel;

// ReSharper disable once CheckNamespace
namespace Cyotek.Drawing.Imaging.ColorReduction
{
  [Description("Bayer-4")]
  [Browsable(false)]
  public class Bayer4 : OrderedDithering
  {
    #region Constructors

    public Bayer4()
      : base(new byte[,]
             {
               {
                 0,
                 8,
                 2,
                 10
               },
               {
                 12,
                 4,
                 14,
                 6
               },
               {
                 3,
                 11,
                 1,
                 9
               },
               {
                 15,
                 7,
                 13,
                 5
               }
             })
    { }

    #endregion
  }
}
