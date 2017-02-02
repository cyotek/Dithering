using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

/* Dithering an image using the Floyd–Steinberg algorithm in C#
 * https://www.cyotek.com/blog/dithering-an-image-using-the-floyd-steinberg-algorithm-in-csharp
 *
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

namespace Cyotek.DitheringTest.Helpers
{
  internal static class ArticleDiagrams
  {
    #region Static Methods

    public static Bitmap CreateBurkesDiagram()
    {
      Bitmap bitmap;
      int w;
      int h;
      int cellSize;
      int rows;
      int cols;
      int processedCells;
      int cell;
      int currentX;
      int currentY;

      currentX = 0;
      currentY = 0;
      cell = 0;
      cellSize = 38;
      rows = 4;
      cols = 7;
      w = cols * cellSize;
      h = rows * cellSize;
      processedCells = 11;

      bitmap = new Bitmap(w + 1, h + 1);

      using (Graphics g = Graphics.FromImage(bitmap))
      {
        g.Clear(Color.Transparent);

        for (int row = 0; row < rows; row++)
        {
          int cy;

          cy = row * cellSize;

          for (int col = 0; col < cols; col++)
          {
            int cx;
            int cw;
            int ch;

            cx = col * cellSize;
            cw = cellSize - 1;
            ch = cellSize - 1;

            g.DrawLine(Pens.Black, cx, cy, cx + cw, cy);
            g.DrawLine(Pens.Black, cx, cy, cx, cy + ch);

            cell++;
            if (cell < processedCells)
            {
              g.FillRectangle(Brushes.Silver, cx + 1, cy + 1, cw, ch);
            }
            else if (cell == processedCells)
            {
              currentX = cx;
              currentY = cy;
              g.FillRectangle(Brushes.CornflowerBlue, cx + 1, cy + 1, cw, ch);
            }
            else
            {
              g.FillRectangle(Brushes.DarkSeaGreen, cx + 1, cy + 1, cw, ch);
            }

            if (col == cols - 1)
            {
              g.DrawLine(Pens.Black, cx + cw + 1, cy, cx + cw + 1, cy + ch);
            }

            if (row == rows - 1)
            {
              g.DrawLine(Pens.Black, cx, cy + ch + 1, cx + cw, cy + ch + 1);
            }
          }
        }

        ArticleDiagrams.DrawString(g, "8/32", currentX + cellSize, currentY, cellSize - 1, cellSize, Color.Black, 10, StringAlignment.Center, StringAlignment.Center);
        ArticleDiagrams.DrawString(g, "4/32", currentX + (cellSize * 2), currentY, cellSize - 1, cellSize, Color.Black, 10, StringAlignment.Center, StringAlignment.Center);
        ArticleDiagrams.DrawString(g, "2/32", currentX - (cellSize * 2), currentY + cellSize, cellSize, cellSize, Color.Black, 10, StringAlignment.Center, StringAlignment.Center);
        ArticleDiagrams.DrawString(g, "4/32", currentX - cellSize, currentY + cellSize, cellSize, cellSize, Color.Black, 10, StringAlignment.Center, StringAlignment.Center);
        ArticleDiagrams.DrawString(g, "8/32", currentX, currentY + cellSize, cellSize, cellSize, Color.Black, 10, StringAlignment.Center, StringAlignment.Center);
        ArticleDiagrams.DrawString(g, "4/32", currentX + cellSize, currentY + cellSize, cellSize, cellSize, Color.Black, 10, StringAlignment.Center, StringAlignment.Center);
        ArticleDiagrams.DrawString(g, "2/32", currentX + (cellSize * 2), currentY + cellSize, cellSize, cellSize, Color.Black, 10, StringAlignment.Center, StringAlignment.Center);
      }

      return bitmap;
    }

    public static Bitmap CreateFloydSteinbergDiagram()
    {
      Bitmap bitmap;
      int w;
      int h;
      int cellSize;
      int halfCellSize;
      int rows;
      int cols;
      int processedCells;
      int cell;
      int currentX;
      int currentY;

      currentX = 0;
      currentY = 0;
      cell = 0;
      cellSize = 38;
      halfCellSize = cellSize >> 1;
      rows = 4;
      cols = 5;
      w = cols * cellSize;
      h = rows * cellSize;
      processedCells = 8;

      bitmap = new Bitmap(w + 1, h + 1);

      using (Graphics g = Graphics.FromImage(bitmap))
      {
        Color arrowColor;
        int arrowSize;
        int penSize;

        penSize = 2;
        arrowSize = 10;
        arrowColor = Color.SlateBlue;

        g.Clear(Color.Transparent);

        for (int row = 0; row < rows; row++)
        {
          int cy;

          cy = row * cellSize;

          for (int col = 0; col < cols; col++)
          {
            int cx;
            int cw;
            int ch;

            cx = col * cellSize;
            cw = cellSize - 1;
            ch = cellSize - 1;

            g.DrawLine(Pens.Black, cx, cy, cx + cw, cy);
            g.DrawLine(Pens.Black, cx, cy, cx, cy + ch);

            cell++;
            if (cell < processedCells)
            {
              g.FillRectangle(Brushes.Silver, cx + 1, cy + 1, cw, ch);
            }
            else if (cell == processedCells)
            {
              currentX = cx;
              currentY = cy;
              g.FillRectangle(Brushes.CornflowerBlue, cx + 1, cy + 1, cw, ch);
            }
            else
            {
              g.FillRectangle(Brushes.DarkSeaGreen, cx + 1, cy + 1, cw, ch);
            }

            if (col == cols - 1)
            {
              g.DrawLine(Pens.Black, cx + cw + 1, cy, cx + cw + 1, cy + ch);
            }

            if (row == rows - 1)
            {
              g.DrawLine(Pens.Black, cx, cy + ch + 1, cx + cw, cy + ch + 1);
            }
          }
        }

        ArticleDiagrams.DrawArrow(g, arrowColor, currentX + halfCellSize, currentY + halfCellSize, (int)(cellSize * 0.75), 0, penSize, arrowSize);
        ArticleDiagrams.DrawArrow(g, arrowColor, currentX + halfCellSize, currentY + halfCellSize, (int)(cellSize * 1.2), 45, penSize, arrowSize);
        ArticleDiagrams.DrawArrow(g, arrowColor, currentX + halfCellSize, currentY + halfCellSize, (int)(cellSize * 0.9), 90, penSize, arrowSize);
        ArticleDiagrams.DrawArrow(g, arrowColor, currentX + halfCellSize, currentY + halfCellSize, (int)(cellSize * 1.2), 135, penSize, arrowSize);

        ArticleDiagrams.DrawString(g, "7/16", currentX + cellSize, currentY, cellSize - 1, cellSize, Color.Black, 10, StringAlignment.Far, StringAlignment.Center);
        ArticleDiagrams.DrawString(g, "3/16", currentX - cellSize, currentY + cellSize, cellSize, cellSize, Color.Black, 10, StringAlignment.Center, StringAlignment.Far);
        ArticleDiagrams.DrawString(g, "5/16", currentX, currentY + cellSize, cellSize, cellSize, Color.Black, 10, StringAlignment.Center, StringAlignment.Far);
        ArticleDiagrams.DrawString(g, "1/16", currentX + cellSize, currentY + cellSize, cellSize, cellSize, Color.Black, 10, StringAlignment.Center, StringAlignment.Far);
      }

      return bitmap;
    }

    public static Bitmap CreateIntroDiagram()
    {
      Bitmap bitmap;
      int w;
      int h;
      int cellSize;
      int halfCellSize;
      int rows;
      int cols;
      int processedCells;
      int cell;
      int currentX;
      int currentY;

      currentX = 0;
      currentY = 0;
      cell = 0;
      cellSize = 32;
      halfCellSize = cellSize >> 1;
      rows = 5;
      cols = 8;
      w = cols * cellSize;
      h = rows * cellSize;
      processedCells = (rows * cols) >> 1;

      bitmap = new Bitmap(w + 1, h + 1);

      using (Graphics g = Graphics.FromImage(bitmap))
      {
        Color arrowColor;
        int arrowSize;
        int penSize;

        penSize = 2;
        arrowSize = 10;
        arrowColor = Color.SlateBlue;

        g.Clear(Color.Transparent);

        for (int row = 0; row < rows; row++)
        {
          int cy;

          cy = row * cellSize;

          for (int col = 0; col < cols; col++)
          {
            int cx;
            int cw;
            int ch;

            cx = col * cellSize;
            cw = cellSize - 1;
            ch = cellSize - 1;

            g.DrawLine(Pens.Black, cx, cy, cx + cw, cy);
            g.DrawLine(Pens.Black, cx, cy, cx, cy + ch);

            cell++;
            if (cell < processedCells)
            {
              g.FillRectangle(Brushes.Silver, cx + 1, cy + 1, cw, ch);
            }
            else if (cell == processedCells)
            {
              currentX = cx;
              currentY = cy;
              g.FillRectangle(Brushes.CornflowerBlue, cx + 1, cy + 1, cw, ch);
            }
            else
            {
              g.FillRectangle(Brushes.DarkSeaGreen, cx + 1, cy + 1, cw, ch);
            }

            if (col == cols - 1)
            {
              g.DrawLine(Pens.Black, cx + cw + 1, cy, cx + cw + 1, cy + ch);
            }

            if (row == rows - 1)
            {
              g.DrawLine(Pens.Black, cx, cy + ch + 1, cx + cw, cy + ch + 1);
            }
          }
        }

        ArticleDiagrams.DrawArrow(g, arrowColor, currentX + halfCellSize, currentY + halfCellSize, cellSize, 0, penSize, arrowSize);
        ArticleDiagrams.DrawArrow(g, arrowColor, currentX + halfCellSize, currentY + halfCellSize, (int)(cellSize * 1.4), 45, penSize, arrowSize);
        ArticleDiagrams.DrawArrow(g, arrowColor, currentX + halfCellSize, currentY + halfCellSize, cellSize, 90, penSize, arrowSize);
        ArticleDiagrams.DrawArrow(g, arrowColor, currentX + halfCellSize, currentY + halfCellSize, (int)(cellSize * 1.4), 135, penSize, arrowSize);
      }

      return bitmap;
    }

    private static void DrawArrow(Graphics g, Color color, int x, int y, int w, int angle, int penSize, int arrowSize)
    {
      using (Matrix rotation = new Matrix(1, 0, 0, 1, 0, 0))
      {
        int halfArrowSize;
        halfArrowSize = arrowSize >> 1;

        rotation.RotateAt(angle, new Point(x, y));
        g.Transform = rotation;

        g.SmoothingMode = SmoothingMode.AntiAlias;

        using (Pen pen = new Pen(color, penSize))
        {
          g.DrawLine(pen, x, y, x + w, y);
        }

        using (Brush brush = new SolidBrush(color))
        {
          g.FillPolygon(brush, new[]
                               {
                                 new Point(x + w + penSize - arrowSize, y - halfArrowSize), new Point(x + w + penSize, y), new Point(x + w + penSize - arrowSize, y + halfArrowSize)
                               });
        }

        g.SmoothingMode = SmoothingMode.Default;

        g.ResetTransform();
      }
    }

    private static void DrawString(Graphics g, string text, int x, int y, int w, int h, Color color, int size, StringAlignment align, StringAlignment verticalAlign)
    {
      using (Font font = new Font("Segoe UI", size, FontStyle.Regular, GraphicsUnit.Point))
      {
        using (Brush brush = new SolidBrush(color))
        {
          using (StringFormat format = (StringFormat)StringFormat.GenericTypographic.Clone())
          {
            format.Alignment = align;
            format.LineAlignment = verticalAlign;
            format.HotkeyPrefix = HotkeyPrefix.None;

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.DrawString(text, font, brush, new Rectangle(x, y, w, h), format);
            g.TextRenderingHint = TextRenderingHint.SystemDefault;
          }
        }
      }
    }

    #endregion
  }
}
