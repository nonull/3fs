namespace Creactive.Windows._3fs
{
    partial class MonitorWindow
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.monitorStateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.startOrStopButton = new System.Windows.Forms.Button();
            this.rootDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathBox = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.pathBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.monitorStateLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 317);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(556, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusBar";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel.Text = "Status: ";
            // 
            // monitorStateLabel
            // 
            this.monitorStateLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.monitorStateLabel.Name = "monitorStateLabel";
            this.monitorStateLabel.Size = new System.Drawing.Size(57, 17);
            this.monitorStateLabel.Text = "Stopped";
            // 
            // startOrStopButton
            // 
            this.startOrStopButton.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startOrStopButton.Location = new System.Drawing.Point(446, 50);
            this.startOrStopButton.Name = "startOrStopButton";
            this.startOrStopButton.Size = new System.Drawing.Size(98, 57);
            this.startOrStopButton.TabIndex = 1;
            this.startOrStopButton.Text = "start";
            this.startOrStopButton.UseVisualStyleBackColor = true;
            this.startOrStopButton.Click += new System.EventHandler(this.startOrStopButton_Click);
            // 
            // rootDirectoryTextBox
            // 
            this.rootDirectoryTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.rootDirectoryTextBox.Location = new System.Drawing.Point(6, 28);
            this.rootDirectoryTextBox.Name = "rootDirectoryTextBox";
            this.rootDirectoryTextBox.ReadOnly = true;
            this.rootDirectoryTextBox.Size = new System.Drawing.Size(411, 21);
            this.rootDirectoryTextBox.TabIndex = 2;
            this.rootDirectoryTextBox.Click += new System.EventHandler(this.rootDirectoryTextBox_Click);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(556, 24);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuBar";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.propertyToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // pathBox
            // 
            this.pathBox.Controls.Add(this.rootDirectoryTextBox);
            this.pathBox.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pathBox.Location = new System.Drawing.Point(6, 50);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(434, 57);
            this.pathBox.TabIndex = 5;
            this.pathBox.TabStop = false;
            this.pathBox.Text = "Path";
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.IncludeSubdirectories = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.propertyToolStripMenuItem.Text = "Property";
            this.propertyToolStripMenuItem.Click += new System.EventHandler(this.propertyToolStripMenuItem_Click);
            // 
            // MonitorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 339);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.startOrStopButton);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "MonitorWindow";
            this.Text = "CreActive FS Monitor";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.pathBox.ResumeLayout(false);
            this.pathBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel monitorStateLabel;
        private System.Windows.Forms.Button startOrStopButton;
        private System.Windows.Forms.TextBox rootDirectoryTextBox;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox pathBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
    }
}

