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
    public partial class CompetitionlistWindow : Form
    {
        private BindingSource bs;
        private DataTable dt;

        public CompetitionlistWindow()
        {
            InitializeComponent();
            SetDataTable(MainWindow.GetCompetitionTable());
        }

        private void SetDataTable(DataTable dt)
        {
            this.dt = dt;
            bs = new BindingSource(dt, null);

            //Set the component data
            dataGridView.DataSource = bs;

            //Set column header text
            dataGridView.Columns[0].HeaderText = "ID";
            dataGridView.Columns[1].HeaderText = "Namn";
            dataGridView.Columns[2].HeaderText = "Deltagare";
            dataGridView.Columns[3].HeaderText = "Datum";
            dataGridView.Columns[4].HeaderText = "Sista anmälan";
            dataGridView.Columns[5].HeaderText = "Stängd anmälan";
        }

        private void nyTävlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ct = new CompetitionForm();
            ct.ShowDialog();
            SetDataTable(MainWindow.GetCompetitionTable());
        }

        private void ändraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tävling_id = int.Parse((string)dataGridView.SelectedRows[0].Cells[0].Value);
            var ct = new CompetitionForm(tävling_id);
            ct.ShowDialog();
            SetDataTable(MainWindow.GetCompetitionTable());
        }

    }
}
