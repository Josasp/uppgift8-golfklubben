﻿using uppgift8_golfklubben.Properties;
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
        }

        protected NpgsqlConnection dbConnection;

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
            //Simple check to see if all database conection info is provided
            if (!(
                Settings.Default["db_address"].ToString().Length < 1 ||
                Settings.Default["db_database"].ToString().Length < 1 ||
                Settings.Default["db_username"].ToString().Length < 1 ||
                Settings.Default["db_password"].ToString().Length < 1
                ))
            {
                //In case it is...

                //Set port to default port if no other port has been set
                String port = Settings.Default["db_port"].ToString().Length < 1 ? "5432" : Settings.Default["db_database"].ToString();

                //Set add SSL enabled to connction string if set in settings
                String ssl = (bool)Settings.Default["db_ssl"]?"SSL=true;SslMode=Require;":"";

                //Connect to database
                dbConnection = new NpgsqlConnection(
                    "Server="       + Settings.Default["db_address"].ToString() +
                    ";Port="        + port +
                    ";User Id="     + Settings.Default["db_username"].ToString()  +
                    ";Password="    + Settings.Default["db_password"].ToString()  +
                    ";Database="    + Settings.Default["db_database"].ToString() +
                    ";" + ssl);

                try
                {
                    dbConnection.Open();
                    kopplaFrånDatabasToolStripMenuItem.Enabled = true;
                    anslutTillDatabasToolStripMenuItem.Enabled = false;
                    connected_statusLabel.Text = "Ansluten";
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

        private void kopplaFrånDatabasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbConnection.Close();
            kopplaFrånDatabasToolStripMenuItem.Enabled = false;
            anslutTillDatabasToolStripMenuItem.Enabled = true;
            connected_statusLabel.Text = "Frånkopplad";
        }

        private void nyMedlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member m = new Member();
            var mf = new MemberForm(ref m);
            mf.ShowDialog();
            MessageBox.Show(m.FirstName);
        }

        private void medlemslistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create the empty table data
            DataTable dt = new DataTable("Table");
            dt.Columns.Add("golfId", typeof(string));
            dt.Columns.Add("firstName", typeof(string));
            dt.Columns.Add("lastName", typeof(string));
            dt.Columns.Add("membership", typeof(string));
            dt.Columns.Add("paid", typeof(bool));

            //TODO Replace the example bit with query from database, loop trough data.
            //Add an example row

            DataRow dr = dt.NewRow();
            dr["golfId"] = "910923-001";
            dr["firstName"] = "Johannes";
            dr["lastName"] = "Asp";
            dr["membership"] = "Greenfee";
            dr["paid"] = true;
            dt.Rows.Add(dr);

            //Create and show the Memberlist Window
            var mw = new MemberlistWindow(dt);
            //Sets mw to be a MDI Child, so it cannot leave this area
            mw.MdiParent = this;
            mw.Show();
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

        private void GetGolfID(string birthdate) 
        {
        
        }
    }
}
