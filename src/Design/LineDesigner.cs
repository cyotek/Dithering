using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Cyotek.Windows.Forms.Design
{
  public class LineDesigner : ControlDesigner
  {
    #region Overridden Properties

    public override SelectionRules SelectionRules
    {
      get
      {
        SelectionRules result;

        result = SelectionRules.Visible | SelectionRules.Moveable;

        switch (((Line)this.Control).Orientation)
        {
          case Orientation.Horizontal:
            result |= (SelectionRules.RightSizeable | SelectionRules.LeftSizeable);
            break;
          default:
            result |= (SelectionRules.TopSizeable | SelectionRules.BottomSizeable);
            break;
        }

        return result;
      }
    }

    #endregion
  }
}
