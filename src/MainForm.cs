using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Windows.Forms;
using Cyotek.DitheringTest.Helpers;
using Cyotek.Drawing;
using Cyotek.Drawing.Imaging.ColorReduction;
using Cyotek.Windows.Forms;

/* Dithering an image using the Floyd–Steinberg algorithm in C#
 * http://www.cyotek.com/blog/dithering-an-image-using-the-floyd-steinberg-algorithm-in-csharp
 *
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

namespace Cyotek.DitheringTest
{
  internal partial class MainForm : Form
  {
    #region Fields

    private Bitmap _image;

    private Bitmap _transformed;

    #endregion

    #region Constructors

    public MainForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Methods

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        this.CleanUpOriginal();
        this.CleanUpTransformed();

        if (components != null)
        {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Form.Shown"/> event.
    /// </summary>
    /// <param name="e">A <see cref="T:System.EventArgs"/> that contains the event data. </param>
    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      this.OpenImage(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"resources\sample.png"));

      //this.OpenImage(ArticleDiagrams.CreateBurkesDiagram());
      //ArticleDiagrams.CreateBurkesDiagram().Save(@"C:\Checkout\cyotek\source\Applications\cyotek.com\files\articleimages\dithering-burkes-diagram.png", ImageFormat.Png);
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (AboutDialog dialog = new AboutDialog())
      {
        dialog.ShowDialog(this);
      }
    }

    private void CleanUpOriginal()
    {
      originalImageBox.Image = null;

      if (_image != null)
      {
        _image.Dispose();
        _image = null;
      }
    }

    /// <summary>
    /// Disposes of interim images
    /// </summary>
    private void CleanUpTransformed()
    {
      transformedImageBox.Image = null;

      if (_transformed != null)
      {
        _transformed.Dispose();
        _transformed = null;
      }
    }

    private void CreateTransformedImage()
    {
      Bitmap image;
      ArgbColor[] originalData;
      Size size;
      IErrorDiffusion dither;

      this.CleanUpTransformed();

      image = _image;
      size = image.Size;

      originalData = image.GetPixelsFrom32BitArgbImage();

      dither = this.GetDitheringInstance();

      for (int row = 0; row < size.Height; row++)
      {
        for (int col = 0; col < size.Width; col++)
        {
          int index;
          ArgbColor current;
          ArgbColor transformed;

          index = row * size.Width + col;

          current = originalData[index];

          // transform the pixel - normally this would be some form of color
          // reduction. For this sample it's simple threshold based
          // monochrome conversion
          transformed = this.TransformPixel(current);
          originalData[index] = transformed;

          // apply a dither algorithm to this pixel
          if (dither != null)
          {
            dither.Diffuse(originalData, current, transformed, col, row, size.Width, size.Height);
          }
        }
      }

      _transformed = originalData.ToBitmap(size);
      transformedImageBox.Image = _transformed;
    }

    private void DefineImageBoxes(object sender, out ImageBox source, out ImageBox dest)
    {
      source = (ImageBox)sender;
      dest = source == originalImageBox ? transformedImageBox : originalImageBox;
    }

    private void DitherCheckBoxCheckedChangedHandler(object sender, EventArgs e)
    {
      this.CreateTransformedImage();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private IErrorDiffusion GetDitheringInstance()
    {
      IErrorDiffusion result;

      if (floydSteinbergRadioButton.Checked)
      {
        result = new FloydSteinbergDithering();
      }
      else if (burkesRadioButton.Checked)
      {
        result = new BurksDithering();
      }
      else if (jarvisJudiceNinkeDitheringradioButton.Checked)
      {
        result = new JarvisJudiceNinkeDithering();
      }
      else if (stuckiRadioButton.Checked)
      {
        result = new StuckiDithering();
      }
      else if (sierra3RadioButton.Checked)
      {
        result = new Sierra3Dithering();
      }
      else if (sierra2RadioButton.Checked)
      {
        result = new Sierra2Dithering();
      }
      else if (sierraLiteRadioButton.Checked)
      {
        result = new SierraLiteDithering();
      }
      else if (atkinsonRadioButton.Checked)
      {
        result = new AtkinsonDithering();
      }
      else if (randomRadioButton.Checked)
      {
        result = new RandomDithering();
      }
      else
      {
        result = null;
      }

      return result;
    }

    private void horizontalSplitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool horizontal;

      horizontal = !horizontalSplitToolStripMenuItem.Checked;
      horizontalSplitToolStripMenuItem.Checked = horizontal;
      horizontalToolStripButton.Checked = horizontal;

      if (horizontal)
      {
        previewSplitContainer.Orientation = Orientation.Horizontal;
        previewSplitContainer.SplitterDistance = (previewSplitContainer.Height - previewSplitContainer.SplitterWidth) / 2;
      }
      else
      {
        previewSplitContainer.Orientation = Orientation.Vertical;
        previewSplitContainer.SplitterDistance = (previewSplitContainer.Width - previewSplitContainer.SplitterWidth) / 2;
      }
    }

    private void OpenImage(Bitmap bitmap)
    {
      this.CleanUpOriginal();

      // Create a copy of the source bitmap.
      // Two reasons:
      //    1. The copy routine will ensure a 32bit ARGB image is returned as the unsafe code
      //       for working with bitmaps via points expects this and I'm not complicating the
      //       project further by adding tons of code
      //    2. Image.FromFile locks the source file until the bitmap is disposed of. I don't
      //       want that to happen, and copying the image gets rid of this issue too

      _image = bitmap.Copy();

      originalImageBox.Image = _image;
      originalImageBox.ActualSize();

      this.CreateTransformedImage();
    }

    private void OpenImage(string fileName)
    {
      try
      {
        using (Bitmap image = (Bitmap)Image.FromFile(fileName))
        {
          this.OpenImage(image);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("Failed to open image. {0}", ex.GetBaseException().Message), "Open Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (FileDialog dialog = new OpenFileDialog
                                 {
                                   Title = "Open Image",
                                   DefaultExt = "png",
                                   Filter = "All Pictures (*.emf;*.wmf;*.jpg;*.jpeg;*.jfif;*.jpe;*.png;*.bmp;*.dib;*.rle;*.gif;*.tif;*.tiff)|*.emf;*.wmf;*.jpg;*.jpeg;*.jfif;*.jpe;*.png;*.bmp;*.dib;*.rle;*.gif;*.tif;*.tiff|Windows Enhanced Metafile (*.emf)|*.emf|Windows Metafile (*.wmf)|*.wmf|JPEG File Interchange Format (*.jpg;*.jpeg;*.jfif;*.jpe)|*.jpg;*.jpeg;*.jfif;*.jpe|Portable Networks Graphic (*.png)|*.png|Windows Bitmap (*.bmp;*.dib;*.rle)|*.bmp;*.dib;*.rle|Graphics Interchange Format (*.gif)|*.gif|Tagged Image File Format (*.tif;*.tiff)|*.tif;*.tiff|All files (*.*)|*.*"
                                 })
      {
        if (dialog.ShowDialog(this) == DialogResult.OK)
        {
          this.OpenImage(dialog.FileName);
        }
      }
    }

    private void originalImageBox_Scroll(object sender, ScrollEventArgs e)
    {
      ImageBox source;
      ImageBox dest;
      Point sourcePosition;
      Point destinationPosition;
      double aspectW;
      double aspectH;

      this.DefineImageBoxes(sender, out source, out dest);

      aspectW = source.Image.Size.Width / (double)dest.Image.Size.Width;
      aspectH = source.Image.Size.Height / (double)dest.Image.Size.Height;

      sourcePosition = source.AutoScrollPosition;
      destinationPosition = new Point(-(int)(sourcePosition.X * aspectW), -(int)(sourcePosition.Y * aspectH));

      dest.ScrollTo(destinationPosition.X, destinationPosition.Y);
    }

    private void originalImageBox_Zoomed(object sender, ImageBoxZoomEventArgs e)
    {
      ImageBox source;
      ImageBox dest;

      this.DefineImageBoxes(sender, out source, out dest);

      dest.Zoom = source.Zoom;
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Bitmap image;

      image = ClipboardHelpers.GetImage();

      if (image == null)
      {
        SystemSounds.Exclamation.Play();
      }
      else
      {
        this.OpenImage(image);
      }
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (FileDialog dialog = new SaveFileDialog
                                 {
                                   Title = "Save Image As",
                                   DefaultExt = "png",
                                   Filter = "Portable Networks Graphic (*.png)|*.png|All files (*.*)|*.*"
                                 })
      {
        if (dialog.ShowDialog(this) == DialogResult.OK)
        {
          try
          {
            _transformed.Save(dialog.FileName, ImageFormat.Png);
          }
          catch (Exception ex)
          {
            MessageBox.Show(string.Format("Failed to save image. {0}", ex.GetBaseException().Message), "Open Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }

    private void thresholdNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      this.CreateTransformedImage();
    }

    private ArgbColor TransformPixel(ArgbColor pixel)
    {
      byte gray;

      gray = (byte)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);

      /*
       * I'm leaving the alpha channel untouched instead of making it fully opaque
       * otherwise the transparent areas become fully black, and I was getting annoyed
       * by this when testing images with large swathes of transparency!
       */

      return gray < (byte)thresholdNumericUpDown.Value ? new ArgbColor(pixel.A, 0, 0, 0) : new ArgbColor(pixel.A, 255, 255, 255);
    }

    #endregion
  }
}
