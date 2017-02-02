using System;
using System.Diagnostics;
using System.Windows.Forms;

/* Dithering an image using the Floyd–Steinberg algorithm in C#
 * https://www.cyotek.com/blog/dithering-an-image-using-the-floyd-steinberg-algorithm-in-csharp
 *
 * Copyright © 2015-2017 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

namespace Cyotek.DitheringTest
{
  internal sealed partial class AboutDialog : Form
  {
    #region Constructors

    public AboutDialog()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Methods

    protected override void OnLoad(EventArgs e)
    {
      FileVersionInfo versionInfo;

      versionInfo = FileVersionInfo.GetVersionInfo(typeof(MainForm).Assembly.Location);
      nameLabel.Text = versionInfo.ProductName;
      copyrightLabel.Text = versionInfo.LegalCopyright;

      this.SetLink(ossLinkLabel, "GitHub", "https://github.com/cyotek/Cyotek.Windows.Forms.ImageBox");
      this.SetLink(ossLinkLabel, "cyotek.com", "https://www.cyotek.com/blog/tag/imagebox");
      this.SetLink(ossLinkLabel, "another article", "https://www.cyotek.com/blog/creating-a-groupbox-containing-an-image-and-a-custom-display-rectangle");
      this.SetLink(ossLinkLabel, "README.md", "https://github.com/cyotek/Dithering/blob/master/README.md");
      this.SetLink(ossLinkLabel, "DHALF.TXT", "https://github.com/cyotek/Dithering/blob/master/resources/DHALF.TXT");
      this.SetLink(ossLinkLabel, "colour distance", "https://www.cyotek.com/blog/finding-nearest-colors-using-euclidean-distance");

      base.OnLoad(e);
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private bool HasLink(LinkLabel.LinkCollection links, int position)
    {
      bool result;

      result = false;

      if (links.LinksAdded)
      {
        for (int i = 0; i < links.Count; i++)
        {
          LinkLabel.Link link;

          link = links[i];

          if (position >= link.Start && position <= link.Start + link.Length)
          {
            result = true;
            break;
          }
        }
      }

      return result;
    }

    private void ossLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.RunUrl((string)e.Link.LinkData);
    }

    private void RunUrl(string url)
    {
      try
      {
        Process.Start(url);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.GetBaseException().Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void SetLink(LinkLabel control, string match, string url)
    {
      int index;

      index = -1;

      do
      {
        index = control.Text.IndexOf(match, index + 1, StringComparison.Ordinal);
      } while (index != -1 && this.HasLink(control.Links, index));

      control.Links.Add(index, match.Length, url);
    }

    private void webLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.RunUrl("https://www.cyotek.com");
    }

    #endregion
  }
}
