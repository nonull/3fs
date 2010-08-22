using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CreactiveFSMonitor
{
    public partial class MonitorWindow : Form
    {
        public MonitorWindow()
        {
            InitializeComponent();

            // To register FileSystem Event Handler
            this.fileSystemWatcher.Created += new FileSystemEventHandler(this.OnFileSystemChanged);
            this.fileSystemWatcher.Deleted += new FileSystemEventHandler(this.OnFileSystemChanged);
            this.fileSystemWatcher.Changed += new FileSystemEventHandler(this.OnFileSystemChanged);

            if (Directory.Exists(this.fileSystemWatcher.Path))
            {
                try
                {
                    this.fileSystemWatcher.EnableRaisingEvents = true;
                    this.logFilePath = this.fileSystemWatcher.Path + "\\.clist";
                    this.logFile = File.Open(this.logFilePath, FileMode.Append, FileAccess.Write, FileShare.Read);
                }
                catch (FileNotFoundException exception)
                {
                }

                
            }
        }

        private void rootDirectoryTextBox_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.rootDirectoryTextBox.Text = this.folderBrowserDialog.SelectedPath;
                this.fileSystemWatcher.Path = this.rootDirectoryTextBox.Text;

                try
                {
                    this.fileSystemWatcher.EnableRaisingEvents = true;
                    this.logFilePath = this.fileSystemWatcher.Path + "\\.clist";
                    this.logFile = File.Open(this.logFilePath, FileMode.Append, FileAccess.Write, FileShare.Read);
                }
                catch (FileNotFoundException exception)
                {
                }
            }

        }

        private void OnFileSystemChanged(object sender, FileSystemEventArgs e)
        {
            if (this.logFilePath.Equals(e.FullPath) == false)
            {
                
                String log = e.FullPath + ":" + e.ChangeType.ToString() + "\r\n";
                byte[] logBytes = System.Text.Encoding.Default.GetBytes(log);
                this.logFile.Write(logBytes, 0, logBytes.Length);
                //Console.WriteLine(e.FullPath + ":" + e.ChangeType.ToString());
                this.logFile.Flush();
                
            }
        }


        private FileStream logFile;
        private String logFilePath;

        private void propertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertyWindow propertyWindow = new PropertyWindow();

            propertyWindow.ShowDialog();
        }

    }
}
