// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace PrefixFiles
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Windows.Forms;
    using System.Xml.Serialization;
    using PublicDomain;

    /// <summary>
    /// Main form.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// The settings data.
        /// </summary>
        private SettingsData settingsData = null;

        /// <summary>
        /// The settings data path.
        /// </summary>
        private string settingsDataPath = $"{Application.ProductName}-SettingsData.txt";

        /// <summary>
        /// Initializes a new instance of the <see cref="T:PrefixFiles.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Set icons */

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set PublicDomain.is tool strip menu item image
            this.freeReleasesPublicDomainisToolStripMenuItem.Image = this.associatedIcon.ToBitmap();

            /* Settings data */

            // Check for settings file
            if (!File.Exists(this.settingsDataPath))
            {
                // Create new settings file
                this.SaveSettingsFile(this.settingsDataPath, new SettingsData());
            }

            // Load settings from disk
            this.settingsData = this.LoadSettingsFile(this.settingsDataPath);
        }

        /// <summary>
        /// Handles the main form load.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormLoad(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the main form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // New checked options list
            List<string> checkedOptionsList = new List<string>();

            // Set checked options list
            foreach (ToolStripMenuItem toolStripMenuItem in this.optionsToolStripMenuItem.DropDownItems)
            {
                // Check if checked
                if (toolStripMenuItem.Checked)
                {
                    // Add to checked options list
                    checkedOptionsList.Add(toolStripMenuItem.Name);
                }
            }

            // Set into settings data
            this.settingsData.CheckedOptionsList = checkedOptionsList;

            // Save settings data to disk
            this.SaveSettingsFile(this.settingsDataPath, this.settingsData);
        }

        /// <summary>
        /// Handles the folders list box drag drop.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFoldersListBoxDragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                foreach (var possibleDirectory in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    // TODO Check for directory [May eb done via FileInfo]
                    if (Directory.Exists(possibleDirectory))
                    {
                        this.foldersListBox.Items.Add(possibleDirectory);
                    }
                }

                // Update current folder count
                this.foldersToolStripStatusLabel.Text = this.foldersListBox.Items.Count.ToString();
            }
        }

        /// <summary>
        /// Handles the folders list box drag enter.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFoldersListBoxDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Clear list
            this.foldersListBox.Items.Clear();

            // Update current folder count
            this.foldersToolStripStatusLabel.Text = this.foldersListBox.Items.Count.ToString();
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our site
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=47777");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/prefix-files");
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the browse for folder button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnBrowseForFolderButtonClick(object sender, EventArgs e)
        {
            // Reset selected path
            this.folderBrowserDialog.SelectedPath = string.Empty;

            // Show folder browser dialog
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
            {
                // Add folder
                this.foldersListBox.Items.Add(this.folderBrowserDialog.SelectedPath);
            }

            // Update current folder count
            this.foldersToolStripStatusLabel.Text = this.foldersListBox.Items.Count.ToString();
        }

        /// <summary>
        /// Handles the prefix files button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnPrefixFilesButtonClick(object sender, EventArgs e)
        {
            // Exception flag
            bool hasException = false;

            // Iterate directories in list
            foreach (string directory in this.foldersListBox.Items)
            {
                try
                {
                    // Check if must rename subdirectories
                    if (this.prefixSubfoldersToolStripMenuItem.Checked)
                    {
                        // Rename subdirectories
                        RenameSubdirectories(directory);
                    }

                    // Rename current directory
                    this.RenameDirectory(directory);
                }
                catch (Exception ex)
                {
                    // Toggle exception flag
                    hasException = true;

                    // Write to error file
                    File.AppendAllText("PrefixFiles-ErrorLog.txt", $"{Environment.NewLine}{Environment.NewLine}-----{Environment.NewLine}{ex.Message}");
                }
            }

            // Clear list
            this.foldersListBox.Items.Clear();

            // Update current folder count
            this.foldersToolStripStatusLabel.Text = this.foldersListBox.Items.Count.ToString();

            // Advise user
            MessageBox.Show($"Files prefixed to directory names. {(hasException ? $"{Environment.NewLine}{Environment.NewLine}Please check \"PrefixFiles-ErrorLog.txt\" file." : "")}", "Prefix files", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Renames the directory.
        /// </summary>
        /// <param name="directoryPath">Directory path.</param>
        private void RenameDirectory(string directoryPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            int fileCount = Directory.EnumerateFiles(directoryPath, "*", this.addFilesInSubfoldersToolStripMenuItem.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).Count();

            string strFoldername = Path.Combine(Directory.GetParent(directoryPath).FullName, fileCount.ToString() + " " + Path.GetFileName(directoryPath.TrimEnd(Path.DirectorySeparatorChar)));

            directoryInfo.MoveTo(strFoldername);
        }

        /// <summary>
        /// Renames the subdirectories.
        /// </summary>
        /// <param name="directoryPath">Directory path.</param>
        private void RenameSubdirectories(string directoryPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            foreach (DirectoryInfo subdirectoryInfo in directoryInfo.GetDirectories("*", SearchOption.TopDirectoryOnly))
            {
                string subdirectoryFullPath = Path.Combine(subdirectoryInfo.Parent.FullName, subdirectoryInfo.Name);

                RenameSubdirectories(subdirectoryFullPath);

                int fileCount = Directory.EnumerateFiles(subdirectoryFullPath, "*", this.addFilesInSubfoldersToolStripMenuItem.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).Count();

                string strFoldername = Path.Combine(Directory.GetParent(subdirectoryFullPath).FullName, fileCount.ToString() + " " + Path.GetFileName(subdirectoryFullPath.TrimEnd(Path.DirectorySeparatorChar)));

                subdirectoryInfo.MoveTo(strFoldername);
            }
        }

        /// <summary>
        /// Handles the remove tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRemoveToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Prevent drawing
            this.foldersListBox.BeginUpdate();

            // TODO Remove all selected items in list box [Can be made differently]
            while (this.foldersListBox.SelectedItems.Count > 0)
            {
                // Remove item
                this.foldersListBox.Items.Remove(this.foldersListBox.SelectedItems[0]);
            }

            // Resume drawing
            this.foldersListBox.EndUpdate();

            // Update current folder count
            this.foldersToolStripStatusLabel.Text = this.foldersListBox.Items.Count.ToString();
        }

        /// <summary>
        /// Handles the folders list box key down.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFoldersListBoxKeyDown(object sender, KeyEventArgs e)
        {
            // Check for delete
            if (e.KeyData == Keys.Delete)
            {
                // Trigger removal
                this.removeToolStripMenuItem.PerformClick();
            }
        }

        /// <summary>
        /// Loads the settings file.
        /// </summary>
        /// <returns>The settings file.</returns>
        /// <param name="settingsFilePath">Settings file path.</param>
        private SettingsData LoadSettingsFile(string settingsFilePath)
        {
            // Use file stream
            using (FileStream fileStream = File.OpenRead(settingsFilePath))
            {
                // Set xml serialzer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                // Return populated settings data
                return xmlSerializer.Deserialize(fileStream) as SettingsData;
            }
        }

        /// <summary>
        /// Saves the settings file.
        /// </summary>
        /// <param name="settingsFilePath">Settings file path.</param>
        /// <param name="settingsDataParam">Settings data parameter.</param>
        private void SaveSettingsFile(string settingsFilePath, SettingsData settingsDataParam)
        {
            try
            {
                // Use stream writer
                using (StreamWriter streamWriter = new StreamWriter(settingsFilePath, false))
                {
                    // Set xml serialzer
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                    // Serialize settings data
                    xmlSerializer.Serialize(streamWriter, settingsDataParam);
                }
            }
            catch (Exception exception)
            {
                // Advise user
                MessageBox.Show($"Error saving settings file.{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{exception.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program        
            this.Close();
        }
    }
}
