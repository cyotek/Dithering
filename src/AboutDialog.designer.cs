namespace Cyotek.DitheringTest
{
  partial class AboutDialog
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
      this.nameLabel = new System.Windows.Forms.Label();
      this.copyrightLabel = new System.Windows.Forms.Label();
      this.webLinkLabel = new System.Windows.Forms.LinkLabel();
      this.closeButton = new System.Windows.Forms.Button();
      this.ossLinkLabel = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nameLabel.Location = new System.Drawing.Point(12, 9);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(61, 13);
      this.nameLabel.TabIndex = 0;
      this.nameLabel.Text = "AppName";
      // 
      // copyrightLabel
      // 
      this.copyrightLabel.AutoSize = true;
      this.copyrightLabel.Location = new System.Drawing.Point(12, 22);
      this.copyrightLabel.Name = "copyrightLabel";
      this.copyrightLabel.Size = new System.Drawing.Size(51, 13);
      this.copyrightLabel.TabIndex = 1;
      this.copyrightLabel.Text = "Copyright";
      // 
      // webLinkLabel
      // 
      this.webLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.webLinkLabel.AutoSize = true;
      this.webLinkLabel.Location = new System.Drawing.Point(12, 233);
      this.webLinkLabel.Name = "webLinkLabel";
      this.webLinkLabel.Size = new System.Drawing.Size(120, 13);
      this.webLinkLabel.TabIndex = 2;
      this.webLinkLabel.TabStop = true;
      this.webLinkLabel.Text = "http://www.cyotek.com";
      this.webLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.webLinkLabel_LinkClicked);
      // 
      // closeButton
      // 
      this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.closeButton.Location = new System.Drawing.Point(420, 228);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(75, 23);
      this.closeButton.TabIndex = 3;
      this.closeButton.Text = "Close";
      this.closeButton.UseVisualStyleBackColor = true;
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      // 
      // ossLinkLabel
      // 
      this.ossLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ossLinkLabel.Location = new System.Drawing.Point(12, 70);
      this.ossLinkLabel.Name = "ossLinkLabel";
      this.ossLinkLabel.Size = new System.Drawing.Size(483, 155);
      this.ossLinkLabel.TabIndex = 4;
      this.ossLinkLabel.TabStop = true;
      this.ossLinkLabel.Text = resources.GetString("ossLinkLabel.Text");
      this.ossLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ossLinkLabel_LinkClicked);
      // 
      // AboutDialog
      // 
      this.AcceptButton = this.closeButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.closeButton;
      this.ClientSize = new System.Drawing.Size(507, 263);
      this.Controls.Add(this.ossLinkLabel);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(this.webLinkLabel);
      this.Controls.Add(this.copyrightLabel);
      this.Controls.Add(this.nameLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AboutDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "About";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.Label copyrightLabel;
    private System.Windows.Forms.LinkLabel webLinkLabel;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.LinkLabel ossLinkLabel;
  }
}
