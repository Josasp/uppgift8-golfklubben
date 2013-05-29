using uppgift8_golfklubben.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift8_golfklubben
{
    public partial class DatabaseSettings : Form
    {
        public DatabaseSettings()
        {
            InitializeComponent();
            address_textBox.Text    = (String) Settings.Default["db_address"];
            port_textBox.Text       = (String) Settings.Default["db_port"];
            database_textBox.Text   = (String) Settings.Default["db_database"];
            username_textBox.Text   = (String) Settings.Default["db_username"];
            password_textBox.Text   = (String) Settings.Default["db_password"];
            ssl_checkBox.Checked    = (bool)   Settings.Default["db_ssl"];
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Settings.Default["db_address"]  = address_textBox.Text;
            Settings.Default["db_port"]     = port_textBox.Text;
            Settings.Default["db_database"] = database_textBox.Text;
            Settings.Default["db_username"] = username_textBox.Text;
            Settings.Default["db_password"] = password_textBox.Text;
            Settings.Default["db_ssl"]      = ssl_checkBox.Checked;
            Settings.Default.Save();
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void database_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
