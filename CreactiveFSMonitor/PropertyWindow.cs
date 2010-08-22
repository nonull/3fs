using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CreactiveFSMonitor
{
    public partial class PropertyWindow : Form
    {
        public PropertyWindow()
        {
            InitializeComponent();
        }

        private String id;
        private String password;

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
        }

        private void propertyCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void propertySubmitButton_Click(object sender, EventArgs e)
        {
            this.id = this.idTextBox.Text;
            this.password = this.passwordTextBox.Text;

            this.Close();
        }



    }
}
