namespace CreactiveFSMonitor
{
    partial class PropertyWindow
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.propertyIdLabel = new System.Windows.Forms.Label();
            this.propertyPasswordLabel = new System.Windows.Forms.Label();
            this.propertySubmitButton = new System.Windows.Forms.Button();
            this.propertyCancelButton = new System.Windows.Forms.Button();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.propertyServerLabel = new System.Windows.Forms.Label();
            this.remotePathTextBox = new System.Windows.Forms.TextBox();
            this.remotePathLabel = new System.Windows.Forms.Label();
            this.serverInputGroupBox = new System.Windows.Forms.GroupBox();
            this.loginInputGroupBox = new System.Windows.Forms.GroupBox();
            this.serverInputGroupBox.SuspendLayout();
            this.loginInputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(95, 20);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(209, 21);
            this.idTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(95, 47);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(209, 21);
            this.passwordTextBox.TabIndex = 4;
            // 
            // propertyIdLabel
            // 
            this.propertyIdLabel.AutoSize = true;
            this.propertyIdLabel.Location = new System.Drawing.Point(16, 23);
            this.propertyIdLabel.Name = "propertyIdLabel";
            this.propertyIdLabel.Size = new System.Drawing.Size(16, 12);
            this.propertyIdLabel.TabIndex = 2;
            this.propertyIdLabel.Text = "ID";
            // 
            // propertyPasswordLabel
            // 
            this.propertyPasswordLabel.AutoSize = true;
            this.propertyPasswordLabel.Location = new System.Drawing.Point(16, 50);
            this.propertyPasswordLabel.Name = "propertyPasswordLabel";
            this.propertyPasswordLabel.Size = new System.Drawing.Size(62, 12);
            this.propertyPasswordLabel.TabIndex = 3;
            this.propertyPasswordLabel.Text = "Password";
            // 
            // propertySubmitButton
            // 
            this.propertySubmitButton.Location = new System.Drawing.Point(175, 182);
            this.propertySubmitButton.Name = "propertySubmitButton";
            this.propertySubmitButton.Size = new System.Drawing.Size(147, 48);
            this.propertySubmitButton.TabIndex = 5;
            this.propertySubmitButton.Text = "Submit";
            this.propertySubmitButton.UseVisualStyleBackColor = true;
            this.propertySubmitButton.Click += new System.EventHandler(this.propertySubmitButton_Click);
            // 
            // propertyCancelButton
            // 
            this.propertyCancelButton.Location = new System.Drawing.Point(12, 182);
            this.propertyCancelButton.Name = "propertyCancelButton";
            this.propertyCancelButton.Size = new System.Drawing.Size(143, 48);
            this.propertyCancelButton.TabIndex = 6;
            this.propertyCancelButton.Text = "Cancel";
            this.propertyCancelButton.UseVisualStyleBackColor = true;
            this.propertyCancelButton.Click += new System.EventHandler(this.propertyCancelButton_Click);
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(95, 20);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(209, 21);
            this.serverTextBox.TabIndex = 1;
            // 
            // propertyServerLabel
            // 
            this.propertyServerLabel.AutoSize = true;
            this.propertyServerLabel.Location = new System.Drawing.Point(16, 23);
            this.propertyServerLabel.Name = "propertyServerLabel";
            this.propertyServerLabel.Size = new System.Drawing.Size(16, 12);
            this.propertyServerLabel.TabIndex = 7;
            this.propertyServerLabel.Text = "IP";
            // 
            // remotePathTextBox
            // 
            this.remotePathTextBox.Location = new System.Drawing.Point(95, 47);
            this.remotePathTextBox.Name = "remotePathTextBox";
            this.remotePathTextBox.Size = new System.Drawing.Size(209, 21);
            this.remotePathTextBox.TabIndex = 2;
            // 
            // remotePathLabel
            // 
            this.remotePathLabel.AutoSize = true;
            this.remotePathLabel.Location = new System.Drawing.Point(16, 50);
            this.remotePathLabel.Name = "remotePathLabel";
            this.remotePathLabel.Size = new System.Drawing.Size(30, 12);
            this.remotePathLabel.TabIndex = 9;
            this.remotePathLabel.Text = "Path";
            // 
            // serverInputGroupBox
            // 
            this.serverInputGroupBox.Controls.Add(this.serverTextBox);
            this.serverInputGroupBox.Controls.Add(this.remotePathLabel);
            this.serverInputGroupBox.Controls.Add(this.propertyServerLabel);
            this.serverInputGroupBox.Controls.Add(this.remotePathTextBox);
            this.serverInputGroupBox.Location = new System.Drawing.Point(12, 5);
            this.serverInputGroupBox.Name = "serverInputGroupBox";
            this.serverInputGroupBox.Size = new System.Drawing.Size(310, 73);
            this.serverInputGroupBox.TabIndex = 0;
            this.serverInputGroupBox.TabStop = false;
            this.serverInputGroupBox.Text = "Server Address";
            // 
            // loginInputGroupBox
            // 
            this.loginInputGroupBox.Controls.Add(this.idTextBox);
            this.loginInputGroupBox.Controls.Add(this.passwordTextBox);
            this.loginInputGroupBox.Controls.Add(this.propertyIdLabel);
            this.loginInputGroupBox.Controls.Add(this.propertyPasswordLabel);
            this.loginInputGroupBox.Location = new System.Drawing.Point(12, 87);
            this.loginInputGroupBox.Name = "loginInputGroupBox";
            this.loginInputGroupBox.Size = new System.Drawing.Size(310, 80);
            this.loginInputGroupBox.TabIndex = 1;
            this.loginInputGroupBox.TabStop = false;
            this.loginInputGroupBox.Text = "Login";
            // 
            // PropertyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(334, 242);
            this.Controls.Add(this.loginInputGroupBox);
            this.Controls.Add(this.serverInputGroupBox);
            this.Controls.Add(this.propertyCancelButton);
            this.Controls.Add(this.propertySubmitButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 280);
            this.Name = "PropertyWindow";
            this.ShowInTaskbar = false;
            this.Text = "Property";
            this.serverInputGroupBox.ResumeLayout(false);
            this.serverInputGroupBox.PerformLayout();
            this.loginInputGroupBox.ResumeLayout(false);
            this.loginInputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label propertyIdLabel;
        private System.Windows.Forms.Label propertyPasswordLabel;
        private System.Windows.Forms.Button propertySubmitButton;
        private System.Windows.Forms.Button propertyCancelButton;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Label propertyServerLabel;
        private System.Windows.Forms.TextBox remotePathTextBox;
        private System.Windows.Forms.Label remotePathLabel;
        private System.Windows.Forms.GroupBox serverInputGroupBox;
        private System.Windows.Forms.GroupBox loginInputGroupBox;
    }
}