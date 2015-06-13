using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Cyotek.Windows.Forms.Design;

namespace Cyotek.Windows.Forms
{
  [Designer(typeof(LineDesigner))]
  public class Line : Control
  {
    #region Instance Fields

    private FlatStyle _flatStyle = FlatStyle.Standard;

    private Color _lineColor;

    private Orientation _orientation;

    #endregion

    #region Public Constructors

    public Line()
    {
      this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
      this.SetStyle(ControlStyles.Selectable, false);
      this.LineColor = SystemColors.ControlDark;
    }

    #endregion

    #region Events

    public event EventHandler FlatStyleChanged;

    /// <summary>
    /// Occurs when the LineColor property value changes
    /// </summary>
    [Category("Property Changed")]
    public event EventHandler LineColorChanged;

    /// <summary>
    /// Occurs when the Orientation property value changes
    /// </summary>
    [Category("Property Changed")]
    public event EventHandler OrientationChanged;

    #endregion

    #region Overridden Properties

    protected override Size DefaultSize
    {
      get { return new Size(100, 2); }
    }

    #endregion

    #region Overridden Methods

    protected override void OnPaint(PaintEventArgs pe)
    {
      int x1;
      int y1;
      int x2;
      int y2;
      int xOffset;
      int yOffset;

      switch (this.Orientation)
      {
        case Orientation.Horizontal:
          x1 = 0;
          y1 = (this.Height / 2) - 1;
          x2 = this.Width;
          y2 = y1;
          xOffset = 0;
          yOffset = 1;
          break;
        default:
          x1 = (this.Width / 2) - 1;
          y1 = 0;
          x2 = x1;
          y2 = this.Height;
          xOffset = 1;
          yOffset = 0;
          break;
      }

      switch (this.FlatStyle)
      {
        case FlatStyle.System:
          using (Pen pen = new Pen(this.LineColor))
          {
            pe.Graphics.DrawLine(pen, x1, y1, x2, y2);
          }
          break;
        default:
          pe.Graphics.DrawLine(SystemPens.ControlDark, x1, y1, x2, y2);
          pe.Graphics.DrawLine(SystemPens.ControlLightLight, x1 + xOffset, y1 + yOffset, x2 + xOffset, y2 + yOffset);
          break;
      }
    }

    protected override void OnSystemColorsChanged(EventArgs e)
    {
      base.OnSystemColorsChanged(e);

      this.Invalidate();
    }

    #endregion

    #region Public Properties

    [Category("Appearance")]
    [DefaultValue(typeof(FlatStyle), "Standard")]
    public FlatStyle FlatStyle
    {
      get { return _flatStyle; }
      set
      {
        if (_flatStyle != value)
        {
          _flatStyle = value;

          this.OnFlatStyleChanged(EventArgs.Empty);
        }
      }
    }

    [Category("Appearance")]
    [DefaultValue(typeof(Color), "ControlDark")]
    public Color LineColor
    {
      get { return _lineColor; }
      set
      {
        if (this.LineColor != value)
        {
          _lineColor = value;

          this.OnLineColorChanged(EventArgs.Empty);
        }
      }
    }

    [Category("Appearance")]
    [DefaultValue(typeof(Orientation), "Horizontal")]
    public Orientation Orientation
    {
      get { return _orientation; }
      set
      {
        if (this.Orientation != value)
        {
          _orientation = value;

          this.OnOrientationChanged(EventArgs.Empty);
        }
      }
    }

    #endregion

    #region Protected Members

    /// <summary>
    /// Raises the <see cref="FlatStyleChangedChanged" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    protected virtual void OnFlatStyleChanged(EventArgs e)
    {
      EventHandler handler;

      handler = this.FlatStyleChanged;

      if (handler != null)
      {
        handler(this, e);
      }
    }

    /// <summary>
    /// Raises the <see cref="LineColorChanged" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    protected virtual void OnLineColorChanged(EventArgs e)
    {
      EventHandler handler;

      this.Invalidate();

      handler = this.LineColorChanged;

      if (handler != null)
      {
        handler(this, e);
      }
    }

    /// <summary>
    /// Raises the <see cref="OrientationChanged" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    protected virtual void OnOrientationChanged(EventArgs e)
    {
      EventHandler handler;

      this.Invalidate();

      handler = this.OrientationChanged;

      if (handler != null)
      {
        handler(this, e);
      }
    }

    #endregion
  }
}
