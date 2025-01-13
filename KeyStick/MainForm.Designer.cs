
namespace KeyStick
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.minimizeOnKeydownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.restoreOnKeyupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpfulReleasesParadisusisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.timeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.timeValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.refreshButton = new System.Windows.Forms.Button();
			this.targetLabel = new System.Windows.Forms.Label();
			this.targetListView = new System.Windows.Forms.ListView();
			this.windowColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.controlCheckBox = new System.Windows.Forms.CheckBox();
			this.altCheckBox = new System.Windows.Forms.CheckBox();
			this.shiftCheckBox = new System.Windows.Forms.CheckBox();
			this.hotkeyComboBox = new System.Windows.Forms.ComboBox();
			this.keyLabel = new System.Windows.Forms.Label();
			this.keyComboBox = new System.Windows.Forms.ComboBox();
			this.keyPressCheckBox = new System.Windows.Forms.CheckBox();
			this.keyPressTimer = new System.Windows.Forms.Timer(this.components);
			this.mainMenuStrip.SuspendLayout();
			this.mainStatusStrip.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.optionsToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(254, 24);
			this.mainMenuStrip.TabIndex = 45;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.toolStripSeparator,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Visible = false;
			this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(138, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.alwaysOnTopToolStripMenuItem,
									this.minimizeOnKeydownToolStripMenuItem,
									this.restoreOnKeyupToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "&Options";
			this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
			// 
			// alwaysOnTopToolStripMenuItem
			// 
			this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
			this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
			// 
			// minimizeOnKeydownToolStripMenuItem
			// 
			this.minimizeOnKeydownToolStripMenuItem.Name = "minimizeOnKeydownToolStripMenuItem";
			this.minimizeOnKeydownToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.minimizeOnKeydownToolStripMenuItem.Text = "&Minimize on key_down";
			this.minimizeOnKeydownToolStripMenuItem.Visible = false;
			// 
			// restoreOnKeyupToolStripMenuItem
			// 
			this.restoreOnKeyupToolStripMenuItem.Name = "restoreOnKeyupToolStripMenuItem";
			this.restoreOnKeyupToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.restoreOnKeyupToolStripMenuItem.Text = "&Restore on key_up";
			this.restoreOnKeyupToolStripMenuItem.Visible = false;
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.helpfulReleasesParadisusisToolStripMenuItem,
									this.originalThreadDonationCodercomToolStripMenuItem,
									this.sourceCodeGithubcomToolStripMenuItem,
									this.toolStripSeparator2,
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// helpfulReleasesParadisusisToolStripMenuItem
			// 
			this.helpfulReleasesParadisusisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpfulReleasesParadisusisToolStripMenuItem.Image")));
			this.helpfulReleasesParadisusisToolStripMenuItem.Name = "helpfulReleasesParadisusisToolStripMenuItem";
			this.helpfulReleasesParadisusisToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.helpfulReleasesParadisusisToolStripMenuItem.Text = "Helpful releases @ Paradisus.io";
			this.helpfulReleasesParadisusisToolStripMenuItem.Click += new System.EventHandler(this.OnHelpfulReleasesParadisusioToolStripMenuItemClick);
			// 
			// originalThreadDonationCodercomToolStripMenuItem
			// 
			this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
			this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
			this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
			this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
			// 
			// sourceCodeGithubcomToolStripMenuItem
			// 
			this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
			this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
			this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.sourceCodeGithubcomToolStripMenuItem.Text = "&Source code @ Github.com";
			this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.timeToolStripStatusLabel,
									this.timeValueToolStripStatusLabel});
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 368);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Size = new System.Drawing.Size(254, 22);
			this.mainStatusStrip.SizingGrip = false;
			this.mainStatusStrip.TabIndex = 44;
			this.mainStatusStrip.Visible = false;
			// 
			// timeToolStripStatusLabel
			// 
			this.timeToolStripStatusLabel.Name = "timeToolStripStatusLabel";
			this.timeToolStripStatusLabel.Size = new System.Drawing.Size(37, 17);
			this.timeToolStripStatusLabel.Text = "Time:";
			this.timeToolStripStatusLabel.Visible = false;
			// 
			// timeValueToolStripStatusLabel
			// 
			this.timeValueToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.timeValueToolStripStatusLabel.Name = "timeValueToolStripStatusLabel";
			this.timeValueToolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
			this.timeValueToolStripStatusLabel.Text = "00:00";
			this.timeValueToolStripStatusLabel.Visible = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.refreshButton, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.targetLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.targetListView, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.keyLabel, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.keyComboBox, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.keyPressCheckBox, 0, 5);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 366);
			this.tableLayoutPanel1.TabIndex = 46;
			// 
			// refreshButton
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.refreshButton, 2);
			this.refreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refreshButton.Location = new System.Drawing.Point(3, 239);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(248, 29);
			this.refreshButton.TabIndex = 2;
			this.refreshButton.Text = "&Refresh";
			this.refreshButton.UseVisualStyleBackColor = true;
			this.refreshButton.Click += new System.EventHandler(this.OnRefreshButtonClick);
			// 
			// targetLabel
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.targetLabel, 2);
			this.targetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.targetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.targetLabel.Location = new System.Drawing.Point(3, 0);
			this.targetLabel.Name = "targetLabel";
			this.targetLabel.Size = new System.Drawing.Size(248, 35);
			this.targetLabel.TabIndex = 0;
			this.targetLabel.Text = "&Window:";
			this.targetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// targetListView
			// 
			this.targetListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.windowColumnHeader});
			this.tableLayoutPanel1.SetColumnSpan(this.targetListView, 2);
			this.targetListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.targetListView.Location = new System.Drawing.Point(3, 38);
			this.targetListView.MultiSelect = false;
			this.targetListView.Name = "targetListView";
			this.targetListView.Size = new System.Drawing.Size(248, 195);
			this.targetListView.TabIndex = 10;
			this.targetListView.UseCompatibleStateImageBehavior = false;
			this.targetListView.View = System.Windows.Forms.View.Details;
			this.targetListView.SelectedIndexChanged += new System.EventHandler(this.OnTargetListViewSelectedIndexChanged);
			// 
			// windowColumnHeader
			// 
			this.windowColumnHeader.Text = "Title";
			this.windowColumnHeader.Width = 100;
			// 
			// panel1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
			this.panel1.Controls.Add(this.tableLayoutPanel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 271);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(254, 30);
			this.panel1.TabIndex = 11;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.Controls.Add(this.controlCheckBox, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.altCheckBox, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.shiftCheckBox, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.hotkeyComboBox, 3, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(254, 30);
			this.tableLayoutPanel2.TabIndex = 4;
			// 
			// controlCheckBox
			// 
			this.controlCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.controlCheckBox.Location = new System.Drawing.Point(3, 5);
			this.controlCheckBox.Name = "controlCheckBox";
			this.controlCheckBox.Size = new System.Drawing.Size(57, 19);
			this.controlCheckBox.TabIndex = 1;
			this.controlCheckBox.Text = "&CTRL";
			this.controlCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.controlCheckBox.UseVisualStyleBackColor = true;
			this.controlCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
			// 
			// altCheckBox
			// 
			this.altCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.altCheckBox.Location = new System.Drawing.Point(66, 5);
			this.altCheckBox.Name = "altCheckBox";
			this.altCheckBox.Size = new System.Drawing.Size(57, 19);
			this.altCheckBox.TabIndex = 2;
			this.altCheckBox.Text = "&ALT";
			this.altCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.altCheckBox.UseVisualStyleBackColor = true;
			this.altCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
			// 
			// shiftCheckBox
			// 
			this.shiftCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.shiftCheckBox.Location = new System.Drawing.Point(129, 5);
			this.shiftCheckBox.Name = "shiftCheckBox";
			this.shiftCheckBox.Size = new System.Drawing.Size(57, 19);
			this.shiftCheckBox.TabIndex = 3;
			this.shiftCheckBox.Text = "&SHIFT";
			this.shiftCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.shiftCheckBox.UseVisualStyleBackColor = true;
			this.shiftCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
			// 
			// hotkeyComboBox
			// 
			this.hotkeyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.hotkeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.hotkeyComboBox.FormattingEnabled = true;
			this.hotkeyComboBox.Location = new System.Drawing.Point(192, 4);
			this.hotkeyComboBox.Name = "hotkeyComboBox";
			this.hotkeyComboBox.Size = new System.Drawing.Size(59, 21);
			this.hotkeyComboBox.TabIndex = 4;
			this.hotkeyComboBox.SelectedIndexChanged += new System.EventHandler(this.OnHotkeyComboBoxSelectedIndexChanged);
			// 
			// keyLabel
			// 
			this.keyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.keyLabel.Location = new System.Drawing.Point(3, 301);
			this.keyLabel.Name = "keyLabel";
			this.keyLabel.Size = new System.Drawing.Size(121, 30);
			this.keyLabel.TabIndex = 14;
			this.keyLabel.Text = "Key:";
			this.keyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// keyComboBox
			// 
			this.keyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.keyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.keyComboBox.FormattingEnabled = true;
			this.keyComboBox.Location = new System.Drawing.Point(130, 305);
			this.keyComboBox.Name = "keyComboBox";
			this.keyComboBox.Size = new System.Drawing.Size(121, 21);
			this.keyComboBox.TabIndex = 15;
			this.keyComboBox.SelectedIndexChanged += new System.EventHandler(this.OnKeyComboBoxSelectedIndexChanged);
			// 
			// keyPressCheckBox
			// 
			this.keyPressCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.keyPressCheckBox.AutoCheck = false;
			this.tableLayoutPanel1.SetColumnSpan(this.keyPressCheckBox, 2);
			this.keyPressCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.keyPressCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.keyPressCheckBox.Location = new System.Drawing.Point(3, 334);
			this.keyPressCheckBox.Name = "keyPressCheckBox";
			this.keyPressCheckBox.Size = new System.Drawing.Size(248, 29);
			this.keyPressCheckBox.TabIndex = 16;
			this.keyPressCheckBox.Text = "&Press key";
			this.keyPressCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.keyPressCheckBox.UseVisualStyleBackColor = true;
			this.keyPressCheckBox.Click += new System.EventHandler(this.OnKeyPressCheckBoxClick);
			// 
			// keyPressTimer
			// 
			this.keyPressTimer.Tick += new System.EventHandler(this.OnKeyPressTimerTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(254, 390);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.mainMenuStrip);
			this.Controls.Add(this.mainStatusStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "KeyStick";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormFormClosing);
			this.Load += new System.EventHandler(this.OnMainFormLoad);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.mainStatusStrip.ResumeLayout(false);
			this.mainStatusStrip.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem restoreOnKeyupToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem minimizeOnKeydownToolStripMenuItem;
		private System.Windows.Forms.Timer keyPressTimer;
		private System.Windows.Forms.ToolStripMenuItem helpfulReleasesParadisusisToolStripMenuItem;
		private System.Windows.Forms.CheckBox keyPressCheckBox;
		private System.Windows.Forms.ComboBox hotkeyComboBox;
		private System.Windows.Forms.CheckBox shiftCheckBox;
		private System.Windows.Forms.CheckBox altCheckBox;
		private System.Windows.Forms.CheckBox controlCheckBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ColumnHeader windowColumnHeader;
		private System.Windows.Forms.ListView targetListView;
		private System.Windows.Forms.Label targetLabel;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.ComboBox keyComboBox;
		private System.Windows.Forms.Label keyLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ToolStripStatusLabel timeValueToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel timeToolStripStatusLabel;
		private System.Windows.Forms.StatusStrip mainStatusStrip;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
	}
}
