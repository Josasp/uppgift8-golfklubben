using Npgsql;
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


            //Draw GUI
            InitializeComponent();

            SetDataTable(dt);
        }

        private void SetDataTable(DataTable dt)
        {
            this.dt = dt;
            bs = new BindingSource(dt, null);

            //Set the component data
            members_dataGridView.DataSource = bs;

            //Set column header text
            members_dataGridView.Columns[0].HeaderText = "Golf-ID";
            members_dataGridView.Columns[1].HeaderText = "Förnamn";
            members_dataGridView.Columns[2].HeaderText = "Efternamn";
            members_dataGridView.Columns[3].HeaderText = "Medlemskap";
            members_dataGridView.Columns[4].HeaderText = "Handicap";
            members_dataGridView.Columns[5].HeaderText = "Betalat";
        }

        private void new_toolStripButton_Click(object sender, EventArgs e)
        {
            Member m = new Member();
            var mf = new MemberForm(ref m, "NEW");
            mf.ShowDialog();
            if (!m.IsEmpty)
            {
                MainWindow.InsertMember(m); 
            }
            SetDataTable(MainWindow.GetMemberTable());
        }

        private void view_toolStripButton_Click(object sender, EventArgs e)
        {
            OpenMemberForm("VIEW");
        }

        private void OpenMemberForm(String state)
        {
            String golfId = (string)members_dataGridView.SelectedRows[0].Cells[0].Value;
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"Medlem\" WHERE \"Golf-ID\" = '" + golfId + "';", MainWindow.dbConnection);
            NpgsqlDataReader ndr = command.ExecuteReader();

            ndr.Read();
            Member m = new Member();
            m.GolfId = (string)ndr["Golf-ID"];
            m.FirstName = (string)ndr["Förnamn"];
            m.LastName = (string)ndr["Efternamn"];
            m.Adress = (string)ndr["Adress"];
            m.Zipcode = (string)ndr["Postnr"];
            m.City = (string)ndr["Stad"];
            m.Phone = (string)ndr["Telefonnummer"];
            m.Email = (string)ndr["Epost"];
            int status_id = (int)ndr["Status_id"];
            m.Membership = status_id.ToString();
            int betalatår = (int)ndr["BetalatÅr"];
            m.Paid = betalatår.ToString();
            double handi = (double)ndr["Handicap"];
            m.Handicap = handi.ToString();

            ndr.Close();
            var mf = new MemberForm(ref m, state);
            mf.ShowDialog();
        }

        private void edit_toolStripButton_Click(object sender, EventArgs e)
        {
            OpenMemberForm("EDIT");
        }
    }
}