using System.ComponentModel;

// ReSharper disable once CheckNamespace
namespace Cyotek.Drawing.Imaging.ColorReduction
{
  [Description("Bayer-3")]
  [Browsable(false)]
  public class Bayer3 : OrderedDithering
  {
    #region Constructors

    public Bayer3()
      : base(new byte[,]
             {
               {
                 0,
                 7,
                 3
               },
               {
                 6,
                 5,
                 2
               },
               {
                 4,
                 1,
                 8
               }
             })
    { }

    #endregion
  }
}
