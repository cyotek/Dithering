using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyotek.DitheringTest.Transforms;
using Cyotek.Drawing.Imaging.ColorReduction;

namespace Cyotek.DitheringTest
{
internal sealed  class WorkerData
  {
    public Bitmap Image { get; set; }

    public IErrorDiffusion Dither { get; set; }

    public IPixelTransform Transform { get; set; }

    public int ColorCount { get; set; }
  }
}
