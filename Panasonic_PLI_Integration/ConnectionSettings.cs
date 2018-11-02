using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panasonic_PLI_Integration
{
    public partial class ConnectionSettings : Form
    {
        public ConnectionSettings()
        {
            InitializeComponent();
        }

        private void ConnectionSettings_Load(object sender, EventArgs e)
        {
            tb_userName.Text = Properties.Settings.Default.UserName;
            tb_password.Text = Properties.Settings.Default.Password;
            tb_address.Text = Properties.Settings.Default.ApiAddress;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.UserName = tb_userName.Text;
            Properties.Settings.Default.Password = tb_password.Text;
            Properties.Settings.Default.ApiAddress = tb_address.Text;

            //Set isConfigured to true
            Properties.Settings.Default.IsConfigured = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //Close settings window
            this.Close();
        }
    }
}
