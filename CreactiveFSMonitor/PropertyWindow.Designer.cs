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
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(96, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(226, 21);
            this.idTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(96, 65);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(226, 21);
            this.passwordTextBox.TabIndex = 1;
            // 
            // propertyIdLabel
            // 
            this.propertyIdLabel.AutoSize = true;
            this.propertyIdLabel.Location = new System.Drawing.Point(17, 41);
            this.propertyIdLabel.Name = "propertyIdLabel";
            this.propertyIdLabel.Size = new System.Drawing.Size(16, 12);
            this.propertyIdLabel.TabIndex = 2;
            this.propertyIdLabel.Text = "ID";
            // 
            // propertyPasswordLabel
            // 
            this.propertyPasswordLabel.AutoSize = true;
            this.propertyPasswordLabel.Location = new System.Drawing.Point(17, 68);
            this.propertyPasswordLabel.Name = "propertyPasswordLabel";
            this.propertyPasswordLabel.Size = new System.Drawing.Size(62, 12);
            this.propertyPasswordLabel.TabIndex = 3;
            this.propertyPasswordLabel.Text = "Password";
            // 
            // propertySubmitButton
            // 
            this.propertySubmitButton.Location = new System.Drawing.Point(175, 92);
            this.propertySubmitButton.Name = "propertySubmitButton";
            this.propertySubmitButton.Size = new System.Drawing.Size(147, 48);
            this.propertySubmitButton.TabIndex = 4;
            this.propertySubmitButton.Text = "Submit";
            this.propertySubmitButton.UseVisualStyleBackColor = true;
            this.propertySubmitButton.Click += new System.EventHandler(this.propertySubmitButton_Click);
            // 
            // propertyCancelButton
            // 
            this.propertyCancelButton.Location = new System.Drawing.Point(12, 92);
            this.propertyCancelButton.Name = "propertyCancelButton";
            this.propertyCancelButton.Size = new System.Drawing.Size(143, 48);
            this.propertyCancelButton.TabIndex = 5;
            this.propertyCancelButton.Text = "Cancel";
            this.propertyCancelButton.UseVisualStyleBackColor = true;
            this.propertyCancelButton.Click += new System.EventHandler(this.propertyCancelButton_Click);
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(96, 11);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(226, 21);
            this.serverTextBox.TabIndex = 6;
            // 
            // propertyServerLabel
            // 
            this.propertyServerLabel.AutoSize = true;
            this.propertyServerLabel.Location = new System.Drawing.Point(17, 14);
            this.propertyServerLabel.Name = "propertyServerLabel";
            this.propertyServerLabel.Size = new System.Drawing.Size(41, 12);
            this.propertyServerLabel.TabIndex = 7;
            this.propertyServerLabel.Text = "Server";
            // 
            // PropertyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(334, 162);
            this.Controls.Add(this.propertyServerLabel);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.propertyCancelButton);
            this.Controls.Add(this.propertySubmitButton);
            this.Controls.Add(this.propertyPasswordLabel);
            this.Controls.Add(this.propertyIdLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.idTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "PropertyWindow";
            this.ShowInTaskbar = false;
            this.Text = "Property";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}