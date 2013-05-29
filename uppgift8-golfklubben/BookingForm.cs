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
    public partial class BookingForm : Form
    {
        public DateTime Date
        {
            get { return monthCalendar.SelectionStart; }
            set { monthCalendar.SetDate(value); }
        }

        public BookingForm()
        {
            InitializeComponent();
        }


        private void player3_findPlayer_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void date_textBox_Enter(object sender, EventArgs e)
        {
            monthCalendar.Visible = true;
        }

        private void date_textBox_Leave(object sender, EventArgs e)
        {
            monthCalendar.Visible = false;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void action_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            date_textBox.Text = monthCalendar.SelectionStart.ToLongDateString();
            monthCalendar.Visible = false;
            
        }
    }
}
