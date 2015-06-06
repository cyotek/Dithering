using System;
using System.Diagnostics;
using System.Windows.Forms;

/* Dithering an image using the Floyd–Steinberg algorithm in C#
 * http://www.cyotek.com/blog/dithering-an-image-using-the-floyd-steinberg-algorithm-in-csharp
 *
 * Copyright © 2015 Cyotek Ltd.
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

      base.OnLoad(e);
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void webLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      try
      {
        Process.Start("http://www.cyotek.com");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.GetBaseException().Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    #endregion
  }
}
