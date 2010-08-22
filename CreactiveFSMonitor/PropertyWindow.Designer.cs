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
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(97, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 21);
            this.idTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(97, 48);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 21);
            this.passwordTextBox.TabIndex = 1;
            // 
            // propertyIdLabel
            // 
            this.propertyIdLabel.AutoSize = true;
            this.propertyIdLabel.Location = new System.Drawing.Point(18, 15);
            this.propertyIdLabel.Name = "propertyIdLabel";
            this.propertyIdLabel.Size = new System.Drawing.Size(16, 12);
            this.propertyIdLabel.TabIndex = 2;
            this.propertyIdLabel.Text = "ID";
            // 
            // propertyPasswordLabel
            // 
            this.propertyPasswordLabel.AutoSize = true;
            this.propertyPasswordLabel.Location = new System.Drawing.Point(18, 51);
            this.propertyPasswordLabel.Name = "propertyPasswordLabel";
            this.propertyPasswordLabel.Size = new System.Drawing.Size(62, 12);
            this.propertyPasswordLabel.TabIndex = 3;
            this.propertyPasswordLabel.Text = "Password";
            // 
            // propertySubmitButton
            // 
            this.propertySubmitButton.Location = new System.Drawing.Point(90, 85);
            this.propertySubmitButton.Name = "propertySubmitButton";
            this.propertySubmitButton.Size = new System.Drawing.Size(107, 48);
            this.propertySubmitButton.TabIndex = 4;
            this.propertySubmitButton.Text = "Submit";
            this.propertySubmitButton.UseVisualStyleBackColor = true;
            this.propertySubmitButton.Click += new System.EventHandler(this.propertySubmitButton_Click);
            // 
            // propertyCancelButton
            // 
            this.propertyCancelButton.Location = new System.Drawing.Point(20, 85);
            this.propertyCancelButton.Name = "propertyCancelButton";
            this.propertyCancelButton.Size = new System.Drawing.Size(53, 47);
            this.propertyCancelButton.TabIndex = 5;
            this.propertyCancelButton.Text = "Cancel";
            this.propertyCancelButton.UseVisualStyleBackColor = true;
            this.propertyCancelButton.Click += new System.EventHandler(this.propertyCancelButton_Click);
            // 
            // PropertyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(216, 145);
            this.Controls.Add(this.propertyCancelButton);
            this.Controls.Add(this.propertySubmitButton);
            this.Controls.Add(this.propertyPasswordLabel);
            this.Controls.Add(this.propertyIdLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.idTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(232, 183);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(232, 183);
            this.Name = "PropertyWindow";
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
    }
}