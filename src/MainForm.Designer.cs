namespace Cyotek.DitheringTest
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.floydSteinbergRadioButton = new System.Windows.Forms.RadioButton();
      this.rootSplitContainer = new System.Windows.Forms.SplitContainer();
      this.previewSplitContainer = new System.Windows.Forms.SplitContainer();
      this.originalImageBox = new Cyotek.Windows.Forms.ImageBox();
      this.transformedImageBox = new Cyotek.Windows.Forms.ImageBox();
      this.colorConversionGroupBox = new System.Windows.Forms.GroupBox();
      this.thresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.ditheringModeGroupBox = new System.Windows.Forms.GroupBox();
      this.randomRadioButton = new System.Windows.Forms.RadioButton();
      this.line1 = new Cyotek.Windows.Forms.Line();
      this.atkinsonRadioButton = new System.Windows.Forms.RadioButton();
      this.sierraLiteRadioButton = new System.Windows.Forms.RadioButton();
      this.sierra2RadioButton = new System.Windows.Forms.RadioButton();
      this.sierra3RadioButton = new System.Windows.Forms.RadioButton();
      this.stuckiRadioButton = new System.Windows.Forms.RadioButton();
      this.jarvisJudiceNinkeDitheringradioButton = new System.Windows.Forms.RadioButton();
      this.burkesRadioButton = new System.Windows.Forms.RadioButton();
      this.noneRadioButton = new System.Windows.Forms.RadioButton();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.horizontalSplitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.saveAsToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.horizontalToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.refreshButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.rootSplitContainer)).BeginInit();
      this.rootSplitContainer.Panel1.SuspendLayout();
      this.rootSplitContainer.Panel2.SuspendLayout();
      this.rootSplitContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.previewSplitContainer)).BeginInit();
      this.previewSplitContainer.Panel1.SuspendLayout();
      this.previewSplitContainer.Panel2.SuspendLayout();
      this.previewSplitContainer.SuspendLayout();
      this.colorConversionGroupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).BeginInit();
      this.ditheringModeGroupBox.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // floydSteinbergRadioButton
      // 
      this.floydSteinbergRadioButton.AutoSize = true;
      this.floydSteinbergRadioButton.Location = new System.Drawing.Point(6, 42);
      this.floydSteinbergRadioButton.Name = "floydSteinbergRadioButton";
      this.floydSteinbergRadioButton.Size = new System.Drawing.Size(98, 17);
      this.floydSteinbergRadioButton.TabIndex = 1;
      this.floydSteinbergRadioButton.Text = "Floyd-&Steinberg";
      this.floydSteinbergRadioButton.UseVisualStyleBackColor = true;
      this.floydSteinbergRadioButton.CheckedChanged += new System.EventHandler(this.DitherCheckBoxCheckedChangedHandler);
      // 
      // rootSplitContainer
      // 
      this.rootSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rootSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.rootSplitContainer.Location = new System.Drawing.Point(0, 49);
      this.rootSplitContainer.Name = "rootSplitContainer";
      // 
      // rootSplitContainer.Panel1
      // 
      this.rootSplitContainer.Panel1.Controls.Add(this.previewSplitContainer);
      // 
      // rootSplitContainer.Panel2
      // 
      this.rootSplitContainer.Panel2.Controls.Add(this.colorConversionGroupBox);
      this.rootSplitContainer.Panel2.Controls.Add(this.ditheringModeGroupBox);
      this.rootSplitContainer.Size = new System.Drawing.Size(728, 461);
      this.rootSplitContainer.SplitterDistance = 528;
      this.rootSplitContainer.TabIndex = 2;
      // 
      // previewSplitContainer
      // 
      this.previewSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.previewSplitContainer.Location = new System.Drawing.Point(0, 0);
      this.previewSplitContainer.Name = "previewSplitContainer";
      this.previewSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // previewSplitContainer.Panel1
      // 
      this.previewSplitContainer.Panel1.Controls.Add(this.originalImageBox);
      // 
      // previewSplitContainer.Panel2
      // 
      this.previewSplitContainer.Panel2.Controls.Add(this.transformedImageBox);
      this.previewSplitContainer.Size = new System.Drawing.Size(528, 461);
      this.previewSplitContainer.SplitterDistance = 227;
      this.previewSplitContainer.TabIndex = 0;
      // 
      // originalImageBox
      // 
      this.originalImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.originalImageBox.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.originalImageBox.Location = new System.Drawing.Point(0, 0);
      this.originalImageBox.Name = "originalImageBox";
      this.originalImageBox.ShowPixelGrid = true;
      this.originalImageBox.Size = new System.Drawing.Size(528, 227);
      this.originalImageBox.TabIndex = 0;
      this.originalImageBox.Text = "Original";
      this.originalImageBox.TextAlign = System.Drawing.ContentAlignment.BottomRight;
      this.originalImageBox.TextBackColor = System.Drawing.SystemColors.Highlight;
      this.originalImageBox.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.originalImageBox.Zoomed += new System.EventHandler<Cyotek.Windows.Forms.ImageBoxZoomEventArgs>(this.originalImageBox_Zoomed);
      this.originalImageBox.Scroll += new System.Windows.Forms.ScrollEventHandler(this.originalImageBox_Scroll);
      // 
      // transformedImageBox
      // 
      this.transformedImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.transformedImageBox.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.transformedImageBox.Location = new System.Drawing.Point(0, 0);
      this.transformedImageBox.Name = "transformedImageBox";
      this.transformedImageBox.ShowPixelGrid = true;
      this.transformedImageBox.Size = new System.Drawing.Size(528, 230);
      this.transformedImageBox.TabIndex = 0;
      this.transformedImageBox.Text = "Transformed";
      this.transformedImageBox.TextAlign = System.Drawing.ContentAlignment.BottomRight;
      this.transformedImageBox.TextBackColor = System.Drawing.SystemColors.Highlight;
      this.transformedImageBox.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.transformedImageBox.Zoomed += new System.EventHandler<Cyotek.Windows.Forms.ImageBoxZoomEventArgs>(this.originalImageBox_Zoomed);
      this.transformedImageBox.Scroll += new System.Windows.Forms.ScrollEventHandler(this.originalImageBox_Scroll);
      // 
      // colorConversionGroupBox
      // 
      this.colorConversionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.colorConversionGroupBox.Controls.Add(this.thresholdNumericUpDown);
      this.colorConversionGroupBox.Controls.Add(this.label1);
      this.colorConversionGroupBox.Location = new System.Drawing.Point(3, 3);
      this.colorConversionGroupBox.Name = "colorConversionGroupBox";
      this.colorConversionGroupBox.Size = new System.Drawing.Size(190, 74);
      this.colorConversionGroupBox.TabIndex = 0;
      this.colorConversionGroupBox.TabStop = false;
      this.colorConversionGroupBox.Text = "Color Conversion";
      // 
      // thresholdNumericUpDown
      // 
      this.thresholdNumericUpDown.Location = new System.Drawing.Point(6, 37);
      this.thresholdNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.thresholdNumericUpDown.Name = "thresholdNumericUpDown";
      this.thresholdNumericUpDown.Size = new System.Drawing.Size(58, 20);
      this.thresholdNumericUpDown.TabIndex = 1;
      this.thresholdNumericUpDown.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
      this.thresholdNumericUpDown.ValueChanged += new System.EventHandler(this.thresholdNumericUpDown_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(132, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Black and white &threshold:";
      // 
      // ditheringModeGroupBox
      // 
      this.ditheringModeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ditheringModeGroupBox.Controls.Add(this.refreshButton);
      this.ditheringModeGroupBox.Controls.Add(this.randomRadioButton);
      this.ditheringModeGroupBox.Controls.Add(this.line1);
      this.ditheringModeGroupBox.Controls.Add(this.atkinsonRadioButton);
      this.ditheringModeGroupBox.Controls.Add(this.sierraLiteRadioButton);
      this.ditheringModeGroupBox.Controls.Add(this.sierra2RadioButton);
      this.ditheringModeGroupBox.Controls.Add(this.sierra3RadioButton);
      this.ditheringModeGroupBox.Controls.Add(this.stuckiRadioButton);
      this.ditheringModeGroupBox.Controls.Add(this.jarvisJudiceNinkeDitheringradioButton);
      this.ditheringModeGroupBox.Controls.Add(this.burkesRadioButton);
      this.ditheringModeGroupBox.Controls.Add(this.noneRadioButton);
      this.ditheringModeGroupBox.Controls.Add(this.floydSteinbergRadioButton);
      this.ditheringModeGroupBox.Location = new System.Drawing.Point(3, 83);
      this.ditheringModeGroupBox.Name = "ditheringModeGroupBox";
      this.ditheringModeGroupBox.Size = new System.Drawing.Size(190, 375);
      this.ditheringModeGroupBox.TabIndex = 1;
      this.ditheringModeGroupBox.TabStop = false;
      this.ditheringModeGroupBox.Text = "Dithering Algorithm";
      // 
      // randomRadioButton
      // 
      this.randomRadioButton.AutoSize = true;
      this.randomRadioButton.Location = new System.Drawing.Point(6, 234);
      this.randomRadioButton.Name = "randomRadioButton";
      this.randomRadioButton.Size = new System.Drawing.Size(65, 17);
      this.randomRadioButton.TabIndex = 10;
      this.randomRadioButton.Text = "Rando&m";
      this.randomRadioButton.UseVisualStyleBackColor = true;
      this.randomRadioButton.CheckedChanged += new System.EventHandler(this.DitherCheckBoxCheckedChangedHandler);
      // 
      // line1
      // 
      this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.line1.Location = new System.Drawing.Point(6, 226);
      this.line1.Name = "line1";
      this.line1.Size = new System.Drawing.Size(175, 2);
      this.line1.TabIndex = 9;
      this.line1.Text = "line1";
      // 
      // atkinsonRadioButton
      // 
      this.atkinsonRadioButton.AutoSize = true;
      this.atkinsonRadioButton.Location = new System.Drawing.Point(6, 203);
      this.atkinsonRadioButton.Name = "atkinsonRadioButton";
      this.atkinsonRadioButton.Size = new System.Drawing.Size(66, 17);
      this.atkinsonRadioButton.TabIndex = 8;
      this.atkinsonRadioButton.Text = "&Atkinson";
      this.atkinsonRadioButton.UseVisualStyleBackColor = true;
      this.atkinsonRadioButton.CheckedChanged += new System.EventHandler(this.DitherCheckBoxCheckedChangedHandler);
      // 
      // sierraLiteRadioButton
      // 
      this.sierraLiteRadioButton.AutoSize = true;
      this.sierraLiteRadioButton.Location = new System.Drawing.Point(6, 180);
      this.sierraLiteRadioButton.Name = "sierraLiteRadioButton";
      this.sierraLiteRadioButton.Size = new System.Drawing.Size(72, 17);
      this.sierraLiteRadioButton.TabIndex = 7;
      this.sierraLiteRadioButton.Text = "Sierra &Lite";
      this.sierraLiteRadioButton.UseVisualStyleBackColor = true;
      this.sierraLiteRadioButton.CheckedChanged += new System.EventHandler(this.DitherCheckBoxCheckedChangedHandler);
      // 
      // sierra2RadioButton
      // 
      this.sierra2RadioButton.AutoSize = true;
      this.sierra2RadioButton.Location = new System.Drawing.Point(6, 157);
      this.sierra2RadioButton.Name = "sierra2RadioButton";
      this.sierra2RadioButton.Size = new System.Drawing.Size(101, 17);
      this.sierra2RadioButton.TabIndex = 6;
      this.sierra2RadioButton.Text = "&Two Row Sierra";
      this.sierra2RadioButton.UseVisualStyleBackColor = true;
      this.sierra2RadioButton.CheckedChanged += new System.EventHandler(this.DitherCheckBoxCheckedChangedHandler);
      // 
      // sierra3RadioButton
      // 
      this.sierra3RadioButton.AutoSize = true;
      this.sierra3RadioButton.Location = new System.Drawing.Point(6, 134);
      this.sierra3RadioButton.Name = "sierra3RadioButton";
      this.sierra3RadioButton.Size = new System.Drawing.Size(52, 17);
      this.sierra3RadioButton.TabIndex = 5;
      this.sierra3RadioButton.Text = "S&ierra";
      this.sierra3RadioButton.UseVisualStyleBackColor = true;
      this.sierra3RadioButton.CheckedChanged += new System.EventHandler(this.DitherCheckBoxCheckedChangedHandler);
      // 
      // stuckiRadioButton
      // 
      this.stuckiRadioButton.AutoSize = true;
      this.stuckiRadioButton.Location = new System.Drawing.Point(6, 111);
      this.stuckiRadioButton.Name = "stuckiRadioButton";
      this.stuckiRadioButton.Size = new System.Drawing.Size(55, 17);
      this.stuckiRadioButton.TabIndex = 4;
      this.stuckiRadioButton.Text = "St&ucki";
      this.stuckiRadioButton.UseVisualStyleBackColor = true;
      this.stuckiRadioButton.CheckedChanged += new System.EventHandler(this.DitherCheckBoxCheckedChangedHandler);
      // 
      // jarvisJudiceNinkeDitheringradioButton
      // 
      this.jarvisJudiceNinkeDitheringradioButton.AutoSize = true;
      this.jarvisJudiceNinkeDitheringradioButton.Location = new System.Drawing.Point(6, 88);
      this.jarvisJudiceNinkeDitheringradioButton.Name = "jarvisJudiceNinkeDitheringradioButton";
      this.jarvisJudiceNinkeDitheringradioButton.Size = new System.Drawing.Size(129, 17);
      this.jarvisJudiceNinkeDitheringradioButton.TabIndex = 3;
      this.jarvisJudiceNinkeDitheringradioButton.Text = "&Jarvis, Judice && Ninke";
      this.jarvisJudiceNinkeDitheringradioButton.UseVisualStyleBackColor = true;
      this.jarvisJudiceNinkeDitheringradioButton.CheckedChanged += new System.EventHandler(this.DitherCheckBoxCheckedChangedHandler);
      // 
      // burkesRadioButton
      // 
      this.burkesRadioButton.AutoSize = true;
      this.burkesRadioButton.Location = new System.Drawing.Point(6, 65);
      this.burkesRadioButton.Name = "burkesRadioButton";
      this.burkesRadioButton.Size = new System.Drawing.Size(58, 17);
      this.burkesRadioButton.TabIndex = 2;
      this.burkesRadioButton.Text = "&Burkes";
      this.burkesRadioButton.UseVisualStyleBackColor = true;
      this.burkesRadioButton.CheckedChanged += new System.EventHandler(this.DitherCheckBoxCheckedChangedHandler);
      // 
      // noneRadioButton
      // 
      this.noneRadioButton.AutoSize = true;
      this.noneRadioButton.Checked = true;
      this.noneRadioButton.Location = new System.Drawing.Point(6, 19);
      this.noneRadioButton.Name = "noneRadioButton";
      this.noneRadioButton.Size = new System.Drawing.Size(51, 17);
      this.noneRadioButton.TabIndex = 0;
      this.noneRadioButton.TabStop = true;
      this.noneRadioButton.Text = "&None";
      this.noneRadioButton.UseVisualStyleBackColor = true;
      this.noneRadioButton.CheckedChanged += new System.EventHandler(this.DitherCheckBoxCheckedChangedHandler);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(728, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Image = global::Cyotek.DitheringTest.Properties.Resources.Open;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.openToolStripMenuItem.Text = "&Open...";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // saveAsToolStripMenuItem
      // 
      this.saveAsToolStripMenuItem.Image = global::Cyotek.DitheringTest.Properties.Resources.Save;
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.saveAsToolStripMenuItem.Text = "Save &As...";
      this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "&Edit";
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.Image = global::Cyotek.DitheringTest.Properties.Resources.Paste;
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.pasteToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.pasteToolStripMenuItem.Text = "&Paste";
      this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalSplitToolStripMenuItem});
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.viewToolStripMenuItem.Text = "&View";
      // 
      // horizontalSplitToolStripMenuItem
      // 
      this.horizontalSplitToolStripMenuItem.Checked = true;
      this.horizontalSplitToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.horizontalSplitToolStripMenuItem.Image = global::Cyotek.DitheringTest.Properties.Resources.HorizontalSplit;
      this.horizontalSplitToolStripMenuItem.Name = "horizontalSplitToolStripMenuItem";
      this.horizontalSplitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.horizontalSplitToolStripMenuItem.Text = "&Horizontal Split";
      this.horizontalSplitToolStripMenuItem.Click += new System.EventHandler(this.horizontalSplitToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.aboutToolStripMenuItem.Text = "&About...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveAsToolStripButton,
            this.toolStripSeparator1,
            this.pasteToolStripButton,
            this.toolStripSeparator2,
            this.horizontalToolStripButton});
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(728, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // openToolStripButton
      // 
      this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.openToolStripButton.Image = global::Cyotek.DitheringTest.Properties.Resources.Open;
      this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripButton.Name = "openToolStripButton";
      this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.openToolStripButton.Text = "Open";
      this.openToolStripButton.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // saveAsToolStripButton
      // 
      this.saveAsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.saveAsToolStripButton.Image = global::Cyotek.DitheringTest.Properties.Resources.Save;
      this.saveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveAsToolStripButton.Name = "saveAsToolStripButton";
      this.saveAsToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.saveAsToolStripButton.Text = "Save As";
      this.saveAsToolStripButton.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // pasteToolStripButton
      // 
      this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.pasteToolStripButton.Image = global::Cyotek.DitheringTest.Properties.Resources.Paste;
      this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pasteToolStripButton.Name = "pasteToolStripButton";
      this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.pasteToolStripButton.Text = "Paste";
      this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // horizontalToolStripButton
      // 
      this.horizontalToolStripButton.Checked = true;
      this.horizontalToolStripButton.CheckState = System.Windows.Forms.CheckState.Checked;
      this.horizontalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.horizontalToolStripButton.Image = global::Cyotek.DitheringTest.Properties.Resources.HorizontalSplit;
      this.horizontalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.horizontalToolStripButton.Name = "horizontalToolStripButton";
      this.horizontalToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.horizontalToolStripButton.Text = "Horizontal";
      this.horizontalToolStripButton.Click += new System.EventHandler(this.horizontalSplitToolStripMenuItem_Click);
      // 
      // refreshButton
      // 
      this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.refreshButton.Location = new System.Drawing.Point(106, 231);
      this.refreshButton.Name = "refreshButton";
      this.refreshButton.Size = new System.Drawing.Size(75, 23);
      this.refreshButton.TabIndex = 11;
      this.refreshButton.Text = "&Refresh";
      this.refreshButton.UseVisualStyleBackColor = true;
      this.refreshButton.Click += new System.EventHandler(this.DitherCheckBoxCheckedChangedHandler);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(728, 510);
      this.Controls.Add(this.rootSplitContainer);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "Dithering Example";
      this.rootSplitContainer.Panel1.ResumeLayout(false);
      this.rootSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.rootSplitContainer)).EndInit();
      this.rootSplitContainer.ResumeLayout(false);
      this.previewSplitContainer.Panel1.ResumeLayout(false);
      this.previewSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.previewSplitContainer)).EndInit();
      this.previewSplitContainer.ResumeLayout(false);
      this.colorConversionGroupBox.ResumeLayout(false);
      this.colorConversionGroupBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).EndInit();
      this.ditheringModeGroupBox.ResumeLayout(false);
      this.ditheringModeGroupBox.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RadioButton floydSteinbergRadioButton;
    private System.Windows.Forms.SplitContainer rootSplitContainer;
    private System.Windows.Forms.SplitContainer previewSplitContainer;
    private Cyotek.Windows.Forms.ImageBox originalImageBox;
    private Cyotek.Windows.Forms.ImageBox transformedImageBox;
    private System.Windows.Forms.RadioButton noneRadioButton;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton openToolStripButton;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton saveAsToolStripButton;
    private System.Windows.Forms.GroupBox ditheringModeGroupBox;
    private System.Windows.Forms.RadioButton burkesRadioButton;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton pasteToolStripButton;
    private System.Windows.Forms.ToolStripButton horizontalToolStripButton;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem horizontalSplitToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.GroupBox colorConversionGroupBox;
    private System.Windows.Forms.NumericUpDown thresholdNumericUpDown;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RadioButton jarvisJudiceNinkeDitheringradioButton;
    private System.Windows.Forms.RadioButton stuckiRadioButton;
    private System.Windows.Forms.RadioButton sierra3RadioButton;
    private System.Windows.Forms.RadioButton sierra2RadioButton;
    private System.Windows.Forms.RadioButton sierraLiteRadioButton;
    private System.Windows.Forms.RadioButton atkinsonRadioButton;
    private System.Windows.Forms.RadioButton randomRadioButton;
    private Windows.Forms.Line line1;
    private System.Windows.Forms.Button refreshButton;
  }
}

