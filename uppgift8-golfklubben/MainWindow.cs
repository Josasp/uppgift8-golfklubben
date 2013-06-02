using uppgift8_golfklubben.Properties;
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            SetItemsEnabled(false);
            Connect();

        }

        public static NpgsqlConnection dbConnection;

        private void läggTillMedlemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bokaTidToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visaBokningarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void databasinställningarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDatabaseSettings();
        }

        private static void openDatabaseSettings()
        {
            //Create database window and show it as a modal dialog
            var dbsettings_window = new DatabaseSettings();
            dbsettings_window.ShowDialog();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit the application
            Application.Exit();
        }

        private void anslutTillDatabasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void Connect()
        {
            //Simple check to see if all database conection info is provided
            if (!(
                Settings.Default["db_address"].ToString().Length < 1 ||
                Settings.Default["db_database"].ToString().Length < 1 ||
                Settings.Default["db_username"].ToString().Length < 1
                ))
            {
                //In case it is...

                //Set port to default port if no other port has been set
                String port = Settings.Default["db_port"].ToString().Length < 1 ? "5432" : Settings.Default["db_port"].ToString();

                //Set add SSL enabled to connction string if set in settings
                String ssl = (bool)Settings.Default["db_ssl"] ? "SSL=true;SslMode=Require;" : "";

                //Connect to database
                dbConnection = new NpgsqlConnection(
                    "Server=" + Settings.Default["db_address"].ToString() +
                    ";Port=" + port +
                    ";User Id=" + Settings.Default["db_username"].ToString() +
                    ";Password=" + Settings.Default["db_password"].ToString() +
                    ";Database=" + Settings.Default["db_database"].ToString() +
                    ";" + ssl);

                try
                {
                    dbConnection.Open();
                    SetItemsEnabled(true);
                }
                catch
                {
                    MessageBox.Show("Det gick inte att ansluta till databasen!",
                    "Anslutningsfel");
                }
            }
            else
            {
                //In case not
                MessageBox.Show("Saknar inställningar för att ansluta till databasen!",
                    "Inställnignar saknas");
                openDatabaseSettings();
            }
        }

        private void SetItemsEnabled(bool p)
        {
            anslutTillDatabasToolStripMenuItem.Enabled = !p;
            kopplaFrånDatabasToolStripMenuItem.Enabled = p;
            nyMedlemToolStripMenuItem.Enabled = p;
            connected_statusLabel.Text = p ? "Ansluten" : "Frånkopplad";
        }

        private void kopplaFrånDatabasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbConnection.Close();
            SetItemsEnabled(false);
        }

        private void nyMedlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member m = new Member();
            var mf = new MemberForm(ref m);
            mf.ShowDialog();
            if (!m.IsEmpty)
            {
                InsertMember(m); 
            }
        }

        public static void InsertMember(Member m)
        {
            String sql = "INSERT INTO \"Medlem\" (\"Golf-ID\",\"Förnamn\",\"Efternamn\",\"Adress\",\"Postnr\",\"Stad\",\"Telefonnummer\",\"Epost\",\"Status_id\",\"BetalatÅr\",\"Handicap\")VALUES ('" + m.GolfId + "','" + m.FirstName + "','" + m.LastName + "','" + m.Adress + "','" + m.Zipcode + "','" + m.City + "','" + m.Phone + "','" + m.Email + "'," + m.Membership + ",'" + m.Paid + "'," + m.Handicap + ");";
            NpgsqlCommand Command = new NpgsqlCommand(sql, MainWindow.dbConnection);
            NpgsqlDataReader result = Command.ExecuteReader();
        }

        private void medlemslistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable mt = GetMemberTable();

            //Create and show the Memberlist Window
            var mw = new MemberlistWindow(mt);
            //Sets mw to be a MDI Child, so it cannot leave this area
            mw.MdiParent = this;
            mw.Show();
        }

        public static DataTable GetMemberTable()
        {
            //Create the empty table data
            DataTable dt = new DataTable("Table");
            dt.Columns.Add("golfId", typeof(string));
            dt.Columns.Add("firstName", typeof(string));
            dt.Columns.Add("lastName", typeof(string));
            dt.Columns.Add("membership", typeof(string));
            dt.Columns.Add("handicap", typeof(double));
            dt.Columns.Add("paid", typeof(bool));

            //TODO Replace the example bit with query from database, loop trough data.
            //Add an example row

            /*
            DataRow dr = dt.NewRow();
            dr["golfId"] = "910923-001";
            dr["firstName"] = "Johannes";
            dr["lastName"] = "Asp";
            dr["membership"] = "Greenfee";
            dr["handicap"] = "10.0";
            dr["paid"] = true;
            dt.Rows.Add(dr);
            */

            NpgsqlCommand command = new NpgsqlCommand("SELECT    \"Medlem\".\"Golf-ID\",    \"Medlem\".\"Förnamn\",    \"Medlem\".\"Efternamn\",    \"Status\".\"Namn\" AS Status,    \"Medlem\".\"BetalatÅr\",    \"Medlem\".\"Handicap\" FROM    public.\"Medlem\",    public.\"Status\" WHERE    \"Medlem\".\"Status_id\" = \"Status\".\"Status_id\";", dbConnection);
            NpgsqlDataReader ndr = command.ExecuteReader();

            while (ndr.Read())
            {
                DataRow dr = dt.NewRow();
                dr["golfId"] = ndr["Golf-ID"];
                dr["firstName"] = ndr["Förnamn"];
                dr["lastName"] = ndr["Efternamn"];
                dr["membership"] = ndr["Status"];
                dr["handicap"] = ndr["Handicap"];
                dr["paid"] = (2013 == (int)ndr["BetalatÅr"]);
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void bookinglist_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bw = new BookingWindow();
            bw.MdiParent = this;
            bw.Show();
        }

        private void bookStartTime_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bf = new BookingForm();
            bf.ShowDialog();
        }
    }
}
