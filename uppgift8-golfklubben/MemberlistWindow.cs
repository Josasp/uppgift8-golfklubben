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
    public partial class MemberlistWindow : Form
    {
        private BindingSource bs;
        private DataTable dt;

        public MemberlistWindow(DataTable dt)
        {
            this.dt = dt;
            bs = new BindingSource(dt, null);

            //Draw GUI
            InitializeComponent();

            //Set the component data
            members_dataGridView.DataSource = bs;

            //Set column header text
            members_dataGridView.Columns[0].HeaderText = "Golf-ID";
            members_dataGridView.Columns[1].HeaderText = "Förnamn";
            members_dataGridView.Columns[2].HeaderText = "Efternamn";
            members_dataGridView.Columns[3].HeaderText = "Medlemskap";
            members_dataGridView.Columns[4].HeaderText = "Betalat";
        }

        private void new_toolStripButton_Click(object sender, EventArgs e)
        {
            Member m = new Member();
            var mf = new MemberForm(ref m);
            mf.ShowDialog();


        }
    }
}