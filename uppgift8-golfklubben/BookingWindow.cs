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
    public partial class BookingWindow : Form
    {
        public BookingWindow()
        {
            InitializeComponent();
        }

        private void book_button_Click(object sender, EventArgs e)
        {
            var bf = new BookingForm();
            bf.Date = monthCalendar.SelectionStart;
            bf.ShowDialog();
        }
    }
}
