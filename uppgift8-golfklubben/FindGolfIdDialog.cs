using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift8_golfklubben
{
    public partial class FindGolfIdDialog : Form
    {
        private TextBox tb;

        public FindGolfIdDialog(ref TextBox tb)
        {
            this.tb = tb;
            InitializeComponent();
            golfId_textBox.Text = this.tb.Text;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void action_button_Click(object sender, EventArgs e)
        {
            //TODO Replace with golfId fron dataGridView
            this.tb.Text = golfId_textBox.Text;
            this.Close();
        }
    }
}
