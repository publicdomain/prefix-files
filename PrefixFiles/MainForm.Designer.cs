
namespace PrefixFiles
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
            if (disposing)
            {
                if (components != null)
                {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countsubfoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.foldersTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.foldersToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addOneLabel = new System.Windows.Forms.Label();
            this.browseForFolderButton = new System.Windows.Forms.Button();
            this.dropFoldersListLabel = new System.Windows.Forms.Label();
            this.foldersListBox = new System.Windows.Forms.ListBox();
            this.prefixFilesButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
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
            this.mainMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.mainMenuStrip.TabIndex = 57;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.newToolStripMenuItem,
                                    this.toolStripSeparator3,
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
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
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
                                    this.countsubfoldersToolStripMenuItem,
                                    this.recursiveToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
            // 
            // countsubfoldersToolStripMenuItem
            // 
            this.countsubfoldersToolStripMenuItem.Name = "countsubfoldersToolStripMenuItem";
            this.countsubfoldersToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.countsubfoldersToolStripMenuItem.Text = "Count &subfolders";
            // 
            // recursiveToolStripMenuItem
            // 
            this.recursiveToolStripMenuItem.Name = "recursiveToolStripMenuItem";
            this.recursiveToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.recursiveToolStripMenuItem.Text = "&Recursive";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.freeReleasesPublicDomainisToolStripMenuItem,
                                    this.originalThreadDonationCodercomToolStripMenuItem,
                                    this.sourceCodeGithubcomToolStripMenuItem,
                                    this.toolStripSeparator2,
                                    this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // freeReleasesPublicDomainisToolStripMenuItem
            // 
            this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
            this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.freeReleasesPublicDomainisToolStripMenuItem.Text = "&Free Releases @ PublicDomain.is";
            this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
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
                                    this.foldersTextToolStripStatusLabel,
                                    this.foldersToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 290);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(284, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 56;
            // 
            // foldersTextToolStripStatusLabel
            // 
            this.foldersTextToolStripStatusLabel.Name = "foldersTextToolStripStatusLabel";
            this.foldersTextToolStripStatusLabel.Size = new System.Drawing.Size(48, 17);
            this.foldersTextToolStripStatusLabel.Text = "Folders:";
            // 
            // foldersToolStripStatusLabel
            // 
            this.foldersToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.foldersToolStripStatusLabel.Name = "foldersToolStripStatusLabel";
            this.foldersToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.foldersToolStripStatusLabel.Text = "0";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.addOneLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.browseForFolderButton, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.dropFoldersListLabel, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.foldersListBox, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.prefixFilesButton, 0, 4);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 5;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(284, 266);
            this.mainTableLayoutPanel.TabIndex = 58;
            // 
            // addOneLabel
            // 
            this.addOneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOneLabel.Location = new System.Drawing.Point(3, 0);
            this.addOneLabel.Name = "addOneLabel";
            this.addOneLabel.Size = new System.Drawing.Size(278, 25);
            this.addOneLabel.TabIndex = 0;
            this.addOneLabel.Text = "&Add one:";
            this.addOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // browseForFolderButton
            // 
            this.browseForFolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseForFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseForFolderButton.Location = new System.Drawing.Point(3, 28);
            this.browseForFolderButton.Name = "browseForFolderButton";
            this.browseForFolderButton.Size = new System.Drawing.Size(278, 29);
            this.browseForFolderButton.TabIndex = 1;
            this.browseForFolderButton.Text = "&Browse for folder";
            this.browseForFolderButton.UseVisualStyleBackColor = true;
            this.browseForFolderButton.Click += new System.EventHandler(this.OnBrowseForFolderButtonClick);
            // 
            // dropFoldersListLabel
            // 
            this.dropFoldersListLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropFoldersListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropFoldersListLabel.Location = new System.Drawing.Point(3, 60);
            this.dropFoldersListLabel.Name = "dropFoldersListLabel";
            this.dropFoldersListLabel.Size = new System.Drawing.Size(278, 25);
            this.dropFoldersListLabel.TabIndex = 2;
            this.dropFoldersListLabel.Text = "&Drop folders list:";
            this.dropFoldersListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foldersListBox
            // 
            this.foldersListBox.AllowDrop = true;
            this.foldersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foldersListBox.FormattingEnabled = true;
            this.foldersListBox.Location = new System.Drawing.Point(3, 88);
            this.foldersListBox.Name = "foldersListBox";
            this.foldersListBox.Size = new System.Drawing.Size(278, 140);
            this.foldersListBox.TabIndex = 3;
            this.foldersListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnFoldersListBoxDragDrop);
            this.foldersListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnFoldersListBoxDragEnter);
            // 
            // prefixFilesButton
            // 
            this.prefixFilesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prefixFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefixFilesButton.Location = new System.Drawing.Point(3, 234);
            this.prefixFilesButton.Name = "prefixFilesButton";
            this.prefixFilesButton.Size = new System.Drawing.Size(278, 29);
            this.prefixFilesButton.TabIndex = 4;
            this.prefixFilesButton.Text = "&Prefix files";
            this.prefixFilesButton.UseVisualStyleBackColor = true;
            this.prefixFilesButton.Click += new System.EventHandler(this.OnPrefixFilesButtonClick);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select folder to prefix";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.mainStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prefix Files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormFormClosing);
            this.Load += new System.EventHandler(this.OnMainFormLoad);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button prefixFilesButton;
        private System.Windows.Forms.ListBox foldersListBox;
        private System.Windows.Forms.Label dropFoldersListLabel;
        private System.Windows.Forms.Button browseForFolderButton;
        private System.Windows.Forms.Label addOneLabel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem recursiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countsubfoldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel foldersToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel foldersTextToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}
