#define USEWORKER
//#undef USEWORKER
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Windows.Forms;
using Cyotek.DitheringTest.Helpers;
using Cyotek.DitheringTest.Transforms;
using Cyotek.Drawing;
using Cyotek.Drawing.Imaging.ColorReduction;
using Cyotek.Windows.Forms;

/* Dithering an image using the Floyd–Steinberg algorithm in C#
 * http://www.cyotek.com/blog/dithering-an-image-using-the-floyd-steinberg-algorithm-in-csharp
 *
 * Copyright © 2015-2017 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

namespace Cyotek.DitheringTest
{
  internal partial class MainForm : Form
  {
    #region Fields

    private Bitmap _image;

    private RadioButton _previousSelection;

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

      paletteSizeComboBox.SelectedIndex = 0;
      noneRadioButton.Checked = true;

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

    private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      Tuple<Bitmap, IPixelTransform, IErrorDiffusion> data;

      data = (Tuple<Bitmap, IPixelTransform, IErrorDiffusion>)e.Argument;

      e.Result = this.GetTransformedImage(data.Item1, data.Item2, data.Item3);
    }

    private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.CleanUpTransformed();

      if (e.Error != null)
      {
        MessageBox.Show("Failed to transform image. " + e.Error.GetBaseException().Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        _transformed = e.Result as Bitmap;
        transformedImageBox.Image = _transformed;
      }

      statusToolStripStatusLabel.Text = string.Empty;
      Cursor.Current = Cursors.Default;
      this.UseWaitCursor = false;
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

    private void DefineImageBoxes(object sender, out ImageBox source, out ImageBox dest)
    {
      source = (ImageBox)sender;
      dest = source == originalImageBox ? transformedImageBox : originalImageBox;
    }

    private void DitherCheckBoxCheckedChangedHandler(object sender, EventArgs e)
    {
      RadioButton control;

      // RadioButtons maintain their state per container. However, I'm using multiple
      // containers so I need to manually reset the previous selection otherwise
      // you will have multiple checked items at once.

      control = sender as RadioButton;
      if (control != null && control.Checked)
      {
        if (!ReferenceEquals(control, _previousSelection) && _previousSelection != null)
        {
          _previousSelection.Checked = false;
        }
        _previousSelection = control;
      }

      refreshButton.Enabled = randomRadioButton.Checked;

      this.RequestImageTransform();
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
      else if (bayer2RadioButton.Checked)
      {
        result = new Bayer2();
      }
      else if (bayer3RadioButton.Checked)
      {
        result = new Bayer3();
      }
      else if (bayer4RadioButton.Checked)
      {
        result = new Bayer4();
      }
      else if (bayer8RadioButton.Checked)
      {
        result = new Bayer8();
      }
      else
      {
        result = null;
      }

      return result;
    }

    private IPixelTransform GetPixelTransform()
    {
      IPixelTransform result;

      result = null;

      if (monochromeRadioButton.Checked)
      {
        result = new MonochromePixelTransform((byte)thresholdNumericUpDown.Value);
      }
      else
      {
        switch (paletteSizeComboBox.SelectedIndex)
        {
          case 0:
            result = new SimpleIndexedPalettePixelTransform8();
            break;
          case 1:
            result = new SimpleIndexedPalettePixelTransform16();
            break;
          case 2:
            result = new SimpleIndexedPalettePixelTransform256();
            break;
        }
      }

      return result;
    }

    private Bitmap GetTransformedImage(Bitmap image, IPixelTransform transform, IErrorDiffusion dither)
    {
      Bitmap result;
      ArgbColor[] pixelData;
      Size size;

      size = image.Size;
      pixelData = image.GetPixelsFrom32BitArgbImage();

      for (int row = 0; row < size.Height; row++)
      {
        for (int col = 0; col < size.Width; col++)
        {
          int index;
          ArgbColor current;
          ArgbColor transformed;

          index = row * size.Width + col;

          current = pixelData[index];

          // transform the pixel - normally this would be some form of color
          // reduction. For this sample it's simple threshold based
          // monochrome conversion
          if (transform != null)
          {
            transformed = transform.Transform(pixelData, current, col, row, size.Width, size.Height);
            pixelData[index] = transformed;
          }
          else
          {
            transformed = current;
          }

          // apply a dither algorithm to this pixel
          dither?.Diffuse(pixelData, current, transformed, col, row, size.Width, size.Height);
        }
      }

      result = pixelData.ToBitmap(size);

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

    private void monochromeRadioButton_CheckedChanged(object sender, EventArgs e)
    {
      if (((RadioButton)sender).Checked)
      {
        if (ReferenceEquals(sender, monochromeRadioButton))
        {
          colorRadioButton.Checked = false;
        }
        else
        {
          monochromeRadioButton.Checked = false;
        }
      }

      monochromePanel.Enabled = monochromeRadioButton.Checked;
      colorPanel.Enabled = colorRadioButton.Checked;

      this.RequestImageTransform();
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

      this.RequestImageTransform();
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

    private void RequestImageTransform()
    {
      if (_image != null && !backgroundWorker.IsBusy)
      {
        IPixelTransform transform;
        IErrorDiffusion ditherer;
        Bitmap image;

        statusToolStripStatusLabel.Text = "Running image transform...";
        Cursor.Current = Cursors.WaitCursor;
        this.UseWaitCursor = true;

        transform = this.GetPixelTransform();
        ditherer = this.GetDitheringInstance();
        image = _image.Copy();

#if USEWORKER
        backgroundWorker.RunWorkerAsync(Tuple.Create(image, transform, ditherer));
#else
        backgroundWorker_RunWorkerCompleted(backgroundWorker, new RunWorkerCompletedEventArgs(this.GetTransformedImage(image, transform, ditherer), null, false));
#endif
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
      this.RequestImageTransform();
    }

    #endregion
  }
}
