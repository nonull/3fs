using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Tamir.SharpSsh;

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
            this.fileSystemWatcher.Renamed += new RenamedEventHandler(this.OnFileSystemRenamed);

            if (Directory.Exists(this.fileSystemWatcher.Path))
            {

            }
        }

        #region UI binding fuctions
        private void rootDirectoryTextBox_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.rootDirectoryTextBox.Text = this.folderBrowserDialog.SelectedPath;
                this.fileSystemWatcher.Path = this.rootDirectoryTextBox.Text;

                //startMonitoring();

            }

        }

        private void propertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertyWindow propertyWindow = new PropertyWindow();

            if (propertyWindow.ShowDialog() == DialogResult.OK)
            {
                this.connectionInfo.server = propertyWindow.Server;
                this.connectionInfo.id = propertyWindow.Id;
                this.connectionInfo.password = propertyWindow.Password;
                this.connectionInfo.path = propertyWindow.Path;
            }
        }

        private void startOrStopButton_Click(object sender, EventArgs e)
        {

            if (this.startOrStopButton.Text == "start")
            {
                if (startMonitoring() == true)
                {
                    this.startOrStopButton.Text = "stop";
                }
            }
            else
            {
                stopMonitoring();
                this.startOrStopButton.Text = "start";
            }




            /*
            string proto = "scp";
            SshTransferProtocolBase sshCp;

            if (proto.Equals("scp"))
            {
                sshCp = new Scp(this.connectionInfo.server, this.connectionInfo.id);
            }
            else
            {
                sshCp = new Sftp(this.connectionInfo.server, this.connectionInfo.id);
            }

            sshCp.Password = this.connectionInfo.password;
            */
        }

        #endregion


        private bool startMonitoring()
        {
            if (this.rootDirectoryTextBox.Text == "")
            {
                return false;
            }

            try
            {
                this.fileSystemWatcher.EnableRaisingEvents = true;
                this.logFilePath = getLogFilePath();
                this.logFile = File.Open(this.logFilePath, FileMode.Append, FileAccess.Write, FileShare.Read);

                return true;
            }
            catch (FileNotFoundException exception)
            {
                return false;
            }
        }

        private void stopMonitoring()
        {
            this.fileSystemWatcher.EnableRaisingEvents = false;
        }

        private String getLogFilePath()
        {
            return this.fileSystemWatcher.Path + "\\.clist";
        }


        private void OnFileSystemChanged(object sender, FileSystemEventArgs e)
        {
            if (this.logFilePath.Equals(e.FullPath) == false)
            {
                Util.FileType fileType = Util.getFileType(e.FullPath);

          
                String log = e.ChangeType.ToString() // CREATED, CHANGED, DELETED 
                    + ":" 
                    + fileType.ToString() // FILE, DIRECTORY, NOT_EXIST
                    + ":" 
                    + e.FullPath.Substring(this.fileSystemWatcher.Path.Length) // relative path
                    + "\r\n";

                byte[] logBytes = System.Text.Encoding.Default.GetBytes(log);
                this.logFile.Write(logBytes, 0, logBytes.Length);
                this.logFile.Flush();
                
            }
        }

        private void OnFileSystemRenamed(object source, RenamedEventArgs e)
        {
            if (this.logFilePath.Equals(e.FullPath) == false)
            {
                Util.FileType fileType = Util.getFileType(e.FullPath);


                String log = e.ChangeType.ToString() // RENAMED
                    + ":" 
                    + fileType.ToString() // FILE, DIRECTORY, NOT_EXIST
                    + ":" 
                    + e.OldFullPath.Substring(this.fileSystemWatcher.Path.Length) // old relative path
                    + ":" 
                    + e.FullPath.Substring(this.fileSystemWatcher.Path.Length) // new relative path
                    + "\r\n";

                byte[] logBytes = System.Text.Encoding.Default.GetBytes(log);
                this.logFile.Write(logBytes, 0, logBytes.Length);
                this.logFile.Flush();

            }
        }






        #region Inner Structure

        private class ConnectionInfo
        {
            public String server;
            public String path;
            public String id;
            public String password;
        }

        #endregion



        #region Definition of Variable

        private FileStream logFile;
        private String logFilePath;

        private ConnectionInfo connectionInfo = new ConnectionInfo();

        #endregion

        

    }
}
