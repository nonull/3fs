using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Creactive.Windows._3fs
{
    public partial class PropertyWindow : Form
    {
        public PropertyWindow()
        {
            InitializeComponent();
        }

        private String id;
        private String password;
        private String server;
        private String path;

        public String Id
        {
            get
            {
                return id;
            }
        }

        public String Password
        {
            get
            {
                return password;
            }
        }

        public String Server
        {
            get
            {
                return server;
            }
        }

        public String Path
        {
            get
            {
                return path;
            }
        }

        private void propertyCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void propertySubmitButton_Click(object sender, EventArgs e)
        {
            this.server = this.serverTextBox.Text;
            this.path = this.remotePathTextBox.Text;
            this.id = this.idTextBox.Text;
            this.password = this.passwordTextBox.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }



    }
}
